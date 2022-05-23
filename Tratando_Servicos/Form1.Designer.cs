namespace Tratando_Servicos
{
    partial class Form1
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
            this.lvServicos = new System.Windows.Forms.ListView();
            this.btnListarServicos = new System.Windows.Forms.Button();
            this.btnPararServico = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvServicos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços do Windows";
            // 
            // lvServicos
            // 
            this.lvServicos.AllowColumnReorder = true;
            this.lvServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServicos.FullRowSelect = true;
            this.lvServicos.GridLines = true;
            this.lvServicos.HideSelection = false;
            this.lvServicos.Location = new System.Drawing.Point(3, 18);
            this.lvServicos.Name = "lvServicos";
            this.lvServicos.Size = new System.Drawing.Size(717, 459);
            this.lvServicos.TabIndex = 0;
            this.lvServicos.UseCompatibleStateImageBehavior = false;
            this.lvServicos.View = System.Windows.Forms.View.Details;
            this.lvServicos.SelectedIndexChanged += new System.EventHandler(this.lvServicos_SelectedIndexChanged);
            // 
            // btnListarServicos
            // 
            this.btnListarServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListarServicos.Location = new System.Drawing.Point(17, 512);
            this.btnListarServicos.Name = "btnListarServicos";
            this.btnListarServicos.Size = new System.Drawing.Size(201, 41);
            this.btnListarServicos.TabIndex = 1;
            this.btnListarServicos.Text = "Listar Serviços do Windows";
            this.btnListarServicos.UseVisualStyleBackColor = true;
            this.btnListarServicos.Click += new System.EventHandler(this.btnListarServicos_Click);
            // 
            // btnPararServico
            // 
            this.btnPararServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPararServico.BackColor = System.Drawing.Color.Black;
            this.btnPararServico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPararServico.Location = new System.Drawing.Point(385, 512);
            this.btnPararServico.Name = "btnPararServico";
            this.btnPararServico.Size = new System.Drawing.Size(109, 41);
            this.btnPararServico.TabIndex = 2;
            this.btnPararServico.Text = "Parar Serviço";
            this.btnPararServico.UseVisualStyleBackColor = false;
            this.btnPararServico.Click += new System.EventHandler(this.btnPararServico_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(625, 512);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(109, 41);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar Serviço";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(505, 512);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(109, 41);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Serviço";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(752, 569);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPararServico);
            this.Controls.Add(this.btnListarServicos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratando Serviços do Windows";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvServicos;
        private System.Windows.Forms.Button btnListarServicos;
        private System.Windows.Forms.Button btnPararServico;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnIniciar;
    }
}

