// class translated from Java
// Credit goes to Charles Hayden http://www.chayden.net/eliza/Eliza.html

namespace Eliza.Core
{
    /// <summary>Eliza word list.</summary>
    /// <remarks>Eliza word list.</remarks>
    public class WordList : List<string>
    {
        private const long serialVersionUID = 1L;

        /// <summary>Print a word list on one line.</summary>
        /// <remarks>Print a word list on one line.</remarks>
        public virtual void Print(int indent)
        {
            for (int i = 0; i < Count; i++)
            {
                string s = this[i];
                ConsoleHelper.Write(s + "  ");
            }
            ConsoleHelper.WriteLine();
        }

        /// <summary>Find a string in a word list.</summary>
        /// <remarks>
        /// Find a string in a word list.
        /// Return true if the word is in the list, false otherwise.
        /// </remarks>
        internal virtual bool Find(string s)
        {
            for (int i = 0; i < Count; i++)
            {
                if (s.Equals(this[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}