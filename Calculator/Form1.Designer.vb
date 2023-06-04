<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_calculator))
		Me.txt_display = New System.Windows.Forms.TextBox()
		Me.lbl_history = New System.Windows.Forms.Label()
		Me.btn_equal = New Calculator.CustomButton()
		Me.btn_nine = New Calculator.CustomButtonNumber()
		Me.btn_eight = New Calculator.CustomButtonNumber()
		Me.btn_seven = New Calculator.CustomButtonNumber()
		Me.btn_six = New Calculator.CustomButtonNumber()
		Me.btn_three = New Calculator.CustomButtonNumber()
		Me.btn_five = New Calculator.CustomButtonNumber()
		Me.btn_four = New Calculator.CustomButtonNumber()
		Me.btn_two = New Calculator.CustomButtonNumber()
		Me.btn_one = New Calculator.CustomButtonNumber()
		Me.btn_zero = New Calculator.CustomButtonNumber()
		Me.btn_divison = New Calculator.CustomButtonOperator()
		Me.btn_multipication = New Calculator.CustomButtonOperator()
		Me.btn_minus = New Calculator.CustomButtonOperator()
		Me.btn_add = New Calculator.CustomButtonOperator()
		Me.btn_clear = New Calculator.CustomButton()
		Me.btn_backspace = New Calculator.CustomButton()
		Me.btn_decimal = New Calculator.CustomButton()
		Me.SuspendLayout()
		'
		'txt_display
		'
		Me.txt_display.BackColor = System.Drawing.Color.White
		Me.txt_display.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txt_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_display.HideSelection = False
		Me.txt_display.ImeMode = System.Windows.Forms.ImeMode.Disable
		Me.txt_display.Location = New System.Drawing.Point(14, 48)
		Me.txt_display.MaxLength = 9
		Me.txt_display.Name = "txt_display"
		Me.txt_display.ReadOnly = True
		Me.txt_display.Size = New System.Drawing.Size(387, 31)
		Me.txt_display.TabIndex = 19
		Me.txt_display.TabStop = False
		Me.txt_display.Text = "0"
		Me.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lbl_history
		'
		Me.lbl_history.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbl_history.BackColor = System.Drawing.Color.White
		Me.lbl_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbl_history.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
		Me.lbl_history.Location = New System.Drawing.Point(12, 7)
		Me.lbl_history.Name = "lbl_history"
		Me.lbl_history.Size = New System.Drawing.Size(393, 75)
		Me.lbl_history.TabIndex = 18
		Me.lbl_history.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'btn_equal
		'
		Me.btn_equal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_equal.Location = New System.Drawing.Point(328, 214)
		Me.btn_equal.Name = "btn_equal"
		Me.btn_equal.Size = New System.Drawing.Size(78, 117)
		Me.btn_equal.TabIndex = 34
		Me.btn_equal.Text = "="
		Me.btn_equal.UseVisualStyleBackColor = True
		'
		'btn_nine
		'
		Me.btn_nine.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_nine.Location = New System.Drawing.Point(169, 91)
		Me.btn_nine.Name = "btn_nine"
		Me.btn_nine.Size = New System.Drawing.Size(78, 60)
		Me.btn_nine.TabIndex = 33
		Me.btn_nine.Tag = "75,60"
		Me.btn_nine.Text = "9"
		Me.btn_nine.UseVisualStyleBackColor = True
		'
		'btn_eight
		'
		Me.btn_eight.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_eight.Location = New System.Drawing.Point(90, 91)
		Me.btn_eight.Name = "btn_eight"
		Me.btn_eight.Size = New System.Drawing.Size(78, 60)
		Me.btn_eight.TabIndex = 32
		Me.btn_eight.Tag = "75,60"
		Me.btn_eight.Text = "8"
		Me.btn_eight.UseVisualStyleBackColor = True
		'
		'btn_seven
		'
		Me.btn_seven.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_seven.Location = New System.Drawing.Point(12, 91)
		Me.btn_seven.Name = "btn_seven"
		Me.btn_seven.Size = New System.Drawing.Size(78, 60)
		Me.btn_seven.TabIndex = 31
		Me.btn_seven.Tag = "75,60"
		Me.btn_seven.Text = "7"
		Me.btn_seven.UseVisualStyleBackColor = True
		'
		'btn_six
		'
		Me.btn_six.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_six.Location = New System.Drawing.Point(169, 153)
		Me.btn_six.Name = "btn_six"
		Me.btn_six.Size = New System.Drawing.Size(78, 60)
		Me.btn_six.TabIndex = 30
		Me.btn_six.Tag = "75,60"
		Me.btn_six.Text = "6"
		Me.btn_six.UseVisualStyleBackColor = True
		'
		'btn_three
		'
		Me.btn_three.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_three.Location = New System.Drawing.Point(169, 214)
		Me.btn_three.Name = "btn_three"
		Me.btn_three.Size = New System.Drawing.Size(78, 60)
		Me.btn_three.TabIndex = 29
		Me.btn_three.Tag = "75,60"
		Me.btn_three.Text = "3"
		Me.btn_three.UseVisualStyleBackColor = True
		'
		'btn_five
		'
		Me.btn_five.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_five.Location = New System.Drawing.Point(90, 153)
		Me.btn_five.Name = "btn_five"
		Me.btn_five.Size = New System.Drawing.Size(78, 60)
		Me.btn_five.TabIndex = 28
		Me.btn_five.Tag = "75,60"
		Me.btn_five.Text = "5"
		Me.btn_five.UseVisualStyleBackColor = True
		'
		'btn_four
		'
		Me.btn_four.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_four.Location = New System.Drawing.Point(12, 153)
		Me.btn_four.Name = "btn_four"
		Me.btn_four.Size = New System.Drawing.Size(78, 60)
		Me.btn_four.TabIndex = 27
		Me.btn_four.Tag = "75,60"
		Me.btn_four.Text = "4"
		Me.btn_four.UseVisualStyleBackColor = True
		'
		'btn_two
		'
		Me.btn_two.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_two.Location = New System.Drawing.Point(90, 214)
		Me.btn_two.Name = "btn_two"
		Me.btn_two.Size = New System.Drawing.Size(78, 60)
		Me.btn_two.TabIndex = 26
		Me.btn_two.Tag = "75,60"
		Me.btn_two.Text = "2"
		Me.btn_two.UseVisualStyleBackColor = True
		'
		'btn_one
		'
		Me.btn_one.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_one.Location = New System.Drawing.Point(12, 214)
		Me.btn_one.Name = "btn_one"
		Me.btn_one.Size = New System.Drawing.Size(78, 60)
		Me.btn_one.TabIndex = 25
		Me.btn_one.Tag = "75,60"
		Me.btn_one.Text = "1"
		Me.btn_one.UseVisualStyleBackColor = True
		'
		'btn_zero
		'
		Me.btn_zero.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_zero.Location = New System.Drawing.Point(12, 276)
		Me.btn_zero.Name = "btn_zero"
		Me.btn_zero.Size = New System.Drawing.Size(156, 55)
		Me.btn_zero.TabIndex = 24
		Me.btn_zero.Text = "0"
		Me.btn_zero.UseVisualStyleBackColor = True
		'
		'btn_divison
		'
		Me.btn_divison.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_divison.Location = New System.Drawing.Point(248, 91)
		Me.btn_divison.Name = "btn_divison"
		Me.btn_divison.Size = New System.Drawing.Size(78, 60)
		Me.btn_divison.TabIndex = 23
		Me.btn_divison.Tag = "75,60"
		Me.btn_divison.Text = "/"
		Me.btn_divison.UseVisualStyleBackColor = True
		'
		'btn_multipication
		'
		Me.btn_multipication.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_multipication.Location = New System.Drawing.Point(248, 153)
		Me.btn_multipication.Name = "btn_multipication"
		Me.btn_multipication.Size = New System.Drawing.Size(78, 60)
		Me.btn_multipication.TabIndex = 22
		Me.btn_multipication.Tag = "75,60"
		Me.btn_multipication.Text = "*"
		Me.btn_multipication.UseVisualStyleBackColor = True
		'
		'btn_minus
		'
		Me.btn_minus.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_minus.Location = New System.Drawing.Point(248, 214)
		Me.btn_minus.Name = "btn_minus"
		Me.btn_minus.Size = New System.Drawing.Size(78, 60)
		Me.btn_minus.TabIndex = 21
		Me.btn_minus.Tag = "75,60"
		Me.btn_minus.Text = "-"
		Me.btn_minus.UseVisualStyleBackColor = True
		'
		'btn_add
		'
		Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_add.Location = New System.Drawing.Point(248, 276)
		Me.btn_add.Name = "btn_add"
		Me.btn_add.Size = New System.Drawing.Size(78, 55)
		Me.btn_add.TabIndex = 20
		Me.btn_add.Tag = "75,60"
		Me.btn_add.Text = "+"
		Me.btn_add.UseVisualStyleBackColor = True
		'
		'btn_clear
		'
		Me.btn_clear.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_clear.Location = New System.Drawing.Point(328, 153)
		Me.btn_clear.Name = "btn_clear"
		Me.btn_clear.Size = New System.Drawing.Size(78, 60)
		Me.btn_clear.TabIndex = 16
		Me.btn_clear.Tag = "78,60"
		Me.btn_clear.Text = "C"
		Me.btn_clear.UseVisualStyleBackColor = True
		'
		'btn_backspace
		'
		Me.btn_backspace.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_backspace.Location = New System.Drawing.Point(328, 91)
		Me.btn_backspace.Name = "btn_backspace"
		Me.btn_backspace.Size = New System.Drawing.Size(78, 60)
		Me.btn_backspace.TabIndex = 17
		Me.btn_backspace.Tag = "78,60"
		Me.btn_backspace.Text = "←"
		Me.btn_backspace.UseVisualStyleBackColor = True
		'
		'btn_decimal
		'
		Me.btn_decimal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
		Me.btn_decimal.Location = New System.Drawing.Point(169, 276)
		Me.btn_decimal.Name = "btn_decimal"
		Me.btn_decimal.Size = New System.Drawing.Size(78, 55)
		Me.btn_decimal.TabIndex = 10
		Me.btn_decimal.Tag = "75,60"
		Me.btn_decimal.Text = "."
		Me.btn_decimal.UseVisualStyleBackColor = True
		'
		'frm_calculator
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(414, 342)
		Me.Controls.Add(Me.btn_equal)
		Me.Controls.Add(Me.btn_nine)
		Me.Controls.Add(Me.btn_eight)
		Me.Controls.Add(Me.btn_seven)
		Me.Controls.Add(Me.btn_six)
		Me.Controls.Add(Me.btn_three)
		Me.Controls.Add(Me.btn_five)
		Me.Controls.Add(Me.btn_four)
		Me.Controls.Add(Me.btn_two)
		Me.Controls.Add(Me.btn_one)
		Me.Controls.Add(Me.btn_zero)
		Me.Controls.Add(Me.btn_divison)
		Me.Controls.Add(Me.btn_multipication)
		Me.Controls.Add(Me.btn_minus)
		Me.Controls.Add(Me.btn_add)
		Me.Controls.Add(Me.btn_clear)
		Me.Controls.Add(Me.btn_backspace)
		Me.Controls.Add(Me.btn_decimal)
		Me.Controls.Add(Me.txt_display)
		Me.Controls.Add(Me.lbl_history)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(432, 389)
		Me.MinimumSize = New System.Drawing.Size(432, 389)
		Me.Name = "frm_calculator"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "  Calculator"
		Me.TopMost = True
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txt_display As TextBox
	Friend WithEvents btn_decimal As CustomButton
	Friend WithEvents btn_backspace As CustomButton
	Friend WithEvents btn_clear As CustomButton
	Friend WithEvents btn_add As CustomButtonOperator
	Friend WithEvents btn_minus As CustomButtonOperator
	Friend WithEvents btn_divison As CustomButtonOperator
	Friend WithEvents btn_multipication As CustomButtonOperator
	Friend WithEvents btn_zero As CustomButtonNumber
	Friend WithEvents btn_one As CustomButtonNumber
	Friend WithEvents btn_two As CustomButtonNumber
	Friend WithEvents btn_five As CustomButtonNumber
	Friend WithEvents btn_four As CustomButtonNumber
	Friend WithEvents btn_six As CustomButtonNumber
	Friend WithEvents btn_three As CustomButtonNumber
	Friend WithEvents btn_eight As CustomButtonNumber
	Friend WithEvents btn_seven As CustomButtonNumber
	Friend WithEvents btn_nine As CustomButtonNumber
	Friend WithEvents btn_equal As CustomButton
	Friend WithEvents lbl_history As Label
End Class
