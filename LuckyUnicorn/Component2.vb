Module Component2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a token from a list and display it to a user 
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        For counter As Integer = 0 To 15
            Dim token As String = GetToken()
            Console.WriteLine(token)
        Next counter
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Dim tokens() As String = {"Horse, Zebra, Donkey, Unicorn"}
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 3)


        Return tokens(index)
    End Function

End Module
