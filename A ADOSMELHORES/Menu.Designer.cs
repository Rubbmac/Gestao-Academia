namespace A_ADOSMELHORES
{
    partial class Menu
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
            this.btn_addFunc = new System.Windows.Forms.Button();
            this.btn_gerFunc = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_menu_sair = new System.Windows.Forms.Button();
            this.box_avisos = new System.Windows.Forms.ListBox();
            this.btn_sim = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gerir_users = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addFunc
            // 
            this.btn_addFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addFunc.Location = new System.Drawing.Point(150, 150);
            this.btn_addFunc.Name = "btn_addFunc";
            this.btn_addFunc.Size = new System.Drawing.Size(240, 85);
            this.btn_addFunc.TabIndex = 0;
            this.btn_addFunc.Text = "Adicionar Funcionário";
            this.btn_addFunc.UseVisualStyleBackColor = false;
            this.btn_addFunc.Click += new System.EventHandler(this.btn_addFunc_Click);
            // 
            // btn_gerFunc
            // 
            this.btn_gerFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_gerFunc.Location = new System.Drawing.Point(150, 300);
            this.btn_gerFunc.Name = "btn_gerFunc";
            this.btn_gerFunc.Size = new System.Drawing.Size(240, 85);
            this.btn_gerFunc.TabIndex = 1;
            this.btn_gerFunc.Text = "Gerir Funcionários";
            this.btn_gerFunc.UseVisualStyleBackColor = false;
            this.btn_gerFunc.Click += new System.EventHandler(this.btn_gerFunc_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_admin.Location = new System.Drawing.Point(150, 450);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(240, 85);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Administração";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_menu_sair
            // 
            this.btn_menu_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_sair.Location = new System.Drawing.Point(948, 823);
            this.btn_menu_sair.Name = "btn_menu_sair";
            this.btn_menu_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_menu_sair.TabIndex = 3;
            this.btn_menu_sair.Text = "Sair";
            this.btn_menu_sair.UseVisualStyleBackColor = false;
            this.btn_menu_sair.Click += new System.EventHandler(this.btn_menu_sair_Click);
            // 
            // box_avisos
            // 
            this.box_avisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_avisos.FormattingEnabled = true;
            this.box_avisos.Location = new System.Drawing.Point(600, 180);
            this.box_avisos.Name = "box_avisos";
            this.box_avisos.Size = new System.Drawing.Size(335, 355);
            this.box_avisos.TabIndex = 4;
            // 
            // btn_sim
            // 
            this.btn_sim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sim.Location = new System.Drawing.Point(12, 823);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(240, 85);
            this.btn_sim.TabIndex = 5;
            this.btn_sim.Text = "Simulador de data (pressione para adicionar 1 dia)";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_data.Enabled = false;
            this.txt_data.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(546, 858);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(110, 35);
            this.txt_data.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 823);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data do Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID | FUNÇÃO | ERRO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_gerir_users
            // 
            this.btn_gerir_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_gerir_users.Location = new System.Drawing.Point(150, 600);
            this.btn_gerir_users.Name = "btn_gerir_users";
            this.btn_gerir_users.Size = new System.Drawing.Size(240, 85);
            this.btn_gerir_users.TabIndex = 9;
            this.btn_gerir_users.Text = "Gerir Users";
            this.btn_gerir_users.UseVisualStyleBackColor = false;
            this.btn_gerir_users.Click += new System.EventHandler(this.btn_gerir_users_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_gerir_users);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_sim);
            this.Controls.Add(this.box_avisos);
            this.Controls.Add(this.btn_menu_sair);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_gerFunc);
            this.Controls.Add(this.btn_addFunc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addFunc;
        private System.Windows.Forms.Button btn_gerFunc;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_menu_sair;
        private System.Windows.Forms.ListBox box_avisos;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gerir_users;
    }
}