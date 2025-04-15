using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            Verificar_Senha verificador = new Verificar_Senha(senha);

            if (verificador.ValidarSenha())
            {
                Console.WriteLine("A senha é válida.");
            }
            else
            {
                Console.WriteLine("A senha não é válida.");
            }
        }
    }
}