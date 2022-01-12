using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Bear
    {


        #region Class Parameters
        private String _species;
        private int _age;
        private bool _isGrizzly;
        #endregion

        #region Class Constructors 
        public Bear() { }
        public Bear(String species, int age, bool isGrizzly)
        {

            _species = species;
            _age = age;
            _isGrizzly = isGrizzly;
        }
        #endregion

        #region Class Methods
        public void getDescription(bool isGrizzly)
        {
            _isGrizzly = isGrizzly;
        }
        public void displayDescription()
        {
            Console.WriteLine(_isGrizzly.ToString());
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
            if (_isGrizzly)
                toString = ("The Bear is " + _age + " yrs old, it is a grizzly bear").ToString(); 
            else
                toString = ("The Bear is " + _age + " yrs old, it is not a grizzly bear").ToString();
            return toString;
        }
        #endregion

    }
}
