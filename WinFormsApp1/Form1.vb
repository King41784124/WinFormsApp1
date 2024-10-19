Public Class Form1

    Public Class Book


        Public Property BookID As Integer
        Public Property Title As String
        Public Property Author As String
        Public Property Available As Boolean
        Public Property DueDate As DateTime

        Dim bookList As New List(Of Book)


        Private Sub Form1_Load(sender As Object, e As EventArgs, dataGridView1 As DataGridView) Handles MyBase.Load
            ' Add sample books
            bookList.Add(New Book() With {.BookID = 1, .Title = "Harry Potter", .Author = "J.K. Rowling", .Available = True})
            bookList.Add(New Book() With {.BookID = 2, .Title = "The Hobbit", .Author = "J.R.R. Tolkien", .Available = True})

            UpdateBookGrid(dataGridView1)
        End Sub


        Private Sub UpdateBookGrid(dataGridView1 As DataGridView)
            dataGridView1.DataSource = Nothing
            dataGridView1.DataSource = bookList
        End Sub

        Private Sub RentBook(bookID As Integer, days As Integer, dataGridView1 As DataGridView)
            Dim book = bookList.FirstOrDefault(Function(b) b.BookID = bookID)
            If book IsNot Nothing AndAlso book.Available Then
                book.Available = False
                book.DueDate = DateTime.Now.AddDays(days)
                UpdateBookGrid(dataGridView1)
                MessageBox.Show($"Book '{book.Title}' rented. Due on {book.DueDate.ToShortDateString()}.")
            Else
                MessageBox.Show("Book not available for rent.")
            End If
        End Sub

        Private Sub ReturnBook(bookID As Integer, dataGridView1 As DataGridView)
            Dim book = bookList.FirstOrDefault(Function(b) b.BookID = bookID)
            If book IsNot Nothing AndAlso Not book.Available Then
                book.Available = True
                book.DueDate = DateTime.MinValue
                UpdateBookGrid(dataGridView1)
                MessageBox.Show($"Book '{book.Title}' returned.")
            Else
                MessageBox.Show("Book not currently rented.")
            End If
        End Sub

#Disable Warning IDE0051 ' Remove unused private members
        Private Sub BtnRent_Click(sender As Object, e As EventArgs, txtDays As TextBox, txtBookID As TextBox, dataGridView1 As DataGridView) Handles btnRent.Click

#Enable Warning IDE0051 ' Remove unused private members

            Dim bookID As Integer = CInt(txtBookID.Text)
            Dim days As Integer = CInt(txtDays.Text)
            RentBook(bookID, days, dataGridView1)
        End Sub

        Private Sub BtnReturn_Click(sender As Object, e As EventArgs, txtBookID As TextBox, dataGridView1 As DataGridView) Handles btnReturn.Click


            Dim bookID As Integer = CInt(txtBookID.Text)
            ReturnBook(bookID, dataGridView1)
        End Sub
    End Class
End Class


