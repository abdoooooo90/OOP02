using System.ComponentModel.DataAnnotations.Schema;

namespace OOP02
{
    #region 1- Design and implement a Class for the employees in a company:
    //internal class Employee
    //{
    //    private int id;
    //    private decimal salary;
    //    private string name;
    //    private int securityLevel;
    //    private DateTime hireDate;
    //    private string gender;

    //    public int ID
    //    {
    //        get { return id; }
    //        set
    //        {
    //            if (value <= 0)
    //                Console.WriteLine("Invalid Id: ");
    //            id = value;
    //        }
    //    }
    //    public decimal Salary
    //    {
    //        get { return salary; }
    //        set 
    //        {
    //            if (value < 0)
    //                Console.WriteLine("Invalid Salary: ");
    //            salary = value;
    //        }
    //    }
    //    public string Name
    //    {
    //        get { return name; }
    //        set 
    //        {
    //            if (string.IsNullOrWhiteSpace(value))
    //                Console.WriteLine("Invalid Name: ");
    //            name = value;
    //        }
    //    }
    //    public string Gender
    //    {
    //        get { return gender; }
    //        set 
    //        {
    //            if (value != "Male" && value != "Female")
    //                Console.WriteLine("Invalid Gender: ");
    //            gender = value;
    //        }
    //    }
    //    public DateTime HireDate
    //    {
    //        get { return hireDate; }
    //        set 
    //        {
    //            if (value > DateTime.Now)
    //                Console.WriteLine("Invalid Date: ");
    //            hireDate = value;
    //        }
    //    }
    //    public int SecurityLevel
    //    {
    //        get { return securityLevel; }
    //        set 
    //        {
    //            if (value > 10 || value <= 0)
    //                Console.WriteLine("Invalid SecurityLevel: ");
    //            securityLevel = value;
    //        }
    //    }
    //    public Employee(int _id, string _name, decimal _salary, int _security, string _gender, DateTime _hireDate)
    //    {
    //        id = _id;
    //        name = _name;
    //        gender = _gender;
    //        hireDate = _hireDate;
    //        salary = _salary;
    //        securityLevel = _security;
    //        gender = _gender;
    //    }
    //    public Employee() : this(1,"Saad", 20000, 10, "Male", DateTime.Now)
    //    { }
    //    public override string ToString()
    //    {
    //        return $"id\tName\tGender\tSalary\tHireDate\t\tSecurityLevel\n{id}\t{name}\t{gender}\t{salary}\t{hireDate}\t\t{securityLevel}";
    //    }

    //}
    #endregion

    #region 2-Develop a Class to represent the Hiring Date Data
    //internal class HiringDate
    //{
    //    private int month;
    //    private int day;
    //    private int year;
    //    public int Month
    //    {
    //        get { return month; } 
    //        set 
    //        {
    //            if (value < 1 || value > 12)
    //                throw new ArgumentException("Invalid Month");
    //            month = value;
    //        } 
    //    }
    //    public int Day
    //    {
    //        get { return day; }
    //        set
    //        {
    //            if (value < 1 || value > DateTime.DaysInMonth(year, month))
    //                throw new ArgumentException("Invalid Day");
    //            day = value;
    //        }
    //    }
    //    public int Year
    //    {
    //        get { return year; }
    //        set
    //        {
    //            if (value < 1900 || value > DateTime.Now.Year)
    //                throw new ArgumentException("Invalid Year");
    //            year = value;
    //        }
    //    }
    //    public HiringDate(int month, int day, int year)
    //    {
    //        this.month = month;
    //        this.day = day;
    //        this.year = year;
    //    }
    //    public HiringDate():this(DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year)
    //    {

    //    }
    //    public override string ToString()
    //    {
    //        return $"The Date: {month}-{day}-{year}";
    //    }
    //}
    #endregion

    #region 3- We need to restrict the Gender field to be only M or F [Male or Female]
    //internal class Gender
    //{
    //    private string sex;
    //    public string Sex
    //    {
    //        get { return sex; }
    //        set
    //        {
    //            if (value != "Male" && value != "Female")
    //                Console.WriteLine("Invalid Gender: ");
    //            sex = value;
    //        }
    //    }
    //    public Gender(string s)
    //    {
    //        sex = s;
    //    }
    //    public Gender() :this("Male"){ }
    //    public override string ToString()
    //    {
    //        return $"Gender: {sex}";
    //    }
    //}
    #endregion

    #region 4- Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    //internal class Employee
    //{
    //    public enum SecurityPrivilege
    //    {
    //        Guest,
    //        Developer,
    //        Secretary,
    //        DBA
    //    }

    //    
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public SecurityPrivilege Privilege { get; set; }
    //    public double Salary { get; set; }
    //    public DateTime HireDate { get; set; }

    //    public Employee(int id, string name, string gender, SecurityPrivilege privilege, double salary, DateTime hireDate)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        Privilege = privilege;
    //        Salary = salary;
    //        HireDate = hireDate;
    //    }

    //    public override string ToString()
    //    {
    //        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Privilege: {Privilege}, Salary: {Salary:C}, Hire Date: {HireDate}";
    //    }
    //}
    #endregion

    #region 5- We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
    //class Employee
    //{
    //        public int ID { get; set; }
    //        public string Name { get; set; }
    //        public string Gender { get; set; }
    //        public double Salary { get; set; }
    //        public DateTime HireDate { get; set; }

    //        public Employee(int id, string name, string gender, double salary, DateTime hireDate)
    //        {
    //            ID = id;
    //            Name = name;
    //            Gender = gender;
    //            Salary = salary;
    //            HireDate = hireDate;
    //        }

    //        public override string ToString()
    //        {
    //            return string.Format($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}, Hire Date: {HireDate}");
    //        }
    //}
    #endregion

    #region 6- Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

    //class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Gender { get; set; }
    //    public double Salary { get; set; }
    //    public DateTime HireDate { get; set; }

    //    public Employee(int id, string name, string gender, double salary, DateTime hireDate)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        Salary = salary;
    //        HireDate = hireDate;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}, Hire Date: {HireDate}");
    //    }
    //}
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region (test) Q1
            //Employee emp = new Employee();
            //Console.WriteLine(emp);
            #endregion

            #region (test) Q2

            //HiringDate date = new HiringDate();
            //Console.WriteLine(date);

            #endregion

            #region (test) Q3
            //Gender gender = new Gender();
            //Console.WriteLine(gender);
            #endregion

            #region (test) Q4
            //Employee employee = new Employee(1, "John Doe", "M", Employee.SecurityPrivilege.Developer, 50000, DateTime.Now);
            //Console.WriteLine(employee);
            #endregion

            #region (test) Q5
            //Employee employee = new Employee(1, "John Doe", "M", 50000, DateTime.Now);
            //Console.WriteLine(employee);
            #endregion

            #region (test) Q6
           // Employee[] employee = new Employee[3];
           // employee[0] = new Employee(1, "Ali", "Male", 70000, DateTime.Today);
           // employee[1] = new Employee(1, "Abdelfatah", "Male", 80000, DateTime.Today);
           // employee[2] = new Employee(1, "Arfa", "Male", 60000, DateTime.Today);
           //foreach(Employee emp in employee)
           // {
           //     Console.WriteLine(emp);
           // }
            #endregion
        }
    }
}
