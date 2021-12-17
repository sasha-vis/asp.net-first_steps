using MyMethod.Factories;

namespace MyMethod
{
    public static class MyMethodFactory
    {
        public static string CreatEmployees(string type, string name)
        {
            switch (type)
            {
                case "programmer":
                    return ProgrammerFactory.CreateEmployee(type, name);
                case "hr-manager":
                    return ProgrammerFactory.CreateEmployee(type, name);
                case "qa-engineer":
                    return ProgrammerFactory.CreateEmployee(type, name);
                case "data-scientist":
                    return ProgrammerFactory.CreateEmployee(type, name);
                case "business-analyst":
                    return ProgrammerFactory.CreateEmployee(type, name);
            }
            return "\nError: The type of employee is incorrect!\n\nPlease, choose another type:\nprogrammer\nhr-manager\nqa-engineer\ndata-scientist\nbusiness analyst\n";
        }
    }
}