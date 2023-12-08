using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendaGEEK
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            splashGEEK spl = new splashGEEK();
            spl.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            spl.Close();
        }

        private void pbxSaida_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            FCliente cli = new FCliente();
            cli.Show();
        }

        private void pbxProduto_Click(object sender, EventArgs e)
        {
            FProduto pro = new FProduto();
            pro.Show();
        }

        private void pbxVenda_Click(object sender, EventArgs e)
        {
            Venda ven = new Venda();
            ven.Show();
        }
    }
}
