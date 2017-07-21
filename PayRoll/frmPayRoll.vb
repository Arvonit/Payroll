Imports System.IO

Public Class frmPayRoll
    Dim strInfo(1000) As String

    Dim intCounter As Integer
    Dim strFirstName(1000) As String
    Dim strLastName(1000) As String
    Dim intPayRate(1000) As Integer
    Dim intAge(1000) As Integer

    Dim intIndex As Integer
    Dim filePath As String

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        frmList.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lstNewEmployees.Items.Count = 0 Then
            MsgBox("Error: Missing data")
            GoTo Break
        End If

        Dim fileWriter As StreamWriter
        filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        filePath &= "\employee-info.txt"
        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)

        For intCounter = 0 To (lstNewEmployees.Items.Count - 1)
            fileWriter.WriteLine(CStr(strFirstName(intCounter)))
            fileWriter.WriteLine(CStr(strLastName(intCounter)))
            fileWriter.WriteLine(CStr(intPayRate(intCounter)))
            fileWriter.WriteLine(CStr(intAge(intCounter)))
        Next

        fileWriter.Close()

Break:
    End Sub

    Private Sub frmPayRoll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmployee.Click
        If txtFirst.Text = "" Then
            MsgBox("Error: Missing information")
            GoTo Break
        ElseIf txtLast.Text = "" Then
            MsgBox("Error: Missing information")
        ElseIf txtPayRate.Text = "" Then
            MsgBox("Error: Missing information")
        ElseIf txtAge.Text = "" Then
            MsgBox("Error: Missing information")
        End If

        lblDetails.Text = "First: Last: Pay Rate: Age:"

        strFirstName(intIndex) = txtFirst.Text
        strLastName(intIndex) = txtLast.Text
        intPayRate(intIndex) = Val(txtPayRate.Text)
        intAge(intIndex) = Val(txtAge.Text)

        strInfo(intIndex) = strFirstName(intIndex) & " " & strLastName(intIndex) & " $" & intPayRate(intIndex) & " " & intAge(intIndex)

        lstNewEmployees.Items.Add(strInfo(intIndex))

        txtFirst.Clear()
        txtLast.Clear()
        txtPayRate.Clear()
        txtAge.Clear()

        intIndex = intIndex + 1

Break:
    End Sub

    Private Sub lstNewEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNewEmployees.SelectedIndexChanged
    End Sub
End Class
