<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listings
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JugadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AciertosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuegocartasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JuegocartasDataSet = New CartaMasAltaBueno.juegocartasDataSet()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RegistroTableAdapter = New CartaMasAltaBueno.juegocartasDataSetTableAdapters.RegistroTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSortDesc = New System.Windows.Forms.Button()
        Me.ButtonSortAsc = New System.Windows.Forms.Button()
        Me.buttonNoFilter = New System.Windows.Forms.Button()
        Me.buttonFilter = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBoxId = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxPlayed = New System.Windows.Forms.TextBox()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.TextBoxDays = New System.Windows.Forms.TextBox()
        Me.TextBoxHits = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuegocartasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuegocartasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.JugadorDataGridViewTextBoxColumn, Me.AciertosDataGridViewTextBoxColumn, Me.TiempoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1368, 231)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'JugadorDataGridViewTextBoxColumn
        '
        Me.JugadorDataGridViewTextBoxColumn.DataPropertyName = "Jugador"
        Me.JugadorDataGridViewTextBoxColumn.HeaderText = "Jugador"
        Me.JugadorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JugadorDataGridViewTextBoxColumn.Name = "JugadorDataGridViewTextBoxColumn"
        Me.JugadorDataGridViewTextBoxColumn.Width = 150
        '
        'AciertosDataGridViewTextBoxColumn
        '
        Me.AciertosDataGridViewTextBoxColumn.DataPropertyName = "Aciertos"
        Me.AciertosDataGridViewTextBoxColumn.HeaderText = "Aciertos"
        Me.AciertosDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AciertosDataGridViewTextBoxColumn.Name = "AciertosDataGridViewTextBoxColumn"
        Me.AciertosDataGridViewTextBoxColumn.Width = 150
        '
        'TiempoDataGridViewTextBoxColumn
        '
        Me.TiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TiempoDataGridViewTextBoxColumn.Name = "TiempoDataGridViewTextBoxColumn"
        Me.TiempoDataGridViewTextBoxColumn.Width = 150
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 150
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "Registro"
        Me.RegistroBindingSource.DataSource = Me.JuegocartasDataSetBindingSource
        '
        'JuegocartasDataSetBindingSource
        '
        Me.JuegocartasDataSetBindingSource.DataSource = Me.JuegocartasDataSet
        Me.JuegocartasDataSetBindingSource.Position = 0
        '
        'JuegocartasDataSet
        '
        Me.JuegocartasDataSet.DataSetName = "juegocartasDataSet"
        Me.JuegocartasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Games played"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Game Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Days Played"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonSortDesc)
        Me.GroupBox1.Controls.Add(Me.ButtonSortAsc)
        Me.GroupBox1.Controls.Add(Me.buttonNoFilter)
        Me.GroupBox1.Controls.Add(Me.buttonFilter)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxId)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 185)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter / Sort"
        '
        'ButtonSortDesc
        '
        Me.ButtonSortDesc.Location = New System.Drawing.Point(613, 89)
        Me.ButtonSortDesc.Name = "ButtonSortDesc"
        Me.ButtonSortDesc.Size = New System.Drawing.Size(108, 31)
        Me.ButtonSortDesc.TabIndex = 6
        Me.ButtonSortDesc.Text = "Sort Desc"
        Me.ButtonSortDesc.UseVisualStyleBackColor = True
        '
        'ButtonSortAsc
        '
        Me.ButtonSortAsc.Location = New System.Drawing.Point(486, 89)
        Me.ButtonSortAsc.Name = "ButtonSortAsc"
        Me.ButtonSortAsc.Size = New System.Drawing.Size(105, 31)
        Me.ButtonSortAsc.TabIndex = 5
        Me.ButtonSortAsc.Text = "Sort Asc"
        Me.ButtonSortAsc.UseVisualStyleBackColor = True
        '
        'buttonNoFilter
        '
        Me.buttonNoFilter.Location = New System.Drawing.Point(613, 31)
        Me.buttonNoFilter.Name = "buttonNoFilter"
        Me.buttonNoFilter.Size = New System.Drawing.Size(108, 31)
        Me.buttonNoFilter.TabIndex = 4
        Me.buttonNoFilter.Text = "No Filter"
        Me.buttonNoFilter.UseVisualStyleBackColor = True
        '
        'buttonFilter
        '
        Me.buttonFilter.Location = New System.Drawing.Point(486, 33)
        Me.buttonFilter.Name = "buttonFilter"
        Me.buttonFilter.Size = New System.Drawing.Size(105, 31)
        Me.buttonFilter.TabIndex = 3
        Me.buttonFilter.Text = "Filter"
        Me.buttonFilter.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(191, 36)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(102, 28)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBoxId
        '
        Me.ComboBoxId.FormattingEnabled = True
        Me.ComboBoxId.Location = New System.Drawing.Point(23, 36)
        Me.ComboBoxId.Name = "ComboBoxId"
        Me.ComboBoxId.Size = New System.Drawing.Size(102, 28)
        Me.ComboBoxId.TabIndex = 0
        Me.ComboBoxId.Text = "Id"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(604, 673)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 31)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxPlayed
        '
        Me.TextBoxPlayed.Location = New System.Drawing.Point(226, 422)
        Me.TextBoxPlayed.Name = "TextBoxPlayed"
        Me.TextBoxPlayed.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxPlayed.TabIndex = 8
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(226, 469)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxTime.TabIndex = 9
        '
        'TextBoxDays
        '
        Me.TextBoxDays.Location = New System.Drawing.Point(226, 516)
        Me.TextBoxDays.Name = "TextBoxDays"
        Me.TextBoxDays.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxDays.TabIndex = 10
        '
        'TextBoxHits
        '
        Me.TextBoxHits.Location = New System.Drawing.Point(226, 577)
        Me.TextBoxHits.Name = "TextBoxHits"
        Me.TextBoxHits.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxHits.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 583)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Hits"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(356, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 26)
        Me.TextBox1.TabIndex = 7
        '
        'listings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 746)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxHits)
        Me.Controls.Add(Me.TextBoxDays)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.TextBoxPlayed)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "listings"
        Me.Text = "listings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuegocartasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuegocartasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents JuegocartasDataSet As juegocartasDataSet
    Friend WithEvents JuegocartasDataSetBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RegistroBindingSource As BindingSource
    Friend WithEvents RegistroTableAdapter As juegocartasDataSetTableAdapters.RegistroTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JugadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AciertosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiempoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSortDesc As Button
    Friend WithEvents ButtonSortAsc As Button
    Friend WithEvents buttonNoFilter As Button
    Friend WithEvents buttonFilter As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBoxId As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBoxPlayed As TextBox
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents TextBoxDays As TextBox
    Friend WithEvents TextBoxHits As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
