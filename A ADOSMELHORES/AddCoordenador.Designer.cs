namespace A_ADOSMELHORES
{
    partial class AddCoordenador
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
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_valid = new System.Windows.Forms.Button();
            this.calen_reg = new System.Windows.Forms.MonthCalendar();
            this.calen_cont = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.lbl_morada = new System.Windows.Forms.Label();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.txt_cont = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_calen = new System.Windows.Forms.Label();
            this.lbl_data_cont = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.btn_c_fim = new System.Windows.Forms.Button();
            this.btn_c_ini = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_c_fim = new System.Windows.Forms.TextBox();
            this.txt_c_ini = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_inserir.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.Location = new System.Drawing.Point(379, 724);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(232, 62);
            this.btn_inserir.TabIndex = 126;
            this.btn_inserir.Text = "Inserir Dados";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_valid
            // 
            this.btn_valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_valid.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valid.Location = new System.Drawing.Point(132, 724);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(232, 62);
            this.btn_valid.TabIndex = 116;
            this.btn_valid.Text = "Validar";
            this.btn_valid.UseVisualStyleBackColor = false;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // calen_reg
            // 
            this.calen_reg.Location = new System.Drawing.Point(384, 297);
            this.calen_reg.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.calen_reg.MaxSelectionCount = 1;
            this.calen_reg.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calen_reg.Name = "calen_reg";
            this.calen_reg.ShowToday = false;
            this.calen_reg.ShowTodayCircle = false;
            this.calen_reg.TabIndex = 115;
            // 
            // calen_cont
            // 
            this.calen_cont.Location = new System.Drawing.Point(132, 297);
            this.calen_cont.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.calen_cont.MaxSelectionCount = 1;
            this.calen_cont.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calen_cont.Name = "calen_cont";
            this.calen_cont.ShowToday = false;
            this.calen_cont.ShowTodayCircle = false;
            this.calen_cont.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 29);
            this.label7.TabIndex = 112;
            this.label7.Text = "Data do Registo Criminal:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 29);
            this.label8.TabIndex = 111;
            this.label8.Text = "Data de fim de contrato:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(335, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 29);
            this.textBox1.TabIndex = 110;
            this.textBox1.Text = "+351";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 109;
            this.label4.Text = "Contacto:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 108;
            this.label5.Text = "Morada:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 107;
            this.label6.Text = "Nome:";
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contacto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contacto.Location = new System.Drawing.Point(617, 179);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(108, 29);
            this.lbl_contacto.TabIndex = 106;
            this.lbl_contacto.Text = "...";
            this.lbl_contacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_contacto.Visible = false;
            // 
            // lbl_morada
            // 
            this.lbl_morada.BackColor = System.Drawing.Color.Transparent;
            this.lbl_morada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_morada.Location = new System.Drawing.Point(617, 135);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(108, 29);
            this.lbl_morada.TabIndex = 105;
            this.lbl_morada.Text = "...";
            this.lbl_morada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_morada.Visible = false;
            // 
            // txt_morada
            // 
            this.txt_morada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_morada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_morada.Location = new System.Drawing.Point(212, 135);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(399, 29);
            this.txt_morada.TabIndex = 104;
            // 
            // txt_cont
            // 
            this.txt_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cont.Location = new System.Drawing.Point(212, 182);
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.Size = new System.Drawing.Size(117, 29);
            this.txt_cont.TabIndex = 103;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(212, 90);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(399, 29);
            this.txt_nome.TabIndex = 102;
            // 
            // lbl_nome
            // 
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(617, 90);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(108, 29);
            this.lbl_nome.TabIndex = 101;
            this.lbl_nome.Text = "...";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nome.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(948, 821);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(240, 87);
            this.btn_cancelar.TabIndex = 100;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_calen
            // 
            this.lbl_calen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_calen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calen.Location = new System.Drawing.Point(617, 361);
            this.lbl_calen.Name = "lbl_calen";
            this.lbl_calen.Size = new System.Drawing.Size(108, 29);
            this.lbl_calen.TabIndex = 127;
            this.lbl_calen.Text = "...";
            this.lbl_calen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_calen.Visible = false;
            // 
            // lbl_data_cont
            // 
            this.lbl_data_cont.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data_cont.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_cont.Location = new System.Drawing.Point(617, 476);
            this.lbl_data_cont.Name = "lbl_data_cont";
            this.lbl_data_cont.Size = new System.Drawing.Size(108, 29);
            this.lbl_data_cont.TabIndex = 133;
            this.lbl_data_cont.Text = "...";
            this.lbl_data_cont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_data_cont.Visible = false;
            // 
            // lbl_salario
            // 
            this.lbl_salario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.Location = new System.Drawing.Point(617, 226);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(108, 29);
            this.lbl_salario.TabIndex = 134;
            this.lbl_salario.Text = "...";
            this.lbl_salario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_salario.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 29);
            this.label9.TabIndex = 140;
            this.label9.Text = "Salário:";
            // 
            // txt_salario
            // 
            this.txt_salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_salario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.Location = new System.Drawing.Point(212, 229);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(117, 29);
            this.txt_salario.TabIndex = 139;
            // 
            // btn_c_fim
            // 
            this.btn_c_fim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_c_fim.Location = new System.Drawing.Point(252, 490);
            this.btn_c_fim.Name = "btn_c_fim";
            this.btn_c_fim.Size = new System.Drawing.Size(33, 27);
            this.btn_c_fim.TabIndex = 149;
            this.btn_c_fim.UseVisualStyleBackColor = false;
            this.btn_c_fim.Click += new System.EventHandler(this.btn_c_fim_Click);
            // 
            // btn_c_ini
            // 
            this.btn_c_ini.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_c_ini.Location = new System.Drawing.Point(252, 459);
            this.btn_c_ini.Name = "btn_c_ini";
            this.btn_c_ini.Size = new System.Drawing.Size(33, 27);
            this.btn_c_ini.TabIndex = 148;
            this.btn_c_ini.UseVisualStyleBackColor = false;
            this.btn_c_ini.Click += new System.EventHandler(this.btn_c_ini_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 27);
            this.label11.TabIndex = 147;
            this.label11.Text = "Fim (pressione para registar a data)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 27);
            this.label10.TabIndex = 146;
            this.label10.Text = "Início (pressione para registar a data)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_c_fim
            // 
            this.txt_c_fim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_c_fim.Enabled = false;
            this.txt_c_fim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_c_fim.Location = new System.Drawing.Point(285, 491);
            this.txt_c_fim.Name = "txt_c_fim";
            this.txt_c_fim.Size = new System.Drawing.Size(74, 25);
            this.txt_c_fim.TabIndex = 145;
            // 
            // txt_c_ini
            // 
            this.txt_c_ini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_c_ini.Enabled = false;
            this.txt_c_ini.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_ini.Location = new System.Drawing.Point(285, 460);
            this.txt_c_ini.Name = "txt_c_ini";
            this.txt_c_ini.Size = new System.Drawing.Size(74, 25);
            this.txt_c_ini.TabIndex = 144;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label12.Location = new System.Drawing.Point(335, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 150;
            this.label12.Text = "Salário/Hora";
            // 
            // AddCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_c_fim);
            this.Controls.Add(this.btn_c_ini);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_c_fim);
            this.Controls.Add(this.txt_c_ini);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_data_cont);
            this.Controls.Add(this.lbl_calen);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.calen_reg);
            this.Controls.Add(this.calen_cont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_contacto);
            this.Controls.Add(this.lbl_morada);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.txt_cont);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_cancelar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCoordenador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.MonthCalendar calen_reg;
        private System.Windows.Forms.MonthCalendar calen_cont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.Label lbl_morada;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.TextBox txt_cont;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_calen;
        private System.Windows.Forms.Label lbl_data_cont;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Button btn_c_fim;
        private System.Windows.Forms.Button btn_c_ini;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_c_fim;
        private System.Windows.Forms.TextBox txt_c_ini;
        private System.Windows.Forms.Label label12;
    }
}