
Public Class AgregarProveedor

    Private Sub AgregarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_REPACCDataSet.Proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.BD_REPACCDataSet.Proveedor)
    End Sub

    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedorBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BD_REPACCDataSet)

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Error al ingresar datos. Revise la información y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class