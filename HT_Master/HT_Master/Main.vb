Public Class Main
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

        Dim Fluid_Prop As New Fluid(Fluid_Type.ToString, "SI", "TP")
        Fluid_Prop.Properties(Fluid_Temperature + 273.15, Fluid_Pressure / 1000)


        Dim row1 As DataRow = TableContent.NewRow()
        row1("Temperature (oC)") = Fluid_Temperature
        row1("Pressure (kPa)") = Fluid_Pressure
        row1("Enthalpy (kJ/kg)") = Math.Round(CDbl(Fluid_Prop.i), 3) / 1000
        'Enthalpy(name, "TP", "SI", T, P)
        'row1("Enthalpy (kJ/kg)") = Math.Round(Enthalpy(Fluid_Type, "TP", "SI", Fluid_Temperature + 273.15, Fluid_Pressure / 1000), 3)
        row1("Density (kg/m^3)") = Math.Round(CDbl(Fluid_Prop.rho), 3)
        row1("Viscosity (Pa*s)") = CDbl(Fluid_Prop.Visc)
        row1("Thermal Conductivity (W/m*K)") = Math.Round(CDbl(Fluid_Prop.k), 3)
        row1("Heat Capacity (J/kg-K)") = Math.Round(CDbl(Fluid_Prop.cp), 3)
        row1("Prandtl Number (N/A)") = Math.Round(CDbl(Fluid_Prop.Pr), 3)
        TableContent.Rows.Add(row1)


        P_Critical.Text = CDbl(Pressure(Fluid_Type, "crit", "SI") * 1000)
        T_Critical.Text = CDbl(Temperature(Fluid_Type, "crit", "SI") - 273.15)
        Sat_T.Text = Temperature(Fluid_Type, "PLIQ", "SI", Fluid_Pressure / 1000) - 273.15
        Sat_iL.Text = Enthalpy(Fluid_Type, "PLIQ", "SI", Fluid_Pressure / 1000)
        Sat_iV.Text = Enthalpy(Fluid_Type, "PVAP", "SI", Fluid_Pressure / 1000)


        'Me.i = Enthalpy(Name, "TP", "SI", t, p) * 1000 ' {J/kg]
        'Me.Visc = Viscosity(Name, "TP", "SI", t, p) / 1000000 '[Pa*s]
        'Me.k = ThermalConductivity(Name, "TP", "SI", t, p) / 1000 '[W/m*K]
        'Me.cp = IsobaricHeatCapacity(Name, "TP", "SI", t, p) * 1000 '[J/kg-K]
        'Me.rho = Density(Name, "TP", "SI", t, p)   ' [kg/m^3]
        'Me.Pr = Prandtl(Name, "TP", "SI", t, p) ' [dimensionless]

    End Sub

    Private Sub Get_PsyProperties_Click(sender As Object, e As EventArgs) Handles Get_PsyProperties.Click
        Dim Psychrimetric As New MoistAirProperties
        Psychrimetric.DBT = CDbl(Tdb_txt.Text) '(oC)
        Psychrimetric.RH = CDbl(RH_txt.Text) / 100 '(%)

        MoistAir_Calc(Psychrimetric)

        Tdp_txt.Text = Psychrimetric.Dew.ToString("0.###")
        h_txt.Text = Psychrimetric.iai.ToString("0.###")
        W_txt.Text = Psychrimetric.W.ToString("0.###")
        rho_txt.Text = Psychrimetric.rhoai.ToString("0.###")
    End Sub
End Class
