using System;
using System.IO;
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
    public partial class MenuAdmin : Form
    {
        public Empresa emp = new Empresa();
        public MenuAdmin(Empresa emp)
        {
            InitializeComponent();
            this.emp = emp;
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(emp);
            this.Hide();
            menu.Show();
        }
        
        private void btn_exportar_Click(object sender, EventArgs e)
        {
            emp.Exportar();
            MessageBox.Show("Dados exportados.");
        }

        private void btn_sal_for_Click(object sender, EventArgs e)
        {
            CalcularSalForm calcularSalForm = new CalcularSalForm(emp);
            this.Hide();
            calcularSalForm.Show();
        }
        private void btn_sal_total_Click(object sender, EventArgs e)
        {
            box_info.Items.Clear();
            double s = emp.CalcularSalarioTotal(),b = emp.CalcBonus();
            box_info.Items.Add("Salários:\t\t€ " + s.ToString());
            box_info.Items.Add("Bónus:\t\t€ " + b.ToString());
            box_info.Items.Add("___________________________");
            box_info.Items.Add("Total Mensal:\t€ " + (s + b));
        }
    }
}
