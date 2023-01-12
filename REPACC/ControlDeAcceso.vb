Imports System.Data
Imports System.Data.SqlClient
Public Class ControlDeAcceso
    Public intentos As Integer = 3

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click

        ProgressBar1.Increment(-100)
        ProgressBar1.Visible = True
        ProgressBar1.BringToFront()
        ProgressBar1.PerformStep()

        If Not txtUsuario.Text = "" AndAlso Not txtContraseña.Text = "" Then

            If intentos > 0 Then

                intentos -= 1

                Dim escalar As Integer = 0


                Dim cnn As New SqlConnection

                cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

                ProgressBar1.PerformStep()

                Try
                    cnn.Open()

                    Dim strSQL As String = _
                    "Select Count(*) FROM Usuarios WHERE Usuario  = '" & _
                    txtUsuario.Text.Trim & "' AND Contraseña = '" & _
                    txtContraseña.Text.Trim & "'"

                    Dim objcomando As SqlCommand = New SqlCommand(strSQL, cnn)

                    escalar = CInt(objcomando.ExecuteScalar)

                    ProgressBar1.PerformStep()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    cnn.Close()
                End Try

                ProgressBar1.PerformStep()

                If escalar > 0 Then

                    Try

                        cnn.Open()
                        Dim strSQL As String = _
                        "Select Admin_Priv FROM Usuarios WHERE Usuario  = '" & _
                        txtUsuario.Text.Trim & "' AND Contraseña = '" & _
                        txtContraseña.Text.Trim & "'"

                        Dim privi As Char

                        Dim objcomando As SqlCommand = New SqlCommand(strSQL, cnn)

                        privi = objcomando.ExecuteScalar()

                        ProgressBar1.PerformStep()

                        If privi = "1" Then

                            Panel_Interfaz.FacturaToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ProductoToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ComprasToolStripMenuItem.Enabled = False

                        ElseIf privi = "0" Then

                            Panel_Interfaz.EmpleadoToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ProveedoresToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ProductoToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ComprasToolStripMenuItem.Enabled = False

                        Else

                            Panel_Interfaz.EmpleadoToolStripMenuItem.Enabled = False
                            Panel_Interfaz.ClienteToolStripMenuItem.Enabled = False
                            Panel_Interfaz.FacturaToolStripMenuItem.Enabled = False

                        End If

                        ProgressBar1.PerformStep()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        cnn.Close()
                    End Try

                    ProgressBar1.Increment(100)

                    cnn.Open()
                    Dim buscarnombre As String = _
                    "Select Nombre FROM Empleados WHERE Id_Empleado = (Select Id_Empleado FROM Usuarios WHERE Usuario  = '" & _
                    txtUsuario.Text.Trim & "' AND Contraseña = '" & _
                    txtContraseña.Text.Trim & "')"

                    Dim buscarapellido As String = _
                    "Select Apellido FROM Empleados WHERE Id_Empleado = (Select Id_Empleado FROM Usuarios WHERE Usuario  = '" & _
                    txtUsuario.Text.Trim & "' AND Contraseña = '" & _
                    txtContraseña.Text.Trim & "')"

                    Dim buscarfoto As String = _
                    "Select Fotografia FROM Empleados WHERE Id_Empleado = (Select Id_Empleado FROM Usuarios WHERE Usuario  = '" & _
                    txtUsuario.Text.Trim & "' AND Contraseña = '" & _
                    txtContraseña.Text.Trim & "')"

                    Dim nombre As String
                    Dim apellido As String
                    Dim foto As String

                    Dim comandus As SqlCommand = New SqlCommand(buscarnombre, cnn)
                    Dim comandusa As SqlCommand = New SqlCommand(buscarapellido, cnn)
                    Dim comandusab As SqlCommand = New SqlCommand(buscarfoto, cnn)

                    nombre = comandus.ExecuteScalar()
                    apellido = comandusa.ExecuteScalar()
                    foto = comandusab.ExecuteScalar()

                    cnn.Close()

                    Panel_Interfaz.WlcomLbl.Text = "¡Bienvenido(a) " & nombre & "!"
                    Panel_Interfaz.ToolStripStatusLabel1.Text = "Autentificado como " & nombre & " " & apellido
                    Panel_Interfaz.PictureBox2.Image = Image.FromFile(foto)

                    Me.Hide()
                    ProgressBar1.Visible = False
                    Panel_Interfaz.Show()

                Else

                    ProgressBar1.Increment(-30)

                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                    MessageBox.Show("Usuario o Contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Me.Text = "REPACC - Login - Quedan " & intentos & " Intentos"

                    ProgressBar1.Visible = False

                    If intentos = 0 Then
                        Close()

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub

    Public Function buscar_emp() As String

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()
        Dim buscarid As String = _
        "Select Id_Empleado FROM Usuarios WHERE Usuario  = '" & _
        txtUsuario.Text.Trim & "' AND Contraseña = '" & _
        txtContraseña.Text.Trim & "'"

        Dim aydi As String

        Dim comandus As SqlCommand = New SqlCommand(buscarid, cnn)

        aydi = comandus.ExecuteScalar()

        cnn.Close()

        Return aydi

    End Function

    Private Sub ControlDeAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtContraseña.Text = ""
        txtUsuario.Text = ""

    End Sub
End Class
