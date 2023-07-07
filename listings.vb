Imports System.ComponentModel
Imports System.Data.OleDb
Public Class listings
    'Funciona el filter por id
    'Funciona el No Filter
    'Funciona el sort Asc y Desc pero por nombre de Jugador
    'El Games Played va bien
    'El Game time va bien
    'El Days played va bien
    'El Hits va vien
    'Falla si quieres ordenar directamente desde el dataGridView pulsando encima del nombre de la columna



    Private Sub listings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'JuegocartasDataSet.Registro' Puede moverla o quitarla según sea necesario.
        'Me.RegistroTableAdapter.Fill(Me.JuegocartasDataSet.Registro)



        Dim rutaBD As String = Application.StartupPath + "\juegocartas.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim conjuntoDatos As New DataSet()

        Try
            con.Open()
            Dim dataAdapter = New OleDbDataAdapter("SELECT * FROM Registro", con)
            Dim tabla As New DataTable()
            dataAdapter.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As OleDbException

            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Try
            con.Open()

            ' Obtener los valores de la columna ID de la tabla Registro
            Dim query As String = "SELECT ID FROM Registro"
            Dim dataAdapter As New OleDbDataAdapter(query, con)
            Dim dataSet As New DataSet()
            dataAdapter.Fill(dataSet, "IDs")

            ' Asignar los valores al ComboBox
            ComboBoxId.DataSource = dataSet.Tables("IDs")
            ComboBoxId.DisplayMember = "ID"
            ComboBoxId.ValueMember = "ID"
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try




        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoResizeColumns()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub buttonFilter_Click(sender As Object, e As EventArgs) Handles buttonFilter.Click
        Dim rutaBD As String = Application.StartupPath + "\juegocartas.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim dataAdapter As New OleDbDataAdapter
        Dim dataSet As New DataSet()

        Try
            con.Open()

            ' Definir la consulta SQL con un parámetro para el ID seleccionado en el ComboBox
            Dim query As String = "SELECT * FROM Registro WHERE ID = @id"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", ComboBoxId.SelectedValue)

            ' Obtener los registros que coinciden con el ID seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Registro")

            ' Asignar los registros al DataGridView
            DataGridView1.DataSource = dataSet.Tables("Registro")
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ButtonNoFilter_Click(sender As Object, e As EventArgs) Handles buttonNoFilter.Click
        Dim rutaBD As String = Application.StartupPath + "\juegocartas.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim dataAdapter As New OleDbDataAdapter
        Dim dataSet As New DataSet()

        Try
            con.Open()

            ' Obtener la tabla completa de la base de datos
            Dim query As String = "SELECT * FROM Registro"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.Fill(dataSet, "Registro")

            ' Asignar la tabla completa al DataGridView
            DataGridView1.DataSource = dataSet.Tables("Registro")
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Obtener el valor de la primera columna de la fila seleccionada
        Dim selectedValue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

        ' Hacer una consulta a la base de datos para obtener los datos correspondientes al valor seleccionado
        Dim rutaBD As String = Application.StartupPath + "\juegocartas.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD
        Dim dataAdapter As New OleDbDataAdapter
        Dim dataSet As New DataSet()

        Try
            con.Open()

            ' Definir la consulta SQL con un parámetro para el valor seleccionado
            Dim query As String = "SELECT * FROM Registro WHERE Jugador = @Jugador"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Jugador", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Registro")

            ' Sumar los valores de la columna deseada
            Dim total As Integer = 0
            For Each row As DataRow In dataSet.Tables("Registro").Rows
                total += Integer.Parse(row("aciertos").ToString())
            Next

            ' Mostrar el total de aciertos del jugador en el TextBox
            TextBoxHits.Text = total.ToString()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()

            ' Definir la consulta SQL con un parámetro para el valor seleccionado
            Dim query As String = "SELECT * FROM Registro WHERE Jugador = @Jugador"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Jugador", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Registro")

            ' Contar el número de registros correspondientes al jugador seleccionado
            Dim countQuery As String = "SELECT COUNT(*) FROM Registro WHERE Jugador = @Jugador"
            Dim countCommand As New OleDbCommand(countQuery, con)
            countCommand.Parameters.AddWithValue("@Jugador", selectedValue)
            Dim count As Integer = CInt(countCommand.ExecuteScalar())

            ' Sumar los valores de la columna deseada y el número de veces que aparece el jugador
            Dim total As Integer = 0
            For Each row As DataRow In dataSet.Tables("Registro").Rows
                total += Integer.Parse(row("Aciertos").ToString())
            Next
            total += count

            ' Mostrar el total de aciertos y el número de veces que aparece el jugador en el TextBox
            TextBoxPlayed.Text = total.ToString()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Try
            con.Open()

            ' Definir la consulta SQL con parámetros para el valor seleccionado y la columna "Tiempo"
            Dim query As String = "SELECT * FROM Registro WHERE Jugador = @Jugador AND Tiempo IS NOT NULL"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Jugador", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Registro")

            ' Sumar los valores de la columna deseada
            Dim total As Integer = 0
            For Each row As DataRow In dataSet.Tables("Registro").Rows
                total += Integer.Parse(row("Tiempo").ToString())
            Next

            ' Mostrar el tiempo jugado por el jugador en el TextBox
            TextBoxTime.Text = total.ToString()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Try
            con.Open()

            ' Definir la consulta SQL con parámetros para el valor seleccionado y la columna "Fecha"
            Dim query As String = "SELECT DISTINCT Fecha FROM Registro WHERE Jugador = @Jugador AND Fecha IS NOT NULL"
            dataAdapter.SelectCommand = New OleDbCommand(query, con)
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Jugador", selectedValue)

            ' Obtener los registros que coinciden con el valor seleccionado
            dataSet.Clear()
            dataAdapter.Fill(dataSet, "Registro")

            ' Contar el número de días distintos
            Dim days As Integer = dataSet.Tables("Registro").Rows.Count

            ' Mostrar el número de días distintos que ha jugado el jugador en el TextBox
            TextBoxDays.Text = days.ToString()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try





    End Sub


    Private Sub ButtonSortAsc_Click(sender As Object, e As EventArgs) Handles ButtonSortAsc.Click
        ' Obtener el DataTable enlazado al DataGridView
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        ' Ordenar los datos por el nombre del jugador en orden ascendente
        dataTable.DefaultView.Sort = "Jugador ASC"

        ' Actualizar el DataGridView para mostrar los datos ordenados
        DataGridView1.Refresh()
    End Sub

    Private Sub ButtonSortDesc_Click(sender As Object, e As EventArgs) Handles ButtonSortDesc.Click
        ' Obtener el DataTable enlazado al DataGridView
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        ' Ordenar los datos por el nombre del jugador en orden descendente
        dataTable.DefaultView.Sort = "Jugador DESC"

        ' Actualizar el DataGridView para mostrar los datos ordenados
        DataGridView1.Refresh()
    End Sub


End Class