using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult Index()
        {
            List<KeyValuePair<int, string>> fbPair = FizzBuzz();
            ViewData["fbPair"] = fbPair;
            return View(ViewData["fbPair"]);
        }

        private List<KeyValuePair<int, string>> FizzBuzz()
        {
            IEnumerable<int> fbint = Enumerable.Range(1, 101);
            int[] intArr = fbint.ToArray<int>();
            int counter = intArr.Count();
            List<KeyValuePair<int, string>> fbPair = new List<KeyValuePair<int, string>>();

            int ndx = 1;
            for (int y = 1; y < counter; y++)
            {
                ndx++;
                float th3 = (float)y % 3f;
                float th5 = (float)y % 5f;

                string whatIsIt = 
                    (th3 == 0 && th5 == 0 ? "FizzBuzz" :
                     ( (th3 == 0) ? "Fizz" :
                       ( (th5 == 0) ? "Buzz" : "noFizzNoBuzz") )
                     );

                fbPair.Add(new KeyValuePair<int, string>(y, whatIsIt));
            }

            return fbPair;
        }
    }
}