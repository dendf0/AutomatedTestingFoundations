namespace NewBase
{
    public class NewBase
    {
        /// <summary>
        /// Changes the base of number
        /// </summary>
        /// <param name="value"> Number in base 10 </param>
        /// <param name="nBase"> New base </param>
        /// <returns>
        /// Number in new base (between 2 and 20)
        /// </returns>
        public static string SetNewBase(int value, int nBase)
        {
            string result = string.Empty;
            char[] baseChars = {'0','1','2','3','4','5','6','7','8','9',
                'A','B','C','D','E','F','G','H','I','J','K' };
            while (value > 0)
            {
                result = baseChars[value % nBase] + result;
                value = value / nBase;
            }
            return result;
        }
    }
}