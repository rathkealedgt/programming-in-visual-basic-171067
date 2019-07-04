''' <summary>
'''     This exercise will introduce you to if statements and while loops.
''' </summary>
''' <author>Harry Burr </author>
''' <date> 7/4/2019 </date>
''' 
Module Module1

    Sub Main()
        ' Housekeeping
        Dim userimpot As String
        Dim keepgoing As String = ""


        While keepgoing = ""

            ' Ask user if they like coffee and record their answer.
            Console.WriteLine("Do you like coffee?")
            userimpot = Console.ReadLine().ToLower()

            ' Check input and respond
            If userimpot = "yes" Or userimpot = "y" Then
                Console.WriteLine("I like Coffe too!")

            ElseIf userimpot = "no" Or userimpot = "n" Then
                Console.WriteLine("that is sad for you :(")

            ElseIf userimpot = "why" Or userimpot = "I know" Then
                Console.WriteLine("Because you suck")
            Else
                Console.WriteLine("I dont understand")
            End If

            ' Pause program to let the user read 
            Console.WriteLine("press q followed by <enter> to quit.")
            keepgoing = Console.ReadLine()

            If keepgoing = "q" Then
                Exit While
            Else
                keepgoing = ""
            End If

        End While
    End Sub

End Module
