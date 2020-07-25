Public Class Form1

    'Write a program that prints the numbers from 1 to 100. 
    'But for multiples of three print “Fizz” instead of the number 
    'and for the multiples of five print “Buzz”. 
    'For numbers which are multiples of both three and five print “FizzBuzz”.

    'Started
    '2013-07-27
    '3:21

    'Finished
    '2013-07-27
    '3:29

    'Delta time: 8 minutes
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        For i As Integer = 1 To 100 Step 1

            Dim FizzBuzz As New FizzBuzz(Number:=i)
            Me.TextBox1.Text = Me.TextBox1.Text & i & ": " & FizzBuzz.Fizzbuzz & vbCrLf

        Next

    End Sub


End Class

Class FizzBuzz
    Private Number As Integer

    Sub New(ByVal Number As Integer)
        Me.Number = Number
    End Sub

    ReadOnly Property Fizzbuzz As String
        Get
            If Me.isFizz And Me.isBuzz Then
                Return "FizzBuzz"
            ElseIf Me.isFizz Then
                Return "Fizz"
            ElseIf Me.isBuzz Then
                Return "Buzz"
            Else
                Return Me.Number.ToString
            End If
        End Get

    End Property

    Private Function isFizz() As Boolean
        Return Me.Number Mod 3 = 0
    End Function

    Private Function isBuzz() As Boolean
        Return Me.Number Mod 5 = 0
    End Function

End Class
