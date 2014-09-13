Imports DataAccessCentralization

Module Module1

    'Inherits BaseDataAccess
    Public Sub Main()
        Dim d As New BaseDataAccess
        d.InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True", "Select * from person")
        Console.WriteLine("Sample API Demo. . .")
        Console.WriteLine("Created by: Sonny R. Recio")
        Console.WriteLine("Press Enter to run demo")
        Console.Read()
        Console.Clear()

        Console.WriteLine("Displaying List of names:")
        For Each i As DataRow In d.getDataTable(0).Rows
            Console.WriteLine()
            Console.WriteLine("First name: {0}" & vbNewLine & "Middle initial:{1}" & vbNewLine & "Last name:{2}", i("fname"), i("mname"), i("lname"))
        Next
    End Sub

End Module
