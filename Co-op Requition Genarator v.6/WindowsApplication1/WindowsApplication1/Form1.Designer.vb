<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCreditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSocietyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCreditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateRequisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRequistionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocietyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCase = New System.Windows.Forms.TextBox()
        Me.lblCreditorName = New System.Windows.Forms.Label()
        Me.lblCourtName = New System.Windows.Forms.Label()
        Me.lblSocietyName = New System.Windows.Forms.Label()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.txtRAmount = New System.Windows.Forms.TextBox()
        Me.txtRDate = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.AllPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1539, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCreditorToolStripMenuItem, Me.AddSocietyToolStripMenuItem, Me.UpdateCreditorToolStripMenuItem})
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AddCreditorToolStripMenuItem
        '
        Me.AddCreditorToolStripMenuItem.Name = "AddCreditorToolStripMenuItem"
        Me.AddCreditorToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AddCreditorToolStripMenuItem.Text = "Add Creditor"
        '
        'AddSocietyToolStripMenuItem
        '
        Me.AddSocietyToolStripMenuItem.Name = "AddSocietyToolStripMenuItem"
        Me.AddSocietyToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AddSocietyToolStripMenuItem.Text = "Add Society"
        '
        'UpdateCreditorToolStripMenuItem
        '
        Me.UpdateCreditorToolStripMenuItem.Name = "UpdateCreditorToolStripMenuItem"
        Me.UpdateCreditorToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.UpdateCreditorToolStripMenuItem.Text = "Update Creditor"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllPaymentsToolStripMenuItem, Me.CreateRequisionToolStripMenuItem, Me.UpdateRequistionToolStripMenuItem, Me.SocietyReportToolStripMenuItem, Me.CreateBackupToolStripMenuItem})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(74, 25)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'CreateRequisionToolStripMenuItem
        '
        Me.CreateRequisionToolStripMenuItem.Name = "CreateRequisionToolStripMenuItem"
        Me.CreateRequisionToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CreateRequisionToolStripMenuItem.Text = "Create Requision"
        '
        'UpdateRequistionToolStripMenuItem
        '
        Me.UpdateRequistionToolStripMenuItem.Name = "UpdateRequistionToolStripMenuItem"
        Me.UpdateRequistionToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.UpdateRequistionToolStripMenuItem.Text = "Update Requistion "
        '
        'SocietyReportToolStripMenuItem
        '
        Me.SocietyReportToolStripMenuItem.Name = "SocietyReportToolStripMenuItem"
        Me.SocietyReportToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.SocietyReportToolStripMenuItem.Text = "Society Report"
        '
        'CreateBackupToolStripMenuItem
        '
        Me.CreateBackupToolStripMenuItem.Name = "CreateBackupToolStripMenuItem"
        Me.CreateBackupToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.CreateBackupToolStripMenuItem.Text = "Backup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(57, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(32, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Case No :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(32, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Court Name :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(32, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Society Name :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(32, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Creditor Name :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(35, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Premium :-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(32, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Recieved Amount :-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Location = New System.Drawing.Point(32, 574)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Recieved Date :-"
        '
        'txtCase
        '
        Me.txtCase.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCase.Location = New System.Drawing.Point(327, 73)
        Me.txtCase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCase.Name = "txtCase"
        Me.txtCase.Size = New System.Drawing.Size(219, 34)
        Me.txtCase.TabIndex = 1
        '
        'lblCreditorName
        '
        Me.lblCreditorName.AutoSize = True
        Me.lblCreditorName.BackColor = System.Drawing.SystemColors.Window
        Me.lblCreditorName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditorName.Location = New System.Drawing.Point(327, 290)
        Me.lblCreditorName.Name = "lblCreditorName"
        Me.lblCreditorName.Size = New System.Drawing.Size(69, 27)
        Me.lblCreditorName.TabIndex = 11
        Me.lblCreditorName.Text = "Name"
        '
        'lblCourtName
        '
        Me.lblCourtName.AutoSize = True
        Me.lblCourtName.BackColor = System.Drawing.SystemColors.Window
        Me.lblCourtName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourtName.Location = New System.Drawing.Point(327, 140)
        Me.lblCourtName.Name = "lblCourtName"
        Me.lblCourtName.Size = New System.Drawing.Size(69, 27)
        Me.lblCourtName.TabIndex = 12
        Me.lblCourtName.Text = "Name"
        '
        'lblSocietyName
        '
        Me.lblSocietyName.AutoSize = True
        Me.lblSocietyName.BackColor = System.Drawing.SystemColors.Window
        Me.lblSocietyName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocietyName.Location = New System.Drawing.Point(327, 210)
        Me.lblSocietyName.Name = "lblSocietyName"
        Me.lblSocietyName.Size = New System.Drawing.Size(69, 27)
        Me.lblSocietyName.TabIndex = 13
        Me.lblSocietyName.Text = "Name"
        '
        'lblPremium
        '
        Me.lblPremium.AutoSize = True
        Me.lblPremium.BackColor = System.Drawing.SystemColors.Window
        Me.lblPremium.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremium.Location = New System.Drawing.Point(331, 363)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(54, 27)
        Me.lblPremium.TabIndex = 14
        Me.lblPremium.Text = "0.00"
        '
        'txtRAmount
        '
        Me.txtRAmount.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRAmount.Location = New System.Drawing.Point(327, 484)
        Me.txtRAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRAmount.Name = "txtRAmount"
        Me.txtRAmount.Size = New System.Drawing.Size(356, 34)
        Me.txtRAmount.TabIndex = 3
        '
        'txtRDate
        '
        Me.txtRDate.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDate.Location = New System.Drawing.Point(327, 572)
        Me.txtRDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRDate.Name = "txtRDate"
        Me.txtRDate.Size = New System.Drawing.Size(356, 34)
        Me.txtRDate.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(553, 68)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 44)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(747, 78)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(747, 631)
        Me.DataGridView1.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(37, 640)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(187, 68)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(265, 640)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(187, 68)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Delete"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClose.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(497, 640)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(187, 68)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Print"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.SystemColors.Window
        Me.lbldate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(1224, 44)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(124, 24)
        Me.lbldate.TabIndex = 22
        Me.lbldate.Text = "dd/mm/yyyy"
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Location = New System.Drawing.Point(32, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Balance :-"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Window
        Me.lblBalance.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(331, 426)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(54, 27)
        Me.lblBalance.TabIndex = 24
        Me.lblBalance.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(328, 554)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "mm/dd/yyyy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.SystemColors.Window
        Me.lbltime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(1359, 44)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(104, 24)
        Me.lbltime.TabIndex = 26
        Me.lbltime.Text = "hh:mm:ss" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
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
        'AllPaymentsToolStripMenuItem
        '
        Me.AllPaymentsToolStripMenuItem.Name = "AllPaymentsToolStripMenuItem"
        Me.AllPaymentsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.AllPaymentsToolStripMenuItem.Text = "All Payments"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.vecteezy_abstract_blue_and_gray_wave_background_
        Me.ClientSize = New System.Drawing.Size(1539, 750)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtRDate)
        Me.Controls.Add(Me.txtRAmount)
        Me.Controls.Add(Me.lblPremium)
        Me.Controls.Add(Me.lblSocietyName)
        Me.Controls.Add(Me.lblCourtName)
        Me.Controls.Add(Me.lblCreditorName)
        Me.Controls.Add(Me.txtCase)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Window"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCreditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSocietyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateRequisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCase As TextBox
    Friend WithEvents lblCreditorName As Label
    Friend WithEvents lblCourtName As Label
    Friend WithEvents lblSocietyName As Label
    Friend WithEvents lblPremium As Label
    Friend WithEvents txtRAmount As TextBox
    Friend WithEvents txtRDate As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents UpdateRequistionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents CreateBackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents UpdateCreditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltime As Label
    Friend WithEvents SocietyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents AllPaymentsToolStripMenuItem As ToolStripMenuItem
End Class
