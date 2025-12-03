using ConsoleApp18.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManager.Service
{
    /// <summary>
    /// Сервизен клас за управление на ученици и техните оценки.
    /// </summary>
    public interface IStudentService
    {
        /// <summary>
        /// Добавя нов ученик със зададено име и оценка.
        /// Ако ученик със същото име вече съществува, хвърля ArgumentException.
        /// </summary>
        /// <param name="name">Име на ученика (непразен низ).</param>
        /// <param name="grade">Оценка в интервала [2.00; 6.00].</param>
        void AddStudent(string name, double grade);

        /// <summary>
        /// Връща колекция от всички ученици.
        /// </summary>
        /// <returns>Списък от всички ученици.</returns>
        IReadOnlyCollection<Student> GetAllStudents();

        /// <summary>
        /// Намира ученика с най-висока оценка.
        /// Ако няма ученици, връща null.
        /// </summary>
        /// <returns>Ученика с най-висока оценка или null.</returns>
        Student? GetBestStudent();

        /// <summary>
        /// Изчислява средна оценка на всички ученици.
        /// Ако няма ученици, връща 0.
        /// </summary>
        /// <returns>Средна оценка.</returns>
        double GetAverageGrade();
    }

}
}
