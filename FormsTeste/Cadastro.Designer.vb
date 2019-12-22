<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageCadastro = New System.Windows.Forms.TabPage()
        Me.lblConfirmar = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.linkClique = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxNovidades = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.btnMostrarSenha = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.tabPageTermos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtTermos = New System.Windows.Forms.TextBox()
        Me.ControleTempo1 = New FormsTeste.ControleTempo()
        Me.TabControl1.SuspendLayout()
        Me.tabPageCadastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabPageTermos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPageCadastro)
        Me.TabControl1.Controls.Add(Me.tabPageTermos)
        Me.TabControl1.Location = New System.Drawing.Point(6, -4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(788, 458)
        Me.TabControl1.TabIndex = 27
        '
        'tabPageCadastro
        '
        Me.tabPageCadastro.Controls.Add(Me.ControleTempo1)
        Me.tabPageCadastro.Controls.Add(Me.lblConfirmar)
        Me.tabPageCadastro.Controls.Add(Me.DateTimePicker1)
        Me.tabPageCadastro.Controls.Add(Me.linkClique)
        Me.tabPageCadastro.Controls.Add(Me.Label9)
        Me.tabPageCadastro.Controls.Add(Me.Label3)
        Me.tabPageCadastro.Controls.Add(Me.Label1)
        Me.tabPageCadastro.Controls.Add(Me.cboxNovidades)
        Me.tabPageCadastro.Controls.Add(Me.btnRegistrar)
        Me.tabPageCadastro.Controls.Add(Me.TextBox2)
        Me.tabPageCadastro.Controls.Add(Me.Label7)
        Me.tabPageCadastro.Controls.Add(Me.TextBox1)
        Me.tabPageCadastro.Controls.Add(Me.txtConfirmar)
        Me.tabPageCadastro.Controls.Add(Me.MaskedTextBox2)
        Me.tabPageCadastro.Controls.Add(Me.btnMostrarSenha)
        Me.tabPageCadastro.Controls.Add(Me.txtSenha)
        Me.tabPageCadastro.Controls.Add(Me.Label8)
        Me.tabPageCadastro.Controls.Add(Me.Label5)
        Me.tabPageCadastro.Controls.Add(Me.Label2)
        Me.tabPageCadastro.Controls.Add(Me.Label4)
        Me.tabPageCadastro.Controls.Add(Me.GroupBox1)
        Me.tabPageCadastro.Controls.Add(Me.Label6)
        Me.tabPageCadastro.Controls.Add(Me.MaskedTextBox1)
        Me.tabPageCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCadastro.Name = "tabPageCadastro"
        Me.tabPageCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCadastro.Size = New System.Drawing.Size(780, 432)
        Me.tabPageCadastro.TabIndex = 0
        Me.tabPageCadastro.Text = "Cadastro"
        Me.tabPageCadastro.UseVisualStyleBackColor = True
        '
        'lblConfirmar
        '
        Me.lblConfirmar.AutoSize = True
        Me.lblConfirmar.Location = New System.Drawing.Point(163, 359)
        Me.lblConfirmar.Name = "lblConfirmar"
        Me.lblConfirmar.Size = New System.Drawing.Size(0, 13)
        Me.lblConfirmar.TabIndex = 26
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 113)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(231, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'linkClique
        '
        Me.linkClique.AutoSize = True
        Me.linkClique.LinkArea = New System.Windows.Forms.LinkArea(23, 25)
        Me.linkClique.Location = New System.Drawing.Point(28, 390)
        Me.linkClique.Name = "linkClique"
        Me.linkClique.Size = New System.Drawing.Size(184, 17)
        Me.linkClique.TabIndex = 21
        Me.linkClique.TabStop = True
        Me.linkClique.Text = "Para mais informações: Clique Aqui"
        Me.linkClique.UseCompatibleTextRendering = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Deseja receber novidades?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nascimento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(257, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro Cliente"
        '
        'cboxNovidades
        '
        Me.cboxNovidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxNovidades.FormattingEnabled = True
        Me.cboxNovidades.Location = New System.Drawing.Point(633, 197)
        Me.cboxNovidades.Name = "cboxNovidades"
        Me.cboxNovidades.Size = New System.Drawing.Size(97, 21)
        Me.cboxNovidades.TabIndex = 24
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.Location = New System.Drawing.Point(296, 378)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(135, 29)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(146, 202)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(231, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Telefone:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(143, 324)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.Size = New System.Drawing.Size(234, 20)
        Me.txtConfirmar.TabIndex = 14
        Me.txtConfirmar.UseSystemPasswordChar = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(146, 240)
        Me.MaskedTextBox2.Mask = "(99) 00000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(234, 20)
        Me.MaskedTextBox2.TabIndex = 19
        '
        'btnMostrarSenha
        '
        Me.btnMostrarSenha.Location = New System.Drawing.Point(402, 284)
        Me.btnMostrarSenha.Name = "btnMostrarSenha"
        Me.btnMostrarSenha.Size = New System.Drawing.Size(29, 24)
        Me.btnMostrarSenha.TabIndex = 10
        Me.btnMostrarSenha.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(143, 284)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(234, 20)
        Me.txtSenha.TabIndex = 13
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "e-Mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Confirmar Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Senha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(529, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 72)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Feminino"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Masculino"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CPF:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(146, 160)
        Me.MaskedTextBox1.Mask = "000.000.000.00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(231, 20)
        Me.MaskedTextBox1.TabIndex = 17
        '
        'tabPageTermos
        '
        Me.tabPageTermos.Controls.Add(Me.Panel1)
        Me.tabPageTermos.Location = New System.Drawing.Point(4, 22)
        Me.tabPageTermos.Name = "tabPageTermos"
        Me.tabPageTermos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageTermos.Size = New System.Drawing.Size(780, 432)
        Me.tabPageTermos.TabIndex = 1
        Me.tabPageTermos.Text = "Termos de Privacidade"
        Me.tabPageTermos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.txtTermos)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 414)
        Me.Panel1.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox1.Location = New System.Drawing.Point(76, 962)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(208, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Eu li e aceito os termos de privacidade"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtTermos
        '
        Me.txtTermos.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.txtTermos.Location = New System.Drawing.Point(-3, 3)
        Me.txtTermos.Multiline = True
        Me.txtTermos.Name = "txtTermos"
        Me.txtTermos.ReadOnly = True
        Me.txtTermos.Size = New System.Drawing.Size(743, 982)
        Me.txtTermos.TabIndex = 7
        '
        'ControleTempo1
        '
        Me.ControleTempo1.Location = New System.Drawing.Point(537, 365)
        Me.ControleTempo1.Name = "ControleTempo1"
        Me.ControleTempo1.Size = New System.Drawing.Size(237, 61)
        Me.ControleTempo1.TabIndex = 27
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Cadastro"
        Me.Text = "Cadastro"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPageCadastro.ResumeLayout(False)
        Me.tabPageCadastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabPageTermos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPageCadastro As TabPage
    Friend WithEvents lblConfirmar As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents linkClique As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxNovidades As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents btnMostrarSenha As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents tabPageTermos As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ControleTempo1 As ControleTempo
    Friend WithEvents txtTermos As TextBox
End Class
