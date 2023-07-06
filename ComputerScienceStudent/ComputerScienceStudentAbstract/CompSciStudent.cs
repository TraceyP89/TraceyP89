using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScienceStudentAbstract
{
     class CompSciStudent : Student
    {
        // Constants to set the values for the required hours
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        //Fields
        private string _academicTrack;

        //Constructor
        public CompSciStudent(string name, string id, string track)
           : base(name, id)
        {
            AcademicTrack = track; 
        }
        //Get and set the data for the academic track
        public string AcademicTrack { get; set; }

        //this method will get the total hours required. This is read-only
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
