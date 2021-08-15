using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class EmployeeService : ITaskRepository, IEmployeeRepository
    {
        public Employe EmployeCreate(Employe _employe) // метод создания Employe

        {
            return _employe;
        }

        public InvocieTask InvocieTaskCreate(InvocieTask _invocieTask) //метод создания InvoiceTask   
        {
            return _invocieTask;
        }

        public Task TaskCreate(Task _task)  // метод создания Task 
        {
            return _task;
        }

        public TaskEmployee TaskEmployeeCreate(TaskEmployee _taskEmployee)  //создание TaskEmployee
        {
            return _taskEmployee;
        }

        public List<Task> TaskReading() // Метод чтения всех Task 
        {
            return new List<Task>();
        }
    }
}
