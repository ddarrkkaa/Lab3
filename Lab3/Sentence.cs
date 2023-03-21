namespace Lab3
{
    public class Sentence
    {
        public List<string> FirstS = new List<string>(); 
        public void AddWord( string word)
        {
            FirstS.Add(word);
        }
        public void DeleteWord( int numb)
        {
            FirstS.RemoveAt(numb);
        }
        public void InsertWord(int numb, string word)
        {
            FirstS.Insert(numb,word);
        }

        public void CountOfLetters()
        {
            List<char> charList = FirstS.SelectMany(str => str.ToCharArray()).ToList();
            Console.WriteLine($"The count of letters is: {charList.Count()}");
        }
        public void CountOfWords()
        {
            Console.WriteLine($"The count of words is: {FirstS.Count()}");
        }

        public void TheLongest()
        {
            string longestWord = FirstS.OrderByDescending(s => s.Length).FirstOrDefault();
            Console.WriteLine($"The longest word is: {longestWord}");
        }
        public void TheShortest()
        {
            string shortestWord = FirstS.OrderByDescending(s => s.Length).LastOrDefault();
            Console.WriteLine($"The shortest word is: {shortestWord}");
        }

        public void ExistTheWord( string word)
        {
            bool exist = FirstS.Contains(word);
            if (exist==true)
                Console.WriteLine("This word is in the sentence");
            else
                Console.WriteLine("This word is not in the sentence");
        }

        public void FindNumb(int numb)
        {
            int numb2 = numb-1;
            Console.WriteLine($"The word {numb} is {FirstS[numb2]}");
        }

        public void Equal(List<string> SecondS)
        {
            //bool eq = false;
            if(FirstS.Count()==SecondS.Count())
                Console.WriteLine("the sentences are equal");
            else
                Console.WriteLine("the sentences aren`t equal");
        }

        public void Show()
        {
            foreach (var VARIABLE in FirstS)
            {
                Console.Write(VARIABLE+" ");
            }
            Console.WriteLine();
        }
    }
}

