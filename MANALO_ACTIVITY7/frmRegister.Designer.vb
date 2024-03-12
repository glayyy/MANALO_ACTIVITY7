<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        txtLastName = New TextBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        txtUsername = New TextBox()
        Label6 = New Label()
        txtPassword = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 0
        Label1.Text = "FIRST NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(323, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 1
        Label2.Text = "MIDDLE NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(587, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 2
        Label3.Text = "LAST NAME"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = SystemColors.ScrollBar
        txtFirstName.ForeColor = SystemColors.WindowText
        txtFirstName.Location = New Point(32, 41)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(151, 24)
        txtFirstName.TabIndex = 3
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.BackColor = SystemColors.ScrollBar
        txtMiddleName.Location = New Point(289, 41)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(151, 24)
        txtMiddleName.TabIndex = 4
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.ScrollBar
        txtLastName.Location = New Point(541, 41)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(151, 24)
        txtLastName.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(338, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 6
        Label4.Text = "BIRTHDATE"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(274, 134)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 24)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(338, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 8
        Label5.Text = "USERNAME"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ScrollBar
        txtUsername.Location = New Point(244, 239)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(253, 24)
        txtUsername.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(337, 281)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 15)
        Label6.TabIndex = 10
        Label6.Text = "PASSWORD"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ScrollBar
        txtPassword.Location = New Point(244, 312)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(253, 24)
        txtPassword.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(334, 350)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(263, 391)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(215, 15)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "ALREADY HAVE AN ACCOUNT? LOGIN"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFirstName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Name = "frmRegister"
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
