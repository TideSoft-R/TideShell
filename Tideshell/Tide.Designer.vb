<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tide
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Timer1 As System.Windows.Forms.Timer
        Me.Time = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Data = New System.Windows.Forms.Label()
        Me.NewControlButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShkafBlyat = New System.Windows.Forms.Button()
        Me.vers = New System.Windows.Forms.Label()
        Me.oboi = New System.Windows.Forms.Panel()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.oboi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Timer1.Enabled = True
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf Me.Timer1_Tick
        '
        'Time
        '
        Me.Time.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Time.BackColor = System.Drawing.Color.Transparent
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Time.ForeColor = System.Drawing.SystemColors.Info
        Me.Time.Location = New System.Drawing.Point(9, 2)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(65, 19)
        Me.Time.TabIndex = 12
        Me.Time.Text = "00:00:00"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(619, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(122, 198)
        Me.Panel3.TabIndex = 16
        Me.Panel3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Выход"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.NewControlButton)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.ShkafBlyat)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 40)
        Me.Panel2.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Time)
        Me.Panel1.Controls.Add(Me.Data)
        Me.Panel1.Location = New System.Drawing.Point(615, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 40)
        Me.Panel1.TabIndex = 19
        '
        'Data
        '
        Me.Data.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Data.BackColor = System.Drawing.Color.Transparent
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Data.ForeColor = System.Drawing.SystemColors.Info
        Me.Data.Location = New System.Drawing.Point(2, 18)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(81, 19)
        Me.Data.TabIndex = 18
        Me.Data.Text = "26.01.2006"
        Me.Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewControlButton
        '
        Me.NewControlButton.BackColor = System.Drawing.Color.White
        Me.NewControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewControlButton.Image = Global.Tideshell.My.Resources.Resources.imageres_27
        Me.NewControlButton.Location = New System.Drawing.Point(3, 4)
        Me.NewControlButton.Name = "NewControlButton"
        Me.NewControlButton.Size = New System.Drawing.Size(32, 32)
        Me.NewControlButton.TabIndex = 17
        Me.NewControlButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(699, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ShkafBlyat
        '
        Me.ShkafBlyat.BackColor = System.Drawing.Color.White
        Me.ShkafBlyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShkafBlyat.Location = New System.Drawing.Point(41, 4)
        Me.ShkafBlyat.Name = "ShkafBlyat"
        Me.ShkafBlyat.Size = New System.Drawing.Size(32, 32)
        Me.ShkafBlyat.TabIndex = 2
        Me.ShkafBlyat.Text = "?"
        Me.ShkafBlyat.UseVisualStyleBackColor = False
        '
        'vers
        '
        Me.vers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vers.AutoSize = True
        Me.vers.BackColor = System.Drawing.Color.Transparent
        Me.vers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.vers.ForeColor = System.Drawing.Color.White
        Me.vers.Location = New System.Drawing.Point(381, 300)
        Me.vers.Name = "vers"
        Me.vers.Size = New System.Drawing.Size(360, 25)
        Me.vers.TabIndex = 18
        Me.vers.Text = "Tideshell.release.candidate.build.X3"
        '
        'oboi
        '
        Me.oboi.BackColor = System.Drawing.Color.LightSkyBlue
        Me.oboi.Controls.Add(Me.vers)
        Me.oboi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oboi.ForeColor = System.Drawing.Color.Black
        Me.oboi.Location = New System.Drawing.Point(0, 0)
        Me.oboi.Name = "oboi"
        Me.oboi.Size = New System.Drawing.Size(741, 328)
        Me.oboi.TabIndex = 19
        '
        'Calendar
        '
        Me.Calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendar.Location = New System.Drawing.Point(568, 166)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 19
        Me.Calendar.Visible = False
        '
        'Tide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(741, 368)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.oboi)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tide"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TideDesktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.oboi.ResumeLayout(False)
        Me.oboi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShkafBlyat As System.Windows.Forms.Button
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NewControlButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents vers As System.Windows.Forms.Label
    Friend WithEvents oboi As System.Windows.Forms.Panel
    Friend WithEvents Data As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Calendar As System.Windows.Forms.MonthCalendar

End Class
