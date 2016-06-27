using System.Web.Mvc;
using AnagramWebsite.Models;

namespace AnagramWebsite.Controllers
{
    public class AnagramController : Controller
    {
        // GET: Anagram
        //public ActionResult Search()
        //{
        //    var anagram = new Anagram();
        //    anagram.FindSecretPhrase("poultry outwits ants", "4624d200580677270a54ccff86b9610e");
        //    return View(anagram);
        //}

        public ActionResult Search(string hintPhrase, string md5HashKey)
        {
            var anagram = new Anagram();
            //anagram.FindSecretPhrase(hintPhrase, md5HashKey);
            anagram.FindSecretPhrase("poultry outwits ants", "4624d200580677270a54ccff86b9610e");
            return View(anagram);
        }
    }
}
