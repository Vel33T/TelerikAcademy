using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class Teacher : ITeacher
    {
        public string Name { get; set; }
        private List<ICourse> courses = new List<ICourse>();

        public Teacher(string name = null)
        {
            this.Name = name;
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Teacher: Name=");
            result.Append(this.Name);
            if (courses.Count > 0)
            {
                result.Append("; Courses=[");
                foreach (ICourse course in courses)
                {
                    result.Append(course.Name);
                    result.Append(", ");
                }
                result.Length -= 2;
                result.Append("]");
            }
            return result.ToString();
        }
    }

    public abstract class Course : ICourse
    {
        public string Name { get; set;}
        public ITeacher Teacher { get; set; }

        private List<string> Topics = new List<string>();

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Name=");
            result.Append(this.Name);
            if (this.Teacher != null)
            {
                result.Append("; Teacher=");
                result.Append(this.Teacher.Name); 
            }
            if (Topics.Count > 0)
            {
                result.Append("; Topics=[");
                foreach (string topic in Topics)
                {
                    result.Append(topic);
                    result.Append(", ");
                }
                result.Length -= 2;
                result.Append("]"); 
            }
            return result.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, ITeacher teacher, string town)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + ": ");
            result.Append(base.ToString());
            result.Append("; Town=");
            result.Append(this.Town);
            return result.ToString();
        }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }

        public LocalCourse(string name, ITeacher teacher, string lab)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Lab = lab;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + ": ");
            result.Append(base.ToString());
            result.Append("; Lab=");
            result.Append(this.Lab);
            return result.ToString();
        }
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
