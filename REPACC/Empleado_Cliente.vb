Imports System.Data.SqlClient
Public Class Empleado_Cliente

    Dim comando As SqlCommand
    Private tbIdEmp As DataTable
    Private tbIdClien As DataTable

    Private Sub Cliente_EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cliente_EmpleadoBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.Cliente_EmpleadoBindingSource.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.BD_REPACCDataSet1)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Empleado_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_REPACCDataSet1._Cliente_Empleado' table. You can move, or remove it, as needed.
        Me.Cliente_EmpleadoTableAdapter.Fill(Me.BD_REPACCDataSet1._Cliente_Empleado)

        tbIdEmp = New DataTable
        tbIdEmp.Load(Recuperar_Combo("Id_Empleado", "Empleados"))

        Id_EmpleadoComboBox.DataSource = tbIdEmp
        Id_EmpleadoComboBox.DisplayMember = tbIdEmp.Columns(0).ColumnName
        Id_EmpleadoComboBox.ValueMember = tbIdEmp.Columns(0).ColumnName

        tbIdClien = New DataTable
        tbIdClien.Load(Recuperar_Combo("Id_cliente", "Cliente"))

        Id_clienteComboBox.DataSource = tbIdClien
        Id_clienteComboBox.DisplayMember = tbIdClien.Columns(0).ColumnName
        Id_clienteComboBox.ValueMember = tbIdClien.Columns(0).ColumnName

    End Sub

    Public Function Recuperar_Combo(ByVal column As String, ByVal table As String) As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT " & column & " FROM " & table
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function
End Class