Imports System.IO
Imports System.Data.SqlClient
Public Class Empleado

    Dim comando As SqlCommand
    Private tbIdEmp As DataTable
    Dim w As String

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click

        Dim objArchivo As FileStream = Nothing
        Dim strArchivo As String = Nothing
        Dim strdir As String

        strArchivo = Application.StartupPath & "\Empleados\" & Id_EmpleadoLabel1.Text & ".jpeg"
        strdir = Application.StartupPath & "\Empleados\"

        FotografiaTextBox.Text = strArchivo

        Try

            Me.Validate()
            Me.EmpleadosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)
            Try

                fotoempleado.Image.Save(strArchivo)

            Catch ex As Exception
            Finally
                Try
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                objArchivo = Nothing
            End Try

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Timer1.Start()
        FotografiaTextBox.Enabled = True
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        NacionalidadTextBox.Enabled = True
        EdadTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        CorreoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        Fecha_ContratacionDateTimePicker.Enabled = True
        PuestoTextBox.Enabled = True
        btnExplorar.Enabled = True
        EmpleadosBindingNavigatorSaveItem.Enabled = True
        w = "00" & Recuperar_IdEmpleado() + 1

    End Sub

    Public Function Recuperar_IdEmpleado() As Integer

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Empleado FROM Usuarios order by Id_Empleado desc"
        comando.Connection = cnn

        Return Int(comando.ExecuteScalar)

        cnn.Close()

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Id_EmpleadoLabel1.Text = w

    End Sub

    Private Sub btnExplorar_Click(sender As Object, e As EventArgs) Handles btnExplorar.Click
        Dim objArchivo As FileStream = Nothing
        Dim strArchivo As String = Nothing
        Dim resp As DialogResult

        With OpenFileDialog2
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = "jpg"
            .Filter = "Archivos de Imagen (*.jpg)|*.jpg"
            Try
                .ShowDialog()
            Catch ex As Exception
            End Try

            resp = Windows.Forms.DialogResult.OK
            If resp = DialogResult.OK Then
                strArchivo = .FileName
                Try
                    ' Abrir archivo para lectura
                    objArchivo = New FileStream(strArchivo, _
                                                FileMode.Open, _
                                                FileAccess.Read)

                    FotografiaTextBox.Text = strArchivo

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    Try
                        ' Cierre del archivo.
                        objArchivo.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    objArchivo = Nothing
                End Try
                actualizaFoto(strArchivo)
            Else
                'nada cancel presionado
            End If
        End With
    End Sub

    Sub actualizaFoto()
        Dim RutaFoto As String = _
    Application.StartupPath & "\Empleados\"
        Dim NombreFoto As String = _
            Id_EmpleadoLabel1.Text & ".jpg"

        If System.IO.File.Exists(RutaFoto & NombreFoto) Then
            fotoempleado.Image = Image.FromFile(RutaFoto & NombreFoto)
        Else
            fotoempleado.Image = Image.FromFile(RutaFoto & _
                                  "NoFoto.jpg")
        End If
        FotografiaTextBox.Text = RutaFoto & NombreFoto
    End Sub

    Sub actualizafoto(ByVal strArc)
        Dim RutaFoto As String = _
        Application.StartupPath & "\Empleados\"

        If System.IO.File.Exists(strArc) Then
            fotoempleado.Image = Image.FromFile(strArc)
        Else
            fotoempleado.Image = Image.FromFile(RutaFoto & _
                                  "NoFoto.jpg")
        End If
        FotografiaTextBox.Text = strArc
    End Sub

End Class