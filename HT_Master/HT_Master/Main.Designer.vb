<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GetProperties = New System.Windows.Forms.Button()
        Me.Sat_iV = New System.Windows.Forms.TextBox()
        Me.Sat_iL = New System.Windows.Forms.TextBox()
        Me.Sat_T = New System.Windows.Forms.TextBox()
        Me.P_Critical = New System.Windows.Forms.TextBox()
        Me.T_Critical = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FluidSelector = New System.Windows.Forms.ComboBox()
        Me.P_Fluid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_Fluid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PropertiesTable = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Psy_Fig = New System.Windows.Forms.PictureBox()
        Me.RH_txt = New System.Windows.Forms.TextBox()
        Me.Tdb_txt = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.h_txt = New System.Windows.Forms.TextBox()
        Me.rho_txt = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.W_txt = New System.Windows.Forms.TextBox()
        Me.Tdp_txt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Get_PsyProperties = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PropertiesTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Psy_Fig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1355, 596)
        Me.SplitContainer1.SplitterDistance = 277
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(28, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1019, 565)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GetProperties)
        Me.TabPage1.Controls.Add(Me.Sat_iV)
        Me.TabPage1.Controls.Add(Me.Sat_iL)
        Me.TabPage1.Controls.Add(Me.Sat_T)
        Me.TabPage1.Controls.Add(Me.P_Critical)
        Me.TabPage1.Controls.Add(Me.T_Critical)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.FluidSelector)
        Me.TabPage1.Controls.Add(Me.P_Fluid)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.T_Fluid)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PropertiesTable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1011, 539)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fluid_Properties"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GetProperties
        '
        Me.GetProperties.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetProperties.Location = New System.Drawing.Point(25, 439)
        Me.GetProperties.Name = "GetProperties"
        Me.GetProperties.Size = New System.Drawing.Size(956, 38)
        Me.GetProperties.TabIndex = 34
        Me.GetProperties.Text = "Get Properties"
        Me.GetProperties.UseVisualStyleBackColor = True
        '
        'Sat_iV
        '
        Me.Sat_iV.Location = New System.Drawing.Point(664, 387)
        Me.Sat_iV.Name = "Sat_iV"
        Me.Sat_iV.ReadOnly = True
        Me.Sat_iV.Size = New System.Drawing.Size(88, 22)
        Me.Sat_iV.TabIndex = 33
        '
        'Sat_iL
        '
        Me.Sat_iL.Location = New System.Drawing.Point(664, 346)
        Me.Sat_iL.Name = "Sat_iL"
        Me.Sat_iL.ReadOnly = True
        Me.Sat_iL.Size = New System.Drawing.Size(88, 22)
        Me.Sat_iL.TabIndex = 32
        '
        'Sat_T
        '
        Me.Sat_T.Location = New System.Drawing.Point(664, 308)
        Me.Sat_T.Name = "Sat_T"
        Me.Sat_T.ReadOnly = True
        Me.Sat_T.Size = New System.Drawing.Size(88, 22)
        Me.Sat_T.TabIndex = 31
        '
        'P_Critical
        '
        Me.P_Critical.Location = New System.Drawing.Point(251, 346)
        Me.P_Critical.Name = "P_Critical"
        Me.P_Critical.ReadOnly = True
        Me.P_Critical.Size = New System.Drawing.Size(88, 22)
        Me.P_Critical.TabIndex = 30
        '
        'T_Critical
        '
        Me.T_Critical.Location = New System.Drawing.Point(251, 308)
        Me.T_Critical.Name = "T_Critical"
        Me.T_Critical.ReadOnly = True
        Me.T_Critical.Size = New System.Drawing.Size(88, 22)
        Me.T_Critical.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(369, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 23)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Saturated Vapor Enthalpy(kJ/kg)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(369, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Saturated Temperature (oC)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(369, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Saturated Liquid Enthalpy(kJ/kg)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Critical Pressure (kPa)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Critical Temperature (oC)"
        '
        'FluidSelector
        '
        Me.FluidSelector.FormattingEnabled = True
        Me.FluidSelector.Items.AddRange(New Object() {"1BUTENE", "AIR", "ACETONE", "AMMONIA", "ARGON", "BENZENE", "BUTANE", "C2BUTENE", "C4F10", "C5F12", "C12", "CF3I", "CO", "CO2", "COS", "CYCLOHEX", "CYCLOPRO", "D2", "D2O", "DECANE", "DME", "ETHANE", "ETHANOL", "ETHYLENE", "FLUORINE", "H2S", "HELIUM", "HEPTANE", "HEXANE", "HMX", "HYDROGEN", "IBUTENE", "IHEXANE", "IPENTANE", "ISOBUTAN", "KRYPTON", "METHANE", "METHANOL", "N2O", "NEON", "NEOPENTN", "NF3", "NITROGEN", "NONANE", "OCTANE", "OXYGEN", "PARAHYD", "PENTANE", "PROPANE", "PROPYLEN", "PROPYLEN", "SF6", "SO2", "T2BUTENE", "TOLUENE", "WATER", "XENON"})
        Me.FluidSelector.Location = New System.Drawing.Point(83, 35)
        Me.FluidSelector.Name = "FluidSelector"
        Me.FluidSelector.Size = New System.Drawing.Size(110, 20)
        Me.FluidSelector.TabIndex = 23
        '
        'P_Fluid
        '
        Me.P_Fluid.Location = New System.Drawing.Point(576, 33)
        Me.P_Fluid.Name = "P_Fluid"
        Me.P_Fluid.Size = New System.Drawing.Size(88, 22)
        Me.P_Fluid.TabIndex = 22
        Me.P_Fluid.Text = "101.325"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(443, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Pressure(kPa) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Temperature(oC) :"
        '
        'T_Fluid
        '
        Me.T_Fluid.Location = New System.Drawing.Point(349, 33)
        Me.T_Fluid.Name = "T_Fluid"
        Me.T_Fluid.Size = New System.Drawing.Size(88, 22)
        Me.T_Fluid.TabIndex = 19
        Me.T_Fluid.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fluid :"
        '
        'PropertiesTable
        '
        Me.PropertiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PropertiesTable.Location = New System.Drawing.Point(25, 73)
        Me.PropertiesTable.Name = "PropertiesTable"
        Me.PropertiesTable.RowTemplate.Height = 24
        Me.PropertiesTable.Size = New System.Drawing.Size(956, 210)
        Me.PropertiesTable.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Get_PsyProperties)
        Me.TabPage2.Controls.Add(Me.h_txt)
        Me.TabPage2.Controls.Add(Me.rho_txt)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.W_txt)
        Me.TabPage2.Controls.Add(Me.Tdp_txt)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.RH_txt)
        Me.TabPage2.Controls.Add(Me.Tdb_txt)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Psy_Fig)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1011, 539)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Psychrometric Chart"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Psy_Fig
        '
        Me.Psy_Fig.Image = Global.HT_Master.My.Resources.Resources.Psychrometric_Chart
        Me.Psy_Fig.Location = New System.Drawing.Point(26, 29)
        Me.Psy_Fig.Name = "Psy_Fig"
        Me.Psy_Fig.Size = New System.Drawing.Size(623, 480)
        Me.Psy_Fig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Psy_Fig.TabIndex = 0
        Me.Psy_Fig.TabStop = False
        '
        'RH_txt
        '
        Me.RH_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RH_txt.Location = New System.Drawing.Point(894, 88)
        Me.RH_txt.Name = "RH_txt"
        Me.RH_txt.Size = New System.Drawing.Size(100, 27)
        Me.RH_txt.TabIndex = 9
        Me.RH_txt.Text = "50"
        '
        'Tdb_txt
        '
        Me.Tdb_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Tdb_txt.Location = New System.Drawing.Point(894, 44)
        Me.Tdb_txt.Name = "Tdb_txt"
        Me.Tdb_txt.Size = New System.Drawing.Size(100, 27)
        Me.Tdb_txt.TabIndex = 8
        Me.Tdb_txt.Text = "27"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(664, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(175, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Relative Humidity (%)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(661, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(214, 23)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Dry Bulb Temperature (oC)"
        '
        'h_txt
        '
        Me.h_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.h_txt.Location = New System.Drawing.Point(897, 436)
        Me.h_txt.Name = "h_txt"
        Me.h_txt.ReadOnly = True
        Me.h_txt.Size = New System.Drawing.Size(100, 27)
        Me.h_txt.TabIndex = 21
        '
        'rho_txt
        '
        Me.rho_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rho_txt.Location = New System.Drawing.Point(897, 392)
        Me.rho_txt.Name = "rho_txt"
        Me.rho_txt.ReadOnly = True
        Me.rho_txt.Size = New System.Drawing.Size(100, 27)
        Me.rho_txt.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(664, 434)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 23)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "Enthalpy (kJ/kg)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(667, 390)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(144, 23)
        Me.Label29.TabIndex = 18
        Me.Label29.Text = "Density (kg/m^3)"
        '
        'W_txt
        '
        Me.W_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.W_txt.Location = New System.Drawing.Point(897, 341)
        Me.W_txt.Name = "W_txt"
        Me.W_txt.ReadOnly = True
        Me.W_txt.Size = New System.Drawing.Size(100, 27)
        Me.W_txt.TabIndex = 17
        '
        'Tdp_txt
        '
        Me.Tdp_txt.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Tdp_txt.Location = New System.Drawing.Point(897, 287)
        Me.Tdp_txt.Name = "Tdp_txt"
        Me.Tdp_txt.ReadOnly = True
        Me.Tdp_txt.Size = New System.Drawing.Size(100, 27)
        Me.Tdp_txt.TabIndex = 16
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(664, 339)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(212, 23)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Absolute Humidity (kg/kg)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(664, 291)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(227, 23)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "Dew Point Temperature (oC)"
        '
        'Get_PsyProperties
        '
        Me.Get_PsyProperties.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Get_PsyProperties.Location = New System.Drawing.Point(671, 168)
        Me.Get_PsyProperties.Name = "Get_PsyProperties"
        Me.Get_PsyProperties.Size = New System.Drawing.Size(322, 50)
        Me.Get_PsyProperties.TabIndex = 22
        Me.Get_PsyProperties.Text = "Get_Psy Properties"
        Me.Get_PsyProperties.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 596)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Main"
        Me.Text = "HT_Master Bing"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PropertiesTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Psy_Fig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GetProperties As Button
    Friend WithEvents Sat_iV As TextBox
    Friend WithEvents Sat_iL As TextBox
    Friend WithEvents Sat_T As TextBox
    Friend WithEvents P_Critical As TextBox
    Friend WithEvents T_Critical As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FluidSelector As ComboBox
    Friend WithEvents P_Fluid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents T_Fluid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PropertiesTable As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Psy_Fig As PictureBox
    Friend WithEvents Get_PsyProperties As Button
    Friend WithEvents h_txt As TextBox
    Friend WithEvents rho_txt As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents W_txt As TextBox
    Friend WithEvents Tdp_txt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents RH_txt As TextBox
    Friend WithEvents Tdb_txt As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
End Class
