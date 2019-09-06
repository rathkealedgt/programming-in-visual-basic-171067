Imports System.Reflection

Module Version1


    Sub Main()
        'startup

        Dim Y As String
        Dim N As String 'sets these to be global veriables 
        Dim UI As String = Y Or N  ' Get input
        Genaratequestions(Y, N)
        'Genarte question / display to user      
        score(UI, Y, N)
        'User input answer to user input

        'end score and output 

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
                userResponse = Console.ReadLine

                '
                If Y Or N Then
                    Vaildinput = True
                End If

            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)

            End Try

        End While

        ' Pauses the program to view output 
        Return userResponse
    End Function



    '*********************************************************************************************************************************************************************************************************

    Public Sub score(UserResponse, Y, N)
        Dim totalscore As Double = 0 'seats the start score as 0 
        Dim questions As String = ""
        Dim Feedback As String = ""
        Dim keepgoing As String = ""
        Dim Getquestions As String = ""

        Dim countq1 As Integer = 0
        Dim countq2 As Integer = 0
        Dim countq3 As Integer = 0
        Dim countq4 As Integer = 0
        Dim countq5 As Integer = 0
        Dim countq6 As Integer = 0
        Dim countq7 As Integer = 0
        Dim countq8 As Integer = 0
        Dim countq9 As Integer = 0
        Dim countq10 As Integer = 0

        For counter As Integer = 0 To totalscore



            If questions = "q1" And UserResponse = Y Then 'if the questioon is q1 and that the user response was Y then they get an extra score of 1 
                totalscore += 1
                Console.ReadLine()

            ElseIf UserResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q2" And UserResponse = Y Then 'if the questioon is q3 and that the user response was Y then they get an extra score of 1 
                totalscore += 1
                Console.ReadLine()

            ElseIf UserResponse = N Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q3" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q4" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q5" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q6" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If

            If questions = "q7" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q8" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q9" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            If questions = "q10" And UserResponse = N Then 'if the questioon is q3 and that the user response was N then they get an extra score of 1 
                totalscore += 1

            ElseIf UserResponse = Y Then  'But if the user response is N then the console wrties sorry incorect and dosent take away or add to the total score 
                Feedback = "sorry incorect" 'writes sorry incorect if the user response is N 

            End If
            Console.WriteLine()
        Next counter
        '**********************************************************************************************************************************************************************************************
        'socore calculations 

        Console.WriteLine(vbNewLine & String.Format(" {0}.", totalscore))
        Console.WriteLine("Your score is {0}", totalscore)


        Console.WriteLine(vbNewLine & "**** win / loss calculations ****")
        Console.WriteLine("  q1 = {0}", countq1)
        Console.WriteLine("  q2 = {0}", countq2)
        Console.WriteLine(" q3 = {0}", countq3)
        Console.WriteLine(" q4 = {0}", countq4)
        Console.WriteLine(" q5 = {0}", countq5)
        Console.WriteLine(" q6 = {0}", countq6)
        Console.WriteLine(" q7 = {0}", countq7)
        Console.WriteLine(" q8 = {0}", countq8)
        Console.WriteLine(" q9 = {0}", countq8)
        Console.WriteLine(" q10 = {0}", countq10)
        Console.ReadLine()


        'diplays the messages written from the feed back 
        Console.WriteLine(Feedback)

        'Displays your new totalscore after the game  
        Console.WriteLine(String.Format("", totalscore.ToString("##0.00")))
        Console.WriteLine()
    End Sub

    '*********************************************************************************************************************************************************************************************************
    Function Genaratequestions(Y, N)

        Dim questions() As String = {"q1", "q2", "q2", "q3", "q4", "q5", "q6", "q7", "q8", "q9", "q10"} 'the questions that will be given to the user 
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 10)

        Dim q1 As Integer = "Was the ** President of the United Stats Donald Trump"
        q1 = Y
        Dim q2 As Integer = "Is Our sun a Star"
        q2 = Y
        Dim q3 As Integer = ""
        q3 = N
        Dim q4 As Integer = "Is Our sun a Star"
        q4 = Y
        Dim q5 As Integer = "Is Our sun a Star"
        q5 = Y
        Dim q6 As Integer = "Is Our sun a Star"
        q6 = Y
        Dim q7 As Integer = "Is Our sun a Star"
        q7 = Y
        Dim q8 As Integer = "Is Our sun a Star"
        q8 = Y
        Dim q9 As Integer = "Is Our sun a Star"
        q9 = Y
        Dim q10 As Integer = "Is Our sun a Star"
        q10 = Y

        For counter As Integer = q1 To q10 'Gose through the questions 
            Console.WriteLine(questions)
        Next counter
        Console.ReadLine()


        Return questions(index) 'gives a selected question
    End Function

End Module
