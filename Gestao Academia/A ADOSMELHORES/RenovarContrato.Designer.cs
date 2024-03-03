namespace A_ADOSMELHORES
{
    partial class RenovarContrato
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
            this.txt_inicio_contrato = new System.Windows.Forms.TextBox();
            this.btn_conf = new System.Windows.Forms.Button();
            this.txt_fim_contrato = new System.Windows.Forms.TextBox();
            this.lbl_calen = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.ListBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_validar = new System.Windows.Forms.Button();
            this.calen_renova_contrato = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_menuAdd_sair = new System.Windows.Forms.Button();
            this.btn_c_fim = new System.Windows.Forms.Button();
            this.btn_c_ini = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_limpar.Location = new System.Drawing.Point(476, 88);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpar.TabIndex = 84;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_inicio_contrato
            // 
            this.txt_inicio_contrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_inicio_contrato.Enabled = false;
            this.txt_inicio_contrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_contrato.Location = new System.Drawing.Point(574, 636);
            this.txt_inicio_contrato.Name = "txt_inicio_contrato";
            this.txt_inicio_contrato.Size = new System.Drawing.Size(140, 29);
            this.txt_inicio_contrato.TabIndex = 82;
            this.txt_inicio_contrato.Visible = false;
            // 
            // btn_conf
            // 
            this.btn_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_conf.Enabled = false;
            this.btn_conf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conf.Location = new System.Drawing.Point(720, 690);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(83, 29);
            this.btn_conf.TabIndex = 80;
            this.btn_conf.Text = "Confirmar";
            this.btn_conf.UseVisualStyleBackColor = false;
            this.btn_conf.Visible = false;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // txt_fim_contrato
            // 
            this.txt_fim_contrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_fim_contrato.Enabled = false;
            this.txt_fim_contrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fim_contrato.Location = new System.Drawing.Point(574, 690);
            this.txt_fim_contrato.Name = "txt_fim_contrato";
            this.txt_fim_contrato.Size = new System.Drawing.Size(140, 29);
            this.txt_fim_contrato.TabIndex = 79;
            this.txt_fim_contrato.Visible = false;
            // 
            // lbl_calen
            // 
            this.lbl_calen.AutoSize = true;
            this.lbl_calen.BackColor = System.Drawing.Color.White;
            this.lbl_calen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_calen.Location = new System.Drawing.Point(168, 559);
            this.lbl_calen.Name = "lbl_calen";
            this.lbl_calen.Size = new System.Drawing.Size(420, 30);
            this.lbl_calen.TabIndex = 77;
            this.lbl_calen.Text = "Indique a data para início e fim de contrato:";
            this.lbl_calen.Visible = false;
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
            this.txt_info.TabIndex = 76;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_id.Location = new System.Drawing.Point(319, 98);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(77, 13);
            this.lbl_id.TabIndex = 75;
            this.lbl_id.Text = "Valor inválido";
            this.lbl_id.Visible = false;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_validar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_validar.Location = new System.Drawing.Point(395, 88);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 29);
            this.btn_validar.TabIndex = 74;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // calen_renova_contrato
            // 
            this.calen_renova_contrato.Location = new System.Drawing.Point(173, 598);
            this.calen_renova_contrato.MaxSelectionCount = 1;
            this.calen_renova_contrato.Name = "calen_renova_contrato";
            this.calen_renova_contrato.ShowToday = false;
            this.calen_renova_contrato.ShowTodayCircle = false;
            this.calen_renova_contrato.TabIndex = 73;
            this.calen_renova_contrato.Visible = false;
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
            // btn_menuAdd_sair
            // 
            this.btn_menuAdd_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menuAdd_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_menuAdd_sair.Location = new System.Drawing.Point(948, 823);
            this.btn_menuAdd_sair.Name = "btn_menuAdd_sair";
            this.btn_menuAdd_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_menuAdd_sair.TabIndex = 70;
            this.btn_menuAdd_sair.Text = "Voltar";
            this.btn_menuAdd_sair.UseVisualStyleBackColor = false;
            this.btn_menuAdd_sair.Click += new System.EventHandler(this.btn_menuAdd_sair_Click);
            // 
            // btn_c_fim
            // 
            this.btn_c_fim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_c_fim.Location = new System.Drawing.Point(535, 691);
            this.btn_c_fim.Name = "btn_c_fim";
            this.btn_c_fim.Size = new System.Drawing.Size(33, 29);
            this.btn_c_fim.TabIndex = 155;
            this.btn_c_fim.UseVisualStyleBackColor = false;
            this.btn_c_fim.Visible = false;
            this.btn_c_fim.Click += new System.EventHandler(this.btn_c_fim_Click);
            // 
            // btn_c_ini
            // 
            this.btn_c_ini.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_c_ini.Location = new System.Drawing.Point(535, 637);
            this.btn_c_ini.Name = "btn_c_ini";
            this.btn_c_ini.Size = new System.Drawing.Size(33, 29);
            this.btn_c_ini.TabIndex = 154;
            this.btn_c_ini.UseVisualStyleBackColor = false;
            this.btn_c_ini.Visible = false;
            this.btn_c_ini.Click += new System.EventHandler(this.btn_c_ini_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 29);
            this.label11.TabIndex = 153;
            this.label11.Text = "Fim (pressione para registar a data)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 636);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 29);
            this.label10.TabIndex = 152;
            this.label10.Text = "Início (pressione para registar a data)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // RenovarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_c_fim);
            this.Controls.Add(this.btn_c_ini);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_inicio_contrato);
            this.Controls.Add(this.btn_conf);
            this.Controls.Add(this.txt_fim_contrato);
            this.Controls.Add(this.lbl_calen);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.calen_renova_contrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_menuAdd_sair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenovarContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_inicio_contrato;
        private System.Windows.Forms.Button btn_conf;
        private System.Windows.Forms.TextBox txt_fim_contrato;
        private System.Windows.Forms.Label lbl_calen;
        private System.Windows.Forms.ListBox txt_info;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.MonthCalendar calen_renova_contrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_menuAdd_sair;
        private System.Windows.Forms.Button btn_c_fim;
        private System.Windows.Forms.Button btn_c_ini;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}