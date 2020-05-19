using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string major;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "함기훈", major = "C#" });
            list.Add(new Teacher() { name = "박성래", major = "수학" });
            list.Add(new Teacher() { name = "민주리", major = "DBP" });
            list.Add(new Teacher() { name = "김보경", major = "가정" });
            list.Add(new Teacher() { name = "장민주", major = "디자인" });
            list.Add(new Teacher() { name = "최규정", major = "JSP" });
            list.Add(new Teacher() { name = "신혜정", major = "Node.js" });

            for (int i = list.Count - 1; i >= 0; i--) 
            {
                if (list[i].major == "C#")
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.major);
            }
        }
    }
}