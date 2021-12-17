namespace MyMethod.Factories
{
    public static class Qa_engineerFactory
    {
        public static string CreateEmployee(string type, string name)
        {
            return type + " " + name + " was created!";
        }
    }
}
