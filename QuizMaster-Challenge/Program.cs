namespace QuestionsMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Quiz completed");
            }
        }
        public static void StartQuiz()
        {
            List<string> Questions = new List<string>();
            Questions.Add("What year is it now: ");
            Questions.Add("What organization is this course in: ");
            Questions.Add("What is: 5*5: ");
            Questions.Add("What code language is this in: ");

            List<string> Answers = new List<string>();
            Answers.Add("2024");
            Answers.Add("ltuc");
            Answers.Add("25");
            Answers.Add("c#");

            int mark = 0;

            for (int i = 0; i < Questions.Count; i++) 
            {
                Console.Write($"{Questions[i]}");
                string answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("Please enter a valid answer.");
                    i--;
                    continue;
                }

                if (answer.ToLower() == Answers[i].ToLower())
                {
                    mark++;
                    Console.Write("Your answer is correct");
                }

                else
                {
                    Console.Write("Your answer is incorrect");
                }

                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine($"Your mark is {mark}/{Questions.Count}");
        }
    }
}
