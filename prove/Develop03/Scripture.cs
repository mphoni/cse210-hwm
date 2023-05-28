using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03
{
    class Scripture
    {
        private List<Word> _words = new List<Word>();
        private List<int> _replacedWordsIndex = new List<int>();

        public int totalWords, hiddenWords = 0;
        public Scripture(List<string> words)
        {
          
            foreach (string word in words)
            {
                Word newWord = new Word(word);
                _words.Add(newWord);
                totalWords ++;
            }
        }

         public string AsString()
        {
            string currentScripture = "";
            foreach (Word word in _words)
            {
                currentScripture += $"{word.AsString()} ";
            }

            return currentScripture;
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            int index;
            do 
            {
                index = random.Next(_words.Count);
            } while (_replacedWordsIndex.Contains(index));

            _words[index].Hide();

            _replacedWordsIndex.Add(index);
            hiddenWords ++;
        }

        public void ShowLastHiddenWord()
        {
            if (_replacedWordsIndex.Count > 0)
            {
                //find the word, then run Word.Show() to flip it back to it's original state
                int index = _replacedWordsIndex[_replacedWordsIndex.Count - 1];
                _words[index].Show();

                //remove reference of the word from the index
                _replacedWordsIndex.Remove(index);
                hiddenWords --;
            }
        }

    }
}