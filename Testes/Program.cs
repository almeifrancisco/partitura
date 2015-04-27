using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.service;
using Service.service.seguranca;
using Repositorio;
using Repositorio.repo;

namespace Testes
{
    class Program
    {
       public static UsuarioService ser = new UsuarioService();
        static PasswordManager pwdManager = new PasswordManager();
        static void Main(string[] args)
        {
            SimulateUserCreation();

        }

        public static string SimulateUserCreation()
        {
            Console.WriteLine("Let us first test the password hash creation i.e. User creation");
            Console.WriteLine("Please enter user id");
            string userid = Console.ReadLine();

            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();

            string salt = null;

            string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);

            // Let us save the values in the database
            Usuario user = new Usuario
            {
                
                senha = passwordHash,
                codS = salt
            };

            // Lets Add the User to the database
            ser.Insert(user); 
            return salt;
        }

        public static void SimulateLogin(string salt)
        {
            Console.WriteLine("Now let is simulate the password comparison");

            Console.WriteLine("Please enter user id");
            string userid = Console.ReadLine();

            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();

            // Let us retrieve the values from the database
            Usuario user2 = ser.Single(userid);

            bool result = pwdManager.IsPasswordMatch(password, user2.codS, user2.senha);

            if (result == true)
            {
                Console.WriteLine("Password Matched");
            }
            else
            {
                Console.WriteLine("Password not Matched");
            }
        }
    }
}
