using MyMethod;

namespace Task1_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethodFactory.CreatEmployees("programmer", "Sasha"));
            Console.WriteLine(MyMethodFactory.CreatEmployees("hr-manager", "Masha"));
            Console.WriteLine(MyMethodFactory.CreatEmployees("qa-engineer", "Dasha"));
            Console.WriteLine(MyMethodFactory.CreatEmployees("data-scientist", "Pasha"));
            Console.WriteLine(MyMethodFactory.CreatEmployees("business-analyst", "Igor"));

            Console.WriteLine(MyMethodFactory.CreatEmployees("fitness-trainer", "Dima"));
        }
    }
}
