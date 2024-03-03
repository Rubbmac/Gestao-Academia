namespace A_ADOSMELHORES
{
    partial class AtualizaRegCrim
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
            this.btn_menuAdd_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.calen_reg = new System.Windows.Forms.MonthCalendar();
            this.btn_validar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.ListBox();
            this.lbl_calen = new System.Windows.Forms.Label();
            this.btn_c_valid = new System.Windows.Forms.Button();
            this.txt_conf = new System.Windows.Forms.TextBox();
            this.btn_conf = new System.Windows.Forms.Button();
            this.lbl_conf = new System.Windows.Forms.Label();
            this.txt_data_antiga = new System.Windows.Forms.TextBox();
            this.lbl_data_antiga = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menuAdd_sair
            // 
            this.btn_menuAdd_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menuAdd_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_menuAdd_sair.Location = new System.Drawing.Point(948, 821);
            this.btn_menuAdd_sair.Name = "btn_menuAdd_sair";
            this.btn_menuAdd_sair.Size = new System.Drawing.Size(240, 87);
            this.btn_menuAdd_sair.TabIndex = 47;
            this.btn_menuAdd_sair.Text = "Voltar";
            this.btn_menuAdd_sair.UseVisualStyleBackColor = false;
            this.btn_menuAdd_sair.Click += new System.EventHandler(this.btn_menuAdd_sair_Click);
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
            this.label2.TabIndex = 55;
            this.label2.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(173, 89);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(140, 29);
            this.txt_id.TabIndex = 54;
            // 
            // calen_reg
            // 
            this.calen_reg.Location = new System.Drawing.Point(173, 598);
            this.calen_reg.MaxSelectionCount = 1;
            this.calen_reg.Name = "calen_reg";
            this.calen_reg.ShowToday = false;
            this.calen_reg.ShowTodayCircle = false;
            this.calen_reg.TabIndex = 56;
            this.calen_reg.Visible = false;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_validar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_validar.Location = new System.Drawing.Point(395, 88);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 29);
            this.btn_validar.TabIndex = 57;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_id.Location = new System.Drawing.Point(319, 98);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(77, 13);
            this.lbl_id.TabIndex = 58;
            this.lbl_id.Text = "Valor inválido";
            this.lbl_id.Visible = false;
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
            this.txt_info.TabIndex = 61;
            // 
            // lbl_calen
            // 
            this.lbl_calen.AutoSize = true;
            this.lbl_calen.BackColor = System.Drawing.Color.White;
            this.lbl_calen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_calen.Location = new System.Drawing.Point(168, 559);
            this.lbl_calen.Name = "lbl_calen";
            this.lbl_calen.Size = new System.Drawing.Size(398, 30);
            this.lbl_calen.TabIndex = 62;
            this.lbl_calen.Text = "Selecione a nova data de registo criminal:";
            this.lbl_calen.Visible = false;
            // 
            // btn_c_valid
            // 
            this.btn_c_valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_c_valid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_c_valid.Location = new System.Drawing.Point(412, 642);
            this.btn_c_valid.Name = "btn_c_valid";
            this.btn_c_valid.Size = new System.Drawing.Size(75, 75);
            this.btn_c_valid.TabIndex = 63;
            this.btn_c_valid.Text = "Validar";
            this.btn_c_valid.UseVisualStyleBackColor = false;
            this.btn_c_valid.Visible = false;
            this.btn_c_valid.Click += new System.EventHandler(this.btn_c_valid_Click);
            // 
            // txt_conf
            // 
            this.txt_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_conf.Enabled = false;
            this.txt_conf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf.Location = new System.Drawing.Point(555, 688);
            this.txt_conf.Name = "txt_conf";
            this.txt_conf.Size = new System.Drawing.Size(140, 29);
            this.txt_conf.TabIndex = 64;
            this.txt_conf.Visible = false;
            // 
            // btn_conf
            // 
            this.btn_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_conf.Enabled = false;
            this.btn_conf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conf.Location = new System.Drawing.Point(701, 688);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(83, 29);
            this.btn_conf.TabIndex = 65;
            this.btn_conf.Text = "Confirmar";
            this.btn_conf.UseVisualStyleBackColor = false;
            this.btn_conf.Visible = false;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // lbl_conf
            // 
            this.lbl_conf.AutoSize = true;
            this.lbl_conf.BackColor = System.Drawing.Color.White;
            this.lbl_conf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_conf.Location = new System.Drawing.Point(551, 666);
            this.lbl_conf.Name = "lbl_conf";
            this.lbl_conf.Size = new System.Drawing.Size(84, 21);
            this.lbl_conf.TabIndex = 66;
            this.lbl_conf.Text = "Nova data:";
            this.lbl_conf.Visible = false;
            // 
            // txt_data_antiga
            // 
            this.txt_data_antiga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_data_antiga.Enabled = false;
            this.txt_data_antiga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_antiga.Location = new System.Drawing.Point(555, 634);
            this.txt_data_antiga.Name = "txt_data_antiga";
            this.txt_data_antiga.Size = new System.Drawing.Size(140, 29);
            this.txt_data_antiga.TabIndex = 67;
            this.txt_data_antiga.Visible = false;
            // 
            // lbl_data_antiga
            // 
            this.lbl_data_antiga.AutoSize = true;
            this.lbl_data_antiga.BackColor = System.Drawing.Color.White;
            this.lbl_data_antiga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_antiga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_data_antiga.Location = new System.Drawing.Point(551, 610);
            this.lbl_data_antiga.Name = "lbl_data_antiga";
            this.lbl_data_antiga.Size = new System.Drawing.Size(119, 21);
            this.lbl_data_antiga.TabIndex = 68;
            this.lbl_data_antiga.Text = "Data no registo:";
            this.lbl_data_antiga.Visible = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_limpar.Location = new System.Drawing.Point(476, 88);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpar.TabIndex = 69;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // AtualizaRegCrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_data_antiga);
            this.Controls.Add(this.txt_data_antiga);
            this.Controls.Add(this.lbl_conf);
            this.Controls.Add(this.btn_conf);
            this.Controls.Add(this.txt_conf);
            this.Controls.Add(this.btn_c_valid);
            this.Controls.Add(this.lbl_calen);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.calen_reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_menuAdd_sair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtualizaRegCrim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizaRegCrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_menuAdd_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MonthCalendar calen_reg;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ListBox txt_info;
        private System.Windows.Forms.Label lbl_calen;
        private System.Windows.Forms.Button btn_c_valid;
        private System.Windows.Forms.TextBox txt_conf;
        private System.Windows.Forms.Button btn_conf;
        private System.Windows.Forms.Label lbl_conf;
        private System.Windows.Forms.TextBox txt_data_antiga;
        private System.Windows.Forms.Label lbl_data_antiga;
        private System.Windows.Forms.Button btn_limpar;
    }
}