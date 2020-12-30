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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Checkmin = New System.Windows.Forms.CheckBox()
        Me.Checkmay = New System.Windows.Forms.CheckBox()
        Me.checknum = New System.Windows.Forms.CheckBox()
        Me.checkesp = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.checkesp)
        Me.GroupBox1.Controls.Add(Me.checknum)
        Me.GroupBox1.Controls.Add(Me.Checkmay)
        Me.GroupBox1.Controls.Add(Me.Checkmin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'Checkmin
        '
        Me.Checkmin.AutoSize = True
        Me.Checkmin.Location = New System.Drawing.Point(7, 20)
        Me.Checkmin.Name = "Checkmin"
        Me.Checkmin.Size = New System.Drawing.Size(58, 17)
        Me.Checkmin.TabIndex = 0
        Me.Checkmin.Text = "( a - z )"
        Me.Checkmin.UseVisualStyleBackColor = True
        '
        'Checkmay
        '
        Me.Checkmay.AutoSize = True
        Me.Checkmay.Location = New System.Drawing.Point(6, 43)
        Me.Checkmay.Name = "Checkmay"
        Me.Checkmay.Size = New System.Drawing.Size(61, 17)
        Me.Checkmay.TabIndex = 1
        Me.Checkmay.Text = "( A - Z )"
        Me.Checkmay.UseVisualStyleBackColor = True
        '
        'checknum
        '
        Me.checknum.AutoSize = True
        Me.checknum.Location = New System.Drawing.Point(6, 66)
        Me.checknum.Name = "checknum"
        Me.checknum.Size = New System.Drawing.Size(59, 17)
        Me.checknum.TabIndex = 2
        Me.checknum.Text = "( 0 - 9 )"
        Me.checknum.UseVisualStyleBackColor = True
        '
        'checkesp
        '
        Me.checkesp.AutoSize = True
        Me.checkesp.Location = New System.Drawing.Point(71, 20)
        Me.checkesp.Name = "checkesp"
        Me.checkesp.Size = New System.Drawing.Size(103, 17)
        Me.checkesp.TabIndex = 3
        Me.checkesp.Text = "Special Symbols"
        Me.checkesp.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(123, 65)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Length: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Generate!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(71, 42)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox6.TabIndex = 8
        Me.CheckBox6.Text = "Copy to Clipboard"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(271, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(296, 152)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Password Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkesp As CheckBox
    Friend WithEvents checknum As CheckBox
    Friend WithEvents Checkmay As CheckBox
    Friend WithEvents Checkmin As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
