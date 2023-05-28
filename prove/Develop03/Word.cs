namespace Develop03
{
    class Word
    {
        private string _original;
        private string _current;

        public Word(string word)
        {
            _original = word;
        }

        public string AsString()
        {
            return _current;
        }

        public void Hide()
        {
            string newWord = "";
            int letterCount = _original.Length;

            for(int i = 0; i <= letterCount; i++)
            {
                newWord = newWord + "_";
            }

            _current = newWord;
        }

          public void Show()
        {
            _current = _original;
        }

    }
}