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

    public partial class Menu : Form
    {
        //Classe empresa com toda a informação
        public Empresa emp = new Empresa();
        public Menu(Empresa emp)
        {
            InitializeComponent();
            box_avisos.Items.Clear();
            txt_data.Text = DateTime.Now.ToShortDateString();
            DateTime dt = DateTime.Parse(txt_data.Text);
            string aviso = "Nenhum aviso a relatar";
            string avisoRegCriminal = "", avisoFimContrato = "", funcao = "";
            for (int i = 0; i < emp.IdGlobal; i++)
            {
                avisoRegCriminal = "";
                avisoFimContrato = "";
                funcao = "";
                if (emp.ListDiretores.Find(f => f.ID == i) != null)
                {
                    Diretores alvo = emp.ListDiretores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";

                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListSecretaria.Find(f => f.ID == i) != null)
                {
                    Secretaria alvo = emp.ListSecretaria.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListCoordenadores.Find(f => f.ID == i) != null)
                {
                    Coordenadores alvo = emp.ListCoordenadores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListFormadores.Find(f => f.ID == i) != null)
                {
                    Formadores alvo = emp.ListFormadores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (avisoRegCriminal != "" || avisoFimContrato != "")
                {
                    box_avisos.Items.Add($"ID: {i}; Função: {funcao}; {avisoRegCriminal} {avisoFimContrato}");
                }
            }
            if (box_avisos.Items.Count == 0)
            {
                box_avisos.Items.Add(aviso);
            }
            this.emp = emp;
        }

        private void btn_addFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdd ma = new MenuAdd(emp);
            ma.Show();
        }

        private void btn_menu_sair_Click(object sender, EventArgs e)
        {

            this.Hide();
            Inicio inicio = new Inicio(emp);
            inicio.Show();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            box_avisos.Items.Clear();
            DateTime dt = DateTime.Parse(txt_data.Text);
            dt = dt.AddDays(1);
            txt_data.Text = dt.ToShortDateString();
            string aviso = "Nenhum aviso a relatar";
            string avisoRegCriminal = "", avisoFimContrato = "", funcao = "";
            for (int i = 0; i < emp.IdGlobal; i++)
            {
                avisoRegCriminal = "";
                avisoFimContrato = "";
                funcao = "";
                if (emp.ListDiretores.Find(f => f.ID == i) != null)
                {
                    Diretores alvo = emp.ListDiretores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";

                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListSecretaria.Find(f => f.ID == i) != null)
                {
                    Secretaria alvo = emp.ListSecretaria.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListCoordenadores.Find(f => f.ID == i) != null)
                {
                    Coordenadores alvo = emp.ListCoordenadores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (emp.ListFormadores.Find(f => f.ID == i) != null)
                {
                    Formadores alvo = emp.ListFormadores.Find(f => f.ID == i);
                    funcao = alvo.Funcao;
                    if (alvo.RegCriminal.AddDays(90) < dt)
                    {
                        avisoRegCriminal = "Registo Criminal Expirado";
                    }
                    if (alvo.FimContrato < dt)
                    {
                        avisoFimContrato = "Contrato Expirado";
                    }
                }
                if (avisoRegCriminal != "" || avisoFimContrato != "")
                {
                    box_avisos.Items.Add($"ID: {i}; Função: {funcao}; {avisoRegCriminal} {avisoFimContrato}");
                }
            }
            if (box_avisos.Items.Count == 0)
            {
                box_avisos.Items.Add(aviso);
            }

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin(emp);
            this.Hide();
            ma.Show();
        }

        private void btn_gerFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuGerir menu = new MenuGerir(emp);
            menu.Show();
        }

        private void btn_gerir_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerirUsers gu = new GerirUsers(emp);
            gu.Show();
        }
    }
}
