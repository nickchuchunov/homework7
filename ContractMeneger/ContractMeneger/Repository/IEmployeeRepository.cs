using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface IEmployeeRepository 
    {


        public Employe EmployeCreate(Employe _employe); // метод создания Employe


        public TaskEmployee TaskEmployeeCreate(TaskEmployee _taskEmployee); //создание TaskEmployee
                                                                                                                                                                                                                                                                                              //



    }
}
