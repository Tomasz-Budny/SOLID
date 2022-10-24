using System;

namespace DIP
{
   public class EmployeeRepositoryBad
   {
      public void Add(Employee employee)
      {
         Console.WriteLine("Add employee to database");
      }
   }

   // Moduł wysokopoziomowy - ponieważ używa EmployeeRepository
   //   KLASA EMPLOYEE SERVICE ZALEŻY OD EMPLOYEE RESPOSITORY WIĘC JEST TO ZŁAMANIE ZASADY DIP 
   // moduł wysokopoziomowy nie może zależeć od moddułu niskopoziomowego
   public class EmployeeServiceBad
   {
      // Moduł niskopoziomowy - ponieważ jest w EmployeeService
      private readonly EmployeeRepositoryBad _employeeRepository = new EmployeeRepositoryBad();

      public void Add(Employee employee)
      {
         _employeeRepository.Add(employee);
      }
   }
}