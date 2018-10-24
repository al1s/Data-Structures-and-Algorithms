using System;
using Xunit;
using multiBracketValidation;

namespace multiBracketValidationTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test if can return true when brackets are balanced in a string
        /// </summary>
        /// <param name="input">Input string to analyze</param>
        [Theory]
        [InlineData("{}[]()")]
        [InlineData("{[()]}")]
        [InlineData("{[(some)]}")]
        [InlineData("if (stack.Peek() != null) return false;")]
        public void ReturnTrueIfBracketsAreBalanced(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }
        /// <summary>
        /// Test if can return false when brackets are not balanced in a string
        /// </summary>
        /// <param name="input">Input string to analyze</param>
        [Theory]
        [InlineData("{}][()")]
        [InlineData("{")]
        [InlineData("}")]
        [InlineData("if (stack.Peek() != null} return false;")]
        public void ReturnFalseIfBracketsAreNotBalanced(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
