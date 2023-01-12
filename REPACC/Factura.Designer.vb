<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_FacturaLabel As System.Windows.Forms.Label
        Dim Id_EmpleadoLabel As System.Windows.Forms.Label
        Dim Id_ClienteLabel As System.Windows.Forms.Label
        Dim Fecha_FacturaLabel As System.Windows.Forms.Label
        Dim Forma_PagoLabel As System.Windows.Forms.Label
        Dim Sub_TotalLabel As System.Windows.Forms.Label
        Dim Total_ISVLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ProductosLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.BD_REPACCDataSet = New REPACC.BD_REPACCDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New REPACC.BD_REPACCDataSetTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager = New REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Fecha_FacturaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sub_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ISVTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductosComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.descripcomb = New System.Windows.Forms.ComboBox()
        Me.SubtotCombo = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Forma_PagoComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_EmpleadoLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Id_FacturaLabel1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Id_FacturaLabel = New System.Windows.Forms.Label()
        Id_EmpleadoLabel = New System.Windows.Forms.Label()
        Id_ClienteLabel = New System.Windows.Forms.Label()
        Fecha_FacturaLabel = New System.Windows.Forms.Label()
        Forma_PagoLabel = New System.Windows.Forms.Label()
        Sub_TotalLabel = New System.Windows.Forms.Label()
        Total_ISVLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ProductosLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CType(Me.BD_REPACCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FacturaLabel
        '
        Id_FacturaLabel.AutoSize = True
        Id_FacturaLabel.Location = New System.Drawing.Point(13, 50)
        Id_FacturaLabel.Name = "Id_FacturaLabel"
        Id_FacturaLabel.Size = New System.Drawing.Size(58, 13)
        Id_FacturaLabel.TabIndex = 2
        Id_FacturaLabel.Text = "Id Factura:"
        '
        'Id_EmpleadoLabel
        '
        Id_EmpleadoLabel.AutoSize = True
        Id_EmpleadoLabel.Location = New System.Drawing.Point(6, 68)
        Id_EmpleadoLabel.Name = "Id_EmpleadoLabel"
        Id_EmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        Id_EmpleadoLabel.TabIndex = 4
        Id_EmpleadoLabel.Text = "Id Empleado:"
        '
        'Id_ClienteLabel
        '
        Id_ClienteLabel.AutoSize = True
        Id_ClienteLabel.Location = New System.Drawing.Point(6, 16)
        Id_ClienteLabel.Name = "Id_ClienteLabel"
        Id_ClienteLabel.Size = New System.Drawing.Size(54, 13)
        Id_ClienteLabel.TabIndex = 6
        Id_ClienteLabel.Text = "Id Cliente:"
        '
        'Fecha_FacturaLabel
        '
        Fecha_FacturaLabel.AutoSize = True
        Fecha_FacturaLabel.Location = New System.Drawing.Point(183, 50)
        Fecha_FacturaLabel.Name = "Fecha_FacturaLabel"
        Fecha_FacturaLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_FacturaLabel.TabIndex = 8
        Fecha_FacturaLabel.Text = "Fecha Factura:"
        '
        'Forma_PagoLabel
        '
        Forma_PagoLabel.AutoSize = True
        Forma_PagoLabel.Location = New System.Drawing.Point(5, 42)
        Forma_PagoLabel.Name = "Forma_PagoLabel"
        Forma_PagoLabel.Size = New System.Drawing.Size(67, 13)
        Forma_PagoLabel.TabIndex = 10
        Forma_PagoLabel.Text = "Forma Pago:"
        '
        'Sub_TotalLabel
        '
        Sub_TotalLabel.AutoSize = True
        Sub_TotalLabel.Location = New System.Drawing.Point(6, 16)
        Sub_TotalLabel.Name = "Sub_TotalLabel"
        Sub_TotalLabel.Size = New System.Drawing.Size(56, 13)
        Sub_TotalLabel.TabIndex = 12
        Sub_TotalLabel.Text = "Sub Total:"
        '
        'Total_ISVLabel
        '
        Total_ISVLabel.AutoSize = True
        Total_ISVLabel.Location = New System.Drawing.Point(6, 42)
        Total_ISVLabel.Name = "Total_ISVLabel"
        Total_ISVLabel.Size = New System.Drawing.Size(54, 13)
        Total_ISVLabel.TabIndex = 14
        Total_ISVLabel.Text = "Total ISV:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(6, 68)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 16
        TotalLabel.Text = "Total:"
        '
        'ProductosLabel
        '
        ProductosLabel.AutoSize = True
        ProductosLabel.Location = New System.Drawing.Point(562, 187)
        ProductosLabel.Name = "ProductosLabel"
        ProductosLabel.Size = New System.Drawing.Size(58, 13)
        ProductosLabel.TabIndex = 22
        ProductosLabel.Text = "Productos:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(562, 243)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 23
        CantidadLabel.Text = "Cantidad:"
        '
        'BD_REPACCDataSet
        '
        Me.BD_REPACCDataSet.DataSetName = "BD_REPACCDataSet"
        Me.BD_REPACCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.BD_REPACCDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.Producto_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Nothing
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(674, 25)
        Me.FacturaBindingNavigator.TabIndex = 1
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.ToolTipText = "Agregar nueva"
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
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Enabled = False
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FacturaBindingNavigatorSaveItem.Text = "Save Data"
        Me.FacturaBindingNavigatorSaveItem.ToolTipText = "Guardar factura"
        '
        'Fecha_FacturaDateTimePicker
        '
        Me.Fecha_FacturaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "Fecha_Factura", True))
        Me.Fecha_FacturaDateTimePicker.Enabled = False
        Me.Fecha_FacturaDateTimePicker.Location = New System.Drawing.Point(268, 46)
        Me.Fecha_FacturaDateTimePicker.Name = "Fecha_FacturaDateTimePicker"
        Me.Fecha_FacturaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_FacturaDateTimePicker.TabIndex = 9
        '
        'Sub_TotalTextBox
        '
        Me.Sub_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Sub_Total", True))
        Me.Sub_TotalTextBox.Enabled = False
        Me.Sub_TotalTextBox.Location = New System.Drawing.Point(68, 13)
        Me.Sub_TotalTextBox.Name = "Sub_TotalTextBox"
        Me.Sub_TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sub_TotalTextBox.TabIndex = 13
        Me.Sub_TotalTextBox.Text = "0"
        '
        'Total_ISVTextBox
        '
        Me.Total_ISVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Total_ISV", True))
        Me.Total_ISVTextBox.Enabled = False
        Me.Total_ISVTextBox.Location = New System.Drawing.Point(68, 39)
        Me.Total_ISVTextBox.Name = "Total_ISVTextBox"
        Me.Total_ISVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_ISVTextBox.TabIndex = 15
        Me.Total_ISVTextBox.Text = "0"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Total", True))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(68, 65)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 17
        Me.TotalTextBox.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Factura, Me.Id_Producto, Me.Descripcion, Me.Cantidad, Me.No_Linea})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 228)
        Me.DataGridView1.TabIndex = 0
        '
        'Id_Factura
        '
        Me.Id_Factura.HeaderText = "Id_Factura"
        Me.Id_Factura.MaxInputLength = 8
        Me.Id_Factura.Name = "Id_Factura"
        Me.Id_Factura.ReadOnly = True
        '
        'Id_Producto
        '
        Me.Id_Producto.HeaderText = "Id_Producto"
        Me.Id_Producto.MaxInputLength = 8
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 50
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'No_Linea
        '
        Me.No_Linea.HeaderText = "No_Linea"
        Me.No_Linea.Name = "No_Linea"
        Me.No_Linea.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(562, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 31)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(562, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 31)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProductosComboBox
        '
        Me.ProductosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductosComboBox.Enabled = False
        Me.ProductosComboBox.FormattingEnabled = True
        Me.ProductosComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProductosComboBox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.ProductosComboBox.Location = New System.Drawing.Point(565, 203)
        Me.ProductosComboBox.Name = "ProductosComboBox"
        Me.ProductosComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ProductosComboBox.TabIndex = 21
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Enabled = False
        Me.CantidadTextBox.Location = New System.Drawing.Point(565, 259)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 24
        Me.CantidadTextBox.Text = "1"
        '
        'descripcomb
        '
        Me.descripcomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.descripcomb.FormattingEnabled = True
        Me.descripcomb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.descripcomb.Items.AddRange(New Object() {"0", "1", "2"})
        Me.descripcomb.Location = New System.Drawing.Point(674, 470)
        Me.descripcomb.Name = "descripcomb"
        Me.descripcomb.Size = New System.Drawing.Size(100, 21)
        Me.descripcomb.TabIndex = 25
        '
        'SubtotCombo
        '
        Me.SubtotCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubtotCombo.FormattingEnabled = True
        Me.SubtotCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SubtotCombo.Items.AddRange(New Object() {"0", "1", "2"})
        Me.SubtotCombo.Location = New System.Drawing.Point(674, 518)
        Me.SubtotCombo.Name = "SubtotCombo"
        Me.SubtotCombo.Size = New System.Drawing.Size(100, 21)
        Me.SubtotCombo.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Forma_PagoComboBox)
        Me.GroupBox1.Controls.Add(Me.Id_ClienteComboBox)
        Me.GroupBox1.Controls.Add(Me.Id_EmpleadoLabel1)
        Me.GroupBox1.Controls.Add(Id_ClienteLabel)
        Me.GroupBox1.Controls.Add(Id_EmpleadoLabel)
        Me.GroupBox1.Controls.Add(Forma_PagoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 93)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la factura"
        '
        'Forma_PagoComboBox
        '
        Me.Forma_PagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Forma_Pago", True))
        Me.Forma_PagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Forma_PagoComboBox.Enabled = False
        Me.Forma_PagoComboBox.FormattingEnabled = True
        Me.Forma_PagoComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Forma_PagoComboBox.Items.AddRange(New Object() {"Contado", "Credito"})
        Me.Forma_PagoComboBox.Location = New System.Drawing.Point(81, 39)
        Me.Forma_PagoComboBox.Name = "Forma_PagoComboBox"
        Me.Forma_PagoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Forma_PagoComboBox.TabIndex = 31
        '
        'Id_ClienteComboBox
        '
        Me.Id_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_Cliente", True))
        Me.Id_ClienteComboBox.Enabled = False
        Me.Id_ClienteComboBox.FormattingEnabled = True
        Me.Id_ClienteComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Id_ClienteComboBox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.Id_ClienteComboBox.Location = New System.Drawing.Point(81, 13)
        Me.Id_ClienteComboBox.Name = "Id_ClienteComboBox"
        Me.Id_ClienteComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_ClienteComboBox.TabIndex = 31
        '
        'Id_EmpleadoLabel1
        '
        Me.Id_EmpleadoLabel1.AutoSize = True
        Me.Id_EmpleadoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Id_EmpleadoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_Empleado", True))
        Me.Id_EmpleadoLabel1.Location = New System.Drawing.Point(81, 68)
        Me.Id_EmpleadoLabel1.Name = "Id_EmpleadoLabel1"
        Me.Id_EmpleadoLabel1.Size = New System.Drawing.Size(2, 15)
        Me.Id_EmpleadoLabel1.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Total_ISVTextBox)
        Me.GroupBox2.Controls.Add(Me.Sub_TotalTextBox)
        Me.GroupBox2.Controls.Add(Sub_TotalLabel)
        Me.GroupBox2.Controls.Add(Total_ISVLabel)
        Me.GroupBox2.Controls.Add(Me.TotalTextBox)
        Me.GroupBox2.Controls.Add(TotalLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 93)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Total de la Factura"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(474, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Id_FacturaLabel1
        '
        Me.Id_FacturaLabel1.AutoSize = True
        Me.Id_FacturaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Id_FacturaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Id_Factura", True))
        Me.Id_FacturaLabel1.Location = New System.Drawing.Point(77, 50)
        Me.Id_FacturaLabel1.Name = "Id_FacturaLabel1"
        Me.Id_FacturaLabel1.Size = New System.Drawing.Size(2, 15)
        Me.Id_FacturaLabel1.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(211, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 44)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Imprimir factura"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 424)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Id_FacturaLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SubtotCombo)
        Me.Controls.Add(Me.descripcomb)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(ProductosLabel)
        Me.Controls.Add(Me.ProductosComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Fecha_FacturaLabel)
        Me.Controls.Add(Me.Fecha_FacturaDateTimePicker)
        Me.Controls.Add(Id_FacturaLabel)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me.BD_REPACCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_REPACCDataSet As REPACC.BD_REPACCDataSet
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As REPACC.BD_REPACCDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As REPACC.BD_REPACCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Fecha_FacturaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sub_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_ISVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ProductosComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents descripcomb As System.Windows.Forms.ComboBox
    Friend WithEvents SubtotCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Id_FacturaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Id_EmpleadoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Id_ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Forma_PagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
