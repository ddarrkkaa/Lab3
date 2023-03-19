namespace Lab3
{
    public class Lab3
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentence: ");
            List<string> Sentence1 = new List<string>(); 
            string sent = Console.ReadLine();
            Sentence1 = sent.Split(",").ToList();
            Sentence sentence = new Sentence();
            
            Console.WriteLine("Enter the word you`d like to add: "); //adding
            string word1 = Console.ReadLine();
            sentence.AddWord(Sentence1, word1);  //злипається останнє слово
            
            Console.WriteLine("Enter the number of the word you`d like to delete: "); //deleting
            int numb1 = Int32.Parse(Console.ReadLine());
            numb1 -= 1;
            sentence.DeleteWord(Sentence1, numb1);
            
            int numb2 = Int32.Parse(Console.ReadLine());
            string word2 = Console.ReadLine();
            sentence.InsertWord(Sentence1, numb2, word2);
        }
    }
}


