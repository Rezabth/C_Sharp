﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string CourseName;

       private Dictionary<Student, string> stuDictionary = new Dictionary<Student, string>();
        List<Student> StudentsList = new List<Student>();

        

        public Exam(string courseName)
        {
            this.CourseName = courseName;
        }


        public void Assign(Student student)
        {
            stuDictionary.Add(student, "");
            
        }

        public void Grade(Student student, string grade)
        {

            if (!stuDictionary.ContainsKey(student))
                throw new UnassignedStudentException();
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            Dictionary<string, int> statistics = new Dictionary<string, int>();

            statistics.Add("IG", 0);
            statistics.Add("G", 0);
            statistics.Add("VG", 0);

            foreach (var student in stuDictionary)
            {
                statistics[student.Value]++;
            }
            return statistics;
        }
    }
}