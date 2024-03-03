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
    public partial class MenuGerir : Form
    {
        public Empresa emp = new Empresa();
        public MenuGerir(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_menu_sair_Click(object sender, EventArgs e)
        {
            Menu menu= new Menu(emp);
            this.Hide();
            menu.Show();
        }

        private void btn_atualizar_rCri_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAtualizaDados dados = new MenuAtualizaDados(emp);
            dados.Show();
        }

        private void btn_add_form_Click(object sender, EventArgs e)
        {
            AlocarFormador alocarFormador = new AlocarFormador(emp);
            this.Hide();
            alocarFormador.Show();
        }

        private void btn_func_valid_Click(object sender, EventArgs e)
        {
            box_info.Items.Clear();
            bool valido = false;
            for (int i = 0; i < emp.IdGlobal; i++)
            {
                if (emp.ListDiretores.Find(x => x.ID == i) != null)
                {
                    Diretores d = emp.ListDiretores.Find(x => x.ID == i);
                    if (d.FimContrato >= DateTime.Now)
                    {
                        box_info.Items.Add($"ID: {d.ID} Nome:  {d.Nome} Função:  {d.Funcao} Fim do Contrato: {d.FimContrato.ToShortDateString()}");
                        valido = true;
                    }
                }
                else if (emp.ListCoordenadores.Find(x => x.ID == i) != null)
                {
                    Coordenadores c = emp.ListCoordenadores.Find(x => x.ID == i);
                    if (c.FimContrato >= DateTime.Now)
                    {
                        box_info.Items.Add($"ID: {c.ID} Nome: {c.Nome} Função: {c.Funcao} Fim do Contrato: {c.FimContrato.ToShortDateString()}");
                        valido = true;
                    }
                }
                else if (emp.ListSecretaria.Find(x => x.ID == i) != null)
                {
                    Secretaria s = emp.ListSecretaria.Find(x => x.ID == i);
                    if (s.FimContrato >= DateTime.Now)
                    {
                        box_info.Items.Add($"ID: {s.ID} Nome: {s.Nome} Função: {s.Funcao} Fim do Contrato: {s.FimContrato.ToShortDateString()}");
                        valido = true;
                    }
                }
                else if (emp.ListFormadores.Find(x => x.ID == i) != null)
                {
                    Formadores f = emp.ListFormadores.Find(x => x.ID == i);
                    if (f.FimContrato >= DateTime.Now)
                    {
                        box_info.Items.Add($"ID: {f.ID} Nome: {f.Nome} Função: {f.Funcao} Fim do Contrato: {f.FimContrato.ToShortDateString()}");
                        valido = true;
                    }
                }
                if (valido)
                {
                    label2.Visible = true;
                    box_info.Visible = true;
                }
            }
        }

        private void btn_rem_func_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveFuncionario rf = new RemoveFuncionario(emp);
            rf.Show();
        }
    }
}
