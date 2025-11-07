Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim numbers As New List(Of Integer)
    Dim filepath As String = "numbers.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim verify As Boolean = Double.TryParse(input.Text, Nothing)

        If verify Then

            Using writer As New StreamWriter(filepath, True)
                writer.WriteLine(input.Text)
                ListBox1.Items.Add(input.Text)
            End Using

            numbers.Clear()
            Using reader As New StreamReader(filepath)
                While Not reader.EndOfStream

                    Dim line As String = reader.ReadLine()

                    If Integer.TryParse(line, Nothing) Then
                        numbers.Add(Convert.ToInt32(line))
                    End If

                End While
            End Using

        Else
            MessageBox.Show("Please enter a valid number.")
        End If

    End Sub

    Private Sub ShowList_Click(sender As Object, e As EventArgs) Handles SortList.Click


        Dim sorted = numbers.OrderBy(Function(n) n)

        ListBox1.Items.Clear()
        For Each item In sorted
            ListBox1.Items.Add(item)
        Next


    End Sub

    Private Sub ClearList_Click(sender As Object, e As EventArgs) Handles ClearList.Click
        numbers.Clear()
        File.WriteAllText(filepath, "")
        ListBox1.Items.Clear()
    End Sub
End Class
