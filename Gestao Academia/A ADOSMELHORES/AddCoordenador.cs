﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ADOSMELHORES
{
    public partial class AddCoordenador : Form
    {
        string nome;
        string morada;
        int contacto;
        double salario;
        DateTime iniContrato;
        DateTime fimContrato;
        DateTime regCriminal;

        //Classe empresa com toda a informação
        public Empresa emp = new Empresa();

        public AddCoordenador(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void btn_c_ini_Click(object sender, EventArgs e)
        {
            txt_c_ini.Text = calen_cont.SelectionStart.ToShortDateString();
        }

        private void btn_c_fim_Click(object sender, EventArgs e)
        {
            txt_c_fim.Text = calen_cont.SelectionStart.ToShortDateString();
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {

            //Inserção de nome
            try
            {
                nome = txt_nome.Text;
                if (txt_nome.Text == "") { throw new Exception(); }
                lbl_nome.Text = "Validado";
                lbl_nome.ForeColor = Color.Green;
                lbl_nome.Visible = true;

            }
            catch (Exception)
            {
                lbl_nome.ForeColor = Color.Red;
                lbl_nome.Text = "Valor inválido";
                lbl_nome.Visible = true;
            }
            //Inserção de morada
            try
            {
                morada = txt_morada.Text;
                if (txt_morada.Text == "") { throw new Exception(); }
                lbl_morada.Text = "Validado";
                lbl_morada.ForeColor = Color.Green;
                lbl_morada.Visible = true;

            }
            catch (Exception)
            {
                lbl_morada.ForeColor = Color.Red;
                lbl_morada.Text = "Valor inválido";
                lbl_morada.Visible = true;
            }
            //Inserção de contacto
            try
            {
                if ((txt_cont.Text).Length != 9)
                {
                    throw new Exception();
                }
                if (txt_cont.Text.Substring(0,1)!="2"&& txt_cont.Text.Substring(0, 1) != "9")
                {
                    throw new Exception();
                }
                contacto = int.Parse(txt_cont.Text);
                lbl_contacto.Text = "Validado";
                lbl_contacto.ForeColor = Color.Green;
                lbl_contacto.Visible = true;

            }
            catch (Exception)
            {
                lbl_contacto.ForeColor = Color.Red;
                lbl_contacto.Text = "Valor inválido";
                lbl_contacto.Visible = true;
            }
            
            //Inserção de salário
            try
            {
                salario = double.Parse(txt_salario.Text);
                lbl_salario.Text = "Validado";
                lbl_salario.ForeColor = Color.Green;
                lbl_salario.Visible = true;
            }
            catch (Exception)
            {

                lbl_salario.ForeColor = Color.Red;
                lbl_salario.Text = "Valor inválido";
                lbl_salario.Visible = true;
            }
            //Inserção de Data de inicio/fim de contrato
            try
            {
                if (DateTime.Parse(txt_c_ini.Text) > DateTime.Parse(txt_c_fim.Text))
                {
                    throw new ArgumentException();
                }
                else if (DateTime.Parse(txt_c_fim.Text) < DateTime.Today)
                {
                    throw new Exception();
                }
                else
                {
                    iniContrato = DateTime.Parse(txt_c_ini.Text);
                    fimContrato = DateTime.Parse(txt_c_fim.Text);
                    lbl_data_cont.ForeColor = Color.Green;
                    lbl_data_cont.Text = "Validado";
                    lbl_data_cont.Visible = true;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro, data de fim de contrato é igual ou mais recente que a data de início de contrato.");
                lbl_data_cont.ForeColor = Color.Red;
                lbl_data_cont.Text = "Data inválida";
                lbl_data_cont.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, data de fim de contrato é anterior à data atual.");
                lbl_data_cont.ForeColor = Color.Red;
                lbl_data_cont.Text = "Data inválida";
                lbl_data_cont.Visible = true;
            }

            //Inserção de Data de registo criminal

            try
            {
                regCriminal = calen_reg.SelectionStart;
                if (calen_reg.SelectionStart > DateTime.Now)
                {
                    throw new Exception();
                }
                lbl_calen.Text = "Validado";
                lbl_calen.ForeColor = Color.Green;
                lbl_calen.Visible = true;
            }
            catch (Exception)
            {
                lbl_calen.Text = "Data inválida";
                lbl_calen.ForeColor = Color.Red;
                lbl_calen.Visible = true;
            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string[] validacoes = { lbl_nome.Text, lbl_morada.Text, lbl_contacto.Text, lbl_salario.Text, lbl_calen.Text, lbl_data_cont.Text};
            try
            {
                foreach (string validacao in validacoes)
                {
                    if (validacao != "Validado")
                    {
                        throw new Exception();
                    }
                }
                emp.AddCoordenador(nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal);
                MessageBox.Show("Informação adicionada com sucesso!");
                this.Hide();
                Menu menu = new Menu(emp);
                menu.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro, existem informações não validadas. Por favor reconfirme.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdd add = new MenuAdd(emp);
            add.Show();
        }

    }
}
