using Microsoft.AspNetCore.Mvc.RazorPages;

using Newtonsoft.Json.Linq;

namespace RazorPageApp_2022.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string json = "{\"name\": \"Hiroyuki\"}";
            var obj = JObject.Parse(json);
            var a = Mult(10, 12);
        }


        public void Goo(int i)
        {
            Console.WriteLine(value: i);
            i = 0;
            Console.WriteLine(value: i);
        }

        public static int Mult(int x, int y)
        {
            int f = x * y;
            return f;
        }

        public static int[] swap(int[] args)
        {
            var temp = args[0];
            args[0] = args[1];
            args[1] = temp;
            return args;
        }

        public static bool M(string p)
        {
            return p is object;
        }
    }
}
