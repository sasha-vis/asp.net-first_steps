namespace MyMethod.Factories
{
    public static class Hr_managerFactory
    {
        public static string CreateEmployee(string type, string name)
        {
            return type + " " + name + " was created!";
        }
    }
}
