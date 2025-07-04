namespace VeW_Games_Tecnologia
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private ComboBox cmbPlataforma;
        private ComboBox cmbGenero;
        private TextBox txtClassificacao;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private CheckBox chkAtivo;
        private ComboBox cmbCategoria;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnConsultaRapida;
        private Button btnLimparConsulta;
        private Button btnMostrarApagados;
        private Button btnRestaurar;
        private Button btnVoltarMenuPrincipal;
        private DataGridView dgvProdutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            cmbPlataforma = new ComboBox();
            cmbGenero = new ComboBox();
            txtClassificacao = new TextBox();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            chkAtivo = new CheckBox();
            cmbCategoria = new ComboBox();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnConsultaRapida = new Button();
            btnLimparConsulta = new Button();
            btnMostrarApagados = new Button();
            btnRestaurar = new Button();
            btnVoltarMenuPrincipal = new Button();
            dgvProdutos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();

            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 90);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Produto";
            txtNome.Size = new Size(344, 23);
            txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(387, 90);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(366, 23);
            txtDescricao.TabIndex = 1;
            // 
            // cmbPlataforma
            // 
            cmbPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlataforma.Location = new Point(21, 143);
            cmbPlataforma.Name = "cmbPlataforma";
            cmbPlataforma.Size = new Size(273, 23);
            cmbPlataforma.TabIndex = 2;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Location = new Point(468, 143);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(285, 23);
            cmbGenero.TabIndex = 3;
            // 
            // txtClassificacao
            // 
            txtClassificacao.Location = new Point(21, 198);
            txtClassificacao.Name = "txtClassificacao";
            txtClassificacao.PlaceholderText = "Classificação Etária";
            txtClassificacao.Size = new Size(161, 23);
            txtClassificacao.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(208, 198);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(125, 23);
            txtPreco.TabIndex = 5;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(374, 198);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Quantidade";
            txtEstoque.Size = new Size(145, 23);
            txtEstoque.TabIndex = 6;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(316, 147);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 7;
            chkAtivo.Text = "Ativo";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new Point(558, 198);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(313, 23);
            cmbCategoria.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(21, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por Nome";
            txtPesquisa.Size = new Size(635, 23);
            txtPesquisa.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(662, 37);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(80, 30);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(759, 37);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 30);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(759, 87);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 30);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(759, 141);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnConsultaRapida
            // 
            btnConsultaRapida.Location = new Point(886, 34);
            btnConsultaRapida.Name = "btnConsultaRapida";
            btnConsultaRapida.Size = new Size(233, 30);
            btnConsultaRapida.TabIndex = 14;
            btnConsultaRapida.Text = "Consulta Rápida";
            btnConsultaRapida.Click += btnConsultaRapida_Click;
            // 
            // btnLimparConsulta
            // 
            btnLimparConsulta.Location = new Point(886, 87);
            btnLimparConsulta.Name = "btnLimparConsulta";
            btnLimparConsulta.Size = new Size(233, 30);
            btnLimparConsulta.TabIndex = 15;
            btnLimparConsulta.Text = "Limpar Consulta";
            btnLimparConsulta.Click += btnLimparConsulta_Click;
            // 
            // btnMostrarApagados
            // 
            btnMostrarApagados.Location = new Point(886, 141);
            btnMostrarApagados.Name = "btnMostrarApagados";
            btnMostrarApagados.Size = new Size(233, 30);
            btnMostrarApagados.TabIndex = 16;
            btnMostrarApagados.Text = "Mostrar Apagados";
            btnMostrarApagados.Click += btnMostrarApagados_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(886, 196);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(233, 30);
            btnRestaurar.TabIndex = 17;
            btnRestaurar.Text = "Restaurar Selecionados";
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnVoltarMenuPrincipal
            // 
            btnVoltarMenuPrincipal.Location = new Point(17, 596);
            btnVoltarMenuPrincipal.Name = "btnVoltarMenuPrincipal";
            btnVoltarMenuPrincipal.Size = new Size(198, 29);
            btnVoltarMenuPrincipal.TabIndex = 18;
            btnVoltarMenuPrincipal.Text = "Voltar ao Menu Principal";
            btnVoltarMenuPrincipal.Click += btnVoltarMenuPrincipal_Click_2;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeight = 29;
            dgvProdutos.Location = new Point(21, 260);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1148, 297);
            dgvProdutos.TabIndex = 19;
            dgvProdutos.CellClick += dgvProdutos_CellContentClick;
            // 
            // Labels
            // 
            label1.AutoSize = true; label1.Location = new Point(21, 67); label1.Text = "Nome do produto";
            label2.AutoSize = true; label2.Location = new Point(21, 9); label2.Text = "Realizar busca";
            label3.AutoSize = true; label3.Location = new Point(387, 67); label3.Text = "Descrição";
            label10.AutoSize = true; label10.Location = new Point(21, 125); label10.Text = "Plataforma";
            label4.AutoSize = true; label4.Location = new Point(21, 180); label4.Text = "Classificação Etária";
            label6.AutoSize = true; label6.Location = new Point(208, 174); label6.Text = "Preço";
            label7.AutoSize = true; label7.Location = new Point(374, 174); label7.Text = "Estoque";
            label8.AutoSize = true; label8.Location = new Point(468, 120); label8.Text = "Gênero";
            label9.AutoSize = true; label9.Location = new Point(558, 174); label9.Text = "Categoria";
            label5.AutoSize = true; label5.Location = new Point(21, 237); label5.Text = "Resultado do Procedimento";

            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1207, 634);
            Controls.AddRange(new Control[] {
                txtNome, txtDescricao, cmbPlataforma, cmbGenero,
                txtClassificacao, txtPreco, txtEstoque, chkAtivo, cmbCategoria,
                txtPesquisa, btnPesquisar, btnSalvar, btnEditar, btnExcluir,
                btnConsultaRapida, btnLimparConsulta, btnMostrarApagados, btnRestaurar,
                btnVoltarMenuPrincipal, dgvProdutos,
                label1, label2, label3, label10, label4, label6, label7, label8, label9, label5
            });
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestão de Produtos – VeW_Jogos_Tech";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
