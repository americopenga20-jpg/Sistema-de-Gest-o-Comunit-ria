Imports MySql.Data.MySqlClient

Public Class Form1
    Dim strConn As String = "server=localhost;database=gestao_comunitaria;uid=root;pwd=;"
    Dim conexao As New MySqlConnection(strConn)

    ' --- 1. CARREGAR DADOS ---
    Public Sub CarregarDados(Optional filtro As String = "")
        Try
            If conexao.State = ConnectionState.Closed Then conexao.Open()
            Dim sql As String = "SELECT * FROM membros"
            If filtro <> "" Then sql &= " WHERE " & filtro

            Dim da As New MySqlDataAdapter(sql, conexao)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvMembros.DataSource = dt
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message)
            If conexao.State = ConnectionState.Open Then conexao.Close()
        End Try
    End Sub

    ' --- 2. BOTÃO SALVAR ---
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If txtNome.Text = "" Or txtIdade.Text = "" Then
                MsgBox("Preencha Nome e Idade!")
                Exit Sub
            End If

            ' --- PARTE COMENTADA (DESATIVADA) ---
            ' Dim statusDoenca As String = If(chkTemDoenca.Checked, "Sim", "Não")
            ' ------------------------------------

            If conexao.State = ConnectionState.Closed Then conexao.Open()

            ' Removi a coluna doenca do INSERT para não bugar
            Dim sql As String = "INSERT INTO `membros` (`nome`, `idade`, `residencia`, `genero`) " &
                               "VALUES (@nome, @idade, @res, @gen)"

            Dim cmd As New MySqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@idade", txtIdade.Text)
            cmd.Parameters.AddWithValue("@res", txtResidencia.Text)
            cmd.Parameters.AddWithValue("@gen", cbGenero.Text)

            ' cmd.Parameters.AddWithValue("@doenca", statusDoenca) ' Comentado para evitar erro

            cmd.ExecuteNonQuery()
            MsgBox("Registado com sucesso!")

            ' Limpar
            txtNome.Clear()
            txtIdade.Clear()
            txtResidencia.Clear()
            ' chkTemDoenca.Checked = False ' Comentado

            conexao.Close()
            CarregarDados()
        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message)
            If conexao.State = ConnectionState.Open Then conexao.Close()
        End Try
    End Sub

    ' --- FILTROS ---
    Private Sub btnCrianca_Click(sender As Object, e As EventArgs) Handles btnCrianca.Click
        CarregarDados("idade <= 13")
    End Sub

    Private Sub btnJovem_Click(sender As Object, e As EventArgs) Handles btnJovem.Click
        CarregarDados("idade > 13 AND idade <= 18")
    End Sub

    Private Sub btnAdulto_Click(sender As Object, e As EventArgs) Handles btnAdulto.Click
        CarregarDados("idade > 18 AND idade <= 60")
    End Sub

    Private Sub btnIdoso_Click(sender As Object, e As EventArgs) Handles btnIdoso.Click
        CarregarDados("idade > 60")
    End Sub

    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btnMostrarTodos.Click
        CarregarDados()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
    End Sub
End Class