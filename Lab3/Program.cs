using Newtonsoft.Json;
namespace Lab3
{
    public class Lab3
    {
        public static void Met1(Sentence sentence)
        {
            string result = JsonConvert.SerializeObject(sentence, Formatting.Indented);
            string filePath2 = @"C:\кпи\ОП\Lab3.json";
            File.WriteAllText(filePath2, result);
        }

        public static Sentence Met2()
        {
            string filePath2 = @"C:\кпи\ОП\Lab3.json";
            var result = JsonConvert.DeserializeObject<Sentence>(File.ReadAllText(filePath2));
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Enter the sentence: ");
            string sent = Console.ReadLine();
            var FirstS = sent.Split(' ').ToList();

            Sentence line = new Sentence();
            foreach (var VARIABLE in FirstS)
            {
                line.AddWord(VARIABLE);
            }
            line.Show();
            
            Console.WriteLine("Enter the word you`d like to add: "); 
            string word1 = Console.ReadLine();
            line.AddWord(word1);  
            
            Console.WriteLine("Enter the number of the word you`d like to delete: "); 
            int numb1 = Int32.Parse(Console.ReadLine());
            numb1 -= 1;
            line.DeleteWord(numb1);
            
            Console.WriteLine("Enter the number of the word you`d like to insert: ");
            int numb2 = Int32.Parse(Console.ReadLine());
            numb2 -= 1;
            Console.WriteLine("Enter the word you`d like to insert: ");
            string word2 = Console.ReadLine();
            line.InsertWord(numb2, word2); 

            line.CountOfLetters();
            
            line.CountOfWords();
            
            line.TheLongest();
            
            line.TheShortest();
            
            Console.WriteLine("Enter the word you`d like to check: "); 
            string word3 = Console.ReadLine();
            line.ExistTheWord(word3);
            
            Console.WriteLine("Enter the number of the word you`d like to find: ");
            int numb4 = Int32.Parse(Console.ReadLine());
            line.FindNumb(numb4);
            
            Console.WriteLine("Enter second sentence: ");
            List<string> SecondS = new List<string>(); 
            string sent2 = Console.ReadLine();
            SecondS = sent2. Split(' ').ToList();
            line.Equal(SecondS);

            Met1(line);
            Met2();
        }
    }
}


