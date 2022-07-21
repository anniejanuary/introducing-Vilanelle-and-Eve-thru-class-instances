using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnClass_Exercise
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string firstName, string lastName, string eyeColor, int age) //every time sb creates Human they need to give these 2 information
        {
            this.firstName = firstName; //allocates "this" firstname as the first name I'm corrently using?? or sth
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            if(age > 1)
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I'm {age} years old and my eyes are {eyeColor}");
            }

            else
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}, I'm {age} year old and my eyes are {eyeColor}");
            }
            
        }
    }
}
