namespace A_ADOSMELHORES
{
    partial class RemoveFuncionario
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
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_info = new System.Windows.Forms.ListBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_validar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpar.Location = new System.Drawing.Point(476, 88);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpar.TabIndex = 76;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_info
            // 
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.FormattingEnabled = true;
            this.txt_info.ItemHeight = 21;
            this.txt_info.Location = new System.Drawing.Point(173, 261);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(388, 189);
            this.txt_info.TabIndex = 75;
            this.txt_info.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(319, 98);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(70, 13);
            this.lbl_id.TabIndex = 74;
            this.lbl_id.Text = "Valor inválido";
            this.lbl_id.Visible = false;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_validar.Location = new System.Drawing.Point(395, 88);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 29);
            this.btn_validar.TabIndex = 73;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(128, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 30);
            this.label2.TabIndex = 72;
            this.label2.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(173, 89);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(140, 29);
            this.txt_id.TabIndex = 71;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_voltar.Location = new System.Drawing.Point(948, 821);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(240, 87);
            this.btn_voltar.TabIndex = 70;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_confirmar.Location = new System.Drawing.Point(173, 563);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_confirmar.TabIndex = 77;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Visible = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click_1);
            // 
            // RemoveFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_voltar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveFuncionario";
            this.Load += new System.EventHandler(this.RemoveFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ListBox txt_info;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}