Module Module1
    ''' <summary>
    '''     This program will show you how to get input from the user.
    ''' </summary>
    ''' <author> Mr Macri </author>
    ''' <date> 10Jun19 </date>
    ''' 
    Sub Main()
        ' Housekeeping
        Dim Usersname, outputMessage As String
        Dim Firstnumber, Secoundnumber, sum, product As Integer

        ' Ask for user name
        Console.WriteLine("What is your name")
        Usersname = Console.ReadLine()

        ' Ask user for two numbers
        Console.WriteLine("Enter a Number")
        Firstnumber = Console.ReadLine()

        Console.WriteLine("Enter another number")
        Secoundnumber = Console.ReadLine()
        ' Add numbers together
        sum = Firstnumber + Secoundnumber

        ' Multiply numbers together
        product = Firstnumber * Secoundnumber

        ' Greet user and display maths
        outputMessage = String.Format("Hello, {0}. The sum of your Numbers equals {1}. The product of your numbers equals {2}." Username, sum)

    End Sub

End Module
