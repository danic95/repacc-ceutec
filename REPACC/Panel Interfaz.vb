Public Class Panel_Interfaz

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Usuario.Show()
        Usuario.MdiParent = Me
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Empleado.Show()
        Empleado.MdiParent = Me
    End Sub

    Private Sub FacturaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem1.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Factura.Show()
        Factura.MdiParent = Me
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem1.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        AgregarProveedor.Show()
        AgregarProveedor.MdiParent = Me
    End Sub


    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Compras.Show()
        Compras.MdiParent = Me
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ControlDeAcceso.Show()
        Me.Close()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        AgregarClientes.Show()
        AgregarClientes.MdiParent = Me
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        AgregarProducto.Show()
        AgregarProducto.MdiParent = Me
    End Sub

    Private Sub Panel_Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlDeAcceso.Text = "REPACC - Login"
        ControlDeAcceso.intentos = 4
        PictureBox1.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ControlDeAcceso.txtUsuario.Text = ""
        ControlDeAcceso.txtContraseña.Text = ""
        ControlDeAcceso.Show()
        Me.Close()
    End Sub

    Private Sub Panel_Interfaz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ControlDeAcceso.txtUsuario.Text = ""
        ControlDeAcceso.txtContraseña.Text = ""
        ControlDeAcceso.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.Show()
        Me.Enabled = False
    End Sub

    Private Sub CrearNuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevoUsuarioToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Usuario.Show()
        Usuario.MdiParent = Me
    End Sub

    Private Sub AsignarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarProveedorToolStripMenuItem.Click

        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Producto_Proveedor.Show()
        Producto_Proveedor.MdiParent = Me

    End Sub

    Private Sub AsignarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarEmpleadoToolStripMenuItem.Click

        PictureBox1.Hide()
        PictureBox2.Hide()
        WlcomLbl.Hide()
        Empleado_Cliente.Show()
        Empleado_Cliente.MdiParent = Me

    End Sub
End Class