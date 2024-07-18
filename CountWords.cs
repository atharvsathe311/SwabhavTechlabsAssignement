namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 1;
            string userSentence = Console.ReadLine();
            string trimmedUserSentence = userSentence.Trim();



            for (int stringIterator = 0; stringIterator < trimmedUserSentence.Length-1; stringIterator++)
            {
                if (trimmedUserSentence[stringIterator] == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("The Number of Words in the sentence are {0}",count);
        }

    }

}