using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
   public interface ITaskRepository
    {


        public InvocieTask InvocieTaskCreate(InvocieTask _invocieTask);  //метод создания InvoiceTask   



        public List<Task> TaskReading();  // Метод чтения всех Task 




        public Task TaskCreate(Task _task);  // метод создания Task 



    }
}
