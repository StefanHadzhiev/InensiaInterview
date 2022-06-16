using Inensia.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Inensia
{
    public class MovieStar
    {
        public MovieStar(string name, string surname, Sex sex, string nationality, string dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Nationality = nationality;
            this.DateOfBirth = Convert.ToDateTime(dateOfBirth);
        }
        public DateTime DateOfBirth { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Sex Sex { get; private set; }

        public string Nationality { get; private set; }


        public int Age
        {
            get 
            {
                return (DateTime.Now.Year - this.DateOfBirth.Year);
            }
        }
    }
}
