Module Module1

    Sub Main()
        Dim test As New Collection
        Dim st As New Stagiaire(1, "test", "abdel", 10, 10)
        Dim st2 As New Stagiaire(2, "test2", "abdel2", 20, 20)
        Dim st3 As New Stagiaire(3, "test3", "abdel3", 30, 30)


        test.Add(st)
        test.Add(st2)
        test.Add(st3)




        Console.ReadKey()




    End Sub

End Module
