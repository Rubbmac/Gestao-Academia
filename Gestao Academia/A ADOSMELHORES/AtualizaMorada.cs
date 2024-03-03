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
    public partial class AtualizaMorada : Form
    {
        public Empresa emp = new Empresa();
        public AtualizaMorada(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {      
            
            try
            {
                if (txt_id.Text == string.Empty)
                {
                    throw new ArgumentNullException();
                }

                if (emp.ListDiretores.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {                    
                    Diretores d = emp.ListDiretores.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Visible = true;
                    txt_nome.Visible = true;
                    txt_morada.Visible = true;
                    txt_nova_morada.Visible = true;
                    lbl_func.Visible = true;
                    lbl_nome.Visible = true;
                    lbl_morada.Visible = true;
                    lbl_nova_morada.Visible = true;
                    btn_confirmar.Visible = true;
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_morada.Text = d.Morada.ToString();
                    lbl_id.Text = string.Empty; 
                    txt_id.Enabled = false;
                }
                else if (emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Coordenadores d = emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Visible = true;
                    txt_nome.Visible = true;
                    txt_morada.Visible = true;
                    txt_nova_morada.Visible = true;
                    lbl_func.Visible = true;
                    lbl_nome.Visible = true;
                    lbl_morada.Visible = true;
                    lbl_nova_morada.Visible = true;
                    btn_confirmar.Visible = true;
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_morada.Text = d.Morada.ToString();
                    lbl_id.Text = string.Empty;
                    txt_id.Enabled = false;
                }
                else if (emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Formadores d = emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Visible = true;
                    txt_nome.Visible = true;
                    txt_morada.Visible = true;
                    txt_nova_morada.Visible = true;
                    lbl_func.Visible = true;
                    lbl_nome.Visible = true;
                    lbl_morada.Visible = true;
                    lbl_nova_morada.Visible = true;
                    btn_confirmar.Visible = true;
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_morada.Text = d.Morada.ToString();
                    lbl_id.Text = string.Empty;
                    txt_id.Enabled = false;
                }
                else if (emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Secretaria d = emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Visible = true;
                    txt_nome.Visible = true;
                    txt_morada.Visible = true;
                    txt_nova_morada.Visible = true;
                    lbl_func.Visible = true;
                    lbl_nome.Visible = true;
                    lbl_morada.Visible = true;
                    lbl_nova_morada.Visible = true;
                    btn_confirmar.Visible = true;
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_morada.Text = d.Morada.ToString();
                    lbl_id.Text = string.Empty;
                    txt_id.Enabled = false;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                lbl_id.Text = "ID inválido";
                lbl_id.ForeColor = Color.Red;
                lbl_id.Visible = true;
                MessageBox.Show("Erro, Insira um ID!");
            }
            catch (Exception)
            {
                lbl_id.Text = "ID inválido";
                lbl_id.ForeColor = Color.Red;
                lbl_id.Visible = true;
                MessageBox.Show("Erro, o ID inserio não pertence a nenhum funcionário!");
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nova_morada.Text == string.Empty)
                {
                    throw new Exception();
                }
                if (txt_func.Text == "Diretor")
                {
                    emp.ListDiretores.Find(f => f.ID == int.Parse(txt_id.Text)).Morada = txt_nova_morada.Text;
                    txt_morada.Text = txt_nova_morada.Text;
                    MessageBox.Show("Morada alterada com sucesso!");
                }
                else if (txt_func.Text == "Coordenador")
                {
                    emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text)).Morada = txt_nova_morada.Text;
                    txt_morada.Text = txt_nova_morada.Text;
                    MessageBox.Show("Morada alterada com sucesso!");
                }
                else if (txt_func.Text == "Formador")
                {
                    emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text)).Morada = txt_nova_morada.Text;
                    txt_morada.Text = txt_nova_morada.Text;
                    MessageBox.Show("Morada alterada com sucesso!");
                }
                else 
                {
                    emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text)).Morada = txt_nova_morada.Text;
                    txt_morada.Text = txt_nova_morada.Text;
                    MessageBox.Show("Morada alterada com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira uma morada");
            }
            txt_nova_morada.Clear();
        }              

        private void btn_sair_Click(object sender, EventArgs e)
        {
            MenuAtualizaDados mad  = new MenuAtualizaDados(emp);
            this.Hide();
            mad.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_func.Clear();
            txt_nome.Clear();
            txt_morada.Clear();
            txt_func.Visible = false;
            txt_nome.Visible = false; 
            txt_morada.Visible = false;
            txt_nova_morada.Visible = false;
            lbl_func.Visible = false;
            lbl_nome.Visible = false;
            lbl_morada.Visible = false;
            lbl_nova_morada.Visible = false;
            btn_confirmar.Visible = false;
        }

      
    }
}
