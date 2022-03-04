using System;
namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable Program.");
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] StringToArray== sentence.Split(' ');
            WordFrequency(StringToArray);
        }
        public static void WordFrequency(string[] Sentence)
        {
            MyMapNode<string, int> MyMapNode = new MyMapNode<string, int>(5);
            foreach (string word in Sentence)
            {
                int count = MyMapNode.CountFrequency(word);
                MyMapNode.Add(word, count);
            }
            MyMapNode.Remove("avoidable");
            IEnumerable<string> DistinctSentence = Sentence.Distinct<string>();
            foreach (string word in DistinctSentence)
            {
                MyMapNode.Display(word);
            }
        }
    }
}
