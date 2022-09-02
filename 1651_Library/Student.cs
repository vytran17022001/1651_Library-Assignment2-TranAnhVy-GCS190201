using System;


namespace _1651_Library
{
    
    public class Student: Person

    {
        private string studentClass;
        public void setStudentClass (string studentClass) { this.studentClass = studentClass; }
        public string getStudentLop () { return this.studentClass; }
        
        public void ShowStudentInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Class: " + this.studentClass);
            
        }
    }


    
}
