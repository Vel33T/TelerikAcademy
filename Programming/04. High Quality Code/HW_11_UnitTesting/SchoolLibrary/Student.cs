namespace SchoolLibrary
{
    using System;

    public class Student
    {
        private string name;
        private readonly int id;
        private static int nextId = 10000;

        public Student(string name)
        {
            if (nextId > 99999)
            {
                throw new ArgumentOutOfRangeException("Ran out of available IDs!");
            }

            this.Name = name;
            this.id = nextId;
            nextId++;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student's name is not entered correctly!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Student's name must be atleast 2 characters long!");
                }

                this.name = value;
            }
        }

        public int Id 
        { 
            get { return this.id; } 
        }
    }
}
