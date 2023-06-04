Imports System.Runtime.Remoting.Channels

Public Class frm_calculator

    Dim m_strOperand1 As String                              'Store 1st Operand Value
    Dim m_strOperand2 As String                              'Store 2nd Operand Value
    Dim m_strOperator As String                              'Store Operator Value
    Dim m_decResult As Decimal                               'Store Opertaion Final Result
    Dim m_decResultState As Boolean = False                  'decResultState use for Check Result have or not
    Dim m_bolPreviousOperation As Boolean = False            'Check Previous Opertion Compelete Or Not. This variable use For Manage nextoperation and Clear History after result 
    Dim m_bolPreviousOperator As Boolean = False             'Check Operator have value or not this variable use for manage continues Operation
    Dim m_bolHistTemp As Boolean = False                     'For Manage Histroy Temperoy Time
    Const m_intHistoryLength As Integer = 40                 'For History Length
    Const m_decMaxNumber As Decimal = 999999999              'For Result Max value
    Const m_decMinNumber As Decimal = -999999999             'For Result Min value

#Region "Form events"

    ''' <summary>
    ''' Form Load Event 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frm_calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Disable TextBox ContextMenu
        'Here set new empty context menu to DisplayTextBox.
        'new context is empty then not show ContextMenu in DisplayTextBox
        txt_display.ContextMenuStrip = New ContextMenuStrip

    End Sub

    ''' <summary>
    ''' To Bind Keyboard Key With Buttons 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode

            'Digit Keys 0 - 9
            'Numpad Means keyboard Numpad Keys
            'D0 to D9 Typing numeric Keys
            Case Keys.NumPad0, Keys.D0
                getNumbers("0")
            Case Keys.NumPad1, Keys.D1
                getNumbers("1")
            Case Keys.NumPad2, Keys.D2
                getNumbers("2")
            Case Keys.NumPad3, Keys.D3
                getNumbers("3")
            Case Keys.NumPad4, Keys.D4
                getNumbers("4")
            Case Keys.NumPad5, Keys.D5
                getNumbers("5")
            Case Keys.NumPad6, Keys.D6
                getNumbers("6")
            Case Keys.NumPad7, Keys.D7
                getNumbers("7")
            Case Keys.NumPad8
                getNumbers("8")
            Case Keys.NumPad9, Keys.D9
                getNumbers("9")

            'Arithmatic Operators
            Case Keys.Add
                getArithmaticOperator("+")

            'Here Substract Key : NumPad Substract Key
            'Oemminus Key : keyboard Typing Substruct Key
            Case Keys.Subtract, Keys.OemMinus
                getArithmaticOperator("-")
            Case Keys.Multiply
                getArithmaticOperator("*")
            Case Keys.Divide, Keys.OemQuestion
                getArithmaticOperator("/")

            'Decimal Point
            'Here Decmial key : Numpad decimal key
            'OemPeriod key : keyboard Typing Decimal Key
            Case Keys.Decimal, Keys.OemPeriod
                getDecimalPoint(".")

            'Enter Key For = operation
            'Enter Key : Keyboard Special Key
            'Separator Key : NumericPad Enter Key
            Case Keys.Enter, Keys.Separator
                performEqualOperation()

            'Backspace
            Case Keys.Back
                performBackspace()

            'Clear (delete)
            Case Keys.Delete, Keys.Escape
                performClear()

            'Combination Key 
            'Shift + oemplus(=) key
            Case Keys.Oemplus
                If e.Shift Then
                    getArithmaticOperator("+")
                Else
                    performEqualOperation()
                End If

            'Combination Key 
            'Shift + 8 key
            Case Keys.D8
                If e.Shift Then
                    getArithmaticOperator("*")
                Else
                    getNumbers("8")
                End If

        End Select

    End Sub

#End Region

#Region "Click event of each control"

    ''' <summary>
    ''' Deciaml point Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_decimal_Click(sender As Object, e As EventArgs) Handles btn_decimal.Click

        getDecimalPoint(sender.text)

    End Sub

    ''' <summary>
    ''' Backspace Click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click

        performBackspace()

    End Sub

    ''' <summary>
    ''' Clear Button Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        performClear()

    End Sub

    ''' <summary>
    ''' Equal (=) button Click Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click

        performEqualOperation()

    End Sub

#End Region

