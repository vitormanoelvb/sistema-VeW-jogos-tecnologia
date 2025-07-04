namespace VeW_Games_Tecnologia
{
    partial class Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creditos));
            btnVoltarMenuPrincipal = new Button();
            lblVitor = new Label();
            lblCreditos = new Label();
            lblGitHubVitor = new LinkLabel();
            lblGitVitor = new Label();
            lblWauclidson = new Label();
            linkGitWauclidson = new LinkLabel();
            lblGitHubWaudson = new Label();
            SuspendLayout();
            // 
            // btnVoltarMenuPrincipal
            // 
            btnVoltarMenuPrincipal.Location = new Point(12, 409);
            btnVoltarMenuPrincipal.Name = "btnVoltarMenuPrincipal";
            btnVoltarMenuPrincipal.Size = new Size(186, 29);
            btnVoltarMenuPrincipal.TabIndex = 0;
            btnVoltarMenuPrincipal.Text = "Voltar ao Menu Principal";
            btnVoltarMenuPrincipal.UseVisualStyleBackColor = true;
            btnVoltarMenuPrincipal.Click += btnVoltarMenuPrincipal_Click;
            // 
            // lblVitor
            // 
            lblVitor.AutoSize = true;
            lblVitor.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitor.Location = new Point(193, 96);
            lblVitor.Name = "lblVitor";
            lblVitor.Size = new Size(462, 54);
            lblVitor.TabIndex = 1;
            lblVitor.Text = "Vitor Manoel Vidal Braz";
            // 
            // lblCreditos
            // 
            lblCreditos.AutoSize = true;
            lblCreditos.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreditos.Location = new Point(317, 38);
            lblCreditos.Name = "lblCreditos";
            lblCreditos.Size = new Size(179, 47);
            lblCreditos.TabIndex = 3;
            lblCreditos.Text = "CÉDITOS";
            // 
            // lblGitHubVitor
            // 
            lblGitHubVitor.AutoSize = true;
            lblGitHubVitor.Location = new Point(298, 183);
            lblGitHubVitor.Name = "lblGitHubVitor";
            lblGitHubVitor.Size = new Size(234, 20);
            lblGitHubVitor.TabIndex = 5;
            lblGitHubVitor.TabStop = true;
            lblGitHubVitor.Text = "https://github.com/vitormanoelvb";
            lblGitHubVitor.LinkClicked += lblGitHubVitor_LinkClicked;
            // 
            // lblGitVitor
            // 
            lblGitVitor.AutoSize = true;
            lblGitVitor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGitVitor.Location = new Point(317, 163);
            lblGitVitor.Name = "lblGitVitor";
            lblGitVitor.Size = new Size(196, 20);
            lblGitVitor.TabIndex = 6;
            lblGitVitor.Text = "GITHUB - VITOR MANOEL:\r\n";
            // 
            // lblWauclidson
            // 
            lblWauclidson.AutoSize = true;
            lblWauclidson.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWauclidson.Location = new Point(204, 212);
            lblWauclidson.Name = "lblWauclidson";
            lblWauclidson.Size = new Size(439, 54);
            lblWauclidson.TabIndex = 7;
            lblWauclidson.Text = "Wauclidson Alves Dias";
            // 
            // linkGitWauclidson
            // 
            linkGitWauclidson.AutoSize = true;
            linkGitWauclidson.Location = new Point(281, 296);
            linkGitWauclidson.Name = "linkGitWauclidson";
            linkGitWauclidson.Size = new Size(232, 20);
            linkGitWauclidson.TabIndex = 8;
            linkGitWauclidson.TabStop = true;
            linkGitWauclidson.Text = "https://github.com/WAUCLIDSON\r\n";
            linkGitWauclidson.LinkClicked += linkGitWauclidson_LinkClicked;
            // 
            // lblGitHubWaudson
            // 
            lblGitHubWaudson.AutoSize = true;
            lblGitHubWaudson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGitHubWaudson.Location = new Point(298, 276);
            lblGitHubWaudson.Name = "lblGitHubWaudson";
            lblGitHubWaudson.Size = new Size(184, 20);
            lblGitHubWaudson.TabIndex = 9;
            lblGitHubWaudson.Text = "GITHUB - WAUCLIDSON:\r\n";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblGitHubWaudson);
            Controls.Add(linkGitWauclidson);
            Controls.Add(lblWauclidson);
            Controls.Add(lblGitVitor);
            Controls.Add(lblGitHubVitor);
            Controls.Add(lblCreditos);
            Controls.Add(lblVitor);
            Controls.Add(btnVoltarMenuPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Creditos";
            Text = "Creditos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltarMenuPrincipal;
        private Label lblVitor;
        private Label lblCreditos;
        private LinkLabel lblGitHubVitor;
        private Label lblGitVitor;
        private Label lblWauclidson;
        private LinkLabel linkGitWauclidson;
        private Label lblGitHubWaudson;
    }
}