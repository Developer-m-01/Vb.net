Imports System.Windows

Public Class CustomButton
    Inherits Button                                     'Inherits Property of  Button Control 

    ''' <summary>
    ''' Constructure For Manage focus Property
    ''' </summary>
    Public Sub New()

        'Custom Control setstyle use for manage some properties of control
        'ControlStyles.Selectable use for Handle focus or control
        SetStyle(ControlStyles.Selectable, False)

    End Sub

End Class
