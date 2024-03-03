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
    public partial class AlterarPassword : Form
    {
        public Empresa emp = new Empresa();
        public string User { get; set; }
        public AlterarPassword(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
            txt_user.Text = emp.User;
            txt_user.Enabled = false;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            bool valido = false;

            try
            {
                if (txt_pass.Text == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    foreach (Users user in emp.ListUsers)
                    {
                        if (user.Username == txt_user.Text && user.Password == txt_pass.Text)
                        {
                            if (txt_pass.Text == txt_nova_pass.Text)
                            {
                                throw new ArgumentException();
                            }
                            else if (txt_nova_pass.Text == txt_conf_pass.Text)
                            {
                                lbl_nova_pass.Visible = false;
                                lbl_pass.Visible = false;
                                user.Password = txt_conf_pass.Text;
                                valido = true;
                                MessageBox.Show("Password alterada com sucesso!");
                                if (emp.ListAdmins.Find(x => x.Username == txt_user.Text) != null)
                                {
                                    emp.ListAdmins.Find(x => x.Username == txt_user.Text).Password = txt_conf_pass.Text;
                                }
                                txt_pass.Text = string.Empty;
                                txt_nova_pass.Text = string.Empty;
                                txt_conf_pass.Text = string.Empty;
                            }
                            else
                            {
                                throw new ArgumentException();
                            }
                        }
                    }
                    if (!valido)
                    {
                        throw new Exception();
                    }

                }
            }
            catch (ArgumentNullException)
            {
                lbl_pass.Visible = true;
                lbl_pass.Text = "Obrigatório!";
                lbl_pass.ForeColor = Color.Red;
            }
            catch (ArgumentException)
            {
                if (txt_pass.Text == txt_nova_pass.Text)
                {
                    lbl_pass.Visible = true;
                    lbl_pass.Text = "Nova password igual à antiga!";
                    lbl_pass.ForeColor = Color.Red;
                }
                else
                {
                    lbl_pass.Visible = false;
                    lbl_nova_pass.Visible = true;
                    lbl_nova_pass.Text = "As Passwords não coincidem!";
                    lbl_nova_pass.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                lbl_pass.Visible = true;
                lbl_pass.Text = "Password Errada!";
                lbl_pass.ForeColor = Color.Red;
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
