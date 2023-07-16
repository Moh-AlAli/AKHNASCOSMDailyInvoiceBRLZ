<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dailyinv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dailyinv))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Btfind = New System.Windows.Forms.PictureBox()
        Me.Bffind = New System.Windows.Forms.PictureBox()
        Me.Txttocus = New System.Windows.Forms.TextBox()
        Me.Txtfrmcus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbcrdb = New System.Windows.Forms.RadioButton()
        Me.rbinv = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Butprint = New System.Windows.Forms.Button()
        Me.CMDClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Btfind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bffind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Document Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Btfind)
        Me.GroupBox1.Controls.Add(Me.Bffind)
        Me.GroupBox1.Controls.Add(Me.Txttocus)
        Me.GroupBox1.Controls.Add(Me.Txtfrmcus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(290, 28)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(149, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'Btfind
        '
        Me.Btfind.Image = CType(resources.GetObject("Btfind.Image"), System.Drawing.Image)
        Me.Btfind.Location = New System.Drawing.Point(416, 67)
        Me.Btfind.Name = "Btfind"
        Me.Btfind.Size = New System.Drawing.Size(23, 20)
        Me.Btfind.TabIndex = 9
        Me.Btfind.TabStop = False
        '
        'Bffind
        '
        Me.Bffind.Image = CType(resources.GetObject("Bffind.Image"), System.Drawing.Image)
        Me.Bffind.Location = New System.Drawing.Point(261, 67)
        Me.Bffind.Name = "Bffind"
        Me.Bffind.Size = New System.Drawing.Size(23, 20)
        Me.Bffind.TabIndex = 8
        Me.Bffind.TabStop = False
        '
        'Txttocus
        '
        Me.Txttocus.Location = New System.Drawing.Point(290, 67)
        Me.Txttocus.Name = "Txttocus"
        Me.Txttocus.Size = New System.Drawing.Size(127, 20)
        Me.Txttocus.TabIndex = 7
        '
        'Txtfrmcus
        '
        Me.Txtfrmcus.Location = New System.Drawing.Point(134, 67)
        Me.Txtfrmcus.Multiline = True
        Me.Txtfrmcus.Name = "Txtfrmcus"
        Me.Txtfrmcus.Size = New System.Drawing.Size(129, 20)
        Me.Txtfrmcus.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbcrdb)
        Me.GroupBox2.Controls.Add(Me.rbinv)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 46)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'rbcrdb
        '
        Me.rbcrdb.AutoSize = True
        Me.rbcrdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcrdb.Location = New System.Drawing.Point(289, 14)
        Me.rbcrdb.Name = "rbcrdb"
        Me.rbcrdb.Size = New System.Drawing.Size(103, 20)
        Me.rbcrdb.TabIndex = 12
        Me.rbcrdb.Text = "Credit Note"
        Me.rbcrdb.UseVisualStyleBackColor = True
        '
        'rbinv
        '
        Me.rbinv.AutoSize = True
        Me.rbinv.Checked = True
        Me.rbinv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbinv.Location = New System.Drawing.Point(133, 14)
        Me.rbinv.Name = "rbinv"
        Me.rbinv.Size = New System.Drawing.Size(75, 20)
        Me.rbinv.TabIndex = 11
        Me.rbinv.TabStop = True
        Me.rbinv.Text = "Invoice"
        Me.rbinv.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Report Type"
        '
        'Butprint
        '
        Me.Butprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butprint.Location = New System.Drawing.Point(67, 181)
        Me.Butprint.Name = "Butprint"
        Me.Butprint.Size = New System.Drawing.Size(75, 23)
        Me.Butprint.TabIndex = 14
        Me.Butprint.Text = "Print"
        Me.Butprint.UseVisualStyleBackColor = True
        '
        'CMDClose
        '
        Me.CMDClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDClose.Location = New System.Drawing.Point(318, 178)
        Me.CMDClose.Name = "CMDClose"
        Me.CMDClose.Size = New System.Drawing.Size(75, 23)
        Me.CMDClose.TabIndex = 15
        Me.CMDClose.Text = "Exit"
        Me.CMDClose.UseVisualStyleBackColor = True
        '
        'dailyinv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 211)
        Me.Controls.Add(Me.CMDClose)
        Me.Controls.Add(Me.Butprint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dailyinv"
        Me.Text = "Invoice Daily"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Btfind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bffind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btfind As System.Windows.Forms.PictureBox
    Friend WithEvents Bffind As System.Windows.Forms.PictureBox
    Friend WithEvents Txttocus As System.Windows.Forms.TextBox
    Friend WithEvents Txtfrmcus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbcrdb As System.Windows.Forms.RadioButton
    Friend WithEvents rbinv As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Butprint As System.Windows.Forms.Button
    Friend WithEvents CMDClose As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
