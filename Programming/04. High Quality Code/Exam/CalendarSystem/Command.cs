using System;

namespace CalendarSystem
{
    public struct Command
    {
        public string CommandName { get; private set; }
        public string[] CommandParams { get; private set; }

        public static Command Parse(string cmd)
        {
            int firstSeparatorIndex = cmd.IndexOf(' ');
            if (firstSeparatorIndex == -1 || firstSeparatorIndex == 0)
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }

            string name = cmd.Substring(0, firstSeparatorIndex);
            string arguments = cmd.Substring(firstSeparatorIndex + 1);

            string[] cmdArguments = arguments.Split('|');
            for (int i = 0; i < cmdArguments.Length; i++)
            {
                cmdArguments[i] = cmdArguments[i].Trim();
            }

            return new Command { CommandName = name, CommandParams = cmdArguments };
        }
    }
}
