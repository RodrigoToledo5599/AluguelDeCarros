using System.Security.Principal;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Services.Autenticacao
{
    public class Autenticacao
    {
        /*
        private readonly IUnitOfWork _db;

        public string path = Environment.CurrentDirectory + @"\Usuario\UsuarioLogado.txt";



        public Autenticacao(IUnitOfWork db)
        {
            _db = db;
        }




        public Usuario? LoggingUser(string email, string password)

        {
            try
            {
                Usuario conta = _db.Usuario.Logging(email, password);
                SavingUser(conta);
                return conta;
            }
            catch (System.NullReferenceException)
            {
                return null;
            }
        }

        public void SavingUser(Usuario user)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(user.Id.ToString());
            sw.Close();
        }

        public void ErasingUser()
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("");
            sw.Close();
        }

        public Usuario GettingUser()
        {
            StreamReader sr = new StreamReader(path);
            int id = int.Parse(sr.ReadLine());
            sr.Close();
            return _db.Usuario.GetById(c => c.Id == id);
        }
        */
    }
}

