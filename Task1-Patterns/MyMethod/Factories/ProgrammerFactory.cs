namespace MyMethod.Factories
{
    public static class ProgrammerFactory
    {
        public static string CreateEmployee(string type, string name)
        {
            return type + " " + name + " was created!";
        }
    }
}
