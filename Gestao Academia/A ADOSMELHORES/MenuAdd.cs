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
    public partial class MenuAdd : Form
    {
        //Classe empresa com toda a informação
        public Empresa emp=new Empresa();
        public MenuAdd(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_menuAdd_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(emp);
            menu.Show();
        }

        private void btn_addCoo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCoordenador addCoordenador = new AddCoordenador(emp);
            addCoordenador.Show();
        }

        private void btn_addDir_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDiretor addDiretor = new AddDiretor(emp);
            addDiretor.Show();
        }

        private void btn_addFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFormador addFormador = new AddFormador(emp);
            addFormador.Show();
        }

        private void btn_addSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSecretaria addSecretaria = new AddSecretaria(emp);
            addSecretaria.Show();
        }
    }
}
