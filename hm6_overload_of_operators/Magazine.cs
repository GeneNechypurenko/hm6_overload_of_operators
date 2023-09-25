using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6_overload_of_operators
{
    internal class Magazine : OutputManager
    {
        private string _title;
        private string _year;
        private string _description;
        private string _phone;
        private string _email;
        public int Employees { get; set; }
        public Magazine(int employees)
        {
            Employees = employees;
        }
        public static Magazine operator +(Magazine m1, Magazine m2)
        {
            return new Magazine(m1.Employees + m2.Employees);
        }
        public static Magazine operator +(Magazine m1, int value)
        {
            return new Magazine(m1.Employees + value);
        }
        public static Magazine operator -(Magazine m1, Magazine m2)
        {
            return new Magazine(m1.Employees - m2.Employees);
        }
        public static Magazine operator -(Magazine m1, int value)
        {
            return new Magazine(m1.Employees - value);
        }
        public static bool operator ==(Magazine m1, Magazine m2)
        {
            return m1.Employees == m2.Employees;
        }
        public static bool operator !=(Magazine m1, Magazine m2)
        {
            return m1.Employees != m2.Employees;
        }
        public static bool operator <(Magazine m1, Magazine m2)
        {
            return m1.Employees < m2.Employees;
        }
        public static bool operator >(Magazine m1, Magazine m2)
        {
            return m1.Employees > m2.Employees;
        }
        public string Title
        {
            get => _title;
            set
            {
                CheckInput(nameof(Title), value);
                _title = value;
            }
        }
        public string Year
        {
            get => _year;
            set
            {
                CheckInput(nameof(Year), value);
                _year = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                CheckInput(nameof(Description), value);
                _description = value;
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                CheckInput(nameof(Phone), value);
                _phone = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                CheckInput(nameof(Email), value);
                _email = value;
            }
        }
        public override string ToString()
        {
            var input = new StringBuilder();

            input.AppendLine($"Numer of Employees: {Employees}");

            return input.ToString();
        }
    }
}
