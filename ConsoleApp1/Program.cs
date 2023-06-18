using System;
using System.Collections.Generic;

namespace UniManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeData();

            // Perform login
            Login();

            Console.WriteLine("Program execution completed. Press any key to exit.");
            Console.ReadKey();
        }

        static void InitializeData()
        {
            Department computerScienceDepartment = new Department("Computer Science", "HannamUni", "232-415-3214");

            // Initialize professors
            Professor professor1 = new Professor("P1", "Lee", "192-333-230", "lee.hannam@hnu.com", "Professor", computerScienceDepartment);
            Professor professor2 = new Professor("P2", "Chang", "773-202-3220", "chang.hannam@hnu.com", "Professor", computerScienceDepartment);

            // Initialize staff
            Staff staff1 = new Staff("S1", "Staf1", "122-200-1313", "staf1.hannam@hnu.com", "Office Administration", 3000);
            Staff staff2 = new Staff("S2", "Staf2", "294-945-3268", "staff2.hannam@hnu.com", "Admissions", 2500);

            // Initialize subjects
            Subject subject1 = new Subject("CS101", "Programming Practice", professor1);
            Subject subject2 = new Subject("CS201", "Data Structures", professor1);
            Subject subject3 = new Subject("CS301", ".net Program", professor2);

            // Initialize students
            List<Student> students = new List<Student>();

            for (int i = 1; i <= 10; i++)
            {
                string studentId = "S" + i.ToString("D3");
                string studentName = "Student " + i;
                string phoneNumber = "010-2865-1804" + i.ToString("D2");
                string email = "student" + i + "@hnu.com";

                // Create a student and enroll them in three subjects
                Student student = new Student(studentId, studentName, phoneNumber, email, computerScienceDepartment);
                student.EnrollSubject(subject1);
                student.EnrollSubject(subject2);
                student.EnrollSubject(subject3);

                students.Add(student);
            }

            // Print the initialized data for verification
            Console.WriteLine("Initialized Data:");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Console.WriteLine("Department:");
            Console.WriteLine(computerScienceDepartment);
            Console.WriteLine();

            Console.WriteLine("Professors:");
            Console.WriteLine(professor1);
            Console.WriteLine(professor2);
            Console.WriteLine();

            Console.WriteLine("Staff:");
            Console.WriteLine(staff1);
            Console.WriteLine(staff2);
            Console.WriteLine();

            Console.WriteLine("Subjects:");
            Console.WriteLine(subject1);
            Console.WriteLine(subject2);
            Console.WriteLine(subject3);
            Console.WriteLine();

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        static void Login()
        {
            Console.WriteLine("Enter your ID:");
            string id = Console.ReadLine();

            if (IsProfessor(id))
            {
                ProfessorLogin(id);
            }
            else if (IsStudent(id))
            {
                StudentLogin(id);
            }
            else
            {
                Console.WriteLine("Wrong ID. Login failed.");
            }
        }

        static bool IsProfessor(string id)
        {
            return id.StartsWith("P");
        }

        static bool IsStudent(string id)
        {
            // Check if the ID belongs to a student
            return id.StartsWith("S");
        }

        static void ProfessorLogin(string professorId)
        {
            Console.WriteLine("Professor Login Successful");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("1. Search for students");
            Console.WriteLine("2. Search for professors and staff");
            Console.WriteLine("3. Search for subjects");
            Console.WriteLine();

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchStudents();
                    break;
                case 2:
                    SearchProfessorsAndStaff();
                    break;
                case 3:
                    SearchSubjects();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void StudentLogin(string studentId)
        {
            Console.WriteLine("Student Login Successful");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.WriteLine("1. Search for students");
            Console.WriteLine("2. Search for professors");
            Console.WriteLine("3. Search for subjects");
            Console.WriteLine();

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchStudents();
                    break;
                case 2:
                    SearchProfessors();
                    break;
                case 3:
                    SearchSubjects();
                    break;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }

        static void SearchStudents()
        {
            Console.WriteLine("Search for students:");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            // Perform student search logic here
            Console.WriteLine("Showing search results...");
        }

        static void SearchProfessorsAndStaff()
        {
            Console.WriteLine("Search for professors and staff:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            // Perform professor and staff search logic here
            Console.WriteLine("Showing search results...");
        }

        static void SearchProfessors()
        {
            Console.WriteLine("Search for professors:");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            // Perform professor search logic here
            Console.WriteLine("Showing search results");
        }

        static void SearchSubjects()
        {
            Console.WriteLine("Search for subjects:");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            // Perform subject search logic here
            Console.WriteLine("Showing search results");
        }
    }

    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(string id, string name, string phoneNumber, string email)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class Professor : Person
    {
        public string Designation { get; set; }
        public Department Department { get; set; }

        public Professor(string id, string name, string phoneNumber, string email, string designation, Department department)
            : base(id, name, phoneNumber, email)
        {
            Designation = designation;
            Department = department;
        }

        public override string ToString()
        {
            return $"Professor ID: {Id}\nName: {Name}\nPhone: {PhoneNumber}\nEmail: {Email}\nDesignation: {Designation}\nDepartment: {Department.Name}\n";
        }
    }

    class Staff : Person
    {
        public string Role { get; set; }
        public decimal Salary { get; set; }

        public Staff(string id, string name, string phoneNumber, string email, string role, decimal salary)
            : base(id, name, phoneNumber, email)
        {
            Role = role;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Staff ID: {Id}\nName: {Name}\nPhone: {PhoneNumber}\nEmail: {Email}\nRole: {Role}\nSalary: {Salary}\n";
        }
    }

    class Student : Person
    {
        public Department Department { get; set; }
        public List<Subject> EnrolledSubjects { get; set; }

        public Student(string id, string name, string phoneNumber, string email, Department department)
            : base(id, name, phoneNumber, email)
        {
            Department = department;
            EnrolledSubjects = new List<Subject>();
        }

        public void EnrollSubject(Subject subject)
        {
            EnrolledSubjects.Add(subject);
        }

        public override string ToString()
        {
            string subjectList = string.Join(", ", EnrolledSubjects);

            return $"Student ID: {Id}\nName: {Name}\nPhone: {PhoneNumber}\nEmail: {Email}\nDepartment: {Department.Name}\nEnrolled Subjects: {subjectList}\n";
        }
    }

    class Subject
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Professor Professor { get; set; }

        public Subject(string code, string name, Professor professor)
        {
            Code = code;
            Name = name;
            Professor = professor;
        }

        public override string ToString()
        {
            return $"Subject Code: {Code}\nName: {Name}\nProfessor: {Professor.Name}\n";
        }
    }

    class Department
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Department(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Department Name: {Name}\nAddress: {Address}\nPhone: {PhoneNumber}\n";
        }
    }
}