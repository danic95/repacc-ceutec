Imports System.Data.SqlClient
Public Class Usuario

    Dim comando As SqlCommand
    Private tbIdEmp As DataTable

    Dim w As String

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Timer1.Start()
        UsuariosBindingNavigatorSaveItem.Enabled = True
        Id_EmpleadoComboBox.Enabled = True
        UsuarioTextBox.Enabled = True
        ContraseñaTextBox.Enabled = True
        Admin_PrivComboBox.Enabled = True
        w = "00" & Recuperar_IdFactura() + 1

    End Sub
    Public Function Recuperar_IdEmpleado_Combo() As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Empleado FROM Empleados"
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbIdEmp = New DataTable
        tbIdEmp.Load(Recuperar_IdEmpleado_Combo())

        Id_EmpleadoComboBox.DataSource = tbIdEmp
        Id_EmpleadoComboBox.DisplayMember = tbIdEmp.Columns(0).ColumnName
        Id_EmpleadoComboBox.ValueMember = tbIdEmp.Columns(0).ColumnName

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Id_UsuarioLabel1.Text = w

    End Sub

    Public Function Recuperar_IdFactura() As Integer

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Usuario FROM Usuarios order by Id_Usuario desc"
        comando.Connection = cnn

        Return Int(comando.ExecuteScalar)

        cnn.Close()

    End Function
End Class