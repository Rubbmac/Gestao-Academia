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
    public partial class CalcularSalForm : Form
    {
        public Empresa emp = new Empresa();
        int id = 0;
        public CalcularSalForm(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp; 
            
            foreach (Formadores f in emp.ListFormadores)
            {
                box_form.Items.Add("ID: " + f.ID + " | " + f.Nome);
            }

            lbl_data_ini.Visible = false;
            lbl_data_fim.Visible = false;
            btn_valid.Visible = false;
        }

        private void btn_menu_sair_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin(emp);
            this.Hide();
            menuAdmin.Show();
        }


        private void btn_valid_Click(object sender, EventArgs e)
        {
            bool validacao = false;
            try
            {
                if (dia_ini.Text == "" || dia_fim.Text == "")
                {
                    throw new ArgumentNullException();
                }
                if (DateTime.Parse(dia_fim.Text) >= DateTime.Parse(dia_ini.Text))
                {
                    validacao = true;
                    lbl_data.Visible = false;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                txt_pag.Text = string.Empty;
                MessageBox.Show("Erro, precisa preencher as duas datas.");
                lbl_data.ForeColor = Color.Red;
                lbl_data.Text = "Data inválida";
                lbl_data.Visible = true;
            }
            catch (Exception)
            {
                txt_pag.Text = string.Empty;
                MessageBox.Show("Erro, data de fim é igual ou mais recente que a data de início.");
                lbl_data.ForeColor = Color.Red;
                lbl_data.Text = "Data inválida";
                lbl_data.Visible = true;
            }

            if (validacao)
            {
                txt_valor.Text = emp.PagamentoFormador(DateTime.Parse(dia_ini.Text), DateTime.Parse(dia_fim.Text), id).ToString();
            }        
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            txt_valor.Clear();
            //txt_c_ini.Clear();
            //txt_c_fim.Clear();
            try
            {
                bool valido = false;
                txt_info.Items.Clear();

                if(box_form.SelectedItem == null)
                {
                    throw new Exception();
                }
                else
                {
                    string[] vStrF = box_form.SelectedItem.ToString().Split(' ');
                    id = int.Parse(vStrF[1]);
                }

                foreach (Formadores d in emp.ListFormadores)
                {
                    if (d.ID == id)
                    {
                        valido = true;
                        txt_info.Items.Add("Nome: " + d.Nome);
                        txt_info.Items.Add("Função: " + d.Funcao);
                        txt_info.Items.Add("Morada: " + d.Morada);
                        txt_info.Items.Add("Contacto: " + d.Contacto);
                        txt_info.Items.Add("Salário/hora: " + d.Salario);
                        txt_info.Items.Add("Início do contrato: " + d.IniContrato.ToShortDateString());
                        txt_info.Items.Add("Fim do contrato: " + d.FimContrato.ToShortDateString());
                        txt_info.Items.Add("Data do registo criminal: " + d.RegCriminal.ToShortDateString());
                    }
                }


                if (!valido)
                {
                    throw new Exception();
                }
                else
                {
                    box_form.Enabled = false;
                    dia_ini.Visible = true;
                    dia_fim.Visible = true;
                    lbl_data_ini.Visible = true;
                    lbl_data_fim.Visible = true;
                    btn_valid.Visible = true;
                    txt_pag.Visible = true;
                    txt_valor.Visible = true;
                    lbl_data.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Obrigatório");
                lbl_data.Visible = false;
                lbl_data_ini.Visible = false;
                lbl_data_fim.Visible = false;
                btn_valid.Visible = false;
                txt_pag.Visible = false;
                txt_valor.Visible = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menu = new MenuAdmin(emp);
            menu.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            box_form.Enabled = true;
            box_form.SelectedItem = null;
            dia_ini.Visible = false;
            dia_fim.Visible = false;
            lbl_data_ini.Visible = false;
            lbl_data_fim.Visible = false;
            btn_valid.Visible = false;
            txt_info.Visible = false;
            txt_pag.Visible = false;
            txt_valor.Visible = false;
            lbl_data.Visible = false;
        }
    }
}
