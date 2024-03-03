namespace A_ADOSMELHORES
{
    partial class CalcularSalForm
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
            this.btn_valid = new System.Windows.Forms.Button();
            this.lbl_data_ini = new System.Windows.Forms.Label();
            this.lbl_data_fim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.ListBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.txt_pag = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.box_form = new System.Windows.Forms.ComboBox();
            this.dia_ini = new System.Windows.Forms.DateTimePicker();
            this.dia_fim = new System.Windows.Forms.DateTimePicker();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valid
            // 
            this.btn_valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_valid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valid.Location = new System.Drawing.Point(315, 450);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 29);
            this.btn_valid.TabIndex = 166;
            this.btn_valid.Text = "Calcular";
            this.btn_valid.UseVisualStyleBackColor = false;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // lbl_data_ini
            // 
            this.lbl_data_ini.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data_ini.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_ini.Location = new System.Drawing.Point(128, 376);
            this.lbl_data_ini.Name = "lbl_data_ini";
            this.lbl_data_ini.Size = new System.Drawing.Size(227, 29);
            this.lbl_data_ini.TabIndex = 162;
            this.lbl_data_ini.Text = "Data de inicio do pagamento";
            // 
            // lbl_data_fim
            // 
            this.lbl_data_fim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data_fim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_fim.Location = new System.Drawing.Point(380, 376);
            this.lbl_data_fim.Name = "lbl_data_fim";
            this.lbl_data_fim.Size = new System.Drawing.Size(227, 29);
            this.lbl_data_fim.TabIndex = 163;
            this.lbl_data_fim.Text = "Data de fim do pagamento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 182;
            this.label1.Text = "ID:";
            // 
            // txt_info
            // 
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.FormattingEnabled = true;
            this.txt_info.ItemHeight = 21;
            this.txt_info.Location = new System.Drawing.Point(132, 151);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(388, 189);
            this.txt_info.TabIndex = 183;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_validar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validar.Location = new System.Drawing.Point(396, 66);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(102, 29);
            this.btn_validar.TabIndex = 184;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // txt_pag
            // 
            this.txt_pag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pag.Location = new System.Drawing.Point(132, 454);
            this.txt_pag.Name = "txt_pag";
            this.txt_pag.Size = new System.Drawing.Size(97, 22);
            this.txt_pag.TabIndex = 185;
            this.txt_pag.Text = "Pagamento:";
            this.txt_pag.Visible = false;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_valor.Enabled = false;
            this.txt_valor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(235, 451);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(74, 25);
            this.txt_valor.TabIndex = 186;
            this.txt_valor.Visible = false;
            // 
            // lbl_data
            // 
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(396, 451);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(108, 29);
            this.lbl_data.TabIndex = 187;
            this.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_data.Visible = false;
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_sair.Location = new System.Drawing.Point(948, 821);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_sair.TabIndex = 188;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // box_form
            // 
            this.box_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_form.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.box_form.FormattingEnabled = true;
            this.box_form.Location = new System.Drawing.Point(156, 66);
            this.box_form.Name = "box_form";
            this.box_form.Size = new System.Drawing.Size(233, 29);
            this.box_form.TabIndex = 189;
            // 
            // dia_ini
            // 
            this.dia_ini.Location = new System.Drawing.Point(132, 417);
            this.dia_ini.Name = "dia_ini";
            this.dia_ini.Size = new System.Drawing.Size(200, 20);
            this.dia_ini.TabIndex = 190;
            this.dia_ini.Visible = false;
            // 
            // dia_fim
            // 
            this.dia_fim.Location = new System.Drawing.Point(384, 417);
            this.dia_fim.Name = "dia_fim";
            this.dia_fim.Size = new System.Drawing.Size(200, 20);
            this.dia_fim.TabIndex = 191;
            this.dia_fim.Visible = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(504, 66);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(102, 29);
            this.btn_limpar.TabIndex = 192;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // CalcularSalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.dia_fim);
            this.Controls.Add(this.dia_ini);
            this.Controls.Add(this.box_form);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_pag);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.lbl_data_fim);
            this.Controls.Add(this.lbl_data_ini);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcularSalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcularSalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.Label lbl_data_ini;
        private System.Windows.Forms.Label lbl_data_fim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txt_info;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.TextBox txt_pag;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox box_form;
        private System.Windows.Forms.DateTimePicker dia_ini;
        private System.Windows.Forms.DateTimePicker dia_fim;
        private System.Windows.Forms.Button btn_limpar;
    }
}