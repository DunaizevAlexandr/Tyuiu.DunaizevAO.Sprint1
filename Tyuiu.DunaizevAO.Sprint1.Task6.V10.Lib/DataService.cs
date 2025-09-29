using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DunaizevAO.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string str = value;

            string[] words = str.Split(' ');

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length % 2 == 1)
                {
                    int chis = word.Length / 2;
                    word = word.Remove(chis, 1);

                }
                if (i > 0)
                {
                    result += " ";
                }
                result += word;
                
            }
            return result;
        }
    }
}

