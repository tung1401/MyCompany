using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitMyCompany
{
    public class WordTest
    {
        public bool StartsWithUpper(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            return char.IsUpper(s[0]);
        }

        [Fact]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "Abc", "αυτοκινητοβιομηχανία", "государство" };
            foreach (var word in words)
            {
                bool result = StartsWithUpper(word);
                Assert.True(result, $"Expected for '{word}': true; Actual: {result}");
            }
        }
    }
}
