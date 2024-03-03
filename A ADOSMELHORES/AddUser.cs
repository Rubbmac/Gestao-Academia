using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ADOSMELHORES
{
    public partial class AddUser : Form
    {
        public Empresa emp = new Empresa();
        public AddUser(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerirUsers gu = new GerirUsers(emp);
            gu.Show();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            bool valido = true;
            lbl_pass.Visible = false;
            lbl_user.Visible = false;
            if (txt_user.Text == string.Empty)
            {
                lbl_user.Text = "Obrigatório";
                lbl_user.ForeColor = Color.Red;
                lbl_user.Visible = true;
                valido = false;
            }
            if (txt_pass.Text == string.Empty)
            {
                lbl_pass.Text = "Obrigatório";
                lbl_pass.ForeColor = Color.Red;
                lbl_pass.Visible = true;
                valido = false;
            }

            foreach (Users users in emp.ListUsers)
            {
                if (users.Username == txt_user.Text)
                {
                    lbl_user.Text = "Username não disponível";
                    lbl_user.ForeColor = Color.Red;
                    lbl_user.Visible = true;
                    valido = false;
                }
            }

            if (valido)
            {
                if (chk_admin.Checked)
                {
                    emp.AddUser(txt_user.Text, txt_pass.Text);
                    emp.AddAdmin(txt_user.Text, txt_pass.Text);
                    txt_user.Clear();
                    txt_pass.Clear();
                    MessageBox.Show("User adicionado com sucesso!");
                }
                else
                {
                    emp.AddUser(txt_user.Text, txt_pass.Text);
                    txt_user.Clear();
                    txt_pass.Clear();
                    MessageBox.Show("User adicionado com sucesso!");
                }
            }

        }
    }
}
