Imports System.Data.SqlClient
Public Class Producto_Proveedor

    Dim comando As SqlCommand
    Private tbIdProd As DataTable
    Private tbIdProv As DataTable

    Private Sub Producto_ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Producto_ProveedorBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.Producto_ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Producto_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_REPACCDataSet._Producto_Proveedor' table. You can move, or remove it, as needed.
        Me.Producto_ProveedorTableAdapter.Fill(Me.BD_REPACCDataSet._Producto_Proveedor)

        tbIdProd = New DataTable
        tbIdProd.Load(Recuperar_Combo("Id_Producto", "Producto"))

        Id_ProductoComboBox.DataSource = tbIdProd
        Id_ProductoComboBox.DisplayMember = tbIdProd.Columns(0).ColumnName
        Id_ProductoComboBox.ValueMember = tbIdProd.Columns(0).ColumnName

        tbIdProv = New DataTable
        tbIdProv.Load(Recuperar_Combo("Id_Proveedor", "Proveedor"))

        Id_ProveedorComboBox.DataSource = tbIdProv
        Id_ProveedorComboBox.DisplayMember = tbIdProv.Columns(0).ColumnName
        Id_ProveedorComboBox.ValueMember = tbIdProv.Columns(0).ColumnName

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