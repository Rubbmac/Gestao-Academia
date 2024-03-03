using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A_ADOSMELHORES
{
    public partial class AlocarFormador : Form
    {
        public Empresa emp = new Empresa();
        public AlocarFormador(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
            foreach (Coordenadores c in emp.ListCoordenadores)
            {
                box_coord.Items.Add("ID: " + c.ID + " | " + c.Nome);
            }
            foreach (Formadores f in emp.ListFormadores)
            {
                box_form.Items.Add("ID: " + f.ID + " | " + f.Nome);
            }


        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            MenuGerir menuGerir = new MenuGerir(emp);
            this.Hide();
            menuGerir.Show();
        }
        private void btn_validar_Click(object sender, EventArgs e)
        {
            bool validar = false;

            try
            {
                int id = 0;
                if (box_coord.SelectedItem == null)
                {
                    //caso não tenha informação na caixa de texto
                    throw new ArgumentNullException();
                }
                else
                {
                    string[] vStr = box_coord.SelectedItem.ToString().Split(' ') ;
                    id = int.Parse(vStr[1]);
                }


                foreach (Coordenadores coordenador in emp.ListCoordenadores)
                {
                    if (coordenador.ID == id)
                    {
                        validar = true;
                        box_coord.Enabled= false;
                        box_form.Visible = true;
                        lbl_coordenador.Visible = true;
                        txt_info.Visible = true;
                        lbl_f_indique.Visible = true;
                        lbl_id_generico.Visible = true;
                        btn_f_conf.Visible = true;
                        lbl_id.Visible = false;
                        txt_info.Items.Clear();
                        txt_info.Items.Add("ID: " + coordenador.ID);
                        txt_info.Items.Add("Nome: " + coordenador.Nome);
                        txt_info.Items.Add("Função: " + coordenador.Funcao);
                        txt_info.Items.Add("Morada: " + coordenador.Morada);
                        txt_info.Items.Add("Contacto: " + coordenador.Contacto);
                        txt_info.Items.Add("Salário/hora: " + coordenador.Salario);
                        txt_info.Items.Add("Início do contrato: " + coordenador.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + coordenador.FimContrato.ToShortDateString());
                    }
                }
                if (!validar)
                {
                    //caso a informação na caixa de texto seja inválida
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                lbl_id.Text = "obrigatório";
                lbl_id.Visible = true;
                lbl_id.ForeColor = Color.Red;
            }
            catch (Exception)
            {

                lbl_id.Text = "id inválido";
                lbl_id.Visible = true;
                lbl_id.ForeColor = Color.Red;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            box_form.Visible = false;
            box_coord.Enabled = true;
            box_coord.SelectedItem = null;
            lbl_coordenador.Visible = false;
            lbl_id.Visible = false;
            txt_info.Visible = false;
            lbl_f_indique.Visible = false;
            lbl_id_generico.Visible = false;
            lbl_f_id.Visible = false;
            btn_f_conf.Visible = false;
            btn_f_conf.Enabled = false;
        }



        private void btn_f_conf_Click(object sender, EventArgs e)
        {
            bool validar = false;
            try
            {
                int idC = 0;
                int idF = 0;
                if (box_form.SelectedItem == null)
                {
                    //caso não tenha informação na caixa de texto
                    throw new ArgumentNullException();
                }
                else
                {
                    string[] vStrC = box_coord.SelectedItem.ToString().Split(' ');
                    idC = int.Parse(vStrC[1]);
                    string[] vStrF = box_form.SelectedItem.ToString().Split(' ');
                    idF = int.Parse(vStrF[1]);
                }
                foreach (Formadores formador in emp.ListFormadores)
                {
                    if (formador.ID == idF)
                    {
                        foreach (Coordenadores coordenador in emp.ListCoordenadores)
                        {
                            if (coordenador.ID == idC)
                            {
                                foreach (Formadores f in coordenador.ListFormadores)
                                {
                                    if (f.ID == idF)
                                    {
                                        throw new ArgumentException();
                                    }
                                }
                                coordenador.ListFormadores.Add(formador);
                                MessageBox.Show($"Formador {formador.Nome} adicionado com sucesso!");
                                validar = true;
                            }
                        }

                    }
                }
                if (!validar)
                {
                    //caso a informação na caixa de texto seja inválida
                    throw new Exception();
                }
                else
                {
                    box_form.Visible = false;
                    box_coord.Enabled = true;
                    box_coord.SelectedItem = null;
                    lbl_coordenador.Visible = false;
                    lbl_id.Visible = false;
                    txt_info.Visible = false;
                    lbl_f_indique.Visible = false;
                    lbl_id_generico.Visible = false;
                    lbl_f_id.Visible = false;
                    btn_f_conf.Visible = false;
                    box_form.SelectedItem = null;
                }
            }
            catch (ArgumentNullException)
            {
                lbl_f_id.Text = "obrigatório";
                lbl_f_id.Visible = true;
                lbl_f_id.ForeColor = Color.Red;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formador já existe na lista do coordenador.");
            }
            catch (Exception)
            {
                lbl_f_id.Text = "id inválido";
                lbl_f_id.Visible = true;
                lbl_f_id.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
