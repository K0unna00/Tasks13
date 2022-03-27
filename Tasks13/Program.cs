using System;

namespace Tasks13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Grup nomresini ve Telebe limitini daxil edin : ");
            string No=Console.ReadLine();
            while (!(No.Length == 5 && char.IsUpper(No[0]) && char.IsUpper(No[1]) && char.IsDigit(No[2]) && char.IsDigit(No[3]) && char.IsDigit(No[4])))
            {
                Console.WriteLine("Yeniden Daxil edin : 2 Boyuk herf ve 3 reqem formatinda olmalidir");
                No = Console.ReadLine();
            }
            int studentLimit = int.Parse(Console.ReadLine());
            while (studentLimit >= 20 || studentLimit<=0)
            {
                Console.WriteLine("Limit 0dan kicik ve ya 20den boyuk ola bilmez ");
                studentLimit = int.Parse(Console.ReadLine());
            }
            Group qrup = new Group();
            qrup.students = new Student[studentLimit];
            bool check=true;
            while (check)
            {
                Console.WriteLine(" 1. Tələbə əlavə et \n 2. Bütün tələbələrə bax \n 3. Tələbələr üzrə axtarış et \n 0. Proqramı bitir");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Nece telebe elave olunmalidir ? ");
                            int count = int.Parse(Console.ReadLine());
                            if (count + qrup.j <= studentLimit)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine("Fullnami i yazin : ");
                                    string fullname = Console.ReadLine();
                                    
                                    Console.WriteLine("Ortalama bali yazin");
                                    int avgPoint = int.Parse(Console.ReadLine());
                                    Student student = new Student(fullname)
                                    {
                                        avgPoint = avgPoint,
                                        groupNo = No
                                    };
                                    qrup.AddStudent(student);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Limit buna icaze vermir");
                                break;
                            }
                        }
                        break;
                    case 2:
                        qrup.getInfo(qrup.students);
                        break;

                    case 3:
                        Console.WriteLine("Axtarmaq istediyiniz telebenin fullnameini yazin : ");
                        string fullnamefilter = Console.ReadLine();
                        qrup.getFiltered(fullnamefilter);
                        break;

                    case 0:
                        check = false;
                        break;

                    default:
                        break;
                }
            }
            
        }
    }
}
