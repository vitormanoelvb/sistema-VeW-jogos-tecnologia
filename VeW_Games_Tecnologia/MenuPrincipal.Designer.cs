namespace VeW_Games_Tecnologia
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btnGestaoProdutos = new Button();
            btnSairDoSistema = new Button();
            lblSistemaVeWJT = new Label();
            btnCreditos = new Button();
            SuspendLayout();
            // 
            // btnGestaoProdutos
            // 
            btnGestaoProdutos.Location = new Point(280, 120);
            btnGestaoProdutos.Name = "btnGestaoProdutos";
            btnGestaoProdutos.Size = new Size(259, 46);
            btnGestaoProdutos.TabIndex = 0;
            btnGestaoProdutos.Text = "Gestão Produtos";
            btnGestaoProdutos.UseVisualStyleBackColor = true;
            btnGestaoProdutos.Click += btnGestaoProdutos_Click;
            // 
            // btnSairDoSistema
            // 
            btnSairDoSistema.Location = new Point(280, 262);
            btnSairDoSistema.Name = "btnSairDoSistema";
            btnSairDoSistema.Size = new Size(259, 49);
            btnSairDoSistema.TabIndex = 1;
            btnSairDoSistema.Text = "Sair Do Sistema";
            btnSairDoSistema.UseVisualStyleBackColor = true;
            btnSairDoSistema.Click += btnSairDoSistema_Click;
            // 
            // lblSistemaVeWJT
            // 
            lblSistemaVeWJT.AutoSize = true;
            lblSistemaVeWJT.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSistemaVeWJT.ForeColor = SystemColors.MenuHighlight;
            lblSistemaVeWJT.Location = new Point(163, 43);
            lblSistemaVeWJT.Name = "lblSistemaVeWJT";
            lblSistemaVeWJT.Size = new Size(533, 54);
            lblSistemaVeWJT.TabIndex = 2;
            lblSistemaVeWJT.Text = "Sistema V e W - Jogos Tech";
            // 
            // btnCreditos
            // 
            btnCreditos.Location = new Point(280, 191);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(259, 43);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "Créditos do Sistema";
            btnCreditos.UseVisualStyleBackColor = true;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundoMenuPrincipal;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreditos);
            Controls.Add(lblSistemaVeWJT);
            Controls.Add(btnSairDoSistema);
            Controls.Add(btnGestaoProdutos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestaoProdutos;
        private Button btnSairDoSistema;
        private Label lblSistemaVeWJT;
        private Button btnCreditos;
    }
}