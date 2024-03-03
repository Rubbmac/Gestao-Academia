using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ADOSMELHORES
{
    public class Diretores : Funcionarios
    {
        public bool IsenHorario { get; set; }
        public double Bonus { get; set; }
        public bool CarroEmpresa { get; set; }


        public Diretores(int id, string nome, string morada, int contacto,double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            bool isenHorario, double bonus, bool carroEmpresa,string funcao) 
            : base(id, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, "Diretor")
        {
            IsenHorario = isenHorario;
            Bonus = bonus;
            CarroEmpresa = carroEmpresa;
        }

    }
}
