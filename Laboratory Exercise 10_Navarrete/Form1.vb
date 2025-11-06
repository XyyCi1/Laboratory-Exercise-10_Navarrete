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

            MessageBox.Show($"{input.Text} saved successfully.")
        Else
            MessageBox.Show("Please enter a valid number.")

        End If

    End Sub

    Private Sub ShowList_Click(sender As Object, e As EventArgs) Handles ShowList.Click




        Dim print As String = "Numbers in the list:" & Environment.NewLine

        Dim sorted = numbers.OrderByDescending(Function(x) x)

        For Each item In sorted
            print += item & Environment.NewLine
        Next

        MessageBox.Show(print)
    End Sub

    Private Sub ClearList_Click(sender As Object, e As EventArgs) Handles ClearList.Click
        numbers.Clear()
        File.WriteAllText(filepath, "")
    End Sub
End Class
