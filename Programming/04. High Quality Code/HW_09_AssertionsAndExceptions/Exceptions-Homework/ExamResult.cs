﻿using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("Grade cannot be negative!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("Minimum grade cannot be negative!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximum grade must be bigger than minimum grade!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Comments cannot be null or empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
