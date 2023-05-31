<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRno = New System.Windows.Forms.TextBox()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.txtInstallment = New System.Windows.Forms.TextBox()
        Me.txtGuaranter1 = New System.Windows.Forms.TextBox()
        Me.txtGuaranter2 = New System.Windows.Forms.TextBox()
        Me.cmbSocietyName = New System.Windows.Forms.ComboBox()
        Me.SocietyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoopDataSet = New WindowsApplication1.coopDataSet()
        Me.cmbCourtName = New System.Windows.Forms.ComboBox()
        Me.CourtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CourtTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.CourtTableAdapter()
        Me.SocietyTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.SocietyTableAdapter()
        Me.txtCreditorName = New System.Windows.Forms.TextBox()
        Me.dtview = New System.Windows.Forms.DataGridView()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(24, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Referee No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(24, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Case No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(24, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Court Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(24, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Society No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(24, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Creditor Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(26, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Premium :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Location = New System.Drawing.Point(24, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Installment :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Location = New System.Drawing.Point(24, 530)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Guaranter 1 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label9.Location = New System.Drawing.Point(24, 603)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 29)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Guaranter 2 :"
        '
        'txtRno
        '
        Me.txtRno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRno.Location = New System.Drawing.Point(228, 48)
        Me.txtRno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRno.Name = "txtRno"
        Me.txtRno.Size = New System.Drawing.Size(303, 30)
        Me.txtRno.TabIndex = 0
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Location = New System.Drawing.Point(228, 107)
        Me.txtCaseNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(303, 30)
        Me.txtCaseNo.TabIndex = 1
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(228, 369)
        Me.txtPremium.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(303, 30)
        Me.txtPremium.TabIndex = 5
        '
        'txtInstallment
        '
        Me.txtInstallment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallment.Location = New System.Drawing.Point(228, 448)
        Me.txtInstallment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInstallment.Name = "txtInstallment"
        Me.txtInstallment.Size = New System.Drawing.Size(303, 30)
        Me.txtInstallment.TabIndex = 6
        '
        'txtGuaranter1
        '
        Me.txtGuaranter1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuaranter1.Location = New System.Drawing.Point(228, 530)
        Me.txtGuaranter1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGuaranter1.Name = "txtGuaranter1"
        Me.txtGuaranter1.Size = New System.Drawing.Size(303, 30)
        Me.txtGuaranter1.TabIndex = 7
        '
        'txtGuaranter2
        '
        Me.txtGuaranter2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuaranter2.Location = New System.Drawing.Point(228, 609)
        Me.txtGuaranter2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGuaranter2.Name = "txtGuaranter2"
        Me.txtGuaranter2.Size = New System.Drawing.Size(303, 30)
        Me.txtGuaranter2.TabIndex = 8
        '
        'cmbSocietyName
        '
        Me.cmbSocietyName.DataSource = Me.SocietyBindingSource
        Me.cmbSocietyName.DisplayMember = "Society_name"
        Me.cmbSocietyName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSocietyName.FormattingEnabled = True
        Me.cmbSocietyName.Location = New System.Drawing.Point(228, 233)
        Me.cmbSocietyName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSocietyName.Name = "cmbSocietyName"
        Me.cmbSocietyName.Size = New System.Drawing.Size(303, 30)
        Me.cmbSocietyName.TabIndex = 3
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
        'cmbCourtName
        '
        Me.cmbCourtName.DataSource = Me.CourtBindingSource
        Me.cmbCourtName.DisplayMember = "Court_name"
        Me.cmbCourtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourtName.FormattingEnabled = True
        Me.cmbCourtName.Location = New System.Drawing.Point(228, 174)
        Me.cmbCourtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCourtName.Name = "cmbCourtName"
        Me.cmbCourtName.Size = New System.Drawing.Size(303, 30)
        Me.cmbCourtName.TabIndex = 2
        '
        'CourtBindingSource
        '
        Me.CourtBindingSource.DataMember = "Court"
        Me.CourtBindingSource.DataSource = Me.CoopDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 665)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 60)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(204, 665)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 60)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(377, 665)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 60)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CourtTableAdapter
        '
        Me.CourtTableAdapter.ClearBeforeFill = True
        '
        'SocietyTableAdapter
        '
        Me.SocietyTableAdapter.ClearBeforeFill = True
        '
        'txtCreditorName
        '
        Me.txtCreditorName.Font = New System.Drawing.Font("Iskoola Pota", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditorName.Location = New System.Drawing.Point(228, 303)
        Me.txtCreditorName.Name = "txtCreditorName"
        Me.txtCreditorName.Size = New System.Drawing.Size(303, 30)
        Me.txtCreditorName.TabIndex = 21
        '
        'dtview
        '
        Me.dtview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtview.Location = New System.Drawing.Point(574, 42)
        Me.dtview.Name = "dtview"
        Me.dtview.RowTemplate.Height = 24
        Me.dtview.Size = New System.Drawing.Size(507, 683)
        Me.dtview.TabIndex = 24
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.vecteezy_abstract_blue_and_gray_wave_background_
        Me.ClientSize = New System.Drawing.Size(1119, 750)
        Me.Controls.Add(Me.dtview)
        Me.Controls.Add(Me.txtCreditorName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCourtName)
        Me.Controls.Add(Me.cmbSocietyName)
        Me.Controls.Add(Me.txtGuaranter2)
        Me.Controls.Add(Me.txtGuaranter1)
        Me.Controls.Add(Me.txtInstallment)
        Me.Controls.Add(Me.txtPremium)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.txtRno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Creditor"
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRno As TextBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents txtInstallment As TextBox
    Friend WithEvents txtGuaranter1 As TextBox
    Friend WithEvents txtGuaranter2 As TextBox
    Friend WithEvents cmbSocietyName As ComboBox
    Friend WithEvents cmbCourtName As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CoopDataSet As coopDataSet
    Friend WithEvents CourtBindingSource As BindingSource
    Friend WithEvents CourtTableAdapter As coopDataSetTableAdapters.CourtTableAdapter
    Friend WithEvents SocietyBindingSource As BindingSource
    Friend WithEvents SocietyTableAdapter As coopDataSetTableAdapters.SocietyTableAdapter
    Friend WithEvents txtCreditorName As TextBox
    Friend WithEvents dtview As DataGridView
End Class
