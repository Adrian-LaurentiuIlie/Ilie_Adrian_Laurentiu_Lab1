using Microsoft.AspNetCore.Mvc;

namespace Ilie_Adrian_Laurentiu_Lab1.Controllers
{
    public class Tentativa : Controller
    {
        public String Index()
        {
            return "Bun venit utilizatorule";
        }

        public String Salut()
        {
            return "Salut domnule utilizator";
        }

        public String Mesaj()
        {
            String nume = "Adrian";
            int varsta = 21;
            return "Acesta este " + nume + " cu varsta de " + varsta; 
        }
    }
}
