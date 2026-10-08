namespace LatypovaFile
{
    public struct Grandfather
    {
        public string name;
        public string[] phrases;
        public int bruiseCount;

        public static int FatherOperations(Grandfather grandfather, params string[] swearWords)
        {
            foreach (string swearWord in grandfather.phrases)
            {
                foreach (string word in swearWords)
                {
                    if (swearWord.IndexOf(word) != -1)
                    {
                        grandfather.bruiseCount++;
                    }
                }
            }
            return grandfather.bruiseCount;
        }
    }
}
