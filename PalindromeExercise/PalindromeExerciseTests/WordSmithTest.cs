using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar",true)]
        [InlineData("Colby", false)]
        [InlineData("coding",false)]
        [InlineData("",false)]
        [InlineData(null,false)]
        [InlineData("mom", true)]
        [InlineData("civic",true)]

        public void IsAPalindrome_Test(string word, bool expected)
        {
            //Arrange
            var ws = new WordSmith();
            //Act
            var actual = ws.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
