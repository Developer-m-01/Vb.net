Public Class CustomButtonNumber
	Inherits CustomButton                      'Inherits Property of CustomButton Which Is Inherits Button 

#Region "Click event of each control"

	''' <summary>
	''' Custom Button Click Event
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub CustomButtonNumberOnClick(ByVal sender As Object, e As EventArgs) Handles Me.Click

		'Called Number Public Method From Main Form 
		'Use For Input numer Value 0 to 9
		frm_calculator.getNumbers(sender.text)

	End Sub

#End Region

End Class
