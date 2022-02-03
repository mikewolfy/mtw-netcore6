using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NetCore6.Tests
{
    public class CollectionCasting
    {
        [Fact]
        public void Casting()
        {
            ICollection<string> myList = new string[]{ "one", "two" };

            var convertedList = myList.ToList();
            convertedList.Add("three");

            //ToList contains original elements
            Assert.Contains("one", convertedList);

            //Original array doesn't contain new elements
            Assert.DoesNotContain("three", myList);

            myList = convertedList;

            Assert.Contains("three", myList);
        }
    }
}