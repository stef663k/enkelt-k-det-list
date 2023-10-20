using enkelt_kædet_liste;

namespace list_test;

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
}