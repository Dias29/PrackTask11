using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask11
{
    public struct Empolyee
    {
        private const int DATE_ADMISSON = 3;
        public string Name { get; set; }
        VacanciesType Vacancy;
        public int Salary { get; set; }
        public int[] DateAdmission;

        public Empolyee(string name, VacanciesType vacancy, int salary, int Day, int Month, int Year)
        {
            Name = name;
            Vacancy = vacancy;
            Salary = salary;
            DateAdmission = new int[DATE_ADMISSON];
            DateAdmission[0] = Day;
            DateAdmission[1] = Month;
            DateAdmission[2] = Year;
        
        }

        
    }
}
