<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCase = New System.Windows.Forms.TextBox()
        Me.txtRefreeno = New System.Windows.Forms.TextBox()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.txtInstallement = New System.Windows.Forms.TextBox()
        Me.txtGuarantor1 = New System.Windows.Forms.TextBox()
        Me.txtGuarantor2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbCourtname = New System.Windows.Forms.ComboBox()
        Me.CourtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoopDataSet = New WindowsApplication1.coopDataSet()
        Me.cmbSocietyname = New System.Windows.Forms.ComboBox()
        Me.SocietyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CourtTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.CourtTableAdapter()
        Me.SocietyTableAdapter = New WindowsApplication1.coopDataSetTableAdapters.SocietyTableAdapter()
        Me.txtCreditorname = New System.Windows.Forms.TextBox()
        CType(Me.CourtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Case No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Refree No  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Court Name   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Society Name  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Creditor Name  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 339)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Premium  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 396)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Installement  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 452)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Guarantor 1   :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 508)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Guarantor 2   :"
        '
        'txtCase
        '
        Me.txtCase.BackColor = System.Drawing.SystemColors.Window
        Me.txtCase.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCase.Location = New System.Drawing.Point(229, 36)
        Me.txtCase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCase.Name = "txtCase"
        Me.txtCase.Size = New System.Drawing.Size(152, 30)
        Me.txtCase.TabIndex = 9
        '
        'txtRefreeno
        '
        Me.txtRefreeno.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefreeno.Location = New System.Drawing.Point(229, 89)
        Me.txtRefreeno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRefreeno.Name = "txtRefreeno"
        Me.txtRefreeno.Size = New System.Drawing.Size(289, 30)
        Me.txtRefreeno.TabIndex = 10
        '
        'txtPremium
        '
        Me.txtPremium.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(229, 330)
        Me.txtPremium.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(289, 30)
        Me.txtPremium.TabIndex = 11
        '
        'txtInstallement
        '
        Me.txtInstallement.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallement.Location = New System.Drawing.Point(229, 387)
        Me.txtInstallement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInstallement.Name = "txtInstallement"
        Me.txtInstallement.Size = New System.Drawing.Size(289, 30)
        Me.txtInstallement.TabIndex = 12
        '
        'txtGuarantor1
        '
        Me.txtGuarantor1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuarantor1.Location = New System.Drawing.Point(229, 444)
        Me.txtGuarantor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGuarantor1.Name = "txtGuarantor1"
        Me.txtGuarantor1.Size = New System.Drawing.Size(289, 30)
        Me.txtGuarantor1.TabIndex = 13
        '
        'txtGuarantor2
        '
        Me.txtGuarantor2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuarantor2.Location = New System.Drawing.Point(229, 499)
        Me.txtGuarantor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGuarantor2.Name = "txtGuarantor2"
        Me.txtGuarantor2.Size = New System.Drawing.Size(289, 30)
        Me.txtGuarantor2.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 36)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbCourtname
        '
        Me.cmbCourtname.DataSource = Me.CourtBindingSource
        Me.cmbCourtname.DisplayMember = "Court_name"
        Me.cmbCourtname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourtname.FormattingEnabled = True
        Me.cmbCourtname.Location = New System.Drawing.Point(229, 142)
        Me.cmbCourtname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCourtname.Name = "cmbCourtname"
        Me.cmbCourtname.Size = New System.Drawing.Size(289, 32)
        Me.cmbCourtname.TabIndex = 16
        '
        'CourtBindingSource
        '
        Me.CourtBindingSource.DataMember = "Court"
        Me.CourtBindingSource.DataSource = Me.CoopDataSet
        '
        'CoopDataSet
        '
        Me.CoopDataSet.DataSetName = "coopDataSet"
        Me.CoopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSocietyname
        '
        Me.cmbSocietyname.DataSource = Me.SocietyBindingSource
        Me.cmbSocietyname.DisplayMember = "Society_name"
        Me.cmbSocietyname.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSocietyname.FormattingEnabled = True
        Me.cmbSocietyname.Location = New System.Drawing.Point(229, 196)
        Me.cmbSocietyname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSocietyname.Name = "cmbSocietyname"
        Me.cmbSocietyname.Size = New System.Drawing.Size(289, 32)
        Me.cmbSocietyname.TabIndex = 17
        '
        'SocietyBindingSource
        '
        Me.SocietyBindingSource.DataMember = "Society"
        Me.SocietyBindingSource.DataSource = Me.CoopDataSet
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(52, 569)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 54)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(209, 569)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 54)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(370, 569)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 54)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CourtTableAdapter
        '
        Me.CourtTableAdapter.ClearBeforeFill = True
        '
        'SocietyTableAdapter
        '
        Me.SocietyTableAdapter.ClearBeforeFill = True
        '
        'txtCreditorname
        '
        Me.txtCreditorname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditorname.Location = New System.Drawing.Point(229, 263)
        Me.txtCreditorname.Name = "txtCreditorname"
        Me.txtCreditorname.Size = New System.Drawing.Size(289, 30)
        Me.txtCreditorname.TabIndex = 22
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.vecteezy_abstract_blue_and_gray_wave_background_
        Me.ClientSize = New System.Drawing.Size(563, 657)
        Me.Controls.Add(Me.txtCreditorname)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbSocietyname)
        Me.Controls.Add(Me.cmbCourtname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGuarantor2)
        Me.Controls.Add(Me.txtGuarantor1)
        Me.Controls.Add(Me.txtInstallement)
        Me.Controls.Add(Me.txtPremium)
        Me.Controls.Add(Me.txtRefreeno)
        Me.Controls.Add(Me.txtCase)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        CType(Me.CourtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SocietyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCase As TextBox
    Friend WithEvents txtRefreeno As TextBox
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents txtInstallement As TextBox
    Friend WithEvents txtGuarantor1 As TextBox
    Friend WithEvents txtGuarantor2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbCourtname As ComboBox
    Friend WithEvents cmbSocietyname As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CoopDataSet As coopDataSet
    Friend WithEvents CourtBindingSource As BindingSource
    Friend WithEvents CourtTableAdapter As coopDataSetTableAdapters.CourtTableAdapter
    Friend WithEvents SocietyBindingSource As BindingSource
    Friend WithEvents SocietyTableAdapter As coopDataSetTableAdapters.SocietyTableAdapter
    Friend WithEvents txtCreditorname As TextBox
End Class
