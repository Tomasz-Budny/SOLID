using System;

namespace DIP
{
    // Dependency inversion principle - zasada odwrócenia zależności 
    // moduły wysokopoziomowe nie powinny zależeć od modułów niskopoziomowych, oba powinny zależeć od abstrakcji
    
    // w skrócie - abstrakcje nie powinny zależeć od szczegółów. To szczegóły powinny zależeć od abstrakcji.
    
    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public interface IEmployeeRepository
    {
        void Add(Employee employee);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public void Add(Employee employee)
        {
            Console.WriteLine("Add employee to database");
        }
    }

    // Teraz moduł wysokopizomowy nie jest zależny od niskopoziomowgo lecz od abstrakcji
    // wieć zasada nie jest naruszona
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
        }
    }

}