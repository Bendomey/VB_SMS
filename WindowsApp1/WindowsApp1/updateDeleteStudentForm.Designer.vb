<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateDeleteStudentForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.deleteStudentButton = New System.Windows.Forms.Button()
        Me.updateStudentButton = New System.Windows.Forms.Button()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.studentPictureBox = New System.Windows.Forms.PictureBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.maleRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(156, 292)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(292, 44)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.femaleRadioButton.ForeColor = System.Drawing.Color.White
        Me.femaleRadioButton.Location = New System.Drawing.Point(148, 9)
        Me.femaleRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(98, 29)
        Me.femaleRadioButton.TabIndex = 1
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Checked = True
        Me.maleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.maleRadioButton.ForeColor = System.Drawing.Color.White
        Me.maleRadioButton.Location = New System.Drawing.Point(5, 9)
        Me.maleRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(76, 29)
        Me.maleRadioButton.TabIndex = 0
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(52, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Gender"
        '
        'deleteStudentButton
        '
        Me.deleteStudentButton.BackColor = System.Drawing.Color.Red
        Me.deleteStudentButton.ForeColor = System.Drawing.Color.White
        Me.deleteStudentButton.Location = New System.Drawing.Point(330, 447)
        Me.deleteStudentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deleteStudentButton.Name = "deleteStudentButton"
        Me.deleteStudentButton.Size = New System.Drawing.Size(140, 32)
        Me.deleteStudentButton.TabIndex = 31
        Me.deleteStudentButton.Text = "Delete"
        Me.deleteStudentButton.UseVisualStyleBackColor = False
        '
        'updateStudentButton
        '
        Me.updateStudentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateStudentButton.BackColor = System.Drawing.Color.ForestGreen
        Me.updateStudentButton.ForeColor = System.Drawing.Color.White
        Me.updateStudentButton.Location = New System.Drawing.Point(52, 447)
        Me.updateStudentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.updateStudentButton.Name = "updateStudentButton"
        Me.updateStudentButton.Size = New System.Drawing.Size(248, 32)
        Me.updateStudentButton.TabIndex = 30
        Me.updateStudentButton.Text = "Save"
        Me.updateStudentButton.UseVisualStyleBackColor = False
        '
        'uploadButton
        '
        Me.uploadButton.BackColor = System.Drawing.Color.ForestGreen
        Me.uploadButton.ForeColor = System.Drawing.Color.White
        Me.uploadButton.Location = New System.Drawing.Point(524, 292)
        Me.uploadButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(302, 31)
        Me.uploadButton.TabIndex = 29
        Me.uploadButton.Text = "Upload Image"
        Me.uploadButton.UseVisualStyleBackColor = False
        '
        'studentPictureBox
        '
        Me.studentPictureBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.studentPictureBox.Location = New System.Drawing.Point(524, 64)
        Me.studentPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentPictureBox.Name = "studentPictureBox"
        Me.studentPictureBox.Size = New System.Drawing.Size(302, 188)
        Me.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPictureBox.TabIndex = 28
        Me.studentPictureBox.TabStop = False
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(524, 365)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addressTextBox.Multiline = True
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(311, 79)
        Me.addressTextBox.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(519, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Address"
        '
        'contactTextBox
        '
        Me.contactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTextBox.Location = New System.Drawing.Point(56, 386)
        Me.contactTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(415, 30)
        Me.contactTextBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Contact"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 262)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(411, 23)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Date of Birth"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnameTextBox.Location = New System.Drawing.Point(52, 194)
        Me.lnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(415, 30)
        Me.lnameTextBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameTextBox.Location = New System.Drawing.Point(56, 133)
        Me.fnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(415, 30)
        Me.fnameTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "First Name"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(56, 64)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(415, 30)
        Me.IDTextBox.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "ID"
        '
        'updateDeleteStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(920, 557)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.deleteStudentButton)
        Me.Controls.Add(Me.updateStudentButton)
        Me.Controls.Add(Me.uploadButton)
        Me.Controls.Add(Me.studentPictureBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "updateDeleteStudentForm"
        Me.Text = "updateDeleteStudentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents deleteStudentButton As Button
    Friend WithEvents updateStudentButton As Button
    Friend WithEvents uploadButton As Button
    Friend WithEvents studentPictureBox As PictureBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
