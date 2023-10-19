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
    public void Countcheck()
    {
        /*  int assertStetment = 1;
         int assertStetmentTwo = 2;
         int assertStetmentThree = 3;
         int expectedcount = 3;
         OurLinkedList list = new OurLinkedList();
         list.Add_first(assertStetment);
         list.Add_first(assertStetmentTwo);
         list.Add_first(assertStetmentThree);
         list.RemoveFirst();
         Assert.Equal(expectedcount, list.Count()); */
    }
    public void PrintCheck()
    {

    }

    public void SortedListCheck()
    {

    }
}