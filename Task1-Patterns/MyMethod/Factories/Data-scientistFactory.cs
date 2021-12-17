namespace MyMethod.Factories
{
    public static class Data_scientistFactory
    {
        public static string CreateEmployee(string type, string name)
        {
            return type + " " + name + " was created!";
        }
    }
}
