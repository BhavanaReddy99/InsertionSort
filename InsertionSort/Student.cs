using System;

namespace InsertionSort
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    class Student1
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            Student[] students = {
            new Student("Alice", 85),
            new Student("Bob", 72),
            new Student("Charlie", 93),
            new Student("David", 64),
            new Student("Eve", 78)
        };

            Console.WriteLine("Unsorted Students:");
            PrintStudents(students);

            // Sort students using Insertion Sort
            InsertionSort(students);

            Console.WriteLine("\nSorted Students by Score (ascending):");
            PrintStudents(students);
        }

        static void InsertionSort(Student[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Student key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].Score > key.Score)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            }
        }
    }
}