#Region "Input event"

    ''' <summary>
    ''' Textbox Enter event for Manage Cursor And Selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt_result_Enter(sender As Object, e As EventArgs) Handles txt_display.Enter

        'Manage TextBox Selection and cursor 
        'Select(0,0) For Manage Selection
        txt_display.Select(0, 0)

        'ActiveControl = Noting Manage Focus Of Textbox 
        Me.ActiveControl = Nothing

    End Sub

#End Region

#Region "Public method"

    ''' <summary>
    ''' Method For Input Numeric (0-9) Values 
    ''' </summary>
    ''' <param name="strValue"></param>
    Public Sub getNumbers(strValue As String)

        'Check Display Result Have any Character if display have Any Character Then no Any Action Perfom (Mostly Work For Error Message Time)
        If Char.IsLetter(txt_display.Text) = False Then

            If m_decResultState = True Then

                txt_display.Text = strValue
                m_decResultState = False
                m_bolPreviousOperator = True

            Else

                'Check Text 1 Value Is 0 .if value is  0 then Replace With input number other vise appand with value
                If txt_display.Text = "0" Then
                    txt_display.Text = strValue
                Else

                    'Check Textbox contains any decimal value or not if any decimal found then no more any appand decimal point in display
                    If InStr(txt_display.Text, ".") Then

                        If txt_display.Text.Length < 10 Then
                            txt_display.Text &= strValue
                        End If

                    Else

                        If txt_display.Text.Length < 9 Then
                            txt_display.Text &= strValue
                        End If

                    End If

                End If

            End If

            'For Work any Provious Operation Done Or Not 
            'After Prvious operation result press Any number for new operation Then Clean History Nol All Variable data
            If m_bolPreviousOperation = True Then

                lbl_history.Text = ""
                m_strOperand1 = txt_display.Text
                m_bolHistTemp = True

            End If

        End If

    End Sub

    ''' <summary>
    ''' Arithmatic Operator (+,-,*,/) input Method
    ''' </summary>
    ''' <param name="strValue"></param>
    Public Sub getArithmaticOperator(strValue As String)

        If Char.IsLetter(txt_display.Text) = False Then

            'Check Previuos Operation Complete Or Not.
            'if PreviousOperation is Done then press any number kye after result then clear history and set new value textbox
            If m_bolPreviousOperation = False Then

                'Condition for Work on Continiuos Opertaion
                'Ex : 1+2*4/5-0
                If m_strOperator <> "" AndAlso m_bolPreviousOperator = True AndAlso m_bolPreviousOperation = False Then

                    performArithmaticOperation()
                    m_strOperator = strValue
                    lbl_history.Text &= m_strOperand2 & m_strOperator
                    m_decResultState = True
                    m_strOperand2 = ""

                Else

                    'For Set Operand1 when operator is null other wise replace Operator with new operator
                    If m_strOperator = "" Then

                        m_strOperand1 = Decimal.Parse(txt_display.Text)
                        m_decResultState = True

                    End If

                    'Tirm Operand 1 Vlaue if Vlaue is only decimal Or 0 after Decimal point
                    'ex 1. = 1  and 1.0 = 1
                    If InStr(m_strOperand1, ".") Then

                        m_strOperand1 = m_strOperand1.ToString.TrimEnd("0")
                        m_strOperand1 = m_strOperand1.ToString.TrimEnd(".")

                    End If

                    m_strOperator = strValue
                    lbl_history.Text = m_strOperand1 & m_strOperator

                End If

            Else

                'Manage after Equal operation start New Multipaal Operation 
                m_strOperand2 = ""
                m_decResultState = True
                m_bolPreviousOperation = False
                m_strOperator = strValue
                lbl_history.Text = m_strOperand1 & m_strOperator

            End If

        End If

        historylength()

    End Sub

#End Region

