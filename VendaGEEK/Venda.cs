using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendaGEEK
{
    public partial class Venda : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Aluno\\Downloads\\AppBoteco-17-do-11-master\\AppBoteco\\DbBoteco.mdf;Integrated Security = True");
        public Venda()
        {
            InitializeComponent();
            CarregaCbxCliente();
            CarregaCbxProduto();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CarregaCbxCliente()
        {
            string cli = "SELECT Id, nome FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        public void CarregaCbxProduto()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string pro = "SELECT Id, nome FROM Produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            cbxCliente.Enabled = false;
            cbxProduto.Enabled = false;
            txtID.Enabled = false;
            txtIDProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtTotal.Enabled = false;
            txtValor.Enabled = false;
            btnAPedido.Enabled = false;
            btnFPedido.Enabled = false;
            btnFVenda.Enabled = false;
            btnNoItem.Enabled = false;
            btnEdItem.Enabled = false;
            btnExItem.Enabled = false;
        }

        private void btnNPedido_Click(object sender, EventArgs e)
        {
            cbxCliente.Enabled = true;
            cbxProduto.Enabled = true;
            txtID.Enabled = true;
            txtIDProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtTotal.Enabled = true;
            txtValor.Enabled = true;
            btnAPedido.Enabled = true;
            btnFPedido.Enabled = true;
            btnFVenda.Enabled = true;
            btnNoItem.Enabled = true;
            btnEdItem.Enabled = true;
            btnExItem.Enabled = true;
            dgvV.Columns.Add("ID", "ID");
            dgvV.Columns.Add("Produto", "Produto");
            dgvV.Columns.Add("Quantidade", "Quantidade");
            dgvV.Columns.Add("Valor", "Valor");
            dgvV.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtValor.Text = dr["preco"].ToString();
                txtIDProduto.Text = dr["Id"].ToString();
                lblEstoque.Text = dr["quantidade"].ToString();
                txtQuantidade.Focus();
                dr.Close();
            }
            con.Close();
        }

        private void btnNoItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                if (txtIDProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvV);
                item.Cells[0].Value = txtIDProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvV.Rows.Add(item);
                txtIDProduto.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                cbxProduto.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvV.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                    txtTotal.Text = Convert.ToString(soma);
                }
            }

            else
            {
                MessageBox.Show("Pedido já cadastrado", "Pedido Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvV.Rows[e.RowIndex];
            cbxProduto.Text = row.Cells[1].Value.ToString();
            txtIDProduto.Text = row.Cells[0].Value.ToString();
            txtQuantidade.Text = row.Cells[2].Value.ToString();
            txtValor.Text = row.Cells[3].Value.ToString();
        }

        private void btnEdItem_Click(object sender, EventArgs e)
        {
            int linha = dgvV.CurrentRow.Index;
            dgvV.Rows[linha].Cells[0].Value = txtIDProduto.Text;
            dgvV.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvV.Rows[linha].Cells[2].Value = txtQuantidade.Text;
            dgvV.Rows[linha].Cells[3].Value = txtValor.Text;
            dgvV.Rows[linha].Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
            txtIDProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cbxProduto.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = Convert.ToString(soma);
            }
        }

        private void btnExItem_Click(object sender, EventArgs e)
        {
            int linha = dgvV.CurrentRow.Index;
            dgvV.Rows.RemoveAt(linha);
            dgvV.Refresh();
            txtIDProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cbxProduto.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = Convert.ToString(soma);
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("Quantidade_Produto", con);
            cmd.Parameters.AddWithValue("@Id", txtIDProduto.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            int valor1 = 0;
            bool conversaoSucedida = int.TryParse(txtQuantidade.Text, out valor1);
            if (dr.Read())
            {
                int valor2 = Convert.ToInt32(dr["quantidade"].ToString());
                if (valor1 > valor2)
                {
                    MessageBox.Show("Não tem quantidade suficiente!", "Estoque Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantidade.Text = "";
                    txtQuantidade.Focus();
                }
            }
            con.Close();
        }

        private void btnFVenda_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET situacao = @situacao WHERE Id = @Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Fechada";
            cmd.ExecuteNonQuery();
            SqlCommand deletarPedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda = @Id", con);
            deletarPedido.CommandType = CommandType.Text;
            deletarPedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
            deletarPedido.ExecuteNonQuery();
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensVendidos", con);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Venda realizada com sucesso", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvV.Columns.Clear();
            dgvV.Rows.Clear();
            txtID.Text = "";
            txtTotal.Text = "";
            txtValor.Text = "";
            lblEstoque.Text = "";
        }

        private void btnFPedido_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_cliente", SqlDbType.NChar).Value = cbxCliente.SelectedValue;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text);
            cmd.Parameters.AddWithValue("@data_venda", SqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Aberta";
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItensPedidos", con);
                cmditens.CommandType = CommandType.StoredProcedure;
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            dgvV.Rows.Clear();
            dgvV.Refresh();
            txtValor.Text = "";
            txtTotal.Text = "";
            lblEstoque.Text = "";
            cbxCliente.Text = "";
            MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaCbxProduto();
            txtTotal.Text = "";
            dgvV.Columns.Clear();
            dgvV.Rows.Clear();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("VendaId", con);
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string venda = dt.Rows[0]["situacao"].ToString().Trim();
                int linhas = dt.Rows.Count;
                if (dt.Rows.Count > 0 && venda == "Aberta")
                {
                    con.Close();
                    con.Open();
                    SqlCommand pedido = new SqlCommand("LocalizarPedido", con);
                    pedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                    pedido.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ped = new SqlDataAdapter(pedido);
                    DataTable dtped = new DataTable();
                    ped.Fill(dtped);
                    int linhasped = dtped.Rows.Count;
                    if (dtped.Rows.Count > 0)
                    {
                        cbxCliente.Enabled = Capture;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtped.Rows[0]["nomecliente"].ToString();
                        txtTotal.Text = dtped.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txtID.Enabled = true;
                        txtIDProduto.Enabled = true;
                        txtQuantidade.Enabled = true;
                        txtTotal.Enabled = true;
                        txtValor.Enabled = true;
                        btnAPedido.Enabled = true;
                        btnFPedido.Enabled = true;
                        btnFVenda.Enabled = true;
                        btnNoItem.Enabled = true;
                        btnEdItem.Enabled = true;
                        btnExItem.Enabled = true;
                        dgvV.Columns.Add("ID", "ID");
                        dgvV.Columns.Add("Produto", "Produto");
                        dgvV.Columns.Add("Quantidade", "Quantidade");
                        dgvV.Columns.Add("Valor", "Valor");
                        dgvV.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasped; i++)
                        {
                            DataGridViewRow itemped = new DataGridViewRow();
                            itemped.CreateCells(dgvV);
                            itemped.Cells[0].Value = dtped.Rows[i]["id_produto"].ToString();
                            itemped.Cells[1].Value = dtped.Rows[i]["nomeproduto"].ToString();
                            itemped.Cells[2].Value = dtped.Rows[i]["quantidade"].ToString();
                            itemped.Cells[3].Value = dtped.Rows[i]["valor_unitario"].ToString();
                            itemped.Cells[4].Value = dtped.Rows[i]["valor_total"].ToString();
                            dgvV.Rows.Add(itemped);
                        }
                    }
                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand lvenda = new SqlCommand("LocalizarVendido", con);
                    lvenda.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIDProduto.Text.Trim());
                    lvenda.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ven = new SqlDataAdapter(lvenda);
                    DataTable dtven = new DataTable();
                    ven.Fill(dtven);
                    int linhasven = dtven.Rows.Count;
                    if (linhasven > 0)
                    {
                        cbxCliente.Enabled = true;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtven.Rows[0]["nomecliente"].ToString();
                        txtTotal.Text = dtven.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txtQuantidade.Enabled = true;
                        txtValor.Enabled = true;
                        btnNoItem.Enabled = true;
                        btnEdItem.Enabled = true;
                        btnExItem.Enabled = true;
                        btnFPedido.Enabled = true;
                        btnAPedido.Enabled = true;
                        dgvV.Columns.Add("ID", "ID");
                        dgvV.Columns.Add("Produto", "Produto");
                        dgvV.Columns.Add("Quantidade", "Quantidade");
                        dgvV.Columns.Add("Valor", "Valor");
                        dgvV.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasven; i++)
                        {
                            DataGridViewRow itemven = new DataGridViewRow();
                            itemven.CreateCells(dgvV);
                            itemven.CreateCells(dgvV);
                            itemven.Cells[0].Value = dtven.Rows[i]["id_produto"].ToString();
                            itemven.Cells[1].Value = dtven.Rows[i]["nomeproduto"].ToString();
                            itemven.Cells[2].Value = dtven.Rows[i]["quantidade"].ToString();
                            itemven.Cells[3].Value = dtven.Rows[i]["valor_unitario"].ToString();
                            itemven.Cells[4].Value = dtven.Rows[i]["valor_total"].ToString();
                            dgvV.Rows.Add(itemven);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum pedido ou venda localizado. Por favor verifique o ID novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            con.Close();
        }

        private void btnAPedido_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET total = @total WHERE Id=@Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text);
            cmd.ExecuteNonQuery();
            SqlCommand deletarPedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda = @Id", con);
            deletarPedido.CommandType = CommandType.Text;
            deletarPedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
            deletarPedido.ExecuteNonQuery();
            foreach (DataGridViewRow dr in dgvV.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensPedidos", con);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Pedido atualizado com sucesso", "Atualização do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvV.Columns.Clear();
            dgvV.Rows.Clear();
            txtID.Text = "";
            txtTotal.Text = "";
            txtValor.Text = "";
            lblEstoque.Text = "";
        }
    }
}
