Imports System.Windows.Forms
Imports DataAccessCentralization

Public Class Form1
    'Dim p As New PersonBusinessLogic
    Dim d As New BaseDataAccess

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        d.InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True")
        DeclarePersonParametersForAdd(txtAddFname.Text, txtAddMname.Text, txtAddLname.Text)
        d.SaveChanges("insert into person(fname,mname,lname) values(@fname,@mname,@lname)")
        getData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        d.InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True")
        DeclarePersonParametersForUpdate(Integer.Parse(txtUpdateId.Text), txtUpdateFname.Text, txtUpdateMname.Text, txtUpdateLname.Text)
        d.SaveChanges("update person set fname=@fname,mname=@mname,lname=@lname where ID=@id")
        getData()
        clearUpdateTexts()
    End Sub

    Private Sub getData()
        d.InitializeDataAccess(ProviderType.Oledb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=person.accdb;Persist Security Info=True", "select * from person")
        DataGridView1.DataSource = d.getDataTable()
    End Sub

    Private Sub DeclarePersonParametersForUpdate(ByVal id As Integer, ByVal fname As String, ByVal mname As String, ByVal lname As String)
        d.CreateCommandParameters("fname", fname)
        d.CreateCommandParameters("mname", mname)
        d.CreateCommandParameters("lname", lname)
        d.CreateCommandParameters("id", id)
    End Sub

    Private Sub DeclarePersonParametersForAdd(ByVal fname As String, ByVal mname As String, ByVal lname As String)
        d.CreateCommandParameters("fname", fname)
        d.CreateCommandParameters("mname", mname)
        d.CreateCommandParameters("lname", lname)
    End Sub

    Private Sub clearUpdateTexts()
        txtUpdateId.Text = ""
        txtUpdateFname.Text = ""
        txtUpdateMname.Text = ""
        txtUpdateLname.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim rowIndex As Integer = e.RowIndex
        txtUpdateId.Text = DataGridView1.Rows(rowIndex).Cells("id").Value.ToString()
        txtUpdateFname.Text = DataGridView1.Rows(rowIndex).Cells("fname").Value.ToString()
        txtUpdateMname.Text = DataGridView1.Rows(rowIndex).Cells("mname").Value.ToString()
        txtUpdateLname.Text = DataGridView1.Rows(rowIndex).Cells("lname").Value.ToString()
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        d.CreateCommandParameters("id", txtUpdateId.Text)
        d.SaveChanges("delete from person where id=@id")
        getData()
        clearUpdateTexts()
    End Sub
End Class