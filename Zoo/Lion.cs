using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Lion
    {
        #region Class Parameters
        private String _species, _maneColor;
        private int _age;
        #endregion

        #region Class Constructors 
        public Lion() { } 
        public Lion(String species, int age, String maneColor){

            _species = species;
            _age = age;
            _maneColor = maneColor;
        }
        #endregion

        #region Class Methods
        public void getDescription(String maneColor)
        {
            _maneColor = maneColor;
        }
        public void displayDescription()
        {
            Console.WriteLine(_maneColor);
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
            
                toString = ("The Lion is " + _age + " yrs old, it's mane is " + _maneColor);

            return toString;
        }
        #endregion
    }
}
