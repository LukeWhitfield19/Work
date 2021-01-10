<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.pBox = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.lblCurrentColour = New System.Windows.Forms.Label()
        Me.lblCursorColour = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBox
        '
        Me.pBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBox.Location = New System.Drawing.Point(12, 12)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(829, 688)
        Me.pBox.TabIndex = 0
        Me.pBox.TabStop = False
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(865, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(122, 61)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(865, 179)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 60)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Quit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClr.Location = New System.Drawing.Point(869, 437)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(118, 59)
        Me.btnClr.TabIndex = 3
        Me.btnClr.Text = "Pick Colour"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'lblCurrentColour
        '
        Me.lblCurrentColour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCurrentColour.Location = New System.Drawing.Point(893, 527)
        Me.lblCurrentColour.Name = "lblCurrentColour"
        Me.lblCurrentColour.Size = New System.Drawing.Size(61, 48)
        Me.lblCurrentColour.TabIndex = 4
        '
        'lblCursorColour
        '
        Me.lblCursorColour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCursorColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCursorColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCursorColour.Location = New System.Drawing.Point(893, 310)
        Me.lblCursorColour.Name = "lblCursorColour"
        Me.lblCursorColour.Size = New System.Drawing.Size(61, 48)
        Me.lblCursorColour.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(889, 585)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fill Colour"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(865, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 61)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 714)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCursorColour)
        Me.Controls.Add(Me.lblCurrentColour)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.pBox)
        Me.Name = "frmMain"
        Me.Text = "FloodFill"
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pBox As PictureBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents lblCurrentColour As Label
    Friend WithEvents lblCursorColour As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
End Class
