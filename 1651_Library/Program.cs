using System;
using System.Collections.Generic;
namespace _1651_Library
{
    public class Program
    {
        static List<Books> BookList = new List<Books>();
        static List<Books> borrowedBook = new List<Books>();
        public static void ManageBook()
        {
            int option = 0;
            string name;
            while(option != -1)
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Search Book");
                Console.WriteLine("3.Delete Book");
                Console.WriteLine("4.Borrow Books");
                Console.WriteLine("5.Return Books");
                Console.WriteLine("6.Show all Borrow Books");
                Console.WriteLine("7.Show All Books");
                Console.WriteLine("8.Back");
                Console.Write("Enter Number: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                { 
                    case 1:
                        Console.Clear();
                        Books newBook = new Books();//khoi tao mot doi tuong moi
                        Console.Write("Input Book Name: ");
                        name = Console.ReadLine();
                        newBook.setName(name);
                      
                        Console.Write("Input Book Author: ");
                        newBook.setauthor(Console.ReadLine());

                        newBook.setId(BookList.Count + 1);// generate Id auto (n+1)
                        
                        Console.Clear();
                        BookList.Add(newBook);
                        Console.Write("!!Add book Successfully!!\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Input Book's Name: ");
                        name = Console.ReadLine();
                        bool flag = false;
                        foreach (Books book in BookList)//chay vong lap toi khi nao thay book can tim
                        {
                            if (book.getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("!!Search Result!!");
                                book.ShowBookInfo();
                                flag = true;
                            }
                        }
                        if (!flag)
                        {
                            Console.Clear();
                            Console.WriteLine("!!This book does not exist!!\n");
                        }
                        break;
                    case 3:
                        Console.Write("Input Book's Name: ");
                        name = Console.ReadLine();
                        bool flagA = false;
                        for (int i = 0; i < BookList.Count; i++) // dung for vi no có index để RemoteAt(i)
                        {
                            if (BookList[i].getName().ToLower() == name.ToLower())
                            {
                                BookList.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine("!!Delete Successfullyy!!\n");
                                flagA = true;
                                break;
                            }
                        }
                        if (!flagA)
                        {
                            Console.Clear();
                            Console.WriteLine("!!This book does not exist!!\n");
                        }
                        break;
                   case 4:
                        Console.Clear();
                        Console.Write("Input Book's Name: ");
                        name = Console.ReadLine();
                        bool flagB = false;
                        foreach (Books book in BookList)
                        {
                            if (book.getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("!!Borrow Successfully!!");
                                borrowedBook.Add(book);
                                flagB = true;
                                break;
                            }
                        }
                        if (!flagB)
                        {
                            Console.Clear();
                            Console.WriteLine("!!This book does not exist!!");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        foreach (Books book in borrowedBook)
                        {
                            book.ShowBookInfo();
                        }
                        bool flagC = false;
                        Console.Write("What book do you want to return?: ");
                        name = Console.ReadLine();
                        for (int i = 0; i < BookList.Count; i++)
                        {
                            if (borrowedBook[i].getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("!!Return Successfully!!");
                                borrowedBook.RemoveAt(i);
                                flagC = true;
                                break;
                            }
                            if (!flagC)
                            {
                                Console.WriteLine("This book was not borrowed!");
                            }
                            break;
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("~~~~All Books that has Borrowed~~~~");
                        foreach (Books book in borrowedBook)
                        {
                            book.ShowBookInfo();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("~~~~All Books~~~~");
                        foreach (Books book in BookList)
                        {
                            book.ShowBookInfo();
                        }
                        break;
                    case 8:
                        option = -1;
                        break;
                         default:
                        break;
                }
            }
        }
        static List<Staff> staffList = new List<Staff>();
        public static void ManageStaff()
        {
            int option = 0;
            string name;
            while (option != -1)
            {
                Console.WriteLine("1.Add Staff");
                Console.WriteLine("2.Delete Staff");
                Console.WriteLine("3.Search Staff");
                Console.WriteLine("4.Show all Staff");
                Console.WriteLine("5.Back");
                Console.Write("Enter Number: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Staff newStaff = new Staff();
                        Console.Write("Input Staff Name: ");
                        name = Console.ReadLine();
                        newStaff.setName(name);

                        Console.Write("Input Staff Age: ");
                        newStaff.setAge(Convert.ToInt32(Console.ReadLine()));

                        Console.Write("Input Staff Gender: ");
                        newStaff.setGender(Console.ReadLine());

                        Console.Write("Input Staff Phone Number: ");
                        newStaff.setPhone(Console.ReadLine());

                        Console.Write("Input Staff Salary: ");
                        newStaff.setSalary(Convert.ToInt64(Console.ReadLine()));

                        Console.Write("Input Staff position: ");
                        newStaff.setStaffClass(Console.ReadLine());

                        newStaff.setId(staffList.Count + 1);

                        Console.Clear();
                        staffList.Add(newStaff);
                        Console.WriteLine("!!Add Successfully!!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Input Staff Name: ");
                        name = Console.ReadLine();
                        bool flag = false;

                        for (int i = 0; i < staffList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == name.ToLower())
                            {
                                staffList.RemoveAt(i);
                                flag = true;
                                Console.Clear();
                                Console.WriteLine("!!Delete Successfully!!");
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("This staff does not exit");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Input Staff Name: ");
                        name = Console.ReadLine();
                        bool flagA = false;

                        for (int i = 0; i < staffList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("~~~~Search Result~~~~");
                                staffList[i].ShowStaffInfo();
                                flagA = true;
                                break;
                            }
                        }
                        if (!flagA)
                        {
                            Console.WriteLine("This");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("~~~~All Staff~~~~");
                        foreach (Staff staff in staffList)
                        {
                            staff.ShowStaffInfo();
                        }
                        break;
                    case 5:
                        option = -1;
                        break;
                }
            }

        }

        static List<Student> studentList = new List<Student>();
        public static void ManageStudent()
        {
            int option = 0;
            string name;
            while (option != -1)
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Delete Student");
                Console.WriteLine("3.Search Student");
                Console.WriteLine("4.Show all Student");
                Console.WriteLine("5.Back");
                Console.Write("Enter Number: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Student newStudent = new Student();
                        Console.Write("Input Student Name: ");
                        name = Console.ReadLine();
                        newStudent.setName(name);

                        Console.Write("Input Student Age: ");
                        newStudent.setAge(Convert.ToInt32(Console.ReadLine()));

                        Console.Write("Input Student Gender: ");
                        newStudent.setGender(Console.ReadLine());

                        Console.Write("Input Student Phone Number: ");
                        newStudent.setPhone(Console.ReadLine());

                        Console.Write("Input Student Class: ");
                        newStudent.setStudentClass(Console.ReadLine());

                       newStudent.setId(studentList.Count + 1);

                        Console.Clear();
                        studentList.Add(newStudent);
                        Console.WriteLine("!!Add Successfully!!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Input Student Name: ");
                        name = Console.ReadLine();
                        bool flag = false;

                        for (int i = 0; i < studentList.Count; i++)
                        {
                            if (staffList[i].getName().ToLower() == name.ToLower())
                            {
                                studentList.RemoveAt(i);
                                flag = true;
                                Console.Clear();
                                Console.WriteLine("!!Delete Successfully!!");
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("This staff does not exit");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Input Student Name: ");
                        name = Console.ReadLine();
                        bool flagA = false;

                        for (int i = 0; i < studentList.Count; i++)
                        {
                            if (studentList[i].getName().ToLower() == name.ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("~~~~Search Result~~~~");
                                studentList[i].ShowStudentInfo();
                                flagA = true;
                                break;
                            }
                        }
                        if (!flagA)
                        {
                            Console.WriteLine("This");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("~~~~All Student~~~~");
                        foreach (Student student in studentList)
                        {
                            student.ShowStudentInfo();
                        }
                        break;
                    case 5:
                        option = -1;
                        break;
                }
            }

        }
        static void Main(string[] args)
        {
            int k = 0;
            while (k != -1)
            {
                Console.WriteLine("1.Manage Book");
                Console.WriteLine("2.Manage Staff");
                Console.WriteLine("3.Manage Student card");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Number: ");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        ManageBook();
                        break;
                    case 2:
                        ManageStaff();
                        break;
                    case 3:
                        ManageStudent();
                        break;
                    case 4:
                        k = -1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
