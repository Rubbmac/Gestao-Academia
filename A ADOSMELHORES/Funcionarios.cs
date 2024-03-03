using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ADOSMELHORES
{
    public class Funcionarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public int Contacto { get; set; }
        public double Salario { get; set; }
        public DateTime IniContrato { get; set; }
        public DateTime FimContrato { get; set; }
        public DateTime RegCriminal { get; set; }
        public string Funcao { get; set; }

        public Funcionarios(int id, string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal, string funcao)
        {
            ID = id;
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            IniContrato = iniContrato;
            FimContrato = fimContrato;
            RegCriminal = regCriminal;
            Salario = salario;
            Funcao = funcao;
        }

    }
}
