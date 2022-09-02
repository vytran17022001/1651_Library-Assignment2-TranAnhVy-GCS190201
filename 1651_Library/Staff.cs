using System;

namespace _1651_Library
{
    
    public class Staff: Person
    {
        public Staff()
        {

        }
        public Staff(string name, int id, string gender, int age, string phone, int salary)
        : base(name, id, gender, age, phone)
        {
            this.salary = salary;
        }

        private string staffClass;
        public void setStaffClass (string staffClass) { this.staffClass = staffClass; }
        public string getStaffchucvu () { return this.staffClass; }

        private long salary;
        public void setSalary(long salary) 
        { 
            this.salary = salary; 
        }
        public long getSalary() 
        {
            return this.salary; 
        }

        public void ShowStaffInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Position: " + this.staffClass);
            Console.WriteLine("Salary:" + this.salary);
        }
    }
}
