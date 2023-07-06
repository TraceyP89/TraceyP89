using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScienceStudentAbstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getRequiredHoursButton_Click(object sender, EventArgs e)
        {
            //Variable that will hold the values for name, id and track
            string name, id, track;

            //Get student's name and ID.
            name = nameTextBox.Text;    
            id = idTextBox.Text;

            //Get student's academic track.
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information System";
            }
            else
            {
                track = "Software Engineering";
            }

            //Create a CompSciStudent object
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //Display student's reuired hours
            studentsNameLabel.Text = csStudent.Name;
            studentsIDLabel.Text = csStudent.ID;
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        //this closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
