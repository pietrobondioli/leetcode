public class Implementation
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            if (needle.Length == 0 || needle.Length > haystack.Length)
            {
                return -1;
            }

            int haystackLength = haystack.Length;
            int needleLength = needle.Length;

            for (int i = 0; i <= haystackLength - needleLength; i++)
            {
                int checkingIndex;

                for (checkingIndex = 0; checkingIndex < needleLength; checkingIndex++)
                {
                    if (haystack[i + checkingIndex] != needle[checkingIndex])
                    {
                        break;
                    }
                }

                if (checkingIndex == needleLength)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}