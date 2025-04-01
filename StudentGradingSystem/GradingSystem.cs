using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.StudentGradingSystem
{
    public class GradingSystem
    {
        public void GradSystemInfo(List<Student> students, 
            Func<List<double>, double> calcAve,
            Predicate<double> checkIsPass,
            Action<Student, double, bool> displayData) { 

            foreach (var student in students)
            {
                var avgGrade = calcAve(student.Grades);
                var isStudentPass = checkIsPass(avgGrade);
                displayData(student, avgGrade, isStudentPass);
            }
        }
    }
}
