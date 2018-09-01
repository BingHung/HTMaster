﻿Public Class HT_TRANSFER_BING

    Private Sub GetProperties_Click(sender As Object, e As EventArgs) Handles GetProperties.Click

        Dim TableContent As New DataTable
        TableContent.Columns.Add(New DataColumn("Temperature (oC)"))
        TableContent.Columns.Add(New DataColumn("Pressure (kPa)"))
        TableContent.Columns.Add(New DataColumn("Enthalpy (kJ/kg)"))
        TableContent.Columns.Add(New DataColumn("Density (kg/m^3)"))
        TableContent.Columns.Add(New DataColumn("Viscosity (Pa*s)"))
        TableContent.Columns.Add(New DataColumn("Thermal Conductivity (W/m*K)"))
        TableContent.Columns.Add(New DataColumn("Heat Capacity (J/kg-K)"))
        TableContent.Columns.Add(New DataColumn("Prandtl Number (N/A)"))

        PropertiesTable.DataSource = TableContent

        Dim Fluid_Pressure As Double = CDbl(P_Fluid.Text)
        Dim Fluid_Temperature As Double = CDbl(T_Fluid.Text)
        Dim Fluid_Type As String = FluidSelector.Text

        'Dim Fluid_Prop As New Fluid(Fluid_Type, "SI", "TP")
        'Fluid_Prop.Properties(Fluid_Temperature + 273.15, Fluid_Pressure / 1000)

        Dim Fluid_Prop As New Fluid(Fluid_Type, "SI", "TP")
        Fluid_Prop.Properties(Fluid_Temperature + 273.15, Fluid_Pressure / 1000)


        'MsgBox(Fluid_Prop.i)
        'MsgBox(Fluid_Prop.rho)

        Dim row1 As DataRow = TableContent.NewRow()
        row1("Temperature (oC)") = Fluid_Temperature
        row1("Pressure (kPa)") = Fluid_Pressure
        row1("Enthalpy (kJ/kg)") = Math.Round(CDbl(Fluid_Prop.i), 3) / 1000
        row1("Density (kg/m^3)") = Math.Round(CDbl(Fluid_Prop.rho), 3)
        row1("Viscosity (Pa*s)") = CDbl(Fluid_Prop.Visc)
        row1("Thermal Conductivity (W/m*K)") = Math.Round(CDbl(Fluid_Prop.k), 3)
        row1("Heat Capacity (J/kg-K)") = Math.Round(CDbl(Fluid_Prop.cp), 3)
        row1("Prandtl Number (N/A)") = Math.Round(CDbl(Fluid_Prop.Pr), 3)
        TableContent.Rows.Add(row1)

        'Me.i = Enthalpy(Name, "TP", "SI", t, p) * 1000 ' {J/kg]
        'Me.Visc = Viscosity(Name, "TP", "SI", t, p) / 1000000 '[Pa*s]
        'Me.k = ThermalConductivity(Name, "TP", "SI", t, p) / 1000 '[W/m*K]
        'Me.cp = IsobaricHeatCapacity(Name, "TP", "SI", t, p) * 1000 '[J/kg-K]
        'Me.rho = Density(Name, "TP", "SI", t, p)   ' [kg/m^3]
        'Me.Pr = Prandtl(Name, "TP", "SI", t, p) ' [dimensionless]

    End Sub


End Class
