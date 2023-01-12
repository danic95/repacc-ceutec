Imports System.Data.SqlClient
Public Class Compras

    Dim comando As SqlCommand
    Private tbIdProd As DataTable
    Private tbIdProv As DataTable
    Private tbdescri As DataTable
    Private tbsubtot As DataTable
    Private tbdetail As DataTable

    Dim w As String

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.ComprasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)
            SaveDetall()
            updatestock()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Public Function Recuperar_Combo(ByVal colum As String, ByVal table As String) As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT " & colum & " FROM " & table
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Timer1.Start()
        Id_CompraLabel1.Enabled = True
        Id_ProductoComboBox.Enabled = True
        Id_ProveedorComboBox.Enabled = True
        Fecha_CompraDateTimePicker.Enabled = True
        CantidadTextBox.Enabled = True
        ComprasBindingNavigatorSaveItem.Enabled = True
        DescripcionLabel1.Enabled = True
        Button1.Enabled = True

        w = "00" & Recuperar_IdFactura() + 1

    End Sub

    Public Function Recuperar_IdFactura() As Integer

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Compra FROM Compras order by Id_Compra desc"
        comando.Connection = cnn

        Return Int(comando.ExecuteScalar)

        cnn.Close()

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DescripcionLabel1.Text = descripcomb.Text
        Id_CompraLabel1.Text = w

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tbdescri = New DataTable
            tbdescri.Load(GetDetall("Descripcion", Id_ProductoComboBox.Text))

            descripcomb.DataSource = tbdescri
            descripcomb.DisplayMember = tbdescri.Columns(0).ColumnName

            DataGridView1.Rows.Insert(DataGridView1.CurrentCell.RowIndex, Id_CompraLabel1.Text, Id_ProductoComboBox.Text, descripcomb.Text, CantidadTextBox.Text, 1)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        End Try
    End Sub

    Public Function GetDetall(column As String, ID As String) As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT " & column & " FROM Producto WHERE Id_Producto = " & ID
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function

    Public Sub SaveDetall()

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

            comando = New SqlCommand
        comando.CommandText = "Insert into Detalle_Compras values ('" & DataGridView1.Item(0, 0).Value & "' ,'" & DataGridView1.Item(1, 0).Value _
                & "' ,'" & DataGridView1.Item(2, 0).Value & "' ," & Int(DataGridView1.Item(3, 0).Value) & " ," & Int(DataGridView1.Item(4, 0).Value) & ")"
            comando.Connection = cnn
            comando.ExecuteNonQuery()

        cnn.Close()

    End Sub

    Private Sub updatestock()

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "Update Producto set Existencia = (select Existencia from producto where Id_Producto = '" & Id_ProductoComboBox.Text _
            & "') +" & Val(CantidadTextBox.Text) & "where id_producto = '" & Id_ProductoComboBox.Text & "'"
        comando.Connection = cnn
        comando.ExecuteNonQuery()

        cnn.Close()

    End Sub

End Class