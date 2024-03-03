using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ADOSMELHORES
{
    public partial class RenovarContrato : Form
    {
        public Empresa emp = new Empresa();
        public string Funcao { get; set; }
        public RenovarContrato(Empresa emp)
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
                        Funcao = s.Funcao;
                    }
                }

                if (!valido)
                {
                    throw new Exception();
                }
                else
                {
                    calen_renova_contrato.Visible = true;
                    lbl_calen.Visible = true;
                    txt_inicio_contrato.Visible = true;
                    txt_fim_contrato.Visible = true;
                    btn_conf.Visible = true;
                    btn_c_ini.Visible = true;   
                    btn_c_fim.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                }
            }
            catch (Exception)
            {
                lbl_id.ForeColor = Color.Red;
                lbl_id.Visible = true;
            }
        }

        private void btn_menuAdd_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAtualizaDados mad = new MenuAtualizaDados(emp);
            mad.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_id.Enabled = true;
            txt_info.Items.Clear();
            calen_renova_contrato.Visible = false;
            lbl_calen.Visible = false;           
            txt_inicio_contrato.Visible = false;
            txt_fim_contrato.Visible = false;
            btn_conf.Visible = false;
            btn_c_ini.Visible = false;
            btn_c_fim.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            txt_fim_contrato.Text = string.Empty;
            txt_inicio_contrato.Text = string.Empty;
        }

        private void btn_c_ini_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Diretores d in emp.ListDiretores)
                {
                    if (d.ID == int.Parse(txt_id.Text))
                    {
                        if (calen_renova_contrato.SelectionStart < DateTime.Today)
                        {
                            throw new ArgumentException();
                        }
                        if (d.FimContrato < calen_renova_contrato.SelectionStart)
                        {
                            txt_inicio_contrato.Text = calen_renova_contrato.SelectionStart.ToShortDateString();
                        }
                        else 
                        {
                            throw new Exception();
                        }
                    }
                }
                foreach (Coordenadores c in emp.ListCoordenadores)
                {
                    if (c.ID == int.Parse(txt_id.Text))
                    {
                        if (calen_renova_contrato.SelectionStart < DateTime.Today)
                        {
                            throw new ArgumentException();
                        }
                        if (c.FimContrato < calen_renova_contrato.SelectionStart)
                        {
                            txt_inicio_contrato.Text = calen_renova_contrato.SelectionStart.ToShortDateString();
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                foreach (Formadores f in emp.ListFormadores)
                {
                    if (f.ID == int.Parse(txt_id.Text))
                    {
                        if (calen_renova_contrato.SelectionStart < DateTime.Today)
                        {
                            throw new ArgumentException();
                        }
                        else if (f.FimContrato < calen_renova_contrato.SelectionStart)
                        {
                            txt_inicio_contrato.Text = calen_renova_contrato.SelectionStart.ToShortDateString();
                        }                        
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                foreach (Secretaria s in emp.ListSecretaria)
                {
                    if (s.ID == int.Parse(txt_id.Text))
                    {
                        if (calen_renova_contrato.SelectionStart < DateTime.Today)
                        {
                            throw new ArgumentException();
                        }
                        else if (calen_renova_contrato.SelectionStart > s.FimContrato)
                        {
                            txt_inicio_contrato.Text = calen_renova_contrato.SelectionStart.ToShortDateString();
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro! Data selecionada tem de ser superior ao dia atual!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Data selecionada anterior ao fim do contrato anterior!");
            }
            
        }

        private void btn_c_fim_Click(object sender, EventArgs e)
        {            
            try
            {
                if (txt_inicio_contrato.Text == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                if (DateTime.Parse(txt_inicio_contrato.Text) <= calen_renova_contrato.SelectionStart)
                {
                    txt_fim_contrato.Text = calen_renova_contrato.SelectionStart.ToShortDateString();
                    btn_conf.Enabled = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Insira primeiro a data de inicio");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! A data do fim de contrato tem de ser maior do que a data de inicio!");
            }
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            foreach (Diretores d in emp.ListDiretores)
            {
                if (d.ID == int.Parse(txt_id.Text))
                {
                    d.IniContrato = DateTime.Parse(txt_inicio_contrato.Text);
                    d.FimContrato = DateTime.Parse(txt_fim_contrato.Text);
                    MessageBox.Show("Contrato renovado com sucesso!");
                }
            }
            foreach (Coordenadores c in emp.ListCoordenadores)
            {
                if (c.ID == int.Parse(txt_id.Text))
                {
                    c.IniContrato = DateTime.Parse(txt_inicio_contrato.Text);
                    c.FimContrato = DateTime.Parse(txt_fim_contrato.Text);
                    MessageBox.Show("Contrato renovado com sucesso!");
                }
            }
            foreach (Formadores f in emp.ListFormadores)
            {
                if (f.ID == int.Parse(txt_id.Text))
                {
                    f.IniContrato = DateTime.Parse(txt_inicio_contrato.Text);
                    f.FimContrato = DateTime.Parse(txt_fim_contrato.Text);
                    MessageBox.Show("Contrato renovado com sucesso!");
                }
            }
            foreach (Secretaria s in emp.ListSecretaria)
            {
                if (s.ID == int.Parse(txt_id.Text))
                {
                    s.IniContrato = DateTime.Parse(txt_inicio_contrato.Text);
                    s.FimContrato = DateTime.Parse(txt_fim_contrato.Text);
                    MessageBox.Show("Contrato renovado com sucesso!");
                }
            }
            txt_fim_contrato.Text = string.Empty;
            txt_inicio_contrato.Text = string.Empty;
            btn_conf.Enabled = false;
            txt_id.Text = string.Empty;
            txt_id.Enabled = true;
            txt_info.Items.Clear();
            calen_renova_contrato.Visible = false;
            lbl_calen.Visible = false;
            txt_inicio_contrato.Visible = false;
            txt_fim_contrato.Visible = false;
            btn_conf.Visible = false;
            btn_c_ini.Visible = false;
            btn_c_fim.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
        }
    }
}
