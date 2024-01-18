namespace LeetCode._1657_Determine_if_Two_Strings_Are_Close;

// https://leetcode.com/problems/determine-if-two-strings-are-close
public class Implementation
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var word1RecurrenceDict = GetWordCharRecurrence(word1);
            var word2RecurrenceDict = GetWordCharRecurrence(word2);

            return CompareWordCharRecurrence(word1RecurrenceDict, word2RecurrenceDict);
        }

        private Dictionary<char, int> GetWordCharRecurrence(string word)
        {
            Dictionary<char, int> recurrenceDict = new();

            foreach (var c in word.ToCharArray())
            {
                if (recurrenceDict.TryGetValue(c, out int currCount))
                {
                    recurrenceDict[c] = currCount + 1;
                }
                else
                {
                    recurrenceDict[c] = 1;
                }
            }

            return recurrenceDict;
        }

        private bool CompareWordCharRecurrence(Dictionary<char, int> word1Recurr, Dictionary<char, int> word2Recurr)
        {
            if (word1Recurr.Count != word2Recurr.Count)
            {
                return false;
            }

            var word1RecurrValuesList = word1Recurr.Values.ToList();
            var word2ReccurrValuesList = word2Recurr.Values.ToList();

            word1RecurrValuesList.Sort();
            word2ReccurrValuesList.Sort();

            var word1RecurrKeysList = word1Recurr.Keys.ToList();
            var word2RecurrKeysList = word2Recurr.Keys.ToList();

            word1RecurrKeysList.Sort();
            word2RecurrKeysList.Sort();

            return word1RecurrValuesList.SequenceEqual(word2ReccurrValuesList) &&
                   word1RecurrKeysList.SequenceEqual(word2RecurrKeysList);
        }
    }
}