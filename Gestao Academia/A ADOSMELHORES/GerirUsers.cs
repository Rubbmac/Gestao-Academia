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
    public partial class GerirUsers : Form
    {
        public Empresa emp = new Empresa();
        public GerirUsers(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
            foreach (Users user in emp.ListAdmins)
            {
                if (user.Username == emp.User)
                {
                    btn_addUser.Visible = true;
                    btn_remover_user.Visible = true;
                }
            }
        }

        private void btn_menu_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(emp);
            menu.Show();
        }

        private void btn_remover_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoverUser ru = new RemoverUser(emp);
            ru.Show();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser au = new AddUser(emp);
            au.Show();
        }

        private void btn_alt_pass_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlterarPassword ap = new AlterarPassword(emp);
            ap.Show();
        }
    }
}
