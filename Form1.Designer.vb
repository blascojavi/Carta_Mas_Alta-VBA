<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.labelJugador = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptioonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBackOfDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTiempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.successes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.deck = New System.Windows.Forms.PictureBox()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.deck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelJugador
        '
        Me.labelJugador.AutoSize = True
        Me.labelJugador.Location = New System.Drawing.Point(505, 56)
        Me.labelJugador.Name = "labelJugador"
        Me.labelJugador.Size = New System.Drawing.Size(0, 20)
        Me.labelJugador.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(526, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Press the rigth button if you think the next card will be bigger"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Press the left button if you think the next card will be smaller"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ListingsToolStripMenuItem, Me.OptioonsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1623, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ListingsToolStripMenuItem
        '
        Me.ListingsToolStripMenuItem.Name = "ListingsToolStripMenuItem"
        Me.ListingsToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.ListingsToolStripMenuItem.Text = "Listings"
        '
        'OptioonsToolStripMenuItem
        '
        Me.OptioonsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePlayerToolStripMenuItem, Me.ChangeBackOfDeckToolStripMenuItem})
        Me.OptioonsToolStripMenuItem.Name = "OptioonsToolStripMenuItem"
        Me.OptioonsToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.OptioonsToolStripMenuItem.Text = "Optioons"
        '
        'ChangePlayerToolStripMenuItem
        '
        Me.ChangePlayerToolStripMenuItem.Name = "ChangePlayerToolStripMenuItem"
        Me.ChangePlayerToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.ChangePlayerToolStripMenuItem.Text = "change player"
        '
        'ChangeBackOfDeckToolStripMenuItem
        '
        Me.ChangeBackOfDeckToolStripMenuItem.Name = "ChangeBackOfDeckToolStripMenuItem"
        Me.ChangeBackOfDeckToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.ChangeBackOfDeckToolStripMenuItem.Text = "change back of Deck"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTiempo, Me.successes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 764)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1623, 32)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTiempo
        '
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(54, 25)
        Me.lblTiempo.Text = "Time:"
        '
        'successes
        '
        Me.successes.Name = "successes"
        Me.successes.Size = New System.Drawing.Size(94, 25)
        Me.successes.Text = "Successes:"
        '
        'deck
        '
        Me.deck.Location = New System.Drawing.Point(37, 56)
        Me.deck.Name = "deck"
        Me.deck.Size = New System.Drawing.Size(268, 392)
        Me.deck.TabIndex = 11
        Me.deck.TabStop = False
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 796)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.labelJugador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deck)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.deck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelJugador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents deck As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptioonsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeBackOfDeckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTiempo As ToolStripStatusLabel
    Friend WithEvents successes As ToolStripStatusLabel
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
