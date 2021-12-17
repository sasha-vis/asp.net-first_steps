namespace MyMethod.Factories
{
    public static class Business_analystFactory
    {
        public static string CreateEmployee(string type, string name)
        {
            return type + " " + name + " was created!";
        }
    }
}
