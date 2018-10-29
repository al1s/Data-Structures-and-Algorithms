using System.Linq;
using Xunit;
using eeneyMeeneyMineyMoe;
using LinkedList.Classes;

namespace eeneyMeeneyMineyMoeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindWinner()
        {
            LList llist = new LList();
            llist.Append("Eeney");
            llist.Append("Meeney");
            llist.Append("Miney");
            llist.Append("Moe");
            Assert.Equal("Eeney", Program.EeneyMeeneyMineyMoe(llist, 3));
        }
        [Fact]
        public void NoWinnerIfDontWantToPlay()
        {
            LList llist = new LList();
            llist.Append("Eeney");
            llist.Append("Meeney");
            llist.Append("Miney");
            llist.Append("Moe");
            Assert.Equal(string.Empty, Program.EeneyMeeneyMineyMoe(llist, 0));
        }
        [Fact]
        public void PerfTest()
        {
            LList llist = new LList();
            string[] array = Enumerable.Range(0, 40000).Select(i => "Num" + i).ToArray();
            foreach (string item in array)
            {
                llist.Append(item);
            }
            Assert.Equal("Num24413", Program.EeneyMeeneyMineyMoe(llist, 30000));
        }
    }
}
