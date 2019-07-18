using FluentAssertions;
using src;
using Xunit;

namespace linkListTests {
    public class UnitTest1 {
        [Fact]
        public void Add_GivenValidArguments_ExpectsSuccess () {
            //Given
            var linkedList = new linkList ();

            //When & //Then
            Assert.Null (linkedList.Head);

        }

        [Fact]
        public void Add_GivenData_ExpectsListWithHeadOnly () {
            //Given
            var expected = new linkList ();
            expected.Head = new Node { Data = 3 };

            var ll = new linkList ();

            //When
            ll.Add (3);

            //Then
            ll.Should ().BeEquivalentTo (expected);
        }

        [Fact]
        public void TestName () 
        {
            //Given
            var expected = new linkList();
            expected.Head = new Node{Data = 3};
            expected.Head.Next = new Node{Data = 5};
            expected.Head.Next.Next = new Node{Data = 9};
            expected.Head.Next.Next.Next = new Node{Data = 1};
            expected.Head.Next.Next.Next.Next = new Node{Data = 2};

            var ll = new linkList();
            
            //When
            ll.Add(3);
            ll.Add(5);
            ll.Add(9);
            ll.Add(1);
            ll.Add(2);

            //Then
            ll.Should().BeEquivalentTo(expected);      
        }
    }
}