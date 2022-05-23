
namespace Tratando_Servicos
{
    partial class Listar_Servicos_Ativos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvServicosAtivos = new System.Windows.Forms.ListView();
            this.btnListarServicos = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localizacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvServicosAtivos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços Ativos do Windows";
            // 
            // lvServicosAtivos
            // 
            this.lvServicosAtivos.AllowColumnReorder = true;
            this.lvServicosAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Localizacao,
            this.Descricao});
            this.lvServicosAtivos.GridLines = true;
            this.lvServicosAtivos.HideSelection = false;
            this.lvServicosAtivos.Location = new System.Drawing.Point(7, 20);
            this.lvServicosAtivos.Name = "lvServicosAtivos";
            this.lvServicosAtivos.Size = new System.Drawing.Size(705, 472);
            this.lvServicosAtivos.TabIndex = 0;
            this.lvServicosAtivos.UseCompatibleStateImageBehavior = false;
            this.lvServicosAtivos.View = System.Windows.Forms.View.Details;
            // 
            // btnListarServicos
            // 
            this.btnListarServicos.Location = new System.Drawing.Point(20, 517);
            this.btnListarServicos.Name = "btnListarServicos";
            this.btnListarServicos.Size = new System.Drawing.Size(148, 40);
            this.btnListarServicos.TabIndex = 1;
            this.btnListarServicos.Text = "Listar Serviços Ativos";
            this.btnListarServicos.UseVisualStyleBackColor = true;
            this.btnListarServicos.Click += new System.EventHandler(this.btnListarServicos_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 250;
            // 
            // Localizacao
            // 
            this.Localizacao.Text = "Localizacao";
            this.Localizacao.Width = 400;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descricao";
            this.Descricao.Width = 500;
            // 
            // Listar_Servicos_Ativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 569);
            this.Controls.Add(this.btnListarServicos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listar_Servicos_Ativos";
            this.Text = "Listar_Servicos_Ativos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvServicosAtivos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Localizacao;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.Button btnListarServicos;
    }
}