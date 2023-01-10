namespace MaxDiffChars
{
    public class MaxDiffChars
    {
        public static int MaximumDifferentCharacters(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            int maxConsecutive = 1;
            int currentMax = 1;
            char lastChar = str[0];
            for(int i = 1; i < str.Length; i++)
            {
                if (str[i] != lastChar)
                {
                    currentMax++;
                    if (currentMax > maxConsecutive)
                    {
                        maxConsecutive = currentMax;
                    }   
                }
                else
                {
                    currentMax = 1;
                }
                lastChar = str[i];
            }
            return maxConsecutive;
        }
    }
}