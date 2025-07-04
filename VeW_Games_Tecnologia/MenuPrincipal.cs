using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeW_Games_Tecnologia
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestaoProdutos_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde o MenuPrincipal
            Form1 frm = new Form1();
            frm.FormClosed += (s, args) => this.Show(); // volta ao menu ao fechar
            frm.Show();
        }

        private void btnSairDoSistema_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde o MenuPrincipal
            Creditos frm = new Creditos();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
