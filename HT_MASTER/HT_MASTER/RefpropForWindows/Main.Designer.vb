<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HT_TRANSFER_BING
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Fluid_Properties = New System.Windows.Forms.TabPage()
        Me.FluidSelector = New System.Windows.Forms.ComboBox()
        Me.P_Fluid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_Fluid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetProperties = New System.Windows.Forms.Button()
        Me.PropertiesTable = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Fluid_Properties.SuspendLayout()
        CType(Me.PropertiesTable, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1248, 633)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Fluid_Properties)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(20, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(913, 599)
        Me.TabControl1.TabIndex = 0
        '
        'Fluid_Properties
        '
        Me.Fluid_Properties.Controls.Add(Me.FluidSelector)
        Me.Fluid_Properties.Controls.Add(Me.P_Fluid)
        Me.Fluid_Properties.Controls.Add(Me.Label3)
        Me.Fluid_Properties.Controls.Add(Me.Label2)
        Me.Fluid_Properties.Controls.Add(Me.T_Fluid)
        Me.Fluid_Properties.Controls.Add(Me.Label1)
        Me.Fluid_Properties.Controls.Add(Me.GetProperties)
        Me.Fluid_Properties.Controls.Add(Me.PropertiesTable)
        Me.Fluid_Properties.Location = New System.Drawing.Point(4, 22)
        Me.Fluid_Properties.Name = "Fluid_Properties"
        Me.Fluid_Properties.Padding = New System.Windows.Forms.Padding(3)
        Me.Fluid_Properties.Size = New System.Drawing.Size(905, 573)
        Me.Fluid_Properties.TabIndex = 0
        Me.Fluid_Properties.Text = "Fluid Properties"
        Me.Fluid_Properties.UseVisualStyleBackColor = True
        '
        'FluidSelector
        '
        Me.FluidSelector.FormattingEnabled = True
        Me.FluidSelector.Items.AddRange(New Object() {"1BUTENE", "AIR", "ACETONE", "AMMONIA", "ARGON", "BENZENE", "BUTANE", "C2BUTENE", "C4F10", "C5F12", "C12", "CF3I", "CO", "CO2", "COS", "CYCLOHEX", "CYCLOPRO", "D2", "D2O", "DECANE", "DME", "ETHANE", "ETHANOL", "ETHYLENE", "FLUORINE", "H2S", "HELIUM", "HEPTANE", "HEXANE", "HMX", "HYDROGEN", "IBUTENE", "IHEXANE", "IPENTANE", "ISOBUTAN", "KRYPTON", "METHANE", "METHANOL", "N2O", "NEON", "NEOPENTN", "NF3", "NITROGEN", "NONANE", "OCTANE", "OXYGEN", "PARAHYD", "PENTANE", "PROPANE", "PROPYLEN", "PROPYLEN", "SF6", "SO2", "T2BUTENE", "TOLUENE", "WATER", "XENON"})
        Me.FluidSelector.Location = New System.Drawing.Point(89, 32)
        Me.FluidSelector.Name = "FluidSelector"
        Me.FluidSelector.Size = New System.Drawing.Size(110, 20)
        Me.FluidSelector.TabIndex = 7
        '
        'P_Fluid
        '
        Me.P_Fluid.Location = New System.Drawing.Point(582, 28)
        Me.P_Fluid.Name = "P_Fluid"
        Me.P_Fluid.Size = New System.Drawing.Size(88, 22)
        Me.P_Fluid.TabIndex = 6
        Me.P_Fluid.Text = "101.325"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pressure(kPa) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Temperature(oC) :"
        '
        'T_Fluid
        '
        Me.T_Fluid.Location = New System.Drawing.Point(355, 30)
        Me.T_Fluid.Name = "T_Fluid"
        Me.T_Fluid.Size = New System.Drawing.Size(88, 22)
        Me.T_Fluid.TabIndex = 3
        Me.T_Fluid.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fluid :"
        '
        'GetProperties
        '
        Me.GetProperties.Location = New System.Drawing.Point(737, 266)
        Me.GetProperties.Name = "GetProperties"
        Me.GetProperties.Size = New System.Drawing.Size(146, 38)
        Me.GetProperties.TabIndex = 1
        Me.GetProperties.Text = "Get Properties"
        Me.GetProperties.UseVisualStyleBackColor = True
        '
        'PropertiesTable
        '
        Me.PropertiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PropertiesTable.Location = New System.Drawing.Point(18, 58)
        Me.PropertiesTable.Name = "PropertiesTable"
        Me.PropertiesTable.RowTemplate.Height = 24
        Me.PropertiesTable.Size = New System.Drawing.Size(865, 202)
        Me.PropertiesTable.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(905, 573)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'HT_TRANSFER_BING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 633)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HT_TRANSFER_BING"
        Me.Text = "HT_TRANSFER_BING"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Fluid_Properties.ResumeLayout(False)
        Me.Fluid_Properties.PerformLayout()
        CType(Me.PropertiesTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Fluid_Properties As TabPage
    Friend WithEvents PropertiesTable As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GetProperties As Button
    Friend WithEvents P_Fluid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents T_Fluid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FluidSelector As ComboBox
End Class
