using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ADOSMELHORES
{
    public class Secretaria : Funcionarios
    {
        public int IdDir { get; set; }
        public string Area { get; set; }

        public Secretaria (int id, string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
           int idDir, string area, string funcao)
           : base(id, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, "Secretaria")
        {
            IdDir = idDir;
            Area = area;
        }



    }
}
