namespace A_ADOSMELHORES
{
    partial class AlocarFormador
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_f_conf = new System.Windows.Forms.Button();
            this.lbl_f_indique = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.ListBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_validar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_coordenador = new System.Windows.Forms.Label();
            this.lbl_f_id = new System.Windows.Forms.Label();
            this.lbl_id_generico = new System.Windows.Forms.Label();
            this.box_coord = new System.Windows.Forms.ComboBox();
            this.box_form = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_sair.Location = new System.Drawing.Point(948, 821);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(240, 87);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_f_conf
            // 
            this.btn_f_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_f_conf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f_conf.Location = new System.Drawing.Point(412, 657);
            this.btn_f_conf.Name = "btn_f_conf";
            this.btn_f_conf.Size = new System.Drawing.Size(83, 29);
            this.btn_f_conf.TabIndex = 88;
            this.btn_f_conf.Text = "Confirmar";
            this.btn_f_conf.UseVisualStyleBackColor = false;
            this.btn_f_conf.Visible = false;
            this.btn_f_conf.Click += new System.EventHandler(this.btn_f_conf_Click);
            // 
            // lbl_f_indique
            // 
            this.lbl_f_indique.AutoSize = true;
            this.lbl_f_indique.BackColor = System.Drawing.Color.White;
            this.lbl_f_indique.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_indique.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_f_indique.Location = new System.Drawing.Point(128, 589);
            this.lbl_f_indique.Name = "lbl_f_indique";
            this.lbl_f_indique.Size = new System.Drawing.Size(577, 30);
            this.lbl_f_indique.TabIndex = 85;
            this.lbl_f_indique.Text = "Indique o ID do formador a adicionar à lista do coordenador:";
            this.lbl_f_indique.Visible = false;
            // 
            // txt_info
            // 
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.FormattingEnabled = true;
            this.txt_info.ItemHeight = 21;
            this.txt_info.Location = new System.Drawing.Point(173, 307);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(388, 189);
            this.txt_info.TabIndex = 84;
            this.txt_info.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_id.Location = new System.Drawing.Point(254, 120);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(77, 13);
            this.lbl_id.TabIndex = 82;
            this.lbl_id.Text = "Valor inválido";
            this.lbl_id.Visible = false;
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_validar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_validar.Location = new System.Drawing.Point(412, 89);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 29);
            this.btn_validar.TabIndex = 81;
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
            this.label2.TabIndex = 79;
            this.label2.Text = "ID:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_limpar.Location = new System.Drawing.Point(512, 88);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpar.TabIndex = 92;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_coordenador
            // 
            this.lbl_coordenador.AutoSize = true;
            this.lbl_coordenador.BackColor = System.Drawing.Color.White;
            this.lbl_coordenador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coordenador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_coordenador.Location = new System.Drawing.Point(169, 274);
            this.lbl_coordenador.Name = "lbl_coordenador";
            this.lbl_coordenador.Size = new System.Drawing.Size(191, 21);
            this.lbl_coordenador.TabIndex = 95;
            this.lbl_coordenador.Text = "Coordenador selecionado:";
            this.lbl_coordenador.Visible = false;
            // 
            // lbl_f_id
            // 
            this.lbl_f_id.AutoSize = true;
            this.lbl_f_id.BackColor = System.Drawing.Color.White;
            this.lbl_f_id.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_f_id.Location = new System.Drawing.Point(254, 689);
            this.lbl_f_id.Name = "lbl_f_id";
            this.lbl_f_id.Size = new System.Drawing.Size(77, 13);
            this.lbl_f_id.TabIndex = 99;
            this.lbl_f_id.Text = "Valor inválido";
            this.lbl_f_id.Visible = false;
            // 
            // lbl_id_generico
            // 
            this.lbl_id_generico.AutoSize = true;
            this.lbl_id_generico.BackColor = System.Drawing.Color.White;
            this.lbl_id_generico.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_generico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_id_generico.Location = new System.Drawing.Point(128, 653);
            this.lbl_id_generico.Name = "lbl_id_generico";
            this.lbl_id_generico.Size = new System.Drawing.Size(39, 30);
            this.lbl_id_generico.TabIndex = 98;
            this.lbl_id_generico.Text = "ID:";
            this.lbl_id_generico.Visible = false;
            // 
            // box_coord
            // 
            this.box_coord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_coord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_coord.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.box_coord.FormattingEnabled = true;
            this.box_coord.Location = new System.Drawing.Point(173, 88);
            this.box_coord.Name = "box_coord";
            this.box_coord.Size = new System.Drawing.Size(233, 29);
            this.box_coord.TabIndex = 100;
            // 
            // box_form
            // 
            this.box_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_form.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.box_form.FormattingEnabled = true;
            this.box_form.Location = new System.Drawing.Point(173, 657);
            this.box_form.Name = "box_form";
            this.box_form.Size = new System.Drawing.Size(233, 29);
            this.box_form.TabIndex = 101;
            this.box_form.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(173, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 102;
            this.label1.Text = "Coordenador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AlocarFormador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_form);
            this.Controls.Add(this.box_coord);
            this.Controls.Add(this.lbl_f_id);
            this.Controls.Add(this.lbl_id_generico);
            this.Controls.Add(this.lbl_coordenador);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_f_conf);
            this.Controls.Add(this.lbl_f_indique);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlocarFormador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlocarFormador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_f_conf;
        private System.Windows.Forms.Label lbl_f_indique;
        private System.Windows.Forms.ListBox txt_info;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_coordenador;
        private System.Windows.Forms.Label lbl_f_id;
        private System.Windows.Forms.Label lbl_id_generico;
        private System.Windows.Forms.ComboBox box_coord;
        private System.Windows.Forms.ComboBox box_form;
        private System.Windows.Forms.Label label1;
    }
}