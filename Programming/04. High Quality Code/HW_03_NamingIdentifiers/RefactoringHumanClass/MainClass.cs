using System;

namespace RefactoringHumanClass
{
    public class MainClass
    {
        public enum Sex { Male, Female };

        public static void Main()
        {
        }

        public class Human
        {
            public Sex Sex { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreateHuman(int age)
        {
            Human human = new Human();
            human.Age = age;
            if (age % 2 == 0)
            {
                human.Name = "The Bad Boy";
                human.Sex = Sex.Male;
            }
            else
            {
                human.Name = "The Hot Chick";
                human.Sex = Sex.Female;
            }
        }
    }
}
