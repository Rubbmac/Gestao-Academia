using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ADOSMELHORES
{
    public class Coordenadores : Funcionarios
    {
        
        public List<Formadores> ListFormadores = new List<Formadores>();

        public Coordenadores (int id, string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            string funcao)
           : base(id, nome, morada, contacto,salario, iniContrato, fimContrato, regCriminal, "Coordenador")
        {
        }



    }
}
