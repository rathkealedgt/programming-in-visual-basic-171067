Module Module2
    Sub main()

        For counter As Integer = q1 To q10
            Dim questions As String = Genaratequestions()
            Console.WriteLine(questions)
        Next counter
        Console.ReadLine()

    End Sub

    Function Genaratequestions() As String
        Dim q1 As Char = "Was the ** President of the United Stats Donald Trump"
        q1 = Y
        Dim q2 As Char = "Is Our sun a Star"
        q2 = Y
        Dim q3 As Char = "fff"
        q3 = N
        Dim q4 As Char = "Is Our sun a Star"
        q4 = Y
        Dim q5 As Char = "Is Our sun a Star"
        q5 = Y
        Dim q6 As Char = "Is Our sun a Star"
        q6 = Y
        Dim q7 As Char = "Is Our sun a Star"
        q7 = Y
        Dim q8 As Char = "Is Our sun a Star"
        q8 = Y
        Dim q9 As Char = "Is Our sun a Star"
        q9 = Y
        Dim q10 As Char = "Is Our sun a Star"
        q10 = Y

        Dim questions As String = ("q1", "q2", "q2", "q3", "q4", "q5", "q6", "q7", "q8", "q9", "q10") 'the questions that will be given to the user 
        Dim rnad As rand = New Random() 'creats a random veriable called rand 
        Dim index As String = rand.Next(q1, q10) 'Selects a random question from the string 

        Return questions(index) 'gives a selected question  
    End Function


End Module
