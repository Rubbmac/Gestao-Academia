using A_ADOSMELHORES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A_ADOSMELHORES
{
    
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Empresa emp = new Empresa();
            emp.AddDiretor("João Silva", "Rua A Lisboa", 923456789,10,DateTime.Parse("2023-12-31"), DateTime.Parse("2024-04-23"), DateTime.Parse("2023-11-30"), true, 100, false);
            emp.AddDiretor("Maria Santos", "Avenida K Lisboa", 910123456, 15, DateTime.Parse("2023-05-31"), DateTime.Parse("2024-04-23"), DateTime.Parse("2023-11-23"), false, 1000, false);
            emp.AddDiretor("Pedro Almeida", "Rua L Porto", 927987654, 70, DateTime.Parse("2023-04-30"), DateTime.Parse("2024-04-23"), DateTime.Parse("2023-10-24"), true, 1000, true);
            emp.AddDiretor("Sara Oliveira", "Avenida M Coimbra", 932555555, 30, DateTime.Parse("2023-03-31"), DateTime.Parse("2024-02-23"), DateTime.Parse("2023-12-31"), true, 1500, false);
            emp.AddDiretor("Daniel Pereira", "Rua N Braga", 961111111, 80, DateTime.Parse("2023-02-28"), DateTime.Parse("2024-07-23"), DateTime.Parse("2023-11-28"), false, 1200, false);
            emp.AddDiretor("Antonio Costa", "Avenida O Faro", 965888888, 40, DateTime.Parse("2023-01-31"), DateTime.Parse("2024-05-23"), DateTime.Parse("2023-11-30"), false, 1000000000, true);
            emp.AddCoordenador("Rui Almeida", "Rua S Lisboa", 919888888, 15.50, DateTime.Parse("2023-06-30"), DateTime.Parse("2024-07-23"), DateTime.Parse("2023-11-25"));
            emp.AddCoordenador("Sofia Pereira", "Avenida T Porto", 926777777, 14.75, DateTime.Parse("2023-05-31"), DateTime.Parse("2024-07-23"), DateTime.Parse("2023-12-31"));
            emp.AddCoordenador("António Silva", "Rua U Coimbra", 937666666, 16.25, DateTime.Parse("2023-04-30"), DateTime.Parse("2024-09-23"), DateTime.Parse("2023-12-30"));
            emp.AddFormador("Mariana Oliveira", "Rua V Lisboa", 918111111, 12.25, DateTime.Parse("2023-06-30"), DateTime.Parse("2024-06-23"), DateTime.Parse("2023-12-30"), "Programação", "Laboral");
            emp.AddFormador("Rodrigo Santos", "Avenida W Porto", 927222222, 11.75, DateTime.Parse("2023-05-31"), DateTime.Parse("2024-04-23"), DateTime.Parse("2024-01-20"), "Design Gráfico", "Pos-Laboral");
            emp.AddFormador("Joaquim Almeida", "Avenida W Porto", 927222222, 11.75, DateTime.Parse("2023-05-31"), DateTime.Parse("2024-02-23"), DateTime.Parse("2024-01-20"), "Design Gráfico", "Pos-Laboral");
            emp.AddFormador("Sandra Santos", "Avenida W Porto", 927222222, 11.75, DateTime.Parse("2023-04-30"), DateTime.Parse("2024-02-23"), DateTime.Parse("2024-01-10"), "Design Gráfico", "Pos-Laboral");
            emp.AddFormador("Inês Almeida", "Rua X Coimbra", 936333333, 13.50, DateTime.Parse("2023-04-30"), DateTime.Parse("2024-03-23"), DateTime.Parse("2024-01-15"), "Engenharia de Software", "Laboral/Pos-Laboral");
            emp.AddSecretaria("Beatriz Pereira", "Rua Y Lisboa", 914444444, 10.00, DateTime.Parse("2023-06-30"), DateTime.Parse("2024-01-23"), DateTime.Parse("2023-12-30"), 1, "Administração");
            emp.AddUser("rcanelas", "atec");
            emp.AddAdmin("rcanelas", "atec");
            emp.AddUser("bjoao", "atec");
            emp.AddAdmin("bjoao", "atec");
            emp.AddUser("msilva", "atec");
            emp.AddAdmin("msilva", "atec");
            emp.AddUser("rmachado", "atec");
            emp.AddAdmin("rmachado", "atec");
            Application.Run(new Inicio(emp));
        }
    }
}
