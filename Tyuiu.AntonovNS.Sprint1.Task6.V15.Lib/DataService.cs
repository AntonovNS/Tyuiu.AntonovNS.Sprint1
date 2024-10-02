using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AntonovNS.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            string B = "", S = "";
            for (var i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    B += value[i];
                }
                else
                {
                    S += value[i];
                }
            }
            if (B.Length > S.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
