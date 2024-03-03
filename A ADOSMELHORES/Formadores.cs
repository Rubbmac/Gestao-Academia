using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ADOSMELHORES
{
    public class Formadores : Funcionarios
    {

        public string AreaForma { get; set; }

        public string Disponibilidade { get; set; }


        public Formadores(int id, string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            string areaForma, string disponibilidade, string funcao)
            : base(id, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, "Formador")
        {
            AreaForma = areaForma;
            Disponibilidade = disponibilidade;  
        }

    }
}
