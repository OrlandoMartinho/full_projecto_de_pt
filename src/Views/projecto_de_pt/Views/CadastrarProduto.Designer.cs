namespace projecto_de_pt.Views
{
    partial class CadastrarProduto
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.descricao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fornecedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.preco = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // nome
            // 
            this.nome.BorderRadius = 4;
            this.nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nome.DefaultText = "";
            this.nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.DisabledState.Parent = this.nome;
            this.nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nome.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.nome.FocusedState.Parent = this.nome;
            this.nome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nome.HoverState.Parent = this.nome;
            this.nome.Location = new System.Drawing.Point(38, 56);
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.PlaceholderText = "";
            this.nome.SelectedText = "";
            this.nome.ShadowDecoration.Parent = this.nome;
            this.nome.Size = new System.Drawing.Size(277, 29);
            this.nome.TabIndex = 1;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(193)))), ((int)(((byte)(51)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(25)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(35, 403);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(277, 45);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Cadastrar";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.Color.Transparent;
            this.descricao.BorderRadius = 4;
            this.descricao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.descricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descricao.FocusedColor = System.Drawing.Color.Yellow;
            this.descricao.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.descricao.FocusedState.Parent = this.descricao;
            this.descricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.descricao.FormattingEnabled = true;
            this.descricao.HoverState.Parent = this.descricao;
            this.descricao.ItemHeight = 24;
            this.descricao.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.descricao.ItemsAppearance.Parent = this.descricao;
            this.descricao.Location = new System.Drawing.Point(38, 110);
            this.descricao.Name = "descricao";
            this.descricao.ShadowDecoration.Parent = this.descricao;
            this.descricao.Size = new System.Drawing.Size(274, 30);
            this.descricao.TabIndex = 5;
            this.descricao.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // quantidade
            // 
            this.quantidade.BorderRadius = 4;
            this.quantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantidade.DefaultText = "";
            this.quantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantidade.DisabledState.Parent = this.quantidade;
            this.quantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantidade.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.quantidade.FocusedState.Parent = this.quantidade;
            this.quantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantidade.HoverState.Parent = this.quantidade;
            this.quantidade.Location = new System.Drawing.Point(38, 233);
            this.quantidade.Name = "quantidade";
            this.quantidade.PasswordChar = '\0';
            this.quantidade.PlaceholderText = "";
            this.quantidade.SelectedText = "";
            this.quantidade.ShadowDecoration.Parent = this.quantidade;
            this.quantidade.Size = new System.Drawing.Size(277, 29);
            this.quantidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade";
            // 
            // fornecedor
            // 
            this.fornecedor.BorderRadius = 4;
            this.fornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fornecedor.DefaultText = "";
            this.fornecedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fornecedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fornecedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fornecedor.DisabledState.Parent = this.fornecedor;
            this.fornecedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fornecedor.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.fornecedor.FocusedState.Parent = this.fornecedor;
            this.fornecedor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fornecedor.HoverState.Parent = this.fornecedor;
            this.fornecedor.Location = new System.Drawing.Point(38, 298);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.PasswordChar = '\0';
            this.fornecedor.PlaceholderText = "";
            this.fornecedor.SelectedText = "";
            this.fornecedor.ShadowDecoration.Parent = this.fornecedor;
            this.fornecedor.Size = new System.Drawing.Size(277, 29);
            this.fornecedor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email do fornecedor";
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.Color.Transparent;
            this.categoria.BorderRadius = 4;
            this.categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FocusedColor = System.Drawing.Color.Yellow;
            this.categoria.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.categoria.FocusedState.Parent = this.categoria;
            this.categoria.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoria.FormattingEnabled = true;
            this.categoria.HoverState.Parent = this.categoria;
            this.categoria.ItemHeight = 24;
            this.categoria.Items.AddRange(new object[] {
            "Higiene e Beleza",
            "Frescos",
            "Consumo"});
            this.categoria.ItemsAppearance.Parent = this.categoria;
            this.categoria.Location = new System.Drawing.Point(38, 171);
            this.categoria.Name = "categoria";
            this.categoria.ShadowDecoration.Parent = this.categoria;
            this.categoria.Size = new System.Drawing.Size(274, 30);
            this.categoria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(320, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // preco
            // 
            this.preco.BorderRadius = 4;
            this.preco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.preco.DefaultText = "";
            this.preco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.preco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.preco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.preco.DisabledState.Parent = this.preco;
            this.preco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.preco.FocusedState.BorderColor = System.Drawing.Color.Yellow;
            this.preco.FocusedState.Parent = this.preco;
            this.preco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.preco.HoverState.Parent = this.preco;
            this.preco.Location = new System.Drawing.Point(37, 360);
            this.preco.Name = "preco";
            this.preco.PasswordChar = '\0';
            this.preco.PlaceholderText = "";
            this.preco.SelectedText = "";
            this.preco.ShadowDecoration.Parent = this.preco;
            this.preco.Size = new System.Drawing.Size(277, 29);
            this.preco.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço";
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 470);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox nome;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox descricao;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox categoria;
        private Guna.UI2.WinForms.Guna2TextBox fornecedor;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox quantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox preco;
        private System.Windows.Forms.Label label7;
    }
}