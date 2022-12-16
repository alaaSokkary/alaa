using System;
namespace alaa;
public abstract class Person{
    public string Name;
    public int Age;
    
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
        public abstract void Print();
}
public class Student : Person{
    public int Year;
    public float Gpa;
    public Student(string name, int age, int year, float gpa) : base(name, age) 
    { 
        Year = year;
        Gpa = gpa;
    }
    public override void Print() {
        Console.WriteLine ($"Name: {Name}, Age: {Age}, Gpa: {Gpa}");
    }
}

} 
public class Staff :Person{

public double Salary;
public int JoinYear;
public Staff (string name,int age,double salary ,int joinyear):base(name,age){
Salary=salary;
JoinYear=joinyear;
}
public override void Print(){
        Console.WriteLine($"My name is{Name},my age is{Age},and my salary is {Salary}");
    }

}

public class Database{
    public Person[] People=new Person[50];
    private int currentIndex=0;
    public void AddStudent(Student student){
        People[currentIndex++]=student;
    }
    public void AddStaff(Staff staff){
        People[currentIndex++]=staff;
    }
    public void PrintAll(){
        for(int i=0;i<currentIndex;i++){
        Console.WriteLine( People[i]);
        }
    }
}

public  class Program{

private static void Main(){
    Console.WriteLine("enter a number 1)student 2)staff 3)print all peaple");
    int x=1;
    var database=new Database();
    while (x!=0)
    {
        x=Convert.ToInt32(Console.ReadLine());
        switch (x)
    {
        case 1:
        Console.Write("Name: ");
        var name=Console.ReadLine();
        Console.Write("Age: ");
        var age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        var year =Convert.ToInt32(Console.ReadLine());
        Console.Write("Gpa: ");
        var gpa = Convert.ToSingle(Console.ReadLine());
        var student =new Student(name,age,year,gpa);
        database.AddStudent(student);
        break;
        
        case 2:
        Console.Write("Name: ");
        name=Console.ReadLine();
        Console.Write("Age: ");
        age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Salary: ");
        var salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("JoinYear: ");
        var joinyear = Convert.ToInt32(Console.ReadLine());
        var staff =new Staff(name,age,salary,joinyear);
        database.AddStaff(staff);
        break;
       case 3:
        Console.WriteLine("Enter the Name :  ");
        String name = Console.ReadLine();
        Console.WriteLine("Enter the Age :  ");
        int age = int.Parse( Console.ReadLine());
        var person =new Person(name,age);
        data_b.AddPerson(person);

         break;
         case 4:
         data_b.print_everthing();
         break;
         default:
         Console.WriteLine("Error input !!!!!!!!!");
         break;
        
    }

}
}
