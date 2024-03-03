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
    public partial class RemoveFuncionario : Form
    {
        public Empresa emp = new Empresa();
        public string Funcao;
        public RemoveFuncionario(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void RemoveFuncionario_Load(object sender, EventArgs e)
        {

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
                        Funcao = s.Funcao;
                    }
                }

                if (!valido)
                {
                    throw new Exception();
                }
                else
                {
                    txt_info.Visible = true;
                    btn_confirmar.Visible = true;
                }
            }
            catch (Exception)
            {
                lbl_id.ForeColor = Color.Red;
                lbl_id.Visible = true;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuGerir mg = new MenuGerir(emp);
            mg.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_id.Enabled = true;
            txt_info.Items.Clear();
            txt_info.Visible = false;
            btn_confirmar.Visible = false;
        }

        private void btn_confirmar_Click_1(object sender, EventArgs e)
        {

            if (emp.ListDiretores.Find(x => x.ID == int.Parse(txt_id.Text)) != null)
            {
                Diretores diretor = emp.ListDiretores.Find(x => x.ID == int.Parse(txt_id.Text));
                emp.ListDiretores.Remove(diretor);
                MessageBox.Show("Removido com sucesso");
            }
            else if (emp.ListCoordenadores.Find(x => x.ID == int.Parse(txt_id.Text)) != null)
            {
                Coordenadores coordenador = emp.ListCoordenadores.Find(x => x.ID == int.Parse(txt_id.Text));
                emp.ListCoordenadores.Remove(coordenador);
                MessageBox.Show("Removido com sucesso");
            }
            else if (emp.ListSecretaria.Find(x => x.ID == int.Parse(txt_id.Text)) != null)
            {
                Secretaria secretaria = emp.ListSecretaria.Find(x => x.ID == int.Parse(txt_id.Text));
                emp.ListSecretaria.Remove(secretaria);
                MessageBox.Show("Removido com sucesso");
            }
            else if (emp.ListFormadores.Find(x => x.ID == int.Parse(txt_id.Text)) != null)
            {
                Formadores formador = emp.ListFormadores.Find(x => x.ID == int.Parse(txt_id.Text));
                emp.ListFormadores.Remove(formador);
                MessageBox.Show("Removido com sucesso");
            }
            txt_info.Items.Clear();
            btn_confirmar.Visible=false;
            txt_info.Visible=false;
            txt_id.Text=string.Empty;
            txt_id.Enabled = true;
        }
    }
}
