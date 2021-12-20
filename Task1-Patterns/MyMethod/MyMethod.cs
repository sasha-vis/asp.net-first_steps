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
                    return Hr_managerFactory.CreateEmployee(type, name);
                case "qa-engineer":
                    return Qa_engineerFactory.CreateEmployee(type, name);
                case "data-scientist":
                    return Data_scientistFactory.CreateEmployee(type, name);
                case "business-analyst":
                    return Business_analystFactory.CreateEmployee(type, name);
            }
            return "\nError: The type of employee is incorrect!\n\nPlease, choose another type:\nprogrammer\nhr-manager\nqa-engineer\ndata-scientist\nbusiness analyst\n";
        }
    }
}