//Author: Curtis Copa
//ID: 609869
//Date: 4/23/2024
//Goal: Calculate the average grade of up to 5 students for a single course.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysA___Curtis_Copa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //create the arrays which store the student names/grades
        string[] studentNames = new string[5];
        decimal[] courseGrades = new decimal[5];
        //this tracks the number of students added
        int currentStudents = 0;

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //this checks if there is space to add a student
            if (currentStudents < 5)
            {
                //this validates that the student name and grade textboxes aren't empty and that the data was entered correctly 
                if (!string.IsNullOrWhiteSpace(txtboxStudentName.Text) && decimal.TryParse(txtboxGrade.Text, out decimal grade) && grade >= 0 && grade <= 100)
                {
                    //name and grade is added to the array, and the current students are accumulated
                    studentNames[currentStudents] = txtboxStudentName.Text;
                    courseGrades[currentStudents] = grade;
                    currentStudents++;
                    //display a message confirming that the info was added
                    MessageBox.Show($"Student data has been added to array at index {currentStudents - 1}.");
                    txtboxStudentName.Clear();
                    txtboxGrade.Clear();
                }
                //display an error message if the input is invalid or if there is no more room in the array
                else
                {
                    MessageBox.Show("Please enter a valid student name and a course grade between 0 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Cannot add more data, the array is full.");
            }
        }

        private void buttonDisplayArray_Click(object sender, EventArgs e)
        {
            //create a variable to store the displayable text
            string displayText = "";
            //create accumulative variables for the number of students and grade points
            int totalStudents = 0;
            decimal totalGrade = 0;
            //the array is looped through
            for (int i = 0; i < studentNames.Length; i++)
            {
                //validate that a student name was entered
                if (!string.IsNullOrEmpty(studentNames[i]))
                {
                    //connect the newly input student name and grade to the displaytext variable
                    displayText += $"Student Name: {studentNames[i]}, Grade: {courseGrades[i]}%\n";
                    //accumulate the total students
                    totalStudents++;
                    //add the current grade to the total grades
                    totalGrade += courseGrades[i];
                }
                else
                {
                    //display (NOT ENTERED) if there is no data entered yet for any students in the array
                    displayText += "(NOT ENTERED)\n";
                }
            }
            
            //validate that students are entered
            if (totalStudents > 0)
            {
                //calculate the average grade, accumulate the total students and display the results 
                decimal averageGrade = totalGrade / totalStudents;
                displayText += $"\nTotal Students: {totalStudents}, Average Grade: {averageGrade:F2}%";
            }

            lblStudentData.Text = displayText;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear the textboxes, labels, and reset the total student count
            txtboxStudentName.Clear();
            txtboxGrade.Clear();
            lblStudentData.Text = "";
            currentStudents = 0;
            //clear the array elements
            Array.Clear(studentNames, 0, studentNames.Length);
            Array.Clear(courseGrades, 0, courseGrades.Length);
        }
    }

}

