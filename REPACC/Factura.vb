Imports System.Data.SqlClient

Public Class Factura

    Dim comando As SqlCommand
    Private tbIdProd As DataTable
    Private tbIdClie As DataTable
    Private tbdescri As DataTable
    Private tbsubtot As DataTable
    Private tbdetail As DataTable

    Dim a As Integer
    Dim w As String

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.FacturaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)
            SaveDetall()
            updateStock()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Button3.Enabled = True

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        a = 0

        tbIdProd = New DataTable
        tbIdProd.Load(Recuperar_IdProducto_Combo())

        ProductosComboBox.DataSource = tbIdProd
        ProductosComboBox.DisplayMember = tbIdProd.Columns(0).ColumnName
        ProductosComboBox.ValueMember = tbIdProd.Columns(0).ColumnName

        tbIdClie = New DataTable
        tbIdClie.Load(Recuperar_IdCliente_Combo())

        Id_ClienteComboBox.DataSource = tbIdClie
        Id_ClienteComboBox.DisplayMember = tbIdClie.Columns(0).ColumnName
        Id_ClienteComboBox.ValueMember = tbIdClie.Columns(0).ColumnName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            tbdescri = New DataTable
            tbdescri.Load(GetDetall("Descripcion", ProductosComboBox.Text))

            descripcomb.DataSource = tbdescri
            descripcomb.DisplayMember = tbdescri.Columns(0).ColumnName

            tbsubtot = New DataTable
            tbsubtot.Load(GetDetall("Precio_Venta", ProductosComboBox.Text))

            SubtotCombo.DataSource = tbsubtot
            SubtotCombo.DisplayMember = tbsubtot.Columns(0).ColumnName

            Sub_TotalTextBox.Text = Val(Sub_TotalTextBox.Text) + (Val(SubtotCombo.Text) * Val(CantidadTextBox.Text))

            a = a + 1
            DataGridView1.Rows.Insert(DataGridView1.CurrentCell.RowIndex, Id_FacturaLabel1.Text, ProductosComboBox.Text, descripcomb.Text, CantidadTextBox.Text, a)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            Sub_TotalTextBox.Text = Val(Sub_TotalTextBox.Text) - (Val(SubtotCombo.Text) * Val(CantidadTextBox.Text))
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            a = a - 1

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        End Try

    End Sub

    Public Function Recuperar_IdProducto_Combo() As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Producto FROM Producto"
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function

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
        Dim e As Integer

        e = 0

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        While e < a

            comando = New SqlCommand
            comando.CommandText = "Insert into Detalle_Factura values ('" & DataGridView1.Item(0, e).Value & "' ,'" & DataGridView1.Item(1, e).Value _
                & "' ,'" & DataGridView1.Item(2, e).Value & "' ," & Int(DataGridView1.Item(3, e).Value) & " ," & Int(DataGridView1.Item(4, e).Value) & ")"
            comando.Connection = cnn
            comando.ExecuteNonQuery()

            e = e + 1

        End While

        cnn.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TotalTextBox.Text = Val(Sub_TotalTextBox.Text) + (Val(Sub_TotalTextBox.Text) * Val(Total_ISVTextBox.Text) / 100)

        Id_FacturaLabel1.Text = w

        Id_EmpleadoLabel1.Text = ControlDeAcceso.buscar_emp

        If Total_ISVTextBox.Text = "" Then

            Total_ISVTextBox.Text = 15

        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Timer1.Start()
        Id_ClienteComboBox.Enabled = True
        Fecha_FacturaDateTimePicker.Enabled = True
        Forma_PagoComboBox.Enabled = True
        Sub_TotalTextBox.Enabled = True
        Total_ISVTextBox.Enabled = True
        TotalTextBox.Enabled = True
        ProductosComboBox.Enabled = True
        CantidadTextBox.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        FacturaBindingNavigatorSaveItem.Enabled = True
        w = "00" & Recuperar_IdFactura() + 1

    End Sub

    Public Function Recuperar_IdFactura() As Integer

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Factura FROM Factura order by Id_Factura desc"
        comando.Connection = cnn

        Return Int(comando.ExecuteScalar)

        cnn.Close()

    End Function

    Public Function Recuperar_IdCliente_Combo() As SqlDataReader

        Dim cnn As New SqlConnection

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        comando = New SqlCommand
        comando.CommandText = "SELECT Id_Cliente FROM Cliente"
        comando.Connection = cnn

        Return comando.ExecuteReader

        cnn.Close()

    End Function

    Private Sub updatestock()

        Dim cnn As New SqlConnection
        Dim e As Integer

        e = 0

        cnn = New SqlConnection("Data Source=" & My.Computer.Name & "\SQLEXPRESS;Initial Catalog=BD_REPACC;Integrated Security=True")

        cnn.Open()

        While e < a

            comando = New SqlCommand
            comando.CommandText = "Update Producto set Existencia = (select Existencia from producto where Id_Producto = '" & DataGridView1.Item(1, e).Value _
                & "') -" & Int(DataGridView1.Item(3, e).Value) & "where id_producto = '" & DataGridView1.Item(1, e).Value & "'"
            comando.Connection = cnn
            comando.ExecuteNonQuery()

            e = e + 1

        End While

        cnn.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim repfac As New DocFactura

        repfac.SetParameterValue("@Id_Factura", Id_FacturaLabel1.Text)
        Visor_de_reportes.CrystalReportViewer1.ReportSource = repfac

        Visor_de_reportes.Show()
        'Visor_de_reportes.MdiParent = Me.MdiParent

    End Sub
End Class