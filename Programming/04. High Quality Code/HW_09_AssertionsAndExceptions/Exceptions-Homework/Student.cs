using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    //Fields
    private string firstName;
    private string lastName;

    //Constructor
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    //Properties
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("The first name cannot be missing!");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("The last name cannot be missing!");
            }
            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    //Methods
    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null || this.Exams.Count == 0)
        {
            throw new ArgumentNullException("There are no exams for this student!");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null || this.Exams.Count == 0)
        {
            throw new ArgumentNullException("There are no exams for this student! Cannot calculate average!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
