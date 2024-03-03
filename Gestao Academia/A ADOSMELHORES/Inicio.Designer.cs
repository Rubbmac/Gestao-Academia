namespace A_ADOSMELHORES
{
    partial class Inicio
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_show_pass = new System.Windows.Forms.Button();
            this.btn_hide_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_start.Location = new System.Drawing.Point(568, 484);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(85, 36);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(459, 511);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(300, 43);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Visible = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(524, 443);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(235, 36);
            this.txt_user.TabIndex = 2;
            this.txt_user.Visible = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(524, 478);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(235, 34);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.Visible = false;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(459, 443);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(65, 35);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User:";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_user.Visible = false;
            // 
            // lbl_pass
            // 
            this.lbl_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(459, 477);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(65, 35);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Pass:";
            this.lbl_pass.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_pass.Visible = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sair.Location = new System.Drawing.Point(1114, 872);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(85, 36);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_show_pass
            // 
            this.btn_show_pass.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.show_eye;
            this.btn_show_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_pass.FlatAppearance.BorderSize = 0;
            this.btn_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_pass.ForeColor = System.Drawing.Color.Transparent;
            this.btn_show_pass.Location = new System.Drawing.Point(717, 478);
            this.btn_show_pass.Name = "btn_show_pass";
            this.btn_show_pass.Size = new System.Drawing.Size(39, 33);
            this.btn_show_pass.TabIndex = 7;
            this.btn_show_pass.UseVisualStyleBackColor = true;
            this.btn_show_pass.Visible = false;
            this.btn_show_pass.Click += new System.EventHandler(this.btn_show_pass_Click);
            // 
            // btn_hide_pass
            // 
            this.btn_hide_pass.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.hide_eye;
            this.btn_hide_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hide_pass.FlatAppearance.BorderSize = 0;
            this.btn_hide_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide_pass.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hide_pass.Location = new System.Drawing.Point(717, 478);
            this.btn_hide_pass.Name = "btn_hide_pass";
            this.btn_hide_pass.Size = new System.Drawing.Size(39, 33);
            this.btn_hide_pass.TabIndex = 8;
            this.btn_hide_pass.UseVisualStyleBackColor = true;
            this.btn_hide_pass.Visible = false;
            this.btn_hide_pass.Click += new System.EventHandler(this.btn_hide_pass_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.ADM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_hide_pass);
            this.Controls.Add(this.btn_show_pass);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_show_pass;
        private System.Windows.Forms.Button btn_hide_pass;
    }
}