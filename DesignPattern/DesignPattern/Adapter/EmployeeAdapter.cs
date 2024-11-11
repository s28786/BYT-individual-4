// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        //{"101","John","SE","10000"},
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                employees.Add(new Employee(Int32.Parse(employeesArray[i, 0]), employeesArray[i, 1], employeesArray[i, 2], Int32.Parse(employeesArray[i, 3])));
            }

            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}