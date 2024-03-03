namespace A_ADOSMELHORES
{
    partial class MenuGerir
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
            this.btn_menu_sair = new System.Windows.Forms.Button();
            this.btn_func_valid = new System.Windows.Forms.Button();
            this.btn_add_form = new System.Windows.Forms.Button();
            this.btn_atualizar_dados = new System.Windows.Forms.Button();
            this.btn_rem_func = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_menu_sair
            // 
            this.btn_menu_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_menu_sair.Location = new System.Drawing.Point(948, 821);
            this.btn_menu_sair.Name = "btn_menu_sair";
            this.btn_menu_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_menu_sair.TabIndex = 7;
            this.btn_menu_sair.Text = "Voltar";
            this.btn_menu_sair.UseVisualStyleBackColor = false;
            this.btn_menu_sair.Click += new System.EventHandler(this.btn_menu_sair_Click);
            // 
            // btn_func_valid
            // 
            this.btn_func_valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_func_valid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_func_valid.Location = new System.Drawing.Point(150, 600);
            this.btn_func_valid.Name = "btn_func_valid";
            this.btn_func_valid.Size = new System.Drawing.Size(240, 85);
            this.btn_func_valid.TabIndex = 6;
            this.btn_func_valid.Text = "Ver funcionários com contrato válido até à data";
            this.btn_func_valid.UseVisualStyleBackColor = false;
            this.btn_func_valid.Click += new System.EventHandler(this.btn_func_valid_Click);
            // 
            // btn_add_form
            // 
            this.btn_add_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add_form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_form.Location = new System.Drawing.Point(150, 450);
            this.btn_add_form.Name = "btn_add_form";
            this.btn_add_form.Size = new System.Drawing.Size(240, 85);
            this.btn_add_form.TabIndex = 5;
            this.btn_add_form.Text = "Alocar Formador a um Coordenador";
            this.btn_add_form.UseVisualStyleBackColor = false;
            this.btn_add_form.Click += new System.EventHandler(this.btn_add_form_Click);
            // 
            // btn_atualizar_dados
            // 
            this.btn_atualizar_dados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_atualizar_dados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_dados.Location = new System.Drawing.Point(150, 150);
            this.btn_atualizar_dados.Name = "btn_atualizar_dados";
            this.btn_atualizar_dados.Size = new System.Drawing.Size(240, 85);
            this.btn_atualizar_dados.TabIndex = 4;
            this.btn_atualizar_dados.Text = "Atualizar Dados";
            this.btn_atualizar_dados.UseVisualStyleBackColor = false;
            this.btn_atualizar_dados.Click += new System.EventHandler(this.btn_atualizar_rCri_Click);
            // 
            // btn_rem_func
            // 
            this.btn_rem_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rem_func.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rem_func.Location = new System.Drawing.Point(150, 300);
            this.btn_rem_func.Name = "btn_rem_func";
            this.btn_rem_func.Size = new System.Drawing.Size(240, 85);
            this.btn_rem_func.TabIndex = 8;
            this.btn_rem_func.Text = "Remover Funcionário";
            this.btn_rem_func.UseVisualStyleBackColor = false;
            this.btn_rem_func.Click += new System.EventHandler(this.btn_rem_func_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contratos Válidos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // box_info
            // 
            this.box_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.box_info.FormattingEnabled = true;
            this.box_info.HorizontalScrollbar = true;
            this.box_info.Location = new System.Drawing.Point(600, 180);
            this.box_info.Name = "box_info";
            this.box_info.Size = new System.Drawing.Size(335, 355);
            this.box_info.TabIndex = 9;
            this.box_info.Visible = false;
            // 
            // MenuGerir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_info);
            this.Controls.Add(this.btn_rem_func);
            this.Controls.Add(this.btn_menu_sair);
            this.Controls.Add(this.btn_func_valid);
            this.Controls.Add(this.btn_add_form);
            this.Controls.Add(this.btn_atualizar_dados);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGerir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGerir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_sair;
        private System.Windows.Forms.Button btn_func_valid;
        private System.Windows.Forms.Button btn_add_form;
        private System.Windows.Forms.Button btn_atualizar_dados;
        private System.Windows.Forms.Button btn_rem_func;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox box_info;
    }
}