using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Wolf
    {
        #region Class Parameters
        private String _species;
        private int _age, _speed;
   
        #endregion

        #region Class Constructors 
        public Wolf() { }
        public Wolf(String species, int age, int speed)
        {

            _species = species;
            _age = age;
            _speed = speed;
        }
        #endregion

        #region Class Methods
        public void getDescription(int speed)
        {
            _speed = speed;
        }
        public void displayDescription()
        {
            Console.WriteLine(_speed.ToString());
        }
        public void getSpecies(String species)
        {
            _species = species;
        }
        public void getAge(int age)
        {
            _age = age;
        }
     
        public String toString(String toString)
        {

            toString = ("The wolf is is " + _age + " yrs old, it can run " + _speed + "Km/Hr");

            return toString;
        }
        #endregion

    }
}
