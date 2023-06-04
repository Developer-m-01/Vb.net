Public Class CustomButtonOperator
	Inherits CustomButton                           'Inherits Property of CustomButton Which Is Inherits Button 

#Region "Click event of each control"

	''' <summary>
	''' Custom Button Click Event
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub CustomButtonOperatorOnClick(ByVal sender As Object, e As EventArgs) Handles Me.Click

		'Called ArithmaticOperator Public Method From Main Form 
		'Use For Input Operator +,-,*,/
		frm_calculator.getArithmaticOperator(sender.text)

	End Sub

#End Region

End Class
