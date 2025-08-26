using System;
using System.Collections.Generic;

namespace Assignment1._4
{
    public class Point
    {
        public int x { get; set; } 
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //X - Left and right
        //Y - Up and down
        public void XComparison(Point p1, Point p2)
        { //P1- 1,2   P2- 3,4
            if (p2.x > p1.x) Console.Write("Point 2 is to the right of Point 1");
            else if (p2.x < p1.x) Console.Write("Point 2 is to the left of Point 1");
            else if (p2.x == p1.x) Console.Write("Point 2 is on the same axis of Point 1");
        }
        public void YComparison(Point p1, Point p2)
        {
            if (p2.y > p1.y) Console.Write("above Point 1");
            else if (p2.y < p1.y) Console.Write("below Point 1");
            else if (p2.y == p1.y) Console.Write("on the same axis of Point 1");
        }
        /*
        public void XYComparison(Point p1, Point p2)
        {
            if (p2.x == p1.x && p2.y == p1.y) Console.WriteLine("Point 2 and Point 1 are on the same point");
            if (p2.x > p1.x && p2.y > p1.y) Console.WriteLine("Point 2 is above and to the right of Point 1");
            if (p2.x < p1.x && p2.x < p1.y) Console.WriteLine("Point 2 is below and to the left of Point 1");
            if (p2.x < p1.x && p2.y > p1.y) Console.WriteLine("Point 2 is below and to the right of Point 1");
            if (p2.x > p1.x && p2.y < p1.y) Console.WriteLine("Point 2 is above to the left of Point 1");
        }
        */
        public void XYComparison(Point p1, Point p2)
        {
            if (p2.x == p1.x && p2.y == p1.y)
            {
                Console.WriteLine("Point 2 and Point 1 are on the same point");
            }
            else
            {
                XComparison(p1, p2);
                Console.Write(" and ");
                YComparison(p1, p2);
                Console.WriteLine("");
            }
        }
    }

    public class Student
    {
        private int StudentId { get; set; }
        private string ?StudentFName { get; set; }
        private string ?StudentLName { get; set; }
        private char StudentGrade { get; set; }

        public Student(int StudentId, string StudentFName, string StudentLName, char StudentGrade)
        {
            this.StudentId = StudentId;
            this.StudentFName = StudentFName;
            this.StudentLName = StudentLName;
            this.StudentGrade = StudentGrade;
        }
        public override string ToString()
        {
            return $"ID: {StudentId}, Name: {StudentFName} {StudentLName}, Grade: {StudentGrade}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing Points
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            //p1.XYComparison(p1, p2);


            //Testing Students
            Student Gary = new Student(1, "Gary","Rojas", 'A' );
            Console.WriteLine(Gary);

        }
    }
}
