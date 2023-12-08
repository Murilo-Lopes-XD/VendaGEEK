namespace VendaGEEK
{
    partial class Venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNPedido = new System.Windows.Forms.Button();
            this.btnAPedido = new System.Windows.Forms.Button();
            this.btnFPedido = new System.Windows.Forms.Button();
            this.btnFVenda = new System.Windows.Forms.Button();
            this.btnNoItem = new System.Windows.Forms.Button();
            this.btnEdItem = new System.Windows.Forms.Button();
            this.btnExItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(24, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(24, 265);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(139, 20);
            this.txtIDProduto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(24, 337);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(139, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estoque: ";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(282, 416);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(0, 20);
            this.lblEstoque.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(630, 418);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(550, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total R$";
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(553, 12);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(235, 374);
            this.dgvV.TabIndex = 14;
            this.dgvV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvV_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::VendaGEEK.Properties.Resources.nami;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(148, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 70);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNPedido
            // 
            this.btnNPedido.BackgroundImage = global::VendaGEEK.Properties.Resources.law;
            this.btnNPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPedido.ForeColor = System.Drawing.Color.White;
            this.btnNPedido.Location = new System.Drawing.Point(419, 1);
            this.btnNPedido.Name = "btnNPedido";
            this.btnNPedido.Size = new System.Drawing.Size(128, 70);
            this.btnNPedido.TabIndex = 16;
            this.btnNPedido.Text = "Novo Pedido";
            this.btnNPedido.UseVisualStyleBackColor = true;
            this.btnNPedido.Click += new System.EventHandler(this.btnNPedido_Click);
            // 
            // btnAPedido
            // 
            this.btnAPedido.BackgroundImage = global::VendaGEEK.Properties.Resources.kid;
            this.btnAPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPedido.ForeColor = System.Drawing.Color.White;
            this.btnAPedido.Location = new System.Drawing.Point(419, 77);
            this.btnAPedido.Name = "btnAPedido";
            this.btnAPedido.Size = new System.Drawing.Size(128, 70);
            this.btnAPedido.TabIndex = 17;
            this.btnAPedido.Text = "Atualizar Pedido";
            this.btnAPedido.UseVisualStyleBackColor = true;
            this.btnAPedido.Click += new System.EventHandler(this.btnAPedido_Click);
            // 
            // btnFPedido
            // 
            this.btnFPedido.BackgroundImage = global::VendaGEEK.Properties.Resources.robin;
            this.btnFPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPedido.ForeColor = System.Drawing.Color.White;
            this.btnFPedido.Location = new System.Drawing.Point(391, 202);
            this.btnFPedido.Name = "btnFPedido";
            this.btnFPedido.Size = new System.Drawing.Size(128, 70);
            this.btnFPedido.TabIndex = 18;
            this.btnFPedido.Text = "Finalizar Pedido";
            this.btnFPedido.UseVisualStyleBackColor = true;
            this.btnFPedido.Click += new System.EventHandler(this.btnFPedido_Click);
            // 
            // btnFVenda
            // 
            this.btnFVenda.BackgroundImage = global::VendaGEEK.Properties.Resources.chopper;
            this.btnFVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFVenda.ForeColor = System.Drawing.Color.White;
            this.btnFVenda.Location = new System.Drawing.Point(391, 278);
            this.btnFVenda.Name = "btnFVenda";
            this.btnFVenda.Size = new System.Drawing.Size(128, 70);
            this.btnFVenda.TabIndex = 19;
            this.btnFVenda.Text = "Finalizar Venda";
            this.btnFVenda.UseVisualStyleBackColor = true;
            this.btnFVenda.Click += new System.EventHandler(this.btnFVenda_Click);
            // 
            // btnNoItem
            // 
            this.btnNoItem.BackgroundImage = global::VendaGEEK.Properties.Resources.luffy;
            this.btnNoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoItem.ForeColor = System.Drawing.Color.White;
            this.btnNoItem.Location = new System.Drawing.Point(187, 144);
            this.btnNoItem.Name = "btnNoItem";
            this.btnNoItem.Size = new System.Drawing.Size(128, 70);
            this.btnNoItem.TabIndex = 20;
            this.btnNoItem.Text = "Novo Item";
            this.btnNoItem.UseVisualStyleBackColor = true;
            this.btnNoItem.Click += new System.EventHandler(this.btnNoItem_Click);
            // 
            // btnEdItem
            // 
            this.btnEdItem.BackgroundImage = global::VendaGEEK.Properties.Resources.zoro;
            this.btnEdItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdItem.ForeColor = System.Drawing.Color.White;
            this.btnEdItem.Location = new System.Drawing.Point(187, 220);
            this.btnEdItem.Name = "btnEdItem";
            this.btnEdItem.Size = new System.Drawing.Size(128, 70);
            this.btnEdItem.TabIndex = 21;
            this.btnEdItem.Text = "Editar Item";
            this.btnEdItem.UseVisualStyleBackColor = true;
            this.btnEdItem.Click += new System.EventHandler(this.btnEdItem_Click);
            // 
            // btnExItem
            // 
            this.btnExItem.BackgroundImage = global::VendaGEEK.Properties.Resources.sanji;
            this.btnExItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExItem.ForeColor = System.Drawing.Color.White;
            this.btnExItem.Location = new System.Drawing.Point(187, 296);
            this.btnExItem.Name = "btnExItem";
            this.btnExItem.Size = new System.Drawing.Size(128, 70);
            this.btnExItem.TabIndex = 22;
            this.btnExItem.Text = "Excluir Item";
            this.btnExItem.UseVisualStyleBackColor = true;
            this.btnExItem.Click += new System.EventHandler(this.btnExItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::VendaGEEK.Properties.Resources.franky;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(391, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 70);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(24, 404);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Valor R$";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(24, 125);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(139, 21);
            this.cbxCliente.TabIndex = 26;
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(24, 202);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(139, 21);
            this.cbxProduto.TabIndex = 27;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VendaGEEK.Properties.Resources.one_piece;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExItem);
            this.Controls.Add(this.btnEdItem);
            this.Controls.Add(this.btnNoItem);
            this.Controls.Add(this.btnFVenda);
            this.Controls.Add(this.btnFPedido);
            this.Controls.Add(this.btnAPedido);
            this.Controls.Add(this.btnNPedido);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvV);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNPedido;
        private System.Windows.Forms.Button btnAPedido;
        private System.Windows.Forms.Button btnFPedido;
        private System.Windows.Forms.Button btnFVenda;
        private System.Windows.Forms.Button btnNoItem;
        private System.Windows.Forms.Button btnEdItem;
        private System.Windows.Forms.Button btnExItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProduto;
    }
}