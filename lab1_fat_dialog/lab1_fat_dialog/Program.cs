using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1_fat_dialog
{
    class Program
    {
        public static string[] answers =
    {
                "Well, I'm happy to hear that",
                "I see your point of view",
                "Well...it's hard to say",
                "I`m not sure",
                "Who knows...",
                "I'm not sure",
                "Sorry, but let's change theme. I don`t like this one",
                "At least I think so",
                "Exactly",
                "That's for sure",
            };
        public static string[] questions =
          {
                "What do you mean?",
                "Have you ever play basketball?",
                "Where you travel?",
                "Do you like your city?",
                "Do you really think so?",
                "What do you think about that?",
                "Where you wanna work?",
                "Is it true?",
                "What dreams you have, when you was small?",
                "You know something new about Intelligent Systems?",
                "You know something new about GameDev?",
                "So, what`s now?",
            };
        public static string[] generalAnswer = { "Yes, I ","Nope, I not "};
        public static string[] time = { "months","years","weeks"};
        public static string[] whyanswers = {
            "I really don`t know. Maybe, it`s magic.",
            "God knows.",
            "Because.",
            "Man, so hard questions, maybe something else?"
        };

        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Robot: Hi. How are you?");
            string result = "";
            while (true)
            {
                result = "Robot: ";
                string s = Console.ReadLine();
                string[] words = s.Split(' ');
                if (string.IsNullOrWhiteSpace(s))
                    Console.WriteLine("Robot: What`s new?");
                else
                {
                    if (s.Contains("?"))
                    {
                        if (s.Contains("Do") || s.Contains("Did") || s.Contains("Will") || s.Contains("Have"))
                        {
                            result += generalAnswer[r.Next(generalAnswer.Length)];
                            for (int i = 2; i < words.Length; i++)
                                result += words[i].Replace('?', '.')+" ";
                            result += "And you?";

                        }
                        else if (s.Contains("Why"))
                            result += whyanswers[r.Next(whyanswers.Length)];
                        else if (s.Contains("How long") || s.Contains("How often"))
                            result += "Hmmmm. Near " + r.Next(10)+ " " + time[r.Next(time.Length)];
                        else if (s.Contains("How"))
                            result += "O, I`m perfect.";
                        else result = answers[r.Next(answers.Length)];
                    }
                    else result += questions[r.Next(questions.Length)];
                    Console.WriteLine(result);
                }
            }
        }
    }
}
