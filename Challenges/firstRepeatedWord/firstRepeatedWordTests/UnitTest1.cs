using System;
using Xunit;
using uniqueChars;

namespace uniqueChars
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether can return true for an empty string
        /// </summary>
        [Fact]
        public void GivenEmptyString_ReturnsTrue()
        {
            // arrange
            string str = string.Empty;
            // act
            bool result = Program.UniqueChars(str);
            //assert
            Assert.True(result);
        }
        /// <summary>
        /// Test whether can return false for a word with repeated chars
        /// </summary>
        [Fact]
        public void GivenWordWithRepeatedChars_ReturnsFalse()
        {
            // arrange
            string str = "Aa";
            // act
            bool result = Program.UniqueChars(str);
            //assert
            Assert.False(result);
        }
        /// <summary>
        /// Test whether can return false for a string with repeated chars
        /// </summary>
        [Fact]
        public void GivenStringWithRepeatedChars_ReturnsFalse()
        {
            // arrange
            string str = "A a";
            // act
            bool result = Program.UniqueChars(str);
            //assert
            Assert.False(result);
        }
        /// <summary>
        /// Test whether can return true for a word with repeated chars
        /// </summary>
        [Fact]
        public void GivenWordWithUniqueChars_ReturnsTrue()
        {
            // arrange
            string str = "abcdefgh";
            // act
            bool result = Program.UniqueChars(str);
            //assert
            Assert.True(result);
        }
        /// <summary>
        /// Test whether can return true for a string with unique chars
        /// </summary>
        [Fact]
        public void GivenStringWithUniqueChars_ReturnsTrue()
        {
            // arrange
            string str = "abcd efgh";
            // act
            bool result = Program.UniqueChars(str);
            //assert
            Assert.True(result);
        }
    }
}
