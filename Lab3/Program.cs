namespace Lab3
{
    public class Lab3
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentence: ");
            List<string> Sentence1 = new List<string>(); 
            string sent = Console.ReadLine();
            Sentence1 = sent. Split(' ').ToList();

            Sentence sentence = new Sentence();
            
            Console.WriteLine("Enter the word you`d like to add: "); 
            string word1 = Console.ReadLine();
            sentence.AddWord(Sentence1, word1);  
            
            Console.WriteLine("Enter the number of the word you`d like to delete: "); 
            int numb1 = Int32.Parse(Console.ReadLine());
            numb1 -= 1;
            sentence.DeleteWord(Sentence1, numb1);
            
            Console.WriteLine("Enter the number of the word you`d like to insert: ");
            int numb2 = Int32.Parse(Console.ReadLine());
            numb2 -= 1;
            Console.WriteLine("Enter the word you`d like to insert: ");
            string word2 = Console.ReadLine();
            sentence.InsertWord(Sentence1, numb2, word2); 

            sentence.CountOfLetters(Sentence1);
            
            sentence.CountOfWords(Sentence1);
            
            sentence.TheLongest(Sentence1);
            
            sentence.TheShortest(Sentence1);
            
            Console.WriteLine("Enter the word you`d like to check: "); 
            string word3 = Console.ReadLine();
            sentence.ExistTheWord(Sentence1,word3);
            
            Console.WriteLine("Enter the number of the word you`d like to find: ");
            int numb4 = Int32.Parse(Console.ReadLine());
            sentence.FindNumb(Sentence1,numb4);
            
            Console.WriteLine("Enter second sentence: ");
            List<string> Sentence2 = new List<string>(); 
            string sent2 = Console.ReadLine();
            Sentence2 = sent2. Split(' ').ToList();
            sentence.Equal(Sentence1,Sentence2);
        }
    }
}


