using System.Linq;
using Xunit;
using Hashtables.Classes;
using System;

namespace HashtablesTests
{
    public class HashtableMethods
    {
        /// <summary>
        /// Test whether we can add new element to a hashtable
        /// </summary>
        [Fact]
        public void AddElmToHashTable_OnAdd_ElementStored()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            string expectedResult = "Cat:Jessy"; 
            // act
            ht.Add(new Node<string>() { Key = "Cat", Value = "Jessy" });
            string actualResult = ht.ToList().Select(elm => $"{elm.Key}:{elm.Value}").ToArray()[0];
            // assert
            Assert.Equal(expectedResult, actualResult);
        }
        /// <summary>
        /// Test whether we can add new element with the same hash to a hashtable
        /// </summary>
        [Fact]
        public void AddElmToHashTable_OnAddElmWithSameHash_ElementStored()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            string expectedResult = "Cat:Jessy,Doe:Tess";
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            Node<string> node2 = new Node<string>() { Key = "Doe", Value = "Tess" };
            // act
            ht.Add(node1);
            ht.Add(node2);
            string[] resultArr = ht.ToList().Select(elm => $"{elm.Key}:{elm.Value}").ToArray();
            string actualResult = string.Join(",", resultArr);
            // assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(ht.GetHash(node1.Key), ht.GetHash(node2.Key));
        }
        /// <summary>
        /// Test whether we can add new element with the same key to a hashtable
        /// </summary>
        [Fact]
        public void AddElmToHashTable_OnAddElmWithSameKey_ExceptionThrown()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            Node<string> node2 = new Node<string>() { Key = "Cat", Value = "Tess" };
            // act
            ht.Add(node1);
            // assert
            var ex = Assert.Throws<Exception>(() => ht.Add(node2));
            Assert.Equal("The node already exists for the key", ex.Message);
        }
        /// <summary>
        /// Test whether we can add find element with the key in a hashtable
        /// </summary>
        [Fact]
        public void FindElmInHashTable_OnExistingKey_ReturnNodeForAKey()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            // act
            ht.Add(node1);
            Node<string> result = ht.Find("Cat");
            // assert
            Assert.Equal(node1, result);
        }
        /// <summary>
        /// Test whether we can add find element with the key in a hashtable
        /// </summary>
        [Fact]
        public void FindElmInHashTable_OnNonExistingKey_ReturnNullNode()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            // act
            ht.Add(node1);
            Node<string> result = ht.Find("Dog");
            // assert
            Assert.Null(result);
        }
        /// <summary>
        /// Test whether we can add check existence of an element with the key in a hashtable
        /// </summary>
        [Fact]
        public void ContainsElmInHashTable_OnExistingKey_ReturnTrue()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            // act
            ht.Add(node1);
            bool result = ht.Contains("Cat");
            // assert
            Assert.True(result);
        }
        /// <summary>
        /// Test whether we can add check existence of an element with the key in a hashtable
        /// </summary>
        [Fact]
        public void ContainsElmInHashTable_OnNonExistingKey_ReturnFalse()
        {
            // arrange
            Hashtable<string> ht = new Hashtable<string>();
            Node<string> node1 = new Node<string>() { Key = "Cat", Value = "Jessy" };
            // act
            ht.Add(node1);
            // assert
            bool result = ht.Contains("Dog");
            // assert
            Assert.False(result);
        }
    }
}
