using Altazion.Api;
using Altazion.Api.Utilisateur.Catalogue;

using System;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("* application de test pour l'api altazion     *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Veuillez entrer votre nom d'utilisateur : ");
            string user = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre mot de passe : ");
            string secret = Console.ReadLine();


            var conn = new ApiConnection(user, secret, "https://api.simplement-e.com");
            var cli = new ArticlesApiClient(conn);

            var items = cli.Rechercher("00000", 5);
        }
    }
}
