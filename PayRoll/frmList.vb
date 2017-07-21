Imports System.IO
Imports System.Drawing.Printing

Public Class frmList
    Dim strFirst(1000) As String
    Dim strLast(1000) As String
    Dim intPay(1000) As Integer
    Dim intAge(1000) As Integer
    Dim intTotalPay(1000) As Integer
    Dim intHours(1000) As Integer

    Dim intCounter As Integer
    Dim intIndex As Integer
    Dim filePath As String

    Dim headerFont As New Font("Arial", 30, System.Drawing.FontStyle.Regular)
    Dim printFont As New Font("Arial", 15, System.Drawing.FontStyle.Regular)

    Private WithEvents PrintPreviewDialog1 As New PrintPreviewDialog
    Private WithEvents PrintDocument1 As New PrintDocument

    Private Sub frmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstEmployees.Sorted = False

        lblDetails.Text = "First: Last: Pay Rate: Age:"

        getData()

        lblTotalEmployees.Text = "Total Employees: " & lstEmployees.Items.Count
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        lstEmployees.Items.Clear()

        lblDetails.Text = "First: Last: Pay Rate: Age:"

        getData()

        lstEmployees.Sorted = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstEmployees.Items.Clear()

        getData()

        lblDetails.Text = "First: Last: Pay Rate: Age: Total Pay:"

        For intCounter = 0 To lstEmployees.Items.Count - 1
            intHours(intCounter) = InputBox("Enter hours worked for " & strFirst(intCounter) & ".", "Hours", 0)

            intTotalPay(intCounter) = intHours(intCounter) * intPay(intCounter)

            lstEmployees.Items(intCounter) = lstEmployees.Items(intCounter) & " $" & intTotalPay(intCounter)
        Next
    End Sub

    Private Sub btnPayRate_Click(sender As Object, e As EventArgs) Handles btnPayRate.Click
        lstEmployees.Items.Clear()

        lblDetails.Text = "Pay Rate: First: Last: Age:"

        Dim fileReader As StreamReader
        filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        filePath &= "\employee-info.txt"
        fileReader = New StreamReader(filePath)

        Do While fileReader.Peek() <> -1S
            strFirst(intCounter) = fileReader.ReadLine()
            strLast(intCounter) = fileReader.ReadLine()
            intPay(intCounter) = fileReader.ReadLine()
            intAge(intCounter) = fileReader.ReadLine()

            lstEmployees.Items.Add("$" & intPay(intCounter) & " " & strFirst(intCounter) & " " & strLast(intCounter) & " " & intAge(intCounter))

            intCounter = intCounter + 1
        Loop

        fileReader.Close()

        lstEmployees.Sorted = True
    End Sub

    Private Sub btnAge_Click(sender As Object, e As EventArgs) Handles btnAge.Click
        lstEmployees.Items.Clear()

        lblDetails.Text = "Age: First: Last: Pay Rate:"

        Dim fileReader As StreamReader
        filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        filePath &= "\employee-info.txt"
        fileReader = New StreamReader(filePath)

        Do While fileReader.Peek() <> -1S
            strFirst(intCounter) = fileReader.ReadLine()
            strLast(intCounter) = fileReader.ReadLine()
            intPay(intCounter) = fileReader.ReadLine()
            intAge(intCounter) = fileReader.ReadLine()

            lstEmployees.Items.Add(intAge(intCounter) & " " & strFirst(intCounter) & " " & strLast(intCounter) & " $" & intPay(intCounter))

            intCounter = intCounter + 1
        Loop

        fileReader.Close()

        lstEmployees.Sorted = True
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim strTradeMark As String
        strTradeMark = "Simple Payroll Program:"

        e.Graphics.DrawString(strTradeMark.ToString, headerFont, Brushes.Black, 62, 62)
        e.Graphics.DrawString(lblDetails.Text.ToString, printFont, Brushes.Black, 62, 140)

        Dim startX As Integer = 62
        Dim startY As Integer = 202
        For x As Integer = 0 To lstEmployees.Items.Count - 1
            e.Graphics.DrawString(lstEmployees.Items(x).ToString, printFont, Brushes.Black, startX, startY)
            startY += 62
        Next
    End Sub

    Function getData()
        Dim fileReader As StreamReader
        filePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        filePath &= "\employee-info.txt"
        fileReader = New StreamReader(filePath)

        Do While fileReader.Peek() <> -1S
            strFirst(intCounter) = fileReader.ReadLine()
            strLast(intCounter) = fileReader.ReadLine()
            intPay(intCounter) = fileReader.ReadLine()
            intAge(intCounter) = fileReader.ReadLine()

            lstEmployees.Items.Add(strFirst(intCounter) & " " & strLast(intCounter) & " $" & intPay(intCounter) & " " & intAge(intCounter))

            intCounter = intCounter + 1
        Loop

        fileReader.Close()
    End Function
End Class