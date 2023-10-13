using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public  abstract class Goal // Super Class
    {
        protected string _shortName;
        protected string _description;
        protected string _points;

        public Goal(string shortname, string description, string points) // constructor
        {
            _shortName = shortname;
            _description = description;
            _points = points;
        }

        //creating getters and setters for the properties

        public string GetShortName()
        {
            return _shortName;
        }

        public void SetShortName( string shortname)
        {
            _shortName = shortname;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription( string description)
        {
            _description = description;
        }

        public string GetPoints()
        {
            return _points;
        }

        public void SetPoints( string points)
        {
            _points = points;
        }

        // Methods to be overridden in other classes Subclasses
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailString();
        public abstract  string GetStringRepresentation();

       


    }

}