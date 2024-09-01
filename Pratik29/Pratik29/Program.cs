

using Pratik29;
using System.Security.Claims;

// Class sınıfından oluşan Liste tanımlaması ve Nesne üretimi
List<Class> classes = new List<Class>
{
    new Class(1, "Matematik"),
    new Class(2, "Türkçe"),
    new Class(3, "Kimya"),
};

// Student sınıfından oluşan Liste tanımlaması ve Nesne üretmi
List<Student> students = new List<Student>
{
    new Student(1, "Ali", 1),
    new Student(2, "Ayşe", 2),
    new Student(3, "Mehmet", 1),
    new Student(4, "Fatma", 3),
    new Student(5, "Ahmet", 2),
};


// Sınıfları ve öğrencileri gruplayan "GROUP JOIN" LINQ sorgusu
var query = classes.GroupJoin(students,
                              @class => @class.ClassID,
                              student => student.ClassID,
                              (@class, studentGroup) => new
                              {
                                  @Class = @class,
                                  Students = studentGroup
                              });


// Liste elemanlarını Konsol ekranına yazdırma
foreach (var qy in query)
{
    Console.WriteLine("Sınıf: " + qy.Class.ClassName);
    foreach (var student in qy.Students)
    {
        Console.WriteLine(" - " + student.StudentName);
    }
}