using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Kursach.AnotherDirectory.ControlClasses
{
    public class Building
    {
        public int Number { get; private set; }
        public List<Department> Departments { get; private set; }
        public Building(int number)
        {
            this.Number = number;
            Departments = new List<Department>();
        }
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void RemoveDepartment(Department department)
        {
            if (Departments.Contains(department))
            {
                Departments.Remove(department);
            }
        }
    }
}
