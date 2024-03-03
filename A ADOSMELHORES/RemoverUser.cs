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
    public partial class RemoverUser : Form
    {
        public Empresa emp = new Empresa();
        public RemoverUser(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                if (txt_user.Text == emp.User)
                {
                    throw new ArgumentException();
                }

                if (emp.ListUsers.Find(x => x.Username == txt_user.Text) != null)
                {
                    Users user = emp.ListUsers.Find(x => x.Username == txt_user.Text);
                    emp.ListUsers.Remove(user);
                    lbl_user.Visible = false;
                    foreach (Users admin in emp.ListAdmins)
                    {
                        if (admin.Username == txt_user.Text)
                        {
                            emp.ListAdmins.Remove(admin);
                        }
                    }
                    MessageBox.Show("User removido com sucesso!");
                    txt_user.Clear();

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                lbl_user.Text = "Obrigatório";
                lbl_user.ForeColor = Color.Red;
                lbl_user.Visible = true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("O user não pode remover a própria conta");
            }
            catch (Exception)
            {
                lbl_user.Text = "Username inválido";
                lbl_user.ForeColor = Color.Red;
                lbl_user.Visible = true;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerirUsers gu = new GerirUsers(emp);
            gu.Show();
        }
    }
}
