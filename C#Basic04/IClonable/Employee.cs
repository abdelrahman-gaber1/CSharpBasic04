using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic04.IClonable
{
    class Department : ICloneable
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public object Clone()
        {
            return new Department()
            {
                Id = this.Id,
                Name = this.Name,
          };
        }

        public override string ToString()
        {
            return $" Id : {Id} , Name : {Name}";
        }

    }
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Salary { get; set; }
        public Department department { get; set; }
        public object Clone()
        {
            return new Employee(this)
            {
                //Id = this.Id,
                //Name = this.Name,
                //Salary = this.Salary,
                //department = (Department) this.department.Clone()
          };
        }
        public Employee()
        {
            
        }
        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;
            this.department =(Department) employee.department.Clone();
            
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Department : {department}";
        }

        public int CompareTo(object? obj)
        {
            Employee emp =(Employee) obj;
            return this.Salary.CompareTo(emp.Salary);
           
            //if(this.Salary > emp.Salary)
            //    return 1;
            //else if (this.Salary < emp.Salary)
            //    return -1;
            //else 
            //    return 0;
        }
    }
}
