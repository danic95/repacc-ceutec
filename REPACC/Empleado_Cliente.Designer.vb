<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado_Cliente
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
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim Id_EmpleadoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado_Cliente))
        Me.BD_REPACCDataSet1 = New REPACC.BD_REPACCDataSet()
        Me.Cliente_EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_EmpleadoTableAdapter = New REPACC.BD_REPACCDataSetTableAdapters.Cliente_EmpleadoTableAdapter()
        Me.TableAdapterManager1 = New REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager()
        Me.Cliente_EmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cliente_EmpleadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Id_clienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_EmpleadoComboBox = New System.Windows.Forms.ComboBox()
        Id_clienteLabel = New System.Windows.Forms.Label()
        Id_EmpleadoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_REPACCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cliente_EmpleadoBindingNavigator.SuspendLayout()
        CType(Me.Cliente_EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(9, 43)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(54, 13)
        Id_clienteLabel.TabIndex = 2
        Id_clienteLabel.Text = "Id Cliente:"
        '
        'Id_EmpleadoLabel
        '
        Id_EmpleadoLabel.AutoSize = True
        Id_EmpleadoLabel.Location = New System.Drawing.Point(9, 70)
        Id_EmpleadoLabel.Name = "Id_EmpleadoLabel"
        Id_EmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        Id_EmpleadoLabel.TabIndex = 4
        Id_EmpleadoLabel.Text = "Id Empleado:"
        '
        'BD_REPACCDataSet1
        '
        Me.BD_REPACCDataSet1.DataSetName = "BD_REPACCDataSet"
        Me.BD_REPACCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cliente_EmpleadoBindingSource
        '
        Me.Cliente_EmpleadoBindingSource.DataMember = "Cliente-Empleado"
        Me.Cliente_EmpleadoBindingSource.DataSource = Me.BD_REPACCDataSet1
        '
        'Cliente_EmpleadoTableAdapter
        '
        Me.Cliente_EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Cliente_EmpleadoTableAdapter = Me.Cliente_EmpleadoTableAdapter
        Me.TableAdapterManager1.ClienteTableAdapter = Nothing
        Me.TableAdapterManager1.ComprasTableAdapter = Nothing
        Me.TableAdapterManager1.Detalle_ComprasTableAdapter = Nothing
        Me.TableAdapterManager1.Detalle_FacturaTableAdapter = Nothing
        Me.TableAdapterManager1.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager1.FacturaTableAdapter = Nothing
        Me.TableAdapterManager1.Producto_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.ProductoTableAdapter = Nothing
        Me.TableAdapterManager1.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsuariosTableAdapter = Nothing
        '
        'Cliente_EmpleadoBindingNavigator
        '
        Me.Cliente_EmpleadoBindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.Cliente_EmpleadoBindingNavigator.BindingSource = Me.Cliente_EmpleadoBindingSource
        Me.Cliente_EmpleadoBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.Cliente_EmpleadoBindingNavigator.DeleteItem = Nothing
        Me.Cliente_EmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.Cliente_EmpleadoBindingNavigatorSaveItem})
        Me.Cliente_EmpleadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cliente_EmpleadoBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.Cliente_EmpleadoBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.Cliente_EmpleadoBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.Cliente_EmpleadoBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.Cliente_EmpleadoBindingNavigator.Name = "Cliente_EmpleadoBindingNavigator"
        Me.Cliente_EmpleadoBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Cliente_EmpleadoBindingNavigator.Size = New System.Drawing.Size(270, 25)
        Me.Cliente_EmpleadoBindingNavigator.TabIndex = 0
        Me.Cliente_EmpleadoBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        Me.ToolStripButton5.ToolTipText = "Agregar nuevo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Ítems totales"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        Me.ToolStripButton1.ToolTipText = "Ir al primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        Me.ToolStripButton2.ToolTipText = "Anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        Me.ToolStripButton3.ToolTipText = "Siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        Me.ToolStripButton4.ToolTipText = "Ir al último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Cliente_EmpleadoBindingNavigatorSaveItem
        '
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cliente_EmpleadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.Name = "Cliente_EmpleadoBindingNavigatorSaveItem"
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.Text = "Save Data"
        Me.Cliente_EmpleadoBindingNavigatorSaveItem.ToolTipText = "Guardar información"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_Empleado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id_Empleado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Id_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Cliente_EmpleadoDataGridView
        '
        Me.Cliente_EmpleadoDataGridView.AutoGenerateColumns = False
        Me.Cliente_EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Cliente_EmpleadoDataGridView.DataSource = Me.Cliente_EmpleadoBindingSource
        Me.Cliente_EmpleadoDataGridView.Location = New System.Drawing.Point(12, 94)
        Me.Cliente_EmpleadoDataGridView.Name = "Cliente_EmpleadoDataGridView"
        Me.Cliente_EmpleadoDataGridView.Size = New System.Drawing.Size(245, 220)
        Me.Cliente_EmpleadoDataGridView.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(189, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Id_clienteComboBox
        '
        Me.Id_clienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cliente_EmpleadoBindingSource, "Id_cliente", True))
        Me.Id_clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_clienteComboBox.FormattingEnabled = True
        Me.Id_clienteComboBox.Location = New System.Drawing.Point(83, 40)
        Me.Id_clienteComboBox.Name = "Id_clienteComboBox"
        Me.Id_clienteComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_clienteComboBox.TabIndex = 14
        '
        'Id_EmpleadoComboBox
        '
        Me.Id_EmpleadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cliente_EmpleadoBindingSource, "Id_Empleado", True))
        Me.Id_EmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Id_EmpleadoComboBox.FormattingEnabled = True
        Me.Id_EmpleadoComboBox.Location = New System.Drawing.Point(83, 67)
        Me.Id_EmpleadoComboBox.Name = "Id_EmpleadoComboBox"
        Me.Id_EmpleadoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_EmpleadoComboBox.TabIndex = 15
        '
        'Empleado_Cliente
        '
        Me.ClientSize = New System.Drawing.Size(270, 324)
        Me.Controls.Add(Me.Id_EmpleadoComboBox)
        Me.Controls.Add(Me.Id_clienteComboBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Id_EmpleadoLabel)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Cliente_EmpleadoDataGridView)
        Me.Controls.Add(Me.Cliente_EmpleadoBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Empleado_Cliente"
        Me.Text = "Asignación de clientes"
        CType(Me.BD_REPACCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cliente_EmpleadoBindingNavigator.ResumeLayout(False)
        Me.Cliente_EmpleadoBindingNavigator.PerformLayout()
        CType(Me.Cliente_EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BD_REPACCDataSet1 As REPACC.BD_REPACCDataSet
    Friend WithEvents Cliente_EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_EmpleadoTableAdapter As REPACC.BD_REPACCDataSetTableAdapters.Cliente_EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager1 As REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cliente_EmpleadoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cliente_EmpleadoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente_EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Id_clienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_EmpleadoComboBox As System.Windows.Forms.ComboBox
End Class
