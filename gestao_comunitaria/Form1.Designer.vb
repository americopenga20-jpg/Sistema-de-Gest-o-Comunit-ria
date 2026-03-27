<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNome = New TextBox()
        txtIdade = New TextBox()
        txtResidencia = New TextBox()
        cbGenero = New ComboBox()
        btnSalvar = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnCrianca = New Button()
        btnJovem = New Button()
        btnAdulto = New Button()
        btnIdoso = New Button()
        btnMostrarTodos = New Button()
        dgvMembros = New DataGridView()
        chkTemDoenca = New CheckBox()
        CType(dgvMembros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(47, 60)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(150, 31)
        txtNome.TabIndex = 0
        txtNome.Text = "Nome"
        ' 
        ' txtIdade
        ' 
        txtIdade.Location = New Point(208, 60)
        txtIdade.Name = "txtIdade"
        txtIdade.Size = New Size(150, 31)
        txtIdade.TabIndex = 0
        txtIdade.Text = "Idade"
        ' 
        ' txtResidencia
        ' 
        txtResidencia.Location = New Point(373, 60)
        txtResidencia.Name = "txtResidencia"
        txtResidencia.Size = New Size(150, 31)
        txtResidencia.TabIndex = 0
        txtResidencia.Text = "Residencia"
        ' 
        ' cbGenero
        ' 
        cbGenero.FormattingEnabled = True
        cbGenero.Items.AddRange(New Object() {"Homem", "Mulher", "Outro"})
        cbGenero.Location = New Point(47, 109)
        cbGenero.Name = "cbGenero"
        cbGenero.Size = New Size(182, 33)
        cbGenero.TabIndex = 1
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackColor = SystemColors.Highlight
        btnSalvar.Location = New Point(518, 113)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(112, 34)
        btnSalvar.TabIndex = 2
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Registo"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(47, 200)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 3
        TextBox2.Text = "Consulta"
        ' 
        ' btnCrianca
        ' 
        btnCrianca.Location = New Point(47, 253)
        btnCrianca.Name = "btnCrianca"
        btnCrianca.Size = New Size(112, 34)
        btnCrianca.TabIndex = 4
        btnCrianca.Text = "Crianças"
        btnCrianca.UseVisualStyleBackColor = True
        ' 
        ' btnJovem
        ' 
        btnJovem.Location = New Point(174, 253)
        btnJovem.Name = "btnJovem"
        btnJovem.Size = New Size(112, 34)
        btnJovem.TabIndex = 4
        btnJovem.Text = "Jovens"
        btnJovem.UseVisualStyleBackColor = True
        ' 
        ' btnAdulto
        ' 
        btnAdulto.Location = New Point(305, 253)
        btnAdulto.Name = "btnAdulto"
        btnAdulto.Size = New Size(112, 34)
        btnAdulto.TabIndex = 4
        btnAdulto.Text = "Adultos"
        btnAdulto.UseVisualStyleBackColor = True
        ' 
        ' btnIdoso
        ' 
        btnIdoso.Location = New Point(434, 253)
        btnIdoso.Name = "btnIdoso"
        btnIdoso.Size = New Size(112, 34)
        btnIdoso.TabIndex = 4
        btnIdoso.Text = "Idosos"
        btnIdoso.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarTodos
        ' 
        btnMostrarTodos.Location = New Point(47, 306)
        btnMostrarTodos.Name = "btnMostrarTodos"
        btnMostrarTodos.Size = New Size(112, 34)
        btnMostrarTodos.TabIndex = 4
        btnMostrarTodos.Text = "Mostrar Todos"
        btnMostrarTodos.UseVisualStyleBackColor = True
        ' 
        ' dgvMembros
        ' 
        dgvMembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembros.Location = New Point(601, 264)
        dgvMembros.Name = "dgvMembros"
        dgvMembros.RowHeadersWidth = 62
        dgvMembros.Size = New Size(360, 225)
        dgvMembros.TabIndex = 5
        ' 
        ' chkTemDoenca
        ' 
        chkTemDoenca.AutoSize = True
        chkTemDoenca.Location = New Point(252, 113)
        chkTemDoenca.Name = "chkTemDoenca"
        chkTemDoenca.Size = New Size(228, 29)
        chkTemDoenca.TabIndex = 6
        chkTemDoenca.Text = "Possui Doença Especial?"
        chkTemDoenca.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1099, 532)
        Controls.Add(chkTemDoenca)
        Controls.Add(dgvMembros)
        Controls.Add(btnMostrarTodos)
        Controls.Add(btnIdoso)
        Controls.Add(btnAdulto)
        Controls.Add(btnJovem)
        Controls.Add(btnCrianca)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnSalvar)
        Controls.Add(cbGenero)
        Controls.Add(txtResidencia)
        Controls.Add(txtIdade)
        Controls.Add(txtNome)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMembros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtResidencia As TextBox
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnCrianca As Button
    Friend WithEvents btnJovem As Button
    Friend WithEvents btnAdulto As Button
    Friend WithEvents btnIdoso As Button
    Friend WithEvents btnMostrarTodos As Button
    Friend WithEvents dgvMembros As DataGridView
    Friend WithEvents chkTemDoenca As CheckBox

End Class
