namespace SinifYoklamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new();
            students.Add(new Student() { Name = "Ali", IsInClass = false, StudentId = 1 });
            students.Add(new Student() { Name = "Veli", IsInClass = false, StudentId = 2 });
            students.Add(new Student() { Name = "Ayşe", IsInClass = false, StudentId = 3 });
            students.Add(new Student() { Name = "Fatma", IsInClass = false, StudentId = 4 });
            students.Add(new Student() { Name = "Zeynep", IsInClass = false, StudentId = 5 });

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
            Console.WriteLine("Lütfen seçtiğiniz işlemin numarasını giriniz: ");

            int result = 0;
        tekrar:;
            while (true)
            {
                string answer = Console.ReadLine();

                if (!int.TryParse(answer, out result))
                {
                    Console.WriteLine("Lütfen seçeneği rakam olarak giriniz");
                    goto tekrar;
                }
                if (!(result > 0 && result < 5))
                {
                    Console.WriteLine("seçeneklerimiz: 1, 2, 3, 4 dür.Lütfen doğru giriş yaptığınızdan emin olunuz.");
                    goto tekrar;
                }
                if(result==1)
                {
                    Console.WriteLine("Sınıf Listesi:");
                    foreach(Student student in students) 
                    {
                        
                        Console.WriteLine();
                    }
                    break;
                }
                if (result == 2)
                {
                    Console.WriteLine("Sınıf Listesi:");
                    foreach (Student student in students)
                    {
                        Console.WriteLine("1. ");
                    }
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
    public int StudentId;
}