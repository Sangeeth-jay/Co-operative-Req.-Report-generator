<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.d2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbsocietyname = New System.Windows.Forms.ComboBox()
        Me.SocietyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoopDataSet = New WindowsApplication1.coopDataSet()
        Me.SocietyTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.SocietyTableAdapter()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(34, 96)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(243, 25)
        Me.d1.TabIndex = 0
        '
        'd2
        '
        Me.d2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(361, 96)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(243, 25)
        Me.d2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(570, 276)
        Me.DataGridView1.TabIndex = 3
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnprint.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(388, 436)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(98, 44)
        Me.btnprint.TabIndex = 4
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnclose.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(506, 436)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(98, 44)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(271, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Amount"
        '
        'cmbsocietyname
        '
        Me.cmbsocietyname.DataSource = Me.SocietyBindingSource
        Me.cmbsocietyname.DisplayMember = "Society_name"
        Me.cmbsocietyname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsocietyname.FormattingEnabled = True
        Me.cmbsocietyname.Location = New System.Drawing.Point(34, 49)
        Me.cmbsocietyname.Name = "cmbsocietyname"
        Me.cmbsocietyname.Size = New System.Drawing.Size(570, 27)
        Me.cmbsocietyname.TabIndex = 8
        '
        'SocietyBindingSource
        '
        Me.SocietyBindingSource.DataMember = "Society"
        Me.SocietyBindingSource.DataSource = Me.CoopDataSet
        '
        'CoopDataSet
        '
        Me.CoopDataSet.DataSetName = "coopDataSet"
        Me.CoopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SocietyTableAdapter
        '
        Me.SocietyTableAdapter.ClearBeforeFill = True
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.SystemColors.Window
        Me.lbltot.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.Location = New System.Drawing.Point(119, 436)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(33, 16)
        Me.lbltot.TabIndex = 9
        Me.lbltot.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 436)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Full Amount :"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.Window
        Me.lblDate.Location = New System.Drawing.Point(539, 33)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(65, 13)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "dd/mm/yyyy"
        '
        'Timer1
        '
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.vecteezy_abstract_blue_and_gray_wave_background_
        Me.ClientSize = New System.Drawing.Size(652, 509)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.cmbsocietyname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents d1 As DateTimePicker
    Friend WithEvents d2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnprint As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbsocietyname As ComboBox
    Friend WithEvents CoopDataSet As coopDataSet
    Friend WithEvents SocietyBindingSource As BindingSource
    Friend WithEvents SocietyTableAdapter As coopDataSetTableAdapters.SocietyTableAdapter
    Friend WithEvents lbltot As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
End Class
