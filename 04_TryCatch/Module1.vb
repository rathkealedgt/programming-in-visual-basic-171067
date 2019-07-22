''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Harry  </author>
''' <date> 13Jun19 </date>
Module Module1

    Sub Main()
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Please enter an valied interger"
        Dim Vaildinput As Boolean = False

        While Not Vaildinput
            Try
                ' Ask user for a number and store it.
                Console.WriteLine("Please enter an integer between 1 and 10.")
                UserResponse = Console.ReadLine()
                Vaildinput = True

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)

            End Try

        End While
        ' Pause the program to view output.
        Dim output As String = String.Format("you entered {0}.", UserResponse)
        Console.WriteLine(output)
        Console.ReadLine()

    End Sub
End Module
