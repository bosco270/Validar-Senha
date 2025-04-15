using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Verificar_Senha
    {
        // Atributos
        private string Senha;

        // Construtor
        public Verificar_Senha(string senha)
        {
            Senha = senha;
        }

        // Método para validar a senha
        public bool ValidarSenha()
        {
            // Verifica o comprimento da senha
            if (Senha.Length < 8)
            {
                Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
                return false;
            }

            // Verifica se contém pelo menos uma letra maiúscula
            if (!Senha.Any(c => char.IsUpper(c)))
            {
                Console.WriteLine("A senha deve conter pelo menos uma letra maiúscula.");
                return false;
            }

            // Verifica se contém pelo menos uma letra minúscula
            if (!Senha.Any(c => char.IsLower(c)))
            {
                Console.WriteLine("A senha deve conter pelo menos uma letra minúscula.");
                return false;
            }

            // Verifica se contém pelo menos um número
            if (!Senha.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("A senha deve conter pelo menos um número.");
                return false;
            }

            // Verifica se contém pelo menos um caractere especial
            if (!Senha.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                Console.WriteLine("A senha deve conter pelo menos um caractere especial.");
                return false;
            }

            // Verifica se não contém espaços em branco
            if (Senha.Any(c => char.IsWhiteSpace(c)))
            {
                Console.WriteLine("A senha não pode conter espaços em branco.");
                return false;
            }

            // Se passar por todas as verificações, a senha é válida
            return true;
        }
    }
}
