<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNome = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAdiciona = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnElse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.lstDados = New System.Windows.Forms.ListBox()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(27, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Coloque o seu nome."
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.Tag = ""
        '
        'btnNome
        '
        Me.btnNome.Location = New System.Drawing.Point(12, 246)
        Me.btnNome.Name = "btnNome"
        Me.btnNome.Size = New System.Drawing.Size(238, 69)
        Me.btnNome.TabIndex = 2
        Me.btnNome.Text = "&OK"
        Me.btnNome.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(521, 246)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(238, 69)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "S&air"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAdiciona
        '
        Me.btnAdiciona.Location = New System.Drawing.Point(12, 208)
        Me.btnAdiciona.Name = "btnAdiciona"
        Me.btnAdiciona.Size = New System.Drawing.Size(95, 32)
        Me.btnAdiciona.TabIndex = 4
        Me.btnAdiciona.Text = "Adicionar 1"
        Me.btnAdiciona.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mostra Variáveis"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnElse
        '
        Me.btnElse.Location = New System.Drawing.Point(637, 321)
        Me.btnElse.Name = "btnElse"
        Me.btnElse.Size = New System.Drawing.Size(121, 26)
        Me.btnElse.TabIndex = 6
        Me.btnElse.Text = "Botão Condicional"
        Me.btnElse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Escreva um número p/comparar"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(364, 30)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(81, 23)
        Me.txtNum1.TabIndex = 8
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(176, 27)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(121, 26)
        Me.btnComparar.TabIndex = 9
        Me.btnComparar.Text = "Botão Comparar"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'btnVerifica
        '
        Me.btnVerifica.Location = New System.Drawing.Point(499, 25)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(121, 30)
        Me.btnVerifica.TabIndex = 10
        Me.btnVerifica.Text = "Verifica Número"
        Me.btnVerifica.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(642, 180)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(117, 28)
        Me.btnFor.TabIndex = 11
        Me.btnFor.Text = "Laço Lista"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'lstDados
        '
        Me.lstDados.FormattingEnabled = True
        Me.lstDados.ItemHeight = 15
        Me.lstDados.Location = New System.Drawing.Point(645, 73)
        Me.lstDados.Name = "lstDados"
        Me.lstDados.Size = New System.Drawing.Size(113, 94)
        Me.lstDados.TabIndex = 12
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(642, 42)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(117, 25)
        Me.btnWhile.TabIndex = 13
        Me.btnWhile.Text = "Do While Lista"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.lstDados)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnVerifica)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnElse)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdiciona)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnNome)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Tag = ""
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnNome As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnAdiciona As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnElse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents btnComparar As Button
    Friend WithEvents btnVerifica As Button
    Friend WithEvents btnFor As Button
    Friend WithEvents lstBox As ListBox
    Friend WithEvents lstDados As ListBox
    Friend WithEvents btnWhile As Button
End Class
