
namespace Tratando_Servicos
{
    partial class Tratando_Servicos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvServicos = new System.Windows.Forms.ListView();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnPararServico = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvServicos);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços do Windows";
            // 
            // lvServicos
            // 
            this.lvServicos.AllowColumnReorder = true;
            this.lvServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServicos.GridLines = true;
            this.lvServicos.HideSelection = false;
            this.lvServicos.Location = new System.Drawing.Point(3, 16);
            this.lvServicos.Name = "lvServicos";
            this.lvServicos.Size = new System.Drawing.Size(674, 497);
            this.lvServicos.TabIndex = 0;
            this.lvServicos.UseCompatibleStateImageBehavior = false;
            this.lvServicos.View = System.Windows.Forms.View.Details;
            this.lvServicos.SelectedIndexChanged += new System.EventHandler(this.lvServicos_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(4, 523);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(154, 33);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Serviços do Windows";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnPararServico
            // 
            this.btnPararServico.Location = new System.Drawing.Point(340, 523);
            this.btnPararServico.Name = "btnPararServico";
            this.btnPararServico.Size = new System.Drawing.Size(106, 33);
            this.btnPararServico.TabIndex = 2;
            this.btnPararServico.Text = "Parar Servico";
            this.btnPararServico.UseVisualStyleBackColor = true;
            this.btnPararServico.Click += new System.EventHandler(this.btnPararServico_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(452, 523);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(106, 33);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Servico";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(564, 523);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(106, 33);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar Servico";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Tratando_Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 560);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPararServico);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tratando_Servicos";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvServicos;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnPararServico;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

