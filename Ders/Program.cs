using System;
using System.Globalization;

class Person
{
    public string Name { get; set; }
    public string SurName { get; set; }

    public Person(string name,string Surname){
        this.Name=name;
        this.SurName=Surname;
        Console.WriteLine("Person nesnesi oluşturuldu.");
    }
     public virtual void Intro(){
        Console.WriteLine($"akademisyen adı : {this.Name} akademisyen soyadı:{this.SurName}");
    }
}

class student :Person{
    public int StudentNumber { get; set; }
    public student(string name,string Surname,int studentnumber):base(name,Surname){
        this.StudentNumber=studentnumber;
        Console.WriteLine("Student nesnesi oluşturuldu.");
    }
    public override void Intro(){
        Console.WriteLine($"öğrenci adı : {this.Name} öğrenci soyadı:{this.SurName} öğrenci numarası:{this.StudentNumber}");
    }
}
class Teacher:Person
{
public string Branch { get; set; }
    public Teacher(string name,string Surname,string branch):base(name,Surname)
    {
        this.Branch=branch;
        Console.WriteLine("Teacher nesnesi oluşturuldu.");
    }
    public void Teach(){
        Console.WriteLine("I am teaching...");
    }
    public override void Intro()
     {
         Console.WriteLine($"başkan adı:{this.Name} başkan soyadı:{this.SurName} başkanın branşı:{this.Branch}");
     }
}
class Program
{
    static void Main(string[] args){

      var person = new Person("Hakan","Aydın");

      var student = new student("Oktay","Erdoğan",436578);
      
      person.Intro();
      student.Intro();
      var TeacherErdo=new Teacher("Erdo","Erdogan","Bilgisayarın temelleri");
      TeacherErdo.Teach();
      TeacherErdo.Intro();
    }
}