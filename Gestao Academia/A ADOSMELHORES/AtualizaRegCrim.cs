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
    public partial class AtualizaRegCrim : Form
    {
        public Empresa emp = new Empresa();
        public string Funcao { get; set; }
        public AtualizaRegCrim(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        
        private void btn_validar_Click(object sender, EventArgs e)
        {
            
            // verificar se o numero inserido no ID é inteiro
            try
            {
                int x;
                x = int.Parse(txt_id.Text);
                lbl_id.Visible = false;
            }
            catch (Exception)
            {
                lbl_id.Visible = true;
                lbl_id.ForeColor = Color.Red;
            }

            // verificar se o ID inserido está presente na list da funçao inserida
            try
            {
                bool valido = false;
                txt_info.Items.Clear();

                foreach (Diretores d in emp.ListDiretores)
                {
                    if (d.ID == int.Parse(txt_id.Text))
                    {
                        txt_id.Enabled = false;
                        valido = true;
                        txt_info.Items.Add("ID: " + d.ID);
                        txt_info.Items.Add("Nome: " + d.Nome);
                        txt_info.Items.Add("Função: " + d.Funcao);
                        txt_info.Items.Add("Morada: " + d.Morada);
                        txt_info.Items.Add("Contacto: " + d.Contacto);
                        txt_info.Items.Add("Salário/hora: " + d.Salario);
                        txt_info.Items.Add("Início do contrato: " + d.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + d.FimContrato.ToShortDateString());
                        txt_data_antiga.Text = d.RegCriminal.ToShortDateString();
                        Funcao = d.Funcao;
                    }
                }

                foreach (Coordenadores c in emp.ListCoordenadores)
                {
                    if (c.ID == int.Parse(txt_id.Text))
                    {
                        txt_id.Enabled = false;
                        valido = true;
                        txt_info.Items.Add("ID: " + c.ID);
                        txt_info.Items.Add("Nome: " + c.Nome);
                        txt_info.Items.Add("Função: " + c.Funcao);
                        txt_info.Items.Add("Morada: " + c.Morada);
                        txt_info.Items.Add("Contacto: " + c.Contacto);
                        txt_info.Items.Add("Salário/hora: " + c.Salario);
                        txt_info.Items.Add("Início do contrato: " + c.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + c.FimContrato.ToShortDateString());
                        txt_data_antiga.Text = c.RegCriminal.ToShortDateString();
                        Funcao = c.Funcao;
                    }
                }

                foreach (Formadores f in emp.ListFormadores)
                {
                    if (f.ID == int.Parse(txt_id.Text))
                    {
                        txt_id.Enabled = false;
                        valido = true;
                        txt_info.Items.Add("ID: " + f.ID);
                        txt_info.Items.Add("Nome: " + f.Nome);
                        txt_info.Items.Add("Função: " + f.Funcao);
                        txt_info.Items.Add("Morada: " + f.Morada);
                        txt_info.Items.Add("Contacto: " + f.Contacto);
                        txt_info.Items.Add("Salário/hora: " + f.Salario);
                        txt_info.Items.Add("Início do contrato: " + f.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + f.FimContrato.ToShortDateString());
                        txt_data_antiga.Text = f.RegCriminal.ToShortDateString();
                        Funcao = f.Funcao;
                    }
                }

                foreach (Secretaria s in emp.ListSecretaria)
                {
                    if (s.ID == int.Parse(txt_id.Text))
                    {
                        txt_id.Enabled = false;
                        valido = true;
                        txt_info.Items.Add("ID: " + s.ID);
                        txt_info.Items.Add("Nome: " + s.Nome);
                        txt_info.Items.Add("Função: " + s.Funcao);
                        txt_info.Items.Add("Morada: " + s.Morada);
                        txt_info.Items.Add("Contacto: " + s.Contacto);
                        txt_info.Items.Add("Salário/hora: " + s.Salario);
                        txt_info.Items.Add("Início do contrato: " + s.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + s.FimContrato.ToShortDateString());
                        txt_data_antiga.Text = s.RegCriminal.ToShortDateString();
                        Funcao = s.Funcao;
                    }
                }
            
                if (!valido)
                {
                    throw new Exception();
                }
                else
                {
                    calen_reg.Visible = true;
                    lbl_calen.Visible = true;
                    btn_c_valid.Visible = true;
                    lbl_data_antiga.Visible = true;
                    txt_data_antiga.Visible = true;
                    txt_conf.Visible = true;
                    lbl_conf.Visible = true;
                    btn_conf.Visible = true;
                }
            }
            catch (Exception)
            {
                lbl_id.ForeColor = Color.Red;
                lbl_id.Visible = true;
            }
        }

        private void btn_c_valid_Click(object sender, EventArgs e)
        {

            //verifica se a data nova do registo criminal é válida (data atual ou mais antiga) e se é posterior à data do registo criminal do funcionário
            try
            {
                if (calen_reg.SelectionStart > DateTime.Now || calen_reg.SelectionStart <= DateTime.Parse(txt_data_antiga.Text))
                {
                    throw new Exception();
                }
                txt_conf.Text = calen_reg.SelectionStart.ToShortDateString();
                btn_conf.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Data inválida.");
            }
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            

            if (Funcao == "Diretor")
            {
                emp.ListDiretores.Find(d => d.ID == int.Parse(txt_id.Text)).RegCriminal = DateTime.Parse(txt_conf.Text);
            }
            else if (Funcao == "Coordenador")
            {
                emp.ListCoordenadores.Find(c => c.ID == int.Parse(txt_id.Text)).RegCriminal = DateTime.Parse(txt_conf.Text);
            }
            else if (Funcao == "Formador")
            {
                emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text)).RegCriminal = DateTime.Parse(txt_conf.Text);
            }
            else
            {
                emp.ListSecretaria.Find(s => s.ID == int.Parse(txt_id.Text)).RegCriminal = DateTime.Parse(txt_conf.Text);
            }
            MessageBox.Show("Sucesso!");
            txt_conf.Text = string.Empty;
            txt_id.Text = string.Empty;
            txt_id.Enabled = true;
            txt_info.Items.Clear();
            calen_reg.Visible = false;
            lbl_calen.Visible = false;
            btn_c_valid.Visible = false;
            lbl_data_antiga.Visible = false;
            txt_data_antiga.Visible = false;
            txt_conf.Visible = false;
            lbl_conf.Visible = false;
            btn_conf.Visible = false;
            btn_conf.Enabled = false;

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_conf.Text = string.Empty;
            txt_id.Text = string.Empty;
            txt_id.Enabled = true;            
            txt_info.Items.Clear();
            calen_reg.Visible = false;
            lbl_calen.Visible = false;
            btn_c_valid.Visible = false;
            lbl_data_antiga.Visible = false;
            txt_data_antiga.Visible = false;
            txt_conf.Visible = false;
            lbl_conf.Visible = false;
            btn_conf.Visible = false;
            btn_conf.Enabled = false;
        }

        private void btn_menuAdd_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAtualizaDados ad = new MenuAtualizaDados(emp);
            ad.Show();
        }

    }
}
