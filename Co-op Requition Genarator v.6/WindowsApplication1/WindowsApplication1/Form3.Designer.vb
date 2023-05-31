<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSocietyName = New System.Windows.Forms.ComboBox()
        Me.SocietyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoopDataSet = New WindowsApplication1.coopDataSet()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.d2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SocietyTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.SocietyTableAdapter()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Society Name : "
        '
        'cmbSocietyName
        '
        Me.cmbSocietyName.DataSource = Me.SocietyBindingSource
        Me.cmbSocietyName.DisplayMember = "Society_name"
        Me.cmbSocietyName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSocietyName.FormattingEnabled = True
        Me.cmbSocietyName.Location = New System.Drawing.Point(196, 31)
        Me.cmbSocietyName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSocietyName.Name = "cmbSocietyName"
        Me.cmbSocietyName.Size = New System.Drawing.Size(666, 27)
        Me.cmbSocietyName.TabIndex = 1
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
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(99, 102)
        Me.d1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(230, 26)
        Me.d1.TabIndex = 2
        '
        'd2
        '
        Me.d2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(584, 102)
        Me.d2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(230, 26)
        Me.d2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'btnCreateR
        '
        Me.btnCreateR.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCreateR.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateR.Location = New System.Drawing.Point(53, 146)
        Me.btnCreateR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreateR.Name = "btnCreateR"
        Me.btnCreateR.Size = New System.Drawing.Size(808, 58)
        Me.btnCreateR.TabIndex = 5
        Me.btnCreateR.Text = "Create Requision Report"
        Me.btnCreateR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 224)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(808, 266)
        Me.DataGridView1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(772, 511)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 49)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(665, 511)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 49)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 514)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Amount :"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.SystemColors.Window
        Me.lblTot.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Location = New System.Drawing.Point(152, 514)
        Me.lblTot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(36, 17)
        Me.lblTot.TabIndex = 10
        Me.lblTot.Text = "0.00"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(746, 69)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(80, 17)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "dd/mm/yyyy"
        '
        'Timer1
        '
        '
        'SocietyTableAdapter
        '
        Me.SocietyTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument2
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.vecteezy_abstract_blue_and_gray_wave_background_
        Me.ClientSize = New System.Drawing.Size(932, 579)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCreateR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.cmbSocietyName)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSocietyName As ComboBox
    Friend WithEvents d1 As DateTimePicker
    Friend WithEvents d2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateR As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CoopDataSet As coopDataSet
    Friend WithEvents SocietyBindingSource As BindingSource
    Friend WithEvents SocietyTableAdapter As coopDataSetTableAdapters.SocietyTableAdapter
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
