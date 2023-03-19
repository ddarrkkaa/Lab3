namespace Lab3
{
    public class Sentence
    {
        public void AddWord(List<string> sentence, string word)
        {
            sentence.Add(word);
            foreach (string element in sentence) 
            {
                Console.WriteLine(element);
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
            foreach (string element in sentence) 
            {
                Console.WriteLine(element);
            }                                                        
        }

        public void CountOfLetters(List<string> sentence)
        {
            List<char> charList = sentence.SelectMany(str => str.ToCharArray()).ToList();
            Console.WriteLine($"The count of lrtters is: {charList.Count()}");
        }
        public void CountOfWords(List<string> sentence)
        {
            Console.WriteLine($"The count of words is: {sentence.Count()}");
        }

        public void TheLongest(List<string> sentence)
        {
            string longestWord = sentence.OrderByDescending(s => s.Length).FirstOrDefault();
            Console.WriteLine($"The longest word is: {longestWord}");
        }
        public void TheShortest(List<string> sentence)
        {
            string shortestWord = sentence.OrderByDescending(s => s.Length).LastOrDefault();
            Console.WriteLine($"The shortest word is: {shortestWord}");
        }

        public void ExistTheWord(List<string> sentence, string word)
        {
            bool exist = sentence.Contains(word);
            if (exist==true)
                Console.WriteLine("This word is in the sentence");
            else
                Console.WriteLine("This word is not in the sentence");
        }

        public void FindNumb(List<string> sentence, int numb)
        {
            int numb2 = numb-1;
            Console.WriteLine($"The word {numb} is {sentence[numb2]}");
        }

        public void Equal(List<string> sentence, List<string> sentence2)
        {
            //bool eq = false;
            if(sentence.Count()==sentence2.Count())
                Console.WriteLine("the sentences are equal");
            else
                Console.WriteLine("the sentences aren`t equal");
        }
    }
}

