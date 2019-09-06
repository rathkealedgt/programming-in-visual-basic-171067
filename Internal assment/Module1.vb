Module component

    Sub Main()

        'Gose to version 1 of the code 
        Version1.Main()


        'Global Veriables 

    End Sub


    ''' <summary>
    '''  String cheacking function. Will cheack if user input is an string eathier Y or N 
    ''' </summary>
    ''' <param name="Y"> a vaild input for Y or Yes </param>
    ''' <param name="N"> vaild input for N or no </param>
    ''' <returns> The vaild user input as a string and eaither Y or N  </returns>

    Function stringcheck(Y As String, N As String) As String

        Dim userResponse As String = Y Or N
        Const ERROR_MESSAGE As String = "Their seems to be an error please reenter your answer" 'Creats an error message if the user has not inputed corectly
        Dim Vaildinput As Boolean = False
        Dim OUTPUT_MESSAGE As String = String.Format("You will be ask a multitude of questions that are all yes or no. Please enter an Answer eathier Y or N {0} and {1} ", Y, N) 'Asks the user to enter Y or N 

        While Not Vaildinput
            Try
                'Ask for user imput 
                Console.WriteLine(OUTPUT_MESSAGE)
                UserResponse = Console.ReadLine

                '
                If Y Or N Then
                    Vaildinput = True
                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)

            End Try

        End While

        ' Pauses the program to view output 
        Return UserResponse
    End Function



    '*********************************************************************************************************************************************************************************************************

End Module

