using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning05
{
    public class Employee    // by Naming your class abstract you have to override the method
    {
        protected string _name;
        protected string _idNumber;

        public Employee() // constructor
        {
        }

        public string GetName() //getter
        {
            return _name;
        }

        public void SetName(string name) // setter
        {
            _name = name;
        }

        public string GetIdNumber() //getter
        {
            return _idNumber;
        }

        public void SetIdNumber(string idNumber)
        {
            _idNumber = idNumber;
        }

        public virtual float GetPay() // The keyword "virtual" will let C# know that this method can be overridden
        {
            return -1;
        }

        // An abstract function does not have a body . You also have to name the base class Abstract as well

        //public abstract float GetPay();
        

        

    }
}