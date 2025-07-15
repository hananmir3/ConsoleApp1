using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

        }

    }
    class muruiti
    {
        public void engine_name()
        {
            Console.WriteLine("turboo");
        }
        public void engine_capacity()
        {
            Console.WriteLine("1500 cc");
        }
        public void engine_size()
        {
            Console.WriteLine("02");
        }

    }
    class hyundai1 : muruiti
    {
        public void tyre_type()
        {
            Console.WriteLine("mrf");
        }
        public void body_type()
        {
            Console.WriteLine("steel body");
        }
        public void glass_type()
        {
            Console.WriteLine("glass type");

        }
    }
    class sukuzii : hyundai1
    {
        public void window_type()
        {
            Console.WriteLine("window");
        }
        public void bolt_type()
        {
            Console.WriteLine("bolt");
        }
    }

}
