using Eventos.Models;

namespace eventosExemplos
{

    class Program
    {
        public delegate List<int> operacao(List<int> list);
        static void Main(string[] args)
        {

            var lis = new List<int> { 1, 2, 3, 4 };
            operacao s = op;
            var r = s.Invoke(lis);

            Console.WriteLine(String.Join(", ", r));


            // Matematica m = new Matematica(10, 20);
            // m.Somar();


        }

        public static List<int> op(List<int> list)
        {
            return list;
        }
    }
}
