using enkelt_kædet_liste;

namespace list_test;
//Jeres test er unødvendig lange
//I stedet kunne have lavet dem såden her 
// [Fact]
// public void testtest(){
//     List.Add_first(1);
//     Assert.Equal("1", List.Count());
//}
public class UnitTest1
{
    [Fact]
    public void Addcheck()
    {
        int assertStetment = 1;
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        Assert.Equal(assertStetment, list.GetElement().data);
    }
    [Fact]
    public void RemoveFirstCheck()
    {
        int assertStetment = 1;
        int assertStetmentTwo = 2;
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.RemoveFirst();
        Assert.Equal(assertStetment, list.GetElement().data);
    }
    //Gruppe 6 comment:
    //Denne kan umuligt gå ind og fjerne element i jeres if statement
    [Fact]
    public void RemoveFirstChecTwo()
    {
        int assertStetment = 1;
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.RemoveFirst();
        Assert.Equal(assertStetment, list.GetElement().data);
    }
    [Fact]
    public void Countcheck()
    {
        int assertStetment = 1;
        int assertStetmentTwo = 2;
        int assertStetmentThree = 3;
        int expectedcount = 3;
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        Assert.Equal(expectedcount, list.Count());
    }
    [Fact]
    public void PrintCheck()
    {
        int assertStetment = 1;
        int assertStetmentTwo = 5;
        int assertStetmentThree = 3;
        string expectedstring = "3, 5, 1";
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        Assert.Equal(expectedstring, list.Print());
    }
    [Fact]
    public void SortedListCheck()
    {
        int assertStetment = 1;
        int assertStetmentTwo = 5;
        int assertStetmentThree = 3;
        int assertStetmentFour = 1;
        int assertStetmentFive = 5;
        int assertStetmentSix = 3;
        string expectedstring = "5, 5, 3, 3, 1, 1";
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        list.Add_first(assertStetmentFour);
        list.Add_first(assertStetmentFive);
        list.Add_first(assertStetmentSix);
        Assert.Equal(expectedstring, list.Sort());
    }
    [Fact]
    public void RemoveElementAtCheck()
    {
        int assertStetment = 2;
        int assertStetmentTwo = 6;
        int assertStetmentThree = 4;
        int assertStetmentFour = 1;
        int assertStetmentFive = 5;
        int assertStetmentSix = 3;
        int removeat = 3;
        string expectedstring = "6, 5, 4, 3, 2";
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        list.Add_first(assertStetmentFour);
        list.Add_first(assertStetmentFive);
        list.Add_first(assertStetmentSix);
        list.RemoveElementAt(removeat);
        Assert.Equal(expectedstring, list.Sort());
    }
    [Fact]
    public void IndexOfCheck()
    {
        int assertStetment = 2;
        int assertStetmentTwo = 6;
        int assertStetmentThree = 4;
        int assertStetmentFour = 1;
        int assertStetmentFive = 5;
        int assertStetmentSix = 3;
        int expectedIndex = 3;
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        list.Add_first(assertStetmentFour);
        list.Add_first(assertStetmentFive);
        list.Add_first(assertStetmentSix);
        Assert.Equal(expectedIndex, list.IndexOf(1));
    }

    [Fact]
    public void AddAtCheck()
    {
        int assertStetment = 12;
        int assertStetmentTwo = 15;
        int assertStetmentThree = 33;
        int assertStetmentFour = 11;
        string expectedstring = "33, 15, 11, 12";
        OurLinkedList list = new OurLinkedList();
        list.Add_first(assertStetment);
        list.Add_first(assertStetmentTwo);
        list.Add_first(assertStetmentThree);
        list.Add_At(assertStetmentFour, 3);
        Assert.Equal(expectedstring, list.Print());
    }


}