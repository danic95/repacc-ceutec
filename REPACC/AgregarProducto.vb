
Imports System.IO
Public Class AgregarProducto

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_REPACCDataSet._Producto_Proveedor' table. You can move, or remove it, as needed.
        Me.Producto_ProveedorTableAdapter.Fill(Me.BD_REPACCDataSet._Producto_Proveedor)
        'TODO: This line of code loads data into the 'BD_REPACCDataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.BD_REPACCDataSet.Producto)
        Timer1.Start()
    End Sub

    Sub actualizaFoto()
        Dim RutaFoto As String = _
    Application.StartupPath & "\Productos\"
        Dim NombreFoto As String = _
            Id_ProductoTextBox.Text & ".jpg"

        If System.IO.File.Exists(RutaFoto & NombreFoto) Then
            Imagenproducto.Image = Image.FromFile(RutaFoto & NombreFoto)
        Else
            Imagenproducto.Image = Image.FromFile(RutaFoto & _
                                  "NoFoto.jpg")
        End If
        FotografiaTextBox.Text = RutaFoto & NombreFoto
    End Sub

    Sub actualizafoto(ByVal strArc)
        Dim RutaFoto As String = _
        Application.StartupPath & "\Productos\"

        If System.IO.File.Exists(strArc) Then
            Imagenproducto.Image = Image.FromFile(strArc)
        Else
            Imagenproducto.Image = Image.FromFile(RutaFoto & _
                                  "NoFoto.jpg")
        End If
        FotografiaTextBox.Text = strArc
    End Sub

    Private Sub btnExplorar_Click(sender As Object, e As EventArgs) Handles btnExplorar.Click
        Dim objArchivo As FileStream = Nothing
        Dim strArchivo As String = Nothing
        Dim resp As DialogResult

        With OpenFileDialog1
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

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click

        Dim objArchivo As FileStream = Nothing
        Dim strArchivo As String = Nothing
        Dim strdir As String

        strArchivo = Application.StartupPath & "\Productos\" & Id_ProductoTextBox.Text & ".jpeg"
        strdir = Application.StartupPath & "\Productos\"

        FotografiaTextBox.Text = strArchivo
        Try
            Me.Validate()
            Me.ProductoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)

            Try

                Imagenproducto.Image.Save(strArchivo)

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If FotografiaTextBox.Text = "" Then

            Imagenproducto.Image = Image.FromFile(Application.StartupPath & _
                                                "\Productos\NoFoto.jpg")

        Else

            actualizaFoto(FotografiaTextBox.Text)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rpt As New NivInv

        Visor_de_reportes.CrystalReportViewer1.ReportSource = rpt

        Visor_de_reportes.Show()
        Visor_de_reportes.MdiParent = Me.MdiParent

    End Sub
End Class