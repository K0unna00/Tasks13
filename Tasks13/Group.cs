using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks13
{
    internal class Group
    {
        public string no;
        public Student[] students;
        public int studentLimit;
        public int j = 0;
        public void AddStudent(Student student)
        {
                students[j++] = student;
                Console.WriteLine("Telebe sayi : " + j);
        }
        public void getInfo(Student[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine($"Fullname : {item.fullname} \n  Group No : {item.groupNo} \n  Avarage Point :  {item.avgPoint}");
            }
        }
        public void getFiltered(string name)
        {
            foreach (var item in students)
            {
                if (item.fullname == name )
                {
                    Console.WriteLine($"Fullname : {item.fullname}\nGroup No : {item.groupNo} \nAvarage Point :  {item.avgPoint}");
                }
            }
        }
    }
}
