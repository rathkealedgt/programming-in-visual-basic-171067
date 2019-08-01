Module Component2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 1
    '''     Generate a token from a list and display it to a user 
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Dim token As String = GetToken()
        Console.WriteLine()
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Dim Token() As String = {"Horse, Zebra, Donkey, Unicorn"}
        Dim rand As Random = New Random()
        Dim index As Integer = rand.Next(0, 4)

        Return Token(index)
    End Function

End Module
