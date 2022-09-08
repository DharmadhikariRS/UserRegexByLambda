namespace UseOfRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex Problems");
            RegexProblem regexProblem = new RegexProblem();

            ////UC1 
            regexProblem.CheckFirstName("Rushi");

            ////UC2
            regexProblem.CheckLastName("Dharmadhikari");

            ///UC3
            regexProblem.CheckEmail("abc.xyz@bl.co.in");

            ///UC4
            regexProblem.CheckMobilNumber("91 8329806536");

            ///UC5
            regexProblem.CheckPassmin8Char("Xyz01234ab11");

            ///UC6
            regexProblem.CheckPass8CharWithUpperCase("A11apacs");

            ///UC7
            regexProblem.CheckPass8CharWithNumber("avtbdAdrbv2");

            ///UC8
            regexProblem.CheckPass8CharWithSpecialChar("abc@abcdefghij");

        }
    }
}