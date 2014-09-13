Imports DataAccessCentralization


Public Class PersonBusinessLogic
    Inherits BaseDataAccess 'access methods via Inheritance

    'Dim d As New BaseDataAccess 'access methods via Instantiation
    Public Sub New()
        InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True")
    End Sub

    public Function GetPerson() As DataTable
        Return getDataTable("Select * from person")
    End Function

    Public Function GetPersonByFirstName(ByVal fname As String) As DataTable
        CreateCommandParameters("fname", fname)
        Return getDataTable(0, "Select * from person where fname=@fname")
    End Function

    Public Function GetPersonByLastName(ByVal lname As String) As DataTable
        CreateCommandParameters("lname", lname)
        Return getDataTable(0, "Select * from person where fname=@lname")
    End Function

    Public Sub InsertPerson(ByVal fname As String, ByVal lname As String)
        CreateCommandParameters("fname", fname)
        CreateCommandParameters("lname", lname)
        SaveChanges("insert into person(fname,lname) values(@fname,@lname)", CommandType.Text)
    End Sub
End Class