#Region "Private method"

    ''' <summary>
    ''' For input Deciaml Point 
    ''' </summary>
    ''' <param name="strValue"></param>
    Private Sub getDecimalPoint(strValue As String)

        If Char.IsLetter(txt_display.Text) = False Then

            'Reuslt State Manage operation Reuslt if result get then not work decimal action in result Value
            If m_decResultState = False Then

                'condition For Manage Only 1 tine Decimal Point In Display With Value
                If InStr(txt_display.Text, strValue) = 0 Then
                    txt_display.Text &= strValue
                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' For Backspace(delete character 1 by 1)
    ''' </summary>
    Private Sub performBackspace()

        If Char.IsLetter(txt_display.Text) = False Then

            If m_decResultState = False Then

                'Work Id Display value length is less then 1 on clear time then set 0 value on display  
                If txt_display.Text.Length <= 1 Then
                    txt_display.Text = "0"
                Else

                    'Remove Method Remove Ecah number one by one from value 
                    txt_display.Text = txt_display.Text.Remove(txt_display.Text.Length - 1, 1)

                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' Method For Clear Display,history and reinisized variable values
    ''' </summary>
    Private Sub performClear()

        'reinitialized All Varibales For Fresh opertaion
        'Clear Display And History  
        txt_display.Text = "0"
        lbl_history.Text = ""
        m_strOperand1 = ""
        m_strOperand2 = ""
        m_strOperator = ""
        m_decResult = 0
        m_decResultState = False
        m_bolPreviousOperation = False
        m_bolPreviousOperator = False
        m_bolHistTemp = False

    End Sub

    ''' <summary>
    ''' Equal Method Use for Perform operation
    ''' </summary>
    Private Sub performEqualOperation()

        If Char.IsLetter(txt_display.Text) = False Then

            'Check The Operator Is Empty Or Not
            If m_strOperator <> "" Then

                'Condition For Manage History After equal Operation
                If m_bolHistTemp = True AndAlso m_bolPreviousOperation = True Then

                    lbl_history.Text = m_strOperand1
                    m_bolHistTemp = False

                End If

                performArithmaticOperation()

                'Condtion for Manage Histoy Appand and Show
                If m_bolPreviousOperation = True Then
                    lbl_history.Text &= m_strOperator & m_strOperand2
                Else

                    lbl_history.Text &= m_strOperand2
                    m_bolPreviousOperation = True

                End If
                historylength()

            End If

        End If

    End Sub

    ''' <summary>
    ''' Method For Arithmatic Opertaions
    ''' </summary>
    Private Sub performArithmaticOperation()

        If Char.IsLetter(txt_display.Text) = False Then

            'Manage operand 2 Value .operand 2 is null then set textvalue as operand 2 value after operator 
            If m_strOperand2 = "" Then

                'Set operand2 Value from textbox
                m_strOperand2 = Decimal.Parse(txt_display.Text)

                'Tirm Operand 2 Value ifvalue append only . or only 0 after .
                If InStr(m_strOperand2, ".") Then

                    m_strOperand2 = m_strOperand2.ToString.TrimEnd("0")
                    m_strOperand2 = m_strOperand2.ToString.TrimEnd(".")

                End If

            End If

            'StrOperator Have Any One Operator Value
            Select Case m_strOperator
                Case "+"
                    m_decResult = Decimal.Parse(m_strOperand1) + Decimal.Parse(m_strOperand2)
                Case "-"
                    m_decResult = Decimal.Parse(m_strOperand1) - Decimal.Parse(m_strOperand2)
                Case "*"
                    m_decResult = Decimal.Parse(m_strOperand1) * Decimal.Parse(m_strOperand2)
                Case "/"

                    'Manage Zero Divison Result
                    If m_strOperand2 = 0 Then

                        txt_display.Text = "Can't Divide By zero"
                        Exit Sub

                    Else
                        m_decResult = Decimal.Parse(m_strOperand1) / Decimal.Parse(m_strOperand2)
                    End If

            End Select

            'Check Result Vlaue If result Vlaue grater then 99999999 then overlfow error or less then -999999999 then underflow Error othervise Display result
            If m_decResult > m_decMaxNumber Then
                txt_display.Text = "Overflow"
            ElseIf m_decResult < m_decMinNumber Then
                txt_display.Text = "Underflow"
            Else

                m_decResult = Math.Round(m_decResult, 3)

                'Trim Result with deciaml(.) or 0
                If InStr(m_decResult, ".") Then

                    m_decResult = m_decResult.ToString.TrimEnd("0")
                    m_decResult = m_decResult.ToString.TrimEnd(".")

                End If

                txt_display.Text = m_decResult
                m_decResultState = True

                m_strOperand1 = m_decResult

            End If

        End If

    End Sub

    ''' <summary>
    ''' Manage History Length
    ''' </summary>
    Private Sub historylength()

        'Trim History Length When history Length is more then intHistoryLength 
        'intHistoryLength is equal to dislpay length . when history value goto near border then trim from left side 
        If lbl_history.Text.Length > m_intHistoryLength Then
            lbl_history.Text = lbl_history.Text.Substring(lbl_history.Text.Length - m_intHistoryLength)
        End If

    End Sub

#End Region

End Class