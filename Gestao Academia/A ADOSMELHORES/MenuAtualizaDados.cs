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
    public partial class MenuAtualizaDados : Form
    {
        public Empresa emp = new Empresa();
        public MenuAtualizaDados(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_atualizar_morada_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizaMorada am = new AtualizaMorada(emp);
            am.Show();
        }

        private void btn_atualizar_contacto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizarContacto ac = new AtualizarContacto(emp);
            ac.Show();
        }  

        private void btn_atualizar_regCrime_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizaRegCrim arc = new AtualizaRegCrim(emp);
            arc.Show();
        }
        private void btn_renovar_contrato_Click(object sender, EventArgs e)
        {
            RenovarContrato rc = new RenovarContrato(emp);
            this.Hide();
            rc.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            MenuGerir gerir = new MenuGerir(emp);
            this.Hide();
            gerir.Show();
        }
    }
}
