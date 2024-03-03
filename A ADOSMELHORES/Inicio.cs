using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace A_ADOSMELHORES
{
    public partial class Inicio : Form
    {
        public Empresa emp = new Empresa();
        public Inicio(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_show_pass.Visible = true;
            lbl_user.Visible = true;
            lbl_pass.Visible = true;
            txt_user.Visible = true;
            txt_pass.Visible = true;
            btn_entrar.Visible = true;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            try
            {
                foreach (Users u in emp.ListUsers)
                {
                    if (txt_user.Text == u.Username && txt_pass.Text == u.Password)
                    {
                        emp.User = u.Username;
                        this.Hide();
                        Menu m = new Menu(emp);
                        m.Show();
                        valido = true;
                    }
                }
                if (!valido) { throw new Exception(); }
            }
            catch (Exception)
            {
                MessageBox.Show("Credênciais inválidas");
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            //esconde o input na password
            txt_pass.PasswordChar = '*';
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            btn_show_pass.Visible = false;
            lbl_user.Visible = false;
            lbl_pass.Visible = false;
            txt_user.Visible = false;
            txt_pass.Visible = false;
            btn_entrar.Visible = false;
            btn_start.Visible = false;
            MessageBox.Show("Melhores cumprimentos:\nBruno João\nMarcelo Silva\nRuben Machado");
            Application.Exit();
        }

        private void btn_show_pass_Click(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '\0';
            btn_show_pass.Visible = false;
            btn_hide_pass.Visible = true;
        }

        private void btn_hide_pass_Click(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
            btn_show_pass.Visible = true;
            btn_hide_pass.Visible = false;
        }
    }
}