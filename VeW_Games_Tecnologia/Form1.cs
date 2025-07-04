#nullable enable
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VeW_Games_Tecnologia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            // Removido: FormClosed += Form1_FormClosed;
            CarregarProdutos();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbPlataforma.Items.AddRange(new object[] {
                "PlayStation 5","PlayStation 4","Xbox Series X","Xbox One","Nintendo Switch",
                "PC (Windows)","Steam Deck","Android","iOS","VR (Realidade Virtual)"
            });
            cmbGenero.Items.AddRange(new object[] {
                "Ação","Aventura","RPG","Simulação","Esportes",
                "Corrida","Terror","Puzzle","FPS","Multiplayer Online"
            });
            cmbCategoria.Items.AddRange(new object[] {
                "Jogo Físico","Jogo Digital","Console","Controle","Headset",
                "Cabo e Acessórios","Gift Card","Cadeira Gamer","Mouse Gamer","Teclado Mecânico"
            });
        }

        private void CarregarProdutos()
        {
            using var conexao = Conexao.ObterConexao();
            using var cmd = new MySqlCommand("SELECT * FROM produtos WHERE ativo = TRUE", conexao);
            using var adapter = new MySqlDataAdapter(cmd);
            var tabela = new DataTable();
            adapter.Fill(tabela);
            dgvProdutos.DataSource = tabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using var conexao = Conexao.ObterConexao();
            using var cmd = new MySqlCommand(
                "SELECT * FROM produtos WHERE nome LIKE @nome AND ativo = TRUE", conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + txtPesquisa.Text + "%");
            using var adapter = new MySqlDataAdapter(cmd);
            var tabela = new DataTable();
            adapter.Fill(tabela);
            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvProdutos.DataSource = tabela;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProdutos.Rows[e.RowIndex];
            txtNome.Text = row.Cells["nome"].Value?.ToString() ?? "";
            txtDescricao.Text = row.Cells["descricao"].Value?.ToString() ?? "";
            cmbPlataforma.Text = row.Cells["plataforma"].Value?.ToString() ?? "";
            cmbGenero.Text = row.Cells["genero"].Value?.ToString() ?? "";
            txtClassificacao.Text = row.Cells["classificacao_etaria"].Value?.ToString() ?? "";
            txtPreco.Text = row.Cells["preco"].Value?.ToString() ?? "";
            txtEstoque.Text = row.Cells["estoque"].Value?.ToString() ?? "";
            chkAtivo.Checked = Convert.ToBoolean(row.Cells["ativo"].Value);
            cmbCategoria.Text = row.Cells["categoria"].Value?.ToString() ?? "";
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um produto para restaurar.", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using var conexao = Conexao.ObterConexao();
            foreach (DataGridViewRow row in dgvProdutos.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                using var cmd = new MySqlCommand("UPDATE produtos SET ativo = TRUE WHERE id = @id", conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            ReorganizarIDs();
            CarregarProdutos();
            MessageBox.Show("Produto(s) restaurado(s) com sucesso!", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                cmbPlataforma.SelectedIndex < 0 ||
                cmbGenero.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtClassificacao.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtEstoque.Text) ||
                cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var precoRaw = txtPreco.Text.Replace("R$", "").Trim();
            if (!decimal.TryParse(precoRaw, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.GetCultureInfo("pt-BR"), out var preco))
            {
                MessageBox.Show("Preço inválido. Digite apenas números (ex: 149,90).", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtEstoque.Text.Trim(), out var estoque))
            {
                MessageBox.Show("Estoque inválido. Digite apenas números inteiros.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conexao = Conexao.ObterConexao();
                using var cmd = new MySqlCommand(
                    @"INSERT INTO produtos
                      (nome, descricao, plataforma, genero, classificacao_etaria, preco, estoque, ativo, categoria)
                      VALUES
                      (@nome,@descricao,@plataforma,@genero,@classificacao,@preco,@estoque,@ativo,@categoria)", conexao);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@plataforma", cmbPlataforma.Text);
                cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
                cmd.Parameters.AddWithValue("@classificacao", txtClassificacao.Text);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@estoque", estoque);
                cmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);

                var linhas = cmd.ExecuteNonQuery();
                if (linhas > 0)
                {
                    ReorganizarIDs();
                    CarregarProdutos();
                    LimparCampos();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto antes de excluir.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Deseja mesmo excluir este produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            if (MessageBox.Show("Tem certeza absoluta? Esta ação é reversível marcando como ativo.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var cell = dgvProdutos.SelectedRows[0].Cells["id"].Value;
            if (cell == null || !int.TryParse(cell.ToString(), out int id))
            {
                MessageBox.Show("ID do produto inválido.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conexao = Conexao.ObterConexao();
                using var cmd = new MySqlCommand("UPDATE produtos SET ativo = FALSE WHERE id = @id", conexao);
                cmd.Parameters.AddWithValue("@id", id);
                var afetadas = cmd.ExecuteNonQuery();

                if (afetadas > 0)
                {
                    ReorganizarIDs();
                    CarregarProdutos();
                    MessageBox.Show("Produto marcado como excluído!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi excluído.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarApagados_Click(object sender, EventArgs e)
        {
            using var conexao = Conexao.ObterConexao();
            using var cmd = new MySqlCommand("SELECT * FROM produtos WHERE ativo = FALSE", conexao);
            using var adapter = new MySqlDataAdapter(cmd);
            var tabela = new DataTable();
            adapter.Fill(tabela);

            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Não há produtos excluídos.", "Mostrar Apagados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvProdutos.DataSource = tabela;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto antes de editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["id"].Value);
            var precoRaw = txtPreco.Text.Replace("R$", "").Trim();
            if (!decimal.TryParse(precoRaw, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.GetCultureInfo("pt-BR"), out var preco))
            {
                MessageBox.Show("Preço inválido.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtEstoque.Text.Trim(), out var estoque))
            {
                MessageBox.Show("Estoque inválido.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conexao = Conexao.ObterConexao();
                using var cmd = new MySqlCommand(
                    @"UPDATE produtos SET
                      nome=@nome, descricao=@descricao, plataforma=@plataforma, genero=@genero,
                      classificacao_etaria=@classificacao, preco=@preco, estoque=@estoque,
                      ativo=@ativo, categoria=@categoria
                      WHERE id=@id", conexao);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@plataforma", cmbPlataforma.Text);
                cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
                cmd.Parameters.AddWithValue("@classificacao", txtClassificacao.Text);
                cmd.Parameters.AddWithValue("@preco", preco);
                cmd.Parameters.AddWithValue("@estoque", estoque);
                cmd.Parameters.AddWithValue("@ativo", chkAtivo.Checked);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);

                cmd.ExecuteNonQuery();
                CarregarProdutos();
                MessageBox.Show("Produto atualizado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparConsulta_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarProdutos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtClassificacao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            chkAtivo.Checked = false;
            txtPesquisa.Clear();
            cmbPlataforma.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnConsultaRapida_Click(object sender, EventArgs e) => ExecutarConsultaRapida();

        private void ExecutarConsultaRapida()
        {
            using var conexao = Conexao.ObterConexao();
            string query = "SELECT * FROM produtos WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(cmbPlataforma.Text)) query += " AND plataforma=@plataforma";
            if (!string.IsNullOrWhiteSpace(cmbGenero.Text)) query += " AND genero=@genero";
            if (!string.IsNullOrWhiteSpace(cmbCategoria.Text)) query += " AND categoria=@categoria";

            using var cmd = new MySqlCommand(query, conexao);
            if (!string.IsNullOrWhiteSpace(cmbPlataforma.Text)) cmd.Parameters.AddWithValue("@plataforma", cmbPlataforma.Text);
            if (!string.IsNullOrWhiteSpace(cmbGenero.Text)) cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
            if (!string.IsNullOrWhiteSpace(cmbCategoria.Text)) cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);

            using var adapter = new MySqlDataAdapter(cmd);
            var tabela = new DataTable();
            adapter.Fill(tabela);
            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado.", "Consulta Rápida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvProdutos.DataSource = tabela;
            var row = tabela.Rows[0];
            txtNome.Text = row["nome"].ToString();
            txtDescricao.Text = row["descricao"].ToString();
            cmbPlataforma.Text = row["plataforma"].ToString();
            cmbGenero.Text = row["genero"].ToString();
            txtClassificacao.Text = row["classificacao_etaria"].ToString();
            txtPreco.Text = row["preco"].ToString();
            txtEstoque.Text = row["estoque"].ToString();
            chkAtivo.Checked = Convert.ToBoolean(row["ativo"]);
            cmbCategoria.Text = row["categoria"].ToString();
        }

        private void btnVoltarMenuPrincipal_Click_2(object sender, EventArgs e)
        {
            // Agora apenas esconde este form, sem encerrar a aplicação
            this.Hide();
            var menu = new MenuPrincipal();
            menu.Show();
        }

        private void ReorganizarIDs()
        {
            using var conexao = Conexao.ObterConexao();
            using (var cmd = new MySqlCommand("SET @n := 0;", conexao)) cmd.ExecuteNonQuery();
            using (var cmd = new MySqlCommand("UPDATE produtos SET id = (@n := @n + 1) ORDER BY id;", conexao)) cmd.ExecuteNonQuery();
            try
            {
                using var cmd = new MySqlCommand("ALTER TABLE produtos AUTO_INCREMENT = 1;", conexao);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
            }
        }
    }
}
