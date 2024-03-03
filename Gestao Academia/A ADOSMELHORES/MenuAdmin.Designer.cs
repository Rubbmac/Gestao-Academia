namespace A_ADOSMELHORES
{
    partial class MenuAdmin
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
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_sal_total = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_sal_for = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.box_info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.Location = new System.Drawing.Point(150, 150);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(240, 85);
            this.btn_exportar.TabIndex = 7;
            this.btn_exportar.Text = "Exportar funcionários para Excel";
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_sal_total
            // 
            this.btn_sal_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sal_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sal_total.Location = new System.Drawing.Point(150, 450);
            this.btn_sal_total.Name = "btn_sal_total";
            this.btn_sal_total.Size = new System.Drawing.Size(240, 85);
            this.btn_sal_total.TabIndex = 8;
            this.btn_sal_total.Text = "Calcular total salários para a empresa";
            this.btn_sal_total.UseVisualStyleBackColor = false;
            this.btn_sal_total.Click += new System.EventHandler(this.btn_sal_total_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_sair.Location = new System.Drawing.Point(948, 823);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(240, 85);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_sal_for
            // 
            this.btn_sal_for.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sal_for.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sal_for.Location = new System.Drawing.Point(150, 300);
            this.btn_sal_for.Name = "btn_sal_for";
            this.btn_sal_for.Size = new System.Drawing.Size(240, 85);
            this.btn_sal_for.TabIndex = 10;
            this.btn_sal_for.Text = "Calcular salário para um dado formador";
            this.btn_sal_for.UseVisualStyleBackColor = false;
            this.btn_sal_for.Click += new System.EventHandler(this.btn_sal_for_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Salários";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_info
            // 
            this.box_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.box_info.FormattingEnabled = true;
            this.box_info.Location = new System.Drawing.Point(600, 180);
            this.box_info.Name = "box_info";
            this.box_info.Size = new System.Drawing.Size(335, 355);
            this.box_info.TabIndex = 11;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_ADOSMELHORES.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 920);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_info);
            this.Controls.Add(this.btn_sal_for);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_sal_total);
            this.Controls.Add(this.btn_exportar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_sal_total;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_sal_for;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox box_info;
    }
}