namespace A_ADOSMELHORES
{
    partial class GerirUsers
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
            this.btn_remover_user = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_alt_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menu_sair
            // 
            this.btn_menu_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_menu_sair.Location = new System.Drawing.Point(932, 823);
            this.btn_menu_sair.Name = "btn_menu_sair";
            this.btn_menu_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_menu_sair.TabIndex = 6;
            this.btn_menu_sair.Text = "Voltar";
            this.btn_menu_sair.UseVisualStyleBackColor = false;
            this.btn_menu_sair.Click += new System.EventHandler(this.btn_menu_sair_Click);
            // 
            // btn_remover_user
            // 
            this.btn_remover_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_remover_user.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover_user.Location = new System.Drawing.Point(150, 450);
            this.btn_remover_user.Name = "btn_remover_user";
            this.btn_remover_user.Size = new System.Drawing.Size(240, 85);
            this.btn_remover_user.TabIndex = 5;
            this.btn_remover_user.Text = "Remover User";
            this.btn_remover_user.UseVisualStyleBackColor = false;
            this.btn_remover_user.Visible = false;
            this.btn_remover_user.Click += new System.EventHandler(this.btn_remover_user_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.Location = new System.Drawing.Point(150, 300);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(240, 85);
            this.btn_addUser.TabIndex = 4;
            this.btn_addUser.Text = "Adicionar User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Visible = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_alt_pass
            // 
            this.btn_alt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_alt_pass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alt_pass.Location = new System.Drawing.Point(150, 150);
            this.btn_alt_pass.Name = "btn_alt_pass";
            this.btn_alt_pass.Size = new System.Drawing.Size(240, 85);
            this.btn_alt_pass.TabIndex = 7;
            this.btn_alt_pass.Text = "Alterar Password";
            this.btn_alt_pass.UseVisualStyleBackColor = false;
            this.btn_alt_pass.Click += new System.EventHandler(this.btn_alt_pass_Click);
            // 
            // GerirUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.btn_alt_pass);
            this.Controls.Add(this.btn_menu_sair);
            this.Controls.Add(this.btn_remover_user);
            this.Controls.Add(this.btn_addUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu_sair;
        private System.Windows.Forms.Button btn_remover_user;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_alt_pass;
    }
}