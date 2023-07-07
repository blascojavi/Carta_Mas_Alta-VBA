Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Form1
    Dim numAleatorioResult As String
    Dim resultPrueba As String
    Dim recurso As String
    Dim cartaAleatoria As New PictureBox
    Dim nombreJugador As String
    Dim tiempo As Integer = 0
    Dim contador As New Timer()
    ' Dim picturebox As PictureBox
    Public contadorPicture As Integer = 0
    Dim pictureboxList As New List(Of PictureBox)
    Dim posicionX As Integer = 40
    Dim currentCard As String
    ''La incializamos en 0 en la primera partida, por lo que en la primera siempre será boton derecho
    'pero aunque se pierda e iniciemos nuevo juego, se queda el valor de la última jugada que hemos perdido
    Dim previousCard As String = 0
    Public aciertos As Integer = 0
    Public errores As Integer = 0
    Public traseraCambio As String = "fondo1"
    Public nombreGanador As String
    Public tiempoGanador As String
    Public bandera As Boolean = True
    Public numsPrueba As New List(Of Integer)
    Public contAleatoria As Integer = 0

    ''Public numsPrueba As New List(Of Integer)
    ''' <summary>
    ''' QUEDA PENDIENTE:
    '''  NO REPITE  NUMEROS, pero falta comprobar, por lo que se ha manejado la excepcion por si es igual saca uno nuevo
    ''' QUE SOBREESCRIBA LOS PICTUREBOX SIN BORRAR LOS ANTERIORES
    ''' EL PRIMER VALOR DE PREVIUSCARD DEBERIA DE SER ALEATORIO, QUEDA PENDIENTE DE REVISAR
    ''' </summary>


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler contador.Tick, AddressOf ActualizarTiempo
        '' NewGameToolStripMenuItem_Click()
        ''  prueba()
        RemoveHandler deck.Click, AddressOf deck_MouseDown
        bandera = False
    End Sub
    Private Sub NewGameToolStripMenuItem_Click() Handles NewGameToolStripMenuItem.Click
        ResetComponents()
        inicioJuego()
        '' crearAleatoria()
        '' aleatoriaNueva()
        dameNombre()
        bandera = True
        deck.Image = My.Resources.ResourceManager.GetObject(traseraCambio)
    End Sub

    Public Sub ResetComponents() ''No elminia el ultimo picturebox
        ''numAleatorioResult = ""
        ''  resultPrueba = ""
        ''   recurso = ""
        cartaAleatoria = New PictureBox()
        ''nombreJugador = ""
        tiempo = 0
        contadorPicture = 0
        '' pictureboxList = New List(Of PictureBox)
        posicionX = 40
        ''  previousCard = 0
        aciertos = 0
        errores = 0


        borrarPictureViews()

        contador.Enabled = True
    End Sub

    Public Sub borrarPictureViews()

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            Dim control As Control = Me.Controls(i)
            If control.GetType() = GetType(PictureBox) Then
                If control.Name.StartsWith("cartaAleatoria") Then
                    Me.Controls.RemoveAt(i)
                    control.Dispose()
                End If
            End If
        Next


    End Sub


    Public Sub inicioJuego()
        ''cargamos el reverso de la carta al iniciar
        deck.Image = My.Resources.ResourceManager.GetObject(traseraCambio)
        tiempo = 0
        contador.Enabled = True
    End Sub




    Public Sub aleatoriaNueva() ''Esta funciona bien, pero borra la anterior

        ObtenerCartaAleatoria()
        '  Dim contador As Integer = 1 'Contador para el nombre de las cartas

        Dim nombreCarta As String = "cartaAleatoria"
        Dim contadorNombre As Integer = pictureboxList.Count + 1


        If contadorPicture <= 52 Then
            'contador += 1 'Aumentar el contado
            ''cartaAleatoria.Image = Nothing
            cartaAleatoria.Name = nombreCarta & contadorNombre
            'cartaAleatoria.Name = nombreCarta
            cartaAleatoria.Size = New Size(268, 392)
            cartaAleatoria.Location = New Point(posicionX, 300)
            ''cartaAleatoria.Image = My.Resources.ResourceManager.GetObject(numsPrueba(contAleatoria))
            contAleatoria += 1 ''
            cartaAleatoria.Image = My.Resources.ResourceManager.GetObject(recurso)
            ''cartaAleatoria.Image = My.Resources.ResourceManager.GetObject(siguienteNumero)
            contadorPicture += 1
            posicionX += 10
            pictureboxList.Add(cartaAleatoria)
            Me.Controls.Add(cartaAleatoria)

        End If
        ''   TextBox1.Text = cartaAleatoria.Name.ToString


        ''    RichTextBox1.AppendText(recurso & Environment.NewLine)
        '' RichTextBox1.AppendText(cartaAleatoria.Name.ToString & Environment.NewLine)


    End Sub



    Public Sub ObtenerCartaAleatoria() ''Creo que no se repiten numeros
        ' Dim numsPrueba As New List(Of Integer)
        numsPrueba = New List(Of Integer)
        Dim rnd As New Random()
        Dim contador As Integer = 0
        Dim valorPosicion As Integer
        Dim contadorPosiAleatoria As Integer = 0


        ' Agrega 52 números aleatorios a la lista "numsPrueba", sin repetirse
        For index = 1 To 52
            resultPrueba = rnd.Next(1, 53)
            If Not numsPrueba.Contains(resultPrueba) Then
                numsPrueba.Add(resultPrueba)
            Else
                Do
                    resultPrueba = rnd.Next(1, 53)
                Loop Until Not numsPrueba.Contains(resultPrueba)
                numsPrueba.Add(resultPrueba)
            End If
        Next

        valorPosicion = numsPrueba(contadorPosiAleatoria)
        contadorPosiAleatoria += 1


        recurso = "_" & valorPosicion

        '' resultPrueba = "_" & resultPrueba
        ''recurso = "_" & resultPrueba

        ''currentCard = resultPrueba

        '' RichTextBox1.AppendText(recurso & Environment.NewLine)
        ' Actualiza las variables "previousCard" y "currentCard" con el número aleatorio actual

        previousCard = currentCard
        currentCard = resultPrueba

    End Sub




    ''   Private Sub aleatorio_Click() Handles aleatorio.Click
    ''    crearAleatoria()
    ''  TextBox1.Text = recurso.ToString
    ''crearAleatoria()
    ''   aleatoriaNueva()
    ''prueba()
    ''  End Sub


    Public Sub dameNombre()
        If String.IsNullOrEmpty(nombreJugador) Then
            nombreJugador = InputBox("Por favor ingrese su nombre:", "Nombre del jugador")
            If nombreJugador = "" Then
                MessageBox.Show("No ha introducido ningun nombre" & vbCrLf & "El nombre por defecto es Jugador 1", "Error", MessageBoxButtons.OK)
                ''Close()
                '' MessageBox.Show("El nombre por defecto es Jugador 1")
                nombreJugador = "jugador1"
            End If
        End If
        labelJugador.Text = nombreJugador

    End Sub

    '' Public Sub deck_Click(sender As Object, e As EventArgs) Handles deck.Click
    ''     tiempo = 0
    ''     contador.Enabled = True
    ''crearAleatoria()

    '' End Sub



    Public Sub ActualizarTiempo(sender As Object, e As EventArgs)
        tiempo += 1
        StatusStrip1.Items("lblTiempo").Text = "Time:   " & tiempo & "   MiliSegundos"
    End Sub

    Public Sub deck_MouseDown(sender As Object, e As MouseEventArgs) Handles deck.MouseDown
        'tiempo = 0
        'contador.Enabled = True

        If bandera = True Then
            If e.Button = MouseButtons.Left Then
                ''CARTA MAS ALTA Aquí escribirías el código que se ejecutaría si se pulsa el botón izquierdo del ratón
                '' MessageBox.Show("Has pulsado el botón izquierdo")
                If currentCard > previousCard Then
                    aciertos += 1
                    aleatoriaNueva()

                ElseIf currentCard = previousCard Then
                    MessageBox.Show("La tarjeta actual es igual a la anterior. Vuelve a intentarlo.")
                    aleatoriaNueva()

                Else
                    errores += 1
                    contador.Enabled = False
                    MessageBox.Show("Apuesta incorrecta, vuelva a intentarlo." & vbCrLf & "Pulse new game", "Ha perdido ", MessageBoxButtons.OK)
                    RemoveHandler deck.Click, AddressOf deck_MouseDown
                    FinJuego()

                End If

            ElseIf e.Button = MouseButtons.Right Then
                ''CARTA MAS BAJA Aquí escribirías el código que se ejecutaría si se pulsa el botón derecho del ratón
                ''  MessageBox.Show("Has pulsado el botón derecho")
                If previousCard > currentCard Then
                    ' La apuesta es correcta, permite continuar el juego
                    aciertos += 1
                    aleatoriaNueva()

                ElseIf currentCard = previousCard Then
                    MessageBox.Show("La tarjeta actual es igual a la anterior. Vuelve a intentarlo.")
                    aleatoriaNueva()


                Else
                    errores += 1
                    ' La apuesta es incorrecta, muestra un mensaje de error al usuario
                    contador.Enabled = False
                    MessageBox.Show("Apuesta incorrecta, vuelva a intentarlo." & vbCrLf & "Pulse new game", "Ha perdido ", MessageBoxButtons.OK)
                    RemoveHandler deck.Click, AddressOf deck_MouseDown

                    FinJuego()

                End If

            End If
        End If





        If aciertos >= 52 Then
            aciertos = 52
            contador.Stop()
            MessageBox.Show("Feliciades jugador " & nombreJugador & vbCrLf & " ¡¡Has ganado!! ", "Enhorabuena", MessageBoxButtons.OK)
            nombreGanador = nombreJugador
            tiempoGanador = tiempo

        End If

        StatusStrip1.Items("successes").Text = "successes: " & aciertos
    End Sub

    Private Sub ListingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListingsToolStripMenuItem.Click
        listings.Show()
    End Sub

    Private Sub ChangePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePlayerToolStripMenuItem.Click
        nombreJugador = ""
        dameNombre()
    End Sub

    Private Sub ChangeBackOfDeckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackOfDeckToolStripMenuItem.Click
        NewBackDeck.Show()
    End Sub

    Public Sub RecibirTraseraCambio(valor As String)
        'Aquí puedes utilizar el valor de traseraCambio como desees
        MessageBox.Show(valor)
        traseraCambio = valor
    End Sub

    Private Sub FinJuego()
        nombreGanador = nombreJugador
        tiempoGanador = tiempo
        bandera = False
        ''ResetComponents()
        InsertarDatos(nombreGanador, aciertos, tiempo)
        'guardarDatos()
    End Sub



    Public Sub guardarDatos()
        ''con esta asignacion hariamos la actualizacon de los datos de la base de datos

        nombreGanador = nombreJugador
        tiempoGanador = tiempo
        Dim Aciertosganador As String = aciertos
        Dim fecha As Date = DateAndTime.Today


        ''   Me.RegistroTableAdapter1.Fill(Me.JuegocartasDataSet1.Registro)

        ''      Dim Id As Integer
        ''       If JuegocartasDataSet1.Registro.Rows.Count() > 0 Then
        '''      Id = JuegocartasDataSet1.Registro.Rows(JuegocartasDataSet1.Registro.Rows.Count - 1)("Id") + 1
        ''       Else
        ''     Id = 1
        ''     End If
        ''    Dim nuevaFila As DataRow = JuegocartasDataSet1.Registro.NewRow
        ''     nuevaFila("Id") = Id
        ''     JuegocartasDataSet1.Registro.Rows.Add(nuevaFila)

        '''     Dim nuevaFila2 As DataRow = JuegocartasDataSet1.Registro.NewRow

        ''      Me.RegistroTableAdapter1.Update(Me.JuegocartasDataSet1.Registro)


    End Sub


    Private Sub InsertarDatos(nombreGanador As String, aciertos As Integer, tiempo As Integer)
        Dim rutaBD As String = Application.StartupPath + "\juegocartas.mdb"
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBD

        Try
            con.Open()

            ' Comprueba el número de ID actual en la tabla
            Dim idActual As Integer = 0
            Dim dataAdapter As New OleDbDataAdapter("SELECT MAX(Id) FROM Registro", con)
            Dim conjuntoDatos As New DataSet()
            dataAdapter.Fill(conjuntoDatos, "Registro")
            If conjuntoDatos.Tables("Registro").Rows.Count > 0 AndAlso Not IsDBNull(conjuntoDatos.Tables("Registro").Rows(0)(0)) Then
                idActual = conjuntoDatos.Tables("Registro").Rows(0)(0)
            End If

            ' Inserta los datos en la tabla
            Dim query As String = "INSERT INTO Registro ( Jugador, Aciertos, Tiempo, Fecha) " &
                              "VALUES ( @Jugador, @Aciertos, @Tiempo, @Fecha)"
            Dim comando As New OleDbCommand(query, con)

            comando.Parameters.AddWithValue("@Jugador", nombreGanador)
            comando.Parameters.AddWithValue("@Aciertos", aciertos)
            comando.Parameters.AddWithValue("@Tiempo", tiempo / 10)
            comando.Parameters.AddWithValue("@Fecha", DateTime.Today.ToString("dd/MM/yyyy"))
            comando.ExecuteNonQuery()
            ' Muestra un mensaje de confirmación si los datos se guardaron correctamente
            MessageBox.Show("Los datos se guardaron correctamente.", "Mensaje")

        Catch ex As OleDbException
            MessageBox.Show("Ocurrió un error al guardar los datos: " & ex.Message, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

