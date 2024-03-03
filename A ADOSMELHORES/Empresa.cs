using A_ADOSMELHORES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A_ADOSMELHORES
{
    public class Empresa
    {
        public List<Formadores> ListFormadores = new List<Formadores>();
        public List<Diretores> ListDiretores = new List<Diretores>();
        public List<Coordenadores> ListCoordenadores = new List<Coordenadores>();
        public List<Secretaria> ListSecretaria = new List<Secretaria>();
        public List<Users> ListUsers = new List<Users>();
        public List<Users> ListAdmins = new List<Users>();
        //2.1
        //Adicionar Formadores
        public int IdGlobal = 1;
        public string User;

        public void AddFormador(string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            string areaForma, string disponibilidade)
        {
            Formadores f = new Formadores(IdGlobal, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, areaForma, disponibilidade, "Formador");
            ListFormadores.Add(f);
            IdGlobal++;
        }
        //Adicionar Diretor
        public void AddDiretor(string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            bool isenHorario, double bonus, bool carroEmpresa)
        {
            Diretores d = new Diretores(IdGlobal, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, isenHorario, bonus, carroEmpresa, "Diretor");
            ListDiretores.Add(d);
            IdGlobal++;
        }
        //Adicionar Secretaria
        public void AddSecretaria(string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal,
            int idDir, string area)
        {
            Secretaria s = new Secretaria(IdGlobal, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, idDir, area, "Secretaria");
            ListSecretaria.Add(s);
            IdGlobal++;
        }
        //Adicionar Coordenador
        public void AddCoordenador(string nome, string morada, int contacto, double salario, DateTime iniContrato, DateTime fimContrato, DateTime regCriminal)
        {
            Coordenadores c = new Coordenadores(IdGlobal, nome, morada, contacto, salario, iniContrato, fimContrato, regCriminal, "Coordenador");
            ListCoordenadores.Add(c);
            IdGlobal++;
        }

        public void AddUser(string username, string password)
        {
            Users u = new Users(username, password);
            ListUsers.Add(u);
        }

        public void AddAdmin(string username, string password)
        {
            Users u = new Users(username, password);
            ListAdmins.Add(u);
        }

        public double PagamentoFormador(DateTime inicio, DateTime fim, int id)
        {
            int diasUteis = 0;
            Formadores alvo;
            try
            {
                alvo = ListFormadores.Find(x => x.ID == id);
            }
            catch (Exception)
            {
                return 0;
            }
            for (DateTime data = inicio; data <= fim; data = data.AddDays(1))
            {
                if (data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasUteis++;
                }
            }
            double pagamento = diasUteis * alvo.Salario * 6;
            return pagamento;
        }

        //2.6
        public void Exportar()
        {
            StreamWriter dr = new StreamWriter(@"diretores.csv");
            dr.WriteLine("Id , Nome , Morada , Nr Telemovel , Salario , Início Do Contrato , Fim Do Contrato , Data Do Registo Criminal , Isencao de horario, Bonus , Carro , Funcao");

            foreach (Diretores diretor in ListDiretores)
            {
                dr.WriteLine($"{diretor.ID},{diretor.Nome},{diretor.Morada},{diretor.Contacto} ,{diretor.Salario} , {diretor.IniContrato.ToShortDateString()}, {diretor.FimContrato.ToShortDateString()},{diretor.RegCriminal.ToShortDateString()},{diretor.IsenHorario},{diretor.Bonus},{diretor.CarroEmpresa}, {diretor.Funcao}");
            }

            dr.Close();

            StreamWriter co = new StreamWriter(@"coordenadores.csv");
            co.WriteLine("Id , Nome , Morada , Nr Telemovel , Salario , Início Do Contrato , Fim Do Contrato , Data Do Registo Criminal ,  Funcao");

            foreach (Coordenadores coordenador in ListCoordenadores)
            {
                co.WriteLine($"{coordenador.ID},{coordenador.Nome},{coordenador.Morada},{coordenador.Contacto} ,{coordenador.Salario} , {coordenador.IniContrato.ToShortDateString()},{coordenador.FimContrato.ToShortDateString()},{coordenador.RegCriminal.ToShortDateString()}, {coordenador.Funcao}");
            }

            co.Close();

            StreamWriter fo = new StreamWriter(@"formadores.csv");
            fo.WriteLine("Id , Nome , Morada , Nr Telemovel , Salario , Início Do Contrato , Fim Do Contrato , Data Do Registo Criminal , Área de formação , Disponibilidade , Funcao");

            foreach (Formadores formador in ListFormadores)
            {
                fo.WriteLine($"{formador.ID},{formador.Nome},{formador.Morada},{formador.Contacto} ,{formador.Salario} , {formador.IniContrato.ToShortDateString()},{formador.FimContrato.ToShortDateString()},{formador.RegCriminal.ToShortDateString()},{formador.AreaForma},{formador.Disponibilidade}, {formador.Funcao}");
            }

            fo.Close();

            StreamWriter se = new StreamWriter(@"secretaria.csv");
            se.WriteLine("Id , Nome , Morada , Nr Telemovel , Salario , Início Do Contrato , Fim Do Contrato , Data Do Registo Criminal , ID Diretor , Área , Funcao");

            foreach (Secretaria secretaria in ListSecretaria)
            {
                se.WriteLine($"{secretaria.ID},{secretaria.Nome},{secretaria.Morada},{secretaria.Contacto} ,{secretaria.Salario} , {secretaria.IniContrato.ToShortDateString()}, {secretaria.FimContrato.ToShortDateString()},{secretaria.RegCriminal.ToShortDateString()},{secretaria.IdDir},{secretaria.Area},{secretaria.Funcao}");
            }

            se.Close();
        }


        //4

        public double CalcularSalarioTotal()
        {
            // após verificação, a média mensal de horas para um trabalhador normal (8h dia) é 168horas por mês, 126horas no caso de 6h por dia

            double salario1 = 0;
            foreach (Formadores formadores in ListFormadores)
            {
                if (formadores.FimContrato >= DateTime.Now)
                {
                    salario1 += formadores.Salario * 126; // 6 horas por dia 
                }
            }

            double salario2 = 0;
            foreach (Diretores diretor in ListDiretores)
            {
                if (diretor.FimContrato >= DateTime.Now)
                {
                    salario2 += (diretor.Salario * 168); // 8 horas por dia
                }
            }
            double salario3 = 0;
            foreach (Secretaria secretaria in ListSecretaria)
            {
                if (secretaria.FimContrato >= DateTime.Now)
                {
                    salario3 += secretaria.Salario * 168; // 8 horas por dia
                }
            }
            double salario4 = 0;
            foreach (Coordenadores coordenador in ListCoordenadores)
            {
                if (coordenador.FimContrato >= DateTime.Now)
                {
                    salario4 += coordenador.Salario * 168; // 8 horas por dia
                }
            }
            return salario1 + salario2 + salario3 + salario4;
        }

        public double CalcBonus()
        {
            double bonus = 0;
            foreach (Diretores d in ListDiretores)
            {
                bonus += d.Bonus;
            }
            return bonus;
        }
    }
}
