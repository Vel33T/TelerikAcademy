using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || problemsSolved > 10)
        {
            throw new ArgumentOutOfRangeException("Solved problems must be in range [0, 10]!");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved >= 0 && ProblemsSolved < 5)
        {
            return new ExamResult(2, 2, 6, "Bad result: Less then 5 problems solved.");
        }
        else if (ProblemsSolved >= 5 && ProblemsSolved <= 7)
        {
            return new ExamResult(4, 4, 6, "Average result: 5 to 7 problems solved.");
        }
        else
        {
            return new ExamResult(6, 2, 6, "Excelent result: More then 7 problems solved.");
        }
    }
}
