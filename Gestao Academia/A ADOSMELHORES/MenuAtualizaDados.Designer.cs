namespace A_ADOSMELHORES
{
    partial class MenuAtualizaDados
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
            this.btn_atualizar_regCrime = new System.Windows.Forms.Button();
            this.btn_atualizar_contacto = new System.Windows.Forms.Button();
            this.btn_atualizar_morada = new System.Windows.Forms.Button();
            this.btn_renovar_contrato = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_atualizar_regCrime
            // 
            this.btn_atualizar_regCrime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_atualizar_regCrime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_regCrime.Location = new System.Drawing.Point(480, 440);
            this.btn_atualizar_regCrime.Name = "btn_atualizar_regCrime";
            this.btn_atualizar_regCrime.Size = new System.Drawing.Size(240, 85);
            this.btn_atualizar_regCrime.TabIndex = 9;
            this.btn_atualizar_regCrime.Text = "Atualizar Registo Criminal";
            this.btn_atualizar_regCrime.UseVisualStyleBackColor = false;
            this.btn_atualizar_regCrime.Click += new System.EventHandler(this.btn_atualizar_regCrime_Click);
            // 
            // btn_atualizar_contacto
            // 
            this.btn_atualizar_contacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_atualizar_contacto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_contacto.Location = new System.Drawing.Point(480, 278);
            this.btn_atualizar_contacto.Name = "btn_atualizar_contacto";
            this.btn_atualizar_contacto.Size = new System.Drawing.Size(240, 85);
            this.btn_atualizar_contacto.TabIndex = 8;
            this.btn_atualizar_contacto.Text = "Atualizar contacto";
            this.btn_atualizar_contacto.UseVisualStyleBackColor = false;
            this.btn_atualizar_contacto.Click += new System.EventHandler(this.btn_atualizar_contacto_Click);
            // 
            // btn_atualizar_morada
            // 
            this.btn_atualizar_morada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_atualizar_morada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_morada.Location = new System.Drawing.Point(480, 119);
            this.btn_atualizar_morada.Name = "btn_atualizar_morada";
            this.btn_atualizar_morada.Size = new System.Drawing.Size(240, 85);
            this.btn_atualizar_morada.TabIndex = 7;
            this.btn_atualizar_morada.Text = "Atualizar Morada";
            this.btn_atualizar_morada.UseVisualStyleBackColor = false;
            this.btn_atualizar_morada.Click += new System.EventHandler(this.btn_atualizar_morada_Click);
            // 
            // btn_renovar_contrato
            // 
            this.btn_renovar_contrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_renovar_contrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renovar_contrato.Location = new System.Drawing.Point(480, 612);
            this.btn_renovar_contrato.Name = "btn_renovar_contrato";
            this.btn_renovar_contrato.Size = new System.Drawing.Size(240, 85);
            this.btn_renovar_contrato.TabIndex = 10;
            this.btn_renovar_contrato.Text = "Renovar Contrato";
            this.btn_renovar_contrato.UseVisualStyleBackColor = false;
            this.btn_renovar_contrato.Click += new System.EventHandler(this.btn_renovar_contrato_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_voltar.Location = new System.Drawing.Point(948, 823);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(240, 85);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // MenuAtualizaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_renovar_contrato);
            this.Controls.Add(this.btn_atualizar_regCrime);
            this.Controls.Add(this.btn_atualizar_contacto);
            this.Controls.Add(this.btn_atualizar_morada);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAtualizaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAtualizaDados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atualizar_regCrime;
        private System.Windows.Forms.Button btn_atualizar_contacto;
        private System.Windows.Forms.Button btn_atualizar_morada;
        private System.Windows.Forms.Button btn_renovar_contrato;
        private System.Windows.Forms.Button btn_voltar;
    }
}