﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HeaderBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DashBoardButton = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.RentalsButton = New System.Windows.Forms.Button()
        Me.InterfacePanel = New System.Windows.Forms.Panel()
        Me.HeaderBar.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderBar
        '
        Me.HeaderBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.HeaderBar.Controls.Add(Me.Label1)
        Me.HeaderBar.Controls.Add(Me.MinimizeButton)
        Me.HeaderBar.Controls.Add(Me.MaximizeButton)
        Me.HeaderBar.Controls.Add(Me.ExitButton)
        Me.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.HeaderBar.Name = "HeaderBar"
        Me.HeaderBar.Size = New System.Drawing.Size(982, 44)
        Me.HeaderBar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 8, 0, 4)
        Me.Label1.Size = New System.Drawing.Size(246, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestion d'Inventaire"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Image = Global.RentalProject.My.Resources.Resources.baseline_minimize_black_18dp
        Me.MinimizeButton.Location = New System.Drawing.Point(811, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(57, 44)
        Me.MinimizeButton.TabIndex = 15
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'MaximizeButton
        '
        Me.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Image = Global.RentalProject.My.Resources.Resources.baseline_maximize_black_18dp
        Me.MaximizeButton.Location = New System.Drawing.Point(868, 0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(57, 44)
        Me.MaximizeButton.TabIndex = 16
        Me.MaximizeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Image = Global.RentalProject.My.Resources.Resources.baseline_clear_black_18dp
        Me.ExitButton.Location = New System.Drawing.Point(925, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(57, 44)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.SettingsButton)
        Me.MenuPanel.Controls.Add(Me.CloseButton)
        Me.MenuPanel.Controls.Add(Me.DashBoardButton)
        Me.MenuPanel.Controls.Add(Me.InventoryButton)
        Me.MenuPanel.Controls.Add(Me.RentalsButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 44)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(10)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(200, 542)
        Me.MenuPanel.TabIndex = 1
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SettingsButton.FlatAppearance.BorderSize = 2
        Me.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.Location = New System.Drawing.Point(0, 426)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(200, 58)
        Me.SettingsButton.TabIndex = 4
        Me.SettingsButton.Text = "Paramètres"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(0, 484)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(200, 58)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Quitter l'application"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'DashBoardButton
        '
        Me.DashBoardButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DashBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashBoardButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashBoardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DashBoardButton.FlatAppearance.BorderSize = 2
        Me.DashBoardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBoardButton.Location = New System.Drawing.Point(0, 116)
        Me.DashBoardButton.Name = "DashBoardButton"
        Me.DashBoardButton.Size = New System.Drawing.Size(200, 58)
        Me.DashBoardButton.TabIndex = 2
        Me.DashBoardButton.Text = "Panneau de contrôles"
        Me.DashBoardButton.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InventoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventoryButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.InventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.InventoryButton.FlatAppearance.BorderSize = 2
        Me.InventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.InventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.Location = New System.Drawing.Point(0, 58)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(200, 58)
        Me.InventoryButton.TabIndex = 1
        Me.InventoryButton.Text = "Inventaire"
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'RentalsButton
        '
        Me.RentalsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentalsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RentalsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RentalsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.RentalsButton.FlatAppearance.BorderSize = 2
        Me.RentalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RentalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentalsButton.Location = New System.Drawing.Point(0, 0)
        Me.RentalsButton.Name = "RentalsButton"
        Me.RentalsButton.Size = New System.Drawing.Size(200, 58)
        Me.RentalsButton.TabIndex = 0
        Me.RentalsButton.Text = "Emprunts"
        Me.RentalsButton.UseVisualStyleBackColor = False
        '
        'InterfacePanel
        '
        Me.InterfacePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.InterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InterfacePanel.Location = New System.Drawing.Point(200, 44)
        Me.InterfacePanel.Name = "InterfacePanel"
        Me.InterfacePanel.Size = New System.Drawing.Size(782, 542)
        Me.InterfacePanel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 586)
        Me.Controls.Add(Me.InterfacePanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.HeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.HeaderBar.ResumeLayout(False)
        Me.HeaderBar.PerformLayout()
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderBar As Panel
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents InterfacePanel As Panel
    Friend WithEvents SettingsButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents DashBoardButton As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents RentalsButton As Button
End Class
