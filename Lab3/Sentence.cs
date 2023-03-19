namespace Lab3
{
    public class Sentence
    {
        public void AddWord(List<string> sentence, string word)
        {
            sentence.Add(word);
            foreach (string element in sentence) 
            {
                Console.Write(element);
            }
        }
        public void DeleteWord(List<string> sentence, int numb)
        {
            sentence.RemoveAt(numb);
            foreach (string element in sentence) 
            {
                Console.WriteLine(element);
            }
        }
        public void InsertWord(List<string> sentence,int numb, string word)
        {
            sentence.Insert(numb,word);
            foreach (string elementr in sentence) 
            {
                Console.Write(elementr);
            }                                                        
        }

        public void CountOfLetters(List<string> se)
        {
            
        }
    }
}

