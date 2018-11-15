using System;
using Xunit;
using repeatedWord;

namespace repeatedWordTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Can return an empty string for empty an input text
        /// </summary>
        [Fact]
        public void OnEmptyInput_ReturnsEmptyString()
        {
            // arrange
            string emptyText = string.Empty;
            // act
            string actualResult = Program.RepeatedWord(emptyText);
            // assert
            Assert.Equal(emptyText, actualResult);
        }
        /// <summary>
        /// Can return an empty string for an input text without repetitions 
        /// </summary>
        [Fact]
        public void OnInputWithoutRepeatedWords_ReturnsEmptyString()
        {
            // arrange
            string textWithoutRepetitions = "a";
            // act
            string actualResult = Program.RepeatedWord(textWithoutRepetitions);
            // assert
            Assert.Equal(string.Empty, actualResult);
        }
        /// <summary>
        /// Can return an repeated string for an input text with repetitions 
        /// </summary>
        [Fact]
        public void OnInputWithRepeatedWords_ReturnsRepeatedString()
        {
            // arrange
            string textWithRepetitions = "A fox is a fox";
            string expectedResult = "a";
            // act
            string actualResult = Program.RepeatedWord(textWithRepetitions);
            // assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
