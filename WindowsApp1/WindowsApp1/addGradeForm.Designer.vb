<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGradeForm
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
        Me.scoreTextBox = New System.Windows.Forms.TextBox()
        Me.studentIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.courseCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.addGradeButton = New System.Windows.Forms.Button()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.studentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scoreTextBox
        '
        Me.scoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.scoreTextBox.Location = New System.Drawing.Point(586, 189)
        Me.scoreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.scoreTextBox.Name = "scoreTextBox"
        Me.scoreTextBox.Size = New System.Drawing.Size(344, 26)
        Me.scoreTextBox.TabIndex = 37
        '
        'studentIDTextBox
        '
        Me.studentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.studentIDTextBox.Location = New System.Drawing.Point(586, 63)
        Me.studentIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentIDTextBox.Name = "studentIDTextBox"
        Me.studentIDTextBox.Size = New System.Drawing.Size(344, 26)
        Me.studentIDTextBox.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(582, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Enter Student ID"
        '
        'courseCodeComboBox
        '
        Me.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.courseCodeComboBox.FormattingEnabled = True
        Me.courseCodeComboBox.Location = New System.Drawing.Point(586, 126)
        Me.courseCodeComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.courseCodeComboBox.Name = "courseCodeComboBox"
        Me.courseCodeComboBox.Size = New System.Drawing.Size(343, 28)
        Me.courseCodeComboBox.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(777, 318)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 31)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'addGradeButton
        '
        Me.addGradeButton.BackColor = System.Drawing.Color.ForestGreen
        Me.addGradeButton.ForeColor = System.Drawing.Color.White
        Me.addGradeButton.Location = New System.Drawing.Point(586, 318)
        Me.addGradeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addGradeButton.Name = "addGradeButton"
        Me.addGradeButton.Size = New System.Drawing.Size(156, 31)
        Me.addGradeButton.TabIndex = 31
        Me.addGradeButton.Text = "Add Grade"
        Me.addGradeButton.UseVisualStyleBackColor = False
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeTextBox.Location = New System.Drawing.Point(586, 260)
        Me.gradeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(346, 26)
        Me.gradeTextBox.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(582, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(582, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Score"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(582, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Select course code"
        '
        'studentsDataGridView
        '
        Me.studentsDataGridView.AllowUserToAddRows = False
        Me.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentsDataGridView.Location = New System.Drawing.Point(36, 42)
        Me.studentsDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentsDataGridView.Name = "studentsDataGridView"
        Me.studentsDataGridView.ReadOnly = True
        Me.studentsDataGridView.RowHeadersWidth = 62
        Me.studentsDataGridView.RowTemplate.Height = 28
        Me.studentsDataGridView.Size = New System.Drawing.Size(503, 331)
        Me.studentsDataGridView.TabIndex = 38
        '
        'addGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(963, 400)
        Me.Controls.Add(Me.studentsDataGridView)
        Me.Controls.Add(Me.scoreTextBox)
        Me.Controls.Add(Me.studentIDTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.courseCodeComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.addGradeButton)
        Me.Controls.Add(Me.gradeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "addGradeForm"
        Me.Text = "Add Grade"
        CType(Me.studentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreTextBox As TextBox
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents courseCodeComboBox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents addGradeButton As Button
    Friend WithEvents gradeTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentsDataGridView As DataGridView
End Class
