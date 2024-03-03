using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A_ADOSMELHORES
{
    public partial class AtualizarContacto : Form
    {

        Empresa emp = new Empresa();

        public AtualizarContacto(Empresa emp)
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
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_contacto.Text = d.Contacto.ToString();
                    lbl_id.Text = "";
                    txt_func.Visible = true;
                    txt_contacto.Visible = true;
                    txt_nome.Visible = true;
                    button1.Visible = true;
                    txt_novo_contacto.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = true;

                }
                else if (emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Coordenadores d = emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_contacto.Text = d.Contacto.ToString();
                    lbl_id.Text = "";
                    txt_func.Visible = true;
                    txt_contacto.Visible = true;
                    txt_nome.Visible = true;
                    button1.Visible = true;
                    txt_novo_contacto.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = false;
                }
                else if (emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Formadores d = emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_contacto.Text = d.Contacto.ToString();
                    lbl_id.Text = "";
                    txt_func.Visible = true;
                    txt_contacto.Visible = true;
                    txt_nome.Visible = true;
                    button1.Visible = true;
                    txt_novo_contacto.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = true;
                }
                else if (emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text)) != null)
                {
                    Secretaria d = emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text));
                    txt_func.Text = d.Funcao.ToString();
                    txt_nome.Text = d.Nome.ToString();
                    txt_contacto.Text = d.Contacto.ToString();
                    lbl_id.Text = "";
                    txt_func.Visible = true;
                    txt_contacto.Visible = true;
                    txt_nome.Visible = true;
                    button1.Visible = true;
                    txt_novo_contacto.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = true;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt_novo_contacto.Text).Length != 9)
                {
                    // Se a entrada não contiver exatamente 9 números, mostrar uma mensagem de erro.
                    throw new ArgumentNullException();
                }
                if (txt_novo_contacto.Text.Substring(0, 1) != "2" && txt_novo_contacto.Text.Substring(0, 1) != "9")
                {
                    throw new ArgumentException();
                }

                if (txt_func.Text == "Diretor")
                {
                    emp.ListDiretores.Find(f => f.ID == int.Parse(txt_id.Text)).Contacto = int.Parse(txt_novo_contacto.Text);
                    txt_contacto.Text = txt_novo_contacto.Text;
                    MessageBox.Show("Contacto alterado com sucesso!");
                }
                else if (txt_func.Text == "Coordenador")
                {
                    emp.ListCoordenadores.Find(f => f.ID == int.Parse(txt_id.Text)).Contacto = int.Parse(txt_novo_contacto.Text);
                    txt_contacto.Text = txt_novo_contacto.Text;
                    MessageBox.Show("Contacto alterado com sucesso!");
                }
                else if (txt_func.Text == "Formador")
                {
                    emp.ListFormadores.Find(f => f.ID == int.Parse(txt_id.Text)).Contacto = int.Parse(txt_novo_contacto.Text);
                    txt_contacto.Text = txt_novo_contacto.Text;
                    MessageBox.Show("Contacto alterado com sucesso!");
                }
                else
                {
                    emp.ListSecretaria.Find(f => f.ID == int.Parse(txt_id.Text)).Contacto = int.Parse(txt_novo_contacto.Text);
                    txt_contacto.Text = txt_novo_contacto.Text;
                    MessageBox.Show("Contacto alterado com sucesso!");
                }
            }
            catch(ArgumentNullException) 
            {
                MessageBox.Show("Número de contato inválido. Certifique-se de inserir exatamente 9 números.");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Número de contato inválido. Certifique-se de que começa por 2 (fixo) ou 9 (móvel)");
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um contacto correto");
            }
            txt_novo_contacto.Clear();

        }



        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            MenuAtualizaDados mad = new MenuAtualizaDados(emp);
            this.Hide();
            mad.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_func.Visible = false;
            txt_contacto.Visible = false;
            txt_nome.Visible = false;
            txt_novo_contacto.Text = string.Empty;
            button1.Visible = false;
            txt_novo_contacto.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;


        }
        
    }
}