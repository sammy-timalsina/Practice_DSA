using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LLDs.InterfacesWithCollections
{
    public class Student:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
           if(this.Marks>other.Marks)
                return 1;
           else if(this.Id<other.Id)
                return -1;
           return 0;
        }
    }
    public class CompareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
           if(x.Id>y.Id)
               return 1;
           else if(x.Id<y.Id)
               return -1;
           else return 0;
        }
    }
    public class TestStudent
    {
        public void TestMain()
        {
            //Student s1 = new Student { Id = 105, Name ="Hari", Class = 12 ,Marks = 225f};
            //Student s2 = new Student { Id = 102, Name = "Pari", Class = 12, Marks = 444f };
            //Student s3 = new Student { Id = 113, Name = "John", Class = 12, Marks = 333f };
            //Student s4 = new Student { Id = 104, Name = "Rob", Class = 12, Marks = 675f };
            //Student s5 = new Student { Id = 109, Name = "Duke", Class = 12, Marks = 625f };

            //List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            ////to make sort work, you should write the logic explicitly
            ////students.Sort();
            //CompareStudent obj = new CompareStudent();  
            //students.Sort(obj);
            //foreach(Student student in students)
            //{
            //    Console.WriteLine(student.Id +" "+ student.Name +" "+student.Class +" "+student.Marks);
            //}
            KthSmallestElement();
        }
        public void KthSmallestElement()
        {
            //arr
            int[] arr = new int[] { 7, 10, 4, 3, 20, 15 };
            int k = 3;
            PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
            PriorityQueue<int,int> maxHeap = new PriorityQueue<int, int>(new ComparePQ()); //Max Heap
            for(int i=0;i<arr.Length;i++)
            {
                maxHeap.Enqueue(arr[i],arr[i]);
                if (maxHeap.Count > k)
                    maxHeap.Dequeue();

                minHeap.Enqueue(1, arr[i]);
            }
            var ans = maxHeap.Dequeue();
        }
    }
    public class ComparePQ : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return -1;
            else if (x < y) return 1;
            else return 0;
        }
    }
}
