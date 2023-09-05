using System.Runtime.CompilerServices;

namespace SinifYoklamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new();
            studentList.Add(new Student() { Name = "Ali", IsInClass = false, StudentNumber = 1 });
            studentList.Add(new Student() { Name = "Veli", IsInClass = false, StudentNumber = 2 });
            studentList.Add(new Student() { Name = "Ayşe", IsInClass = false, StudentNumber = 3 });
            studentList.Add(new Student() { Name = "Fatma", IsInClass = false, StudentNumber = 4 });
            studentList.Add(new Student() { Name = "Zeynep", IsInClass = false, StudentNumber = 5 });

            Console.WriteLine("------------------------");
            Console.WriteLine("Dersimize Hoşgeldiniz!");
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine("Derse Başlamadan Önce Yapılması Gerekenler");
            Console.WriteLine(" ");
            Console.WriteLine("Öğrenci Listesi için ------> 1");
            Console.WriteLine("Yoklama almak için  -------> 2");
            Console.WriteLine("Gelmeyenler Listesi için --> 3");
            Console.WriteLine("Çıkış yapmak istiyorsanız -> 4");
            Console.WriteLine(" ");

            int result = 0;

            while (true)
            {
                
                
                Console.WriteLine("İşlemin numarasını giriniz: ");
                string answer = Console.ReadLine();

                if (!int.TryParse(answer, out result))
                {
                    Console.WriteLine("Lütfen seçeneği rakam olarak giriniz");
                    continue;
                }
                if (!(result > 0 && result < 5))
                {
                    Console.WriteLine("seçeneklerimiz: 1, 2, 3, 4 dür.Lütfen doğru giriş yaptığınızdan emin olunuz.");
                    continue;
                }
                if (result == 1)
                {
                    Console.WriteLine("Sınıf Listesi:");
                    foreach (var student in studentList)
                    {
                        Console.WriteLine(student.StudentNumber + " -- " + student.Name);
                    }
                    Console.WriteLine("işleminiz başarıyla gerçekleşmiştir.");
                    Console.WriteLine("************************************************************************ ");
                    continue;
                }
                if (result == 2)
                {
                    Console.WriteLine("Sınıf Listesi:");
                    foreach (var student in studentList)
                    {
                        Console.WriteLine(student.StudentNumber + " -- " + student.Name + " Geldi mi? ( true / false ): ");
                        student.IsInClass = bool.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("işleminiz başarıyla gerçekleşmiştir.");
                    Console.WriteLine("************************************************************************ ");
                    continue;
                }
                if (result == 3)
                {
                    Console.WriteLine("Gelmeyenler Listesi:");
                    var notInClassList = studentList.Where(p => p.IsInClass == false).ToList();

                    foreach (var student in notInClassList)
                    {
                        Console.WriteLine(student.StudentNumber + " -- " + student.Name + " gelmedi!");
                    }
                    Console.WriteLine("işleminiz başarıyla gerçekleşmiştir.");
                    Console.WriteLine("************************************************************************ ");
                    continue;
                }
                if (result == 4)
                {
                    Console.WriteLine("İyi dersler dileriz..."); 
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

public class Student
{
    public string Name;
    public bool IsInClass;
    public int StudentNumber;
}
