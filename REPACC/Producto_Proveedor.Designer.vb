<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Proveedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_ProductoLabel As System.Windows.Forms.Label
        Dim Id_ProveedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Proveedor))
        Me.BD_REPACCDataSet = New REPACC.BD_REPACCDataSet()
        Me.Producto_ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Producto_ProveedorTableAdapter = New REPACC.BD_REPACCDataSetTableAdapters.Producto_ProveedorTableAdapter()
        Me.TableAdapterManager = New REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager()
        Me.Producto_ProveedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Producto_ProveedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Producto_ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Id_ProductoComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Id_ProductoLabel = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        CType(Me.BD_REPACCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto_ProveedorBindingNavigator.SuspendLayout()
        CType(Me.Producto_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ProductoLabel
        '
        Id_ProductoLabel.AutoSize = True
        Id_ProductoLabel.Location = New System.Drawing.Point(12, 40)
        Id_ProductoLabel.Name = "Id_ProductoLabel"
        Id_ProductoLabel.Size = New System.Drawing.Size(65, 13)
        Id_ProductoLabel.TabIndex = 1
        Id_ProductoLabel.Text = "Id Producto:"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(12, 66)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(71, 13)
        Id_ProveedorLabel.TabIndex = 3
        Id_ProveedorLabel.Text = "Id Proveedor:"
        '
        'BD_REPACCDataSet
        '
        Me.BD_REPACCDataSet.DataSetName = "BD_REPACCDataSet"
        Me.BD_REPACCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Producto_ProveedorBindingSource
        '
        Me.Producto_ProveedorBindingSource.DataMember = "Producto-Proveedor"
        Me.Producto_ProveedorBindingSource.DataSource = Me.BD_REPACCDataSet
        '
        'Producto_ProveedorTableAdapter
        '
        Me.Producto_ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Cliente_EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_ComprasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_FacturaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.Producto_ProveedorTableAdapter = Me.Producto_ProveedorTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Producto_ProveedorBindingNavigator
        '
        Me.Producto_ProveedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Producto_ProveedorBindingNavigator.BindingSource = Me.Producto_ProveedorBindingSource
        Me.Producto_ProveedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Producto_ProveedorBindingNavigator.DeleteItem = Nothing
        Me.Producto_ProveedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Producto_ProveedorBindingNavigatorSaveItem})
        Me.Producto_ProveedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Producto_ProveedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Producto_ProveedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Producto_ProveedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Producto_ProveedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Producto_ProveedorBindingNavigator.Name = "Producto_ProveedorBindingNavigator"
        Me.Producto_ProveedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Producto_ProveedorBindingNavigator.Size = New System.Drawing.Size(270, 25)
        Me.Producto_ProveedorBindingNavigator.TabIndex = 0
        Me.Producto_ProveedorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.ToolTipText = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Ítems totales"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Ir al primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Ir al último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Producto_ProveedorBindingNavigatorSaveItem
        '
        Me.Producto_ProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Producto_ProveedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("Producto_ProveedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Producto_ProveedorBindingNavigatorSaveItem.Name = "Producto_ProveedorBindingNavigatorSaveItem"
        Me.Producto_ProveedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Producto_ProveedorBindingNavigatorSaveItem.Text = "Save Data"
        Me.Producto_ProveedorBindingNavigatorSaveItem.ToolTipText = "Guardar información"
        '
        'Producto_ProveedorDataGridView
        '
        Me.Producto_ProveedorDataGridView.AutoGenerateColumns = False
        Me.Producto_ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Producto_ProveedorDataGridView.DataSource = Me.Producto_ProveedorBindingSource
        Me.Producto_ProveedorDataGridView.Location = New System.Drawing.Point(12, 89)
        Me.Producto_ProveedorDataGridView.Name = "Producto_ProveedorDataGridView"
        Me.Producto_ProveedorDataGridView.Size = New System.Drawing.Size(244, 221)
        Me.Producto_ProveedorDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(195, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Id_ProductoComboBox
        '
        Me.Id_ProductoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Producto_ProveedorBindingSource, "Id_Producto", True))
        Me.Id_ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_ProductoComboBox.FormattingEnabled = True
        Me.Id_ProductoComboBox.Location = New System.Drawing.Point(89, 36)
        Me.Id_ProductoComboBox.Name = "Id_ProductoComboBox"
        Me.Id_ProductoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_ProductoComboBox.TabIndex = 10
        '
        'Id_ProveedorComboBox
        '
        Me.Id_ProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Producto_ProveedorBindingSource, "Id_Proveedor", True))
        Me.Id_ProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_ProveedorComboBox.FormattingEnabled = True
        Me.Id_ProveedorComboBox.Location = New System.Drawing.Point(89, 63)
        Me.Id_ProveedorComboBox.Name = "Id_ProveedorComboBox"
        Me.Id_ProveedorComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_ProveedorComboBox.TabIndex = 11
        '
        'Producto_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 320)
        Me.Controls.Add(Me.Id_ProveedorComboBox)
        Me.Controls.Add(Me.Id_ProductoComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Producto_ProveedorDataGridView)
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(Id_ProductoLabel)
        Me.Controls.Add(Me.Producto_ProveedorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Producto_Proveedor"
        Me.Text = "Asignación de proveedores"
        CType(Me.BD_REPACCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto_ProveedorBindingNavigator.ResumeLayout(False)
        Me.Producto_ProveedorBindingNavigator.PerformLayout()
        CType(Me.Producto_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_REPACCDataSet As REPACC.BD_REPACCDataSet
    Friend WithEvents Producto_ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Producto_ProveedorTableAdapter As REPACC.BD_REPACCDataSetTableAdapters.Producto_ProveedorTableAdapter
    Friend WithEvents TableAdapterManager As REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Producto_ProveedorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Producto_ProveedorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Producto_ProveedorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Id_ProductoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_ProveedorComboBox As System.Windows.Forms.ComboBox
End Class
