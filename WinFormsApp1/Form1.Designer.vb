<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBookID = New TextBox()
        txtDays = New TextBox()
        btnRent = New Button()
        btnReturn = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(261, 245)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(125, 27)
        txtBookID.TabIndex = 0
        ' 
        ' txtDays
        ' 
        txtDays.Location = New Point(436, 245)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(125, 27)
        txtDays.TabIndex = 1
        ' 
        ' btnRent
        ' 
        btnRent.Location = New Point(279, 295)
        btnRent.Name = "btnRent"
        btnRent.Size = New Size(94, 29)
        btnRent.TabIndex = 2
        btnRent.Text = "Rent"
        btnRent.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(451, 295)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 29)
        btnReturn.TabIndex = 3
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(261, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnReturn)
        Controls.Add(btnRent)
        Controls.Add(txtDays)
        Controls.Add(txtBookID)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents btnRent As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
