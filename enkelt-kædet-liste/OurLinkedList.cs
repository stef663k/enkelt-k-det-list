namespace enkelt_kædet_liste
{
    public class OurLinkedList
    {
        // First element som variabel 
        // NextElementInList Metode som returnerer næste element eller null hvis den er det sidste.

        //Create new element. and is first =null? If yes then add element, if no. 
        //Use Next element till nextelement.next is null then set nextelement.next = new element

        //Add_first(data) metode (13 min) AddCheck før og efter, bekræftet.
        //checker om der er en first, hvis ikke så sætter first til at være et nye element.
        //Hvis der er en first så skabber vi det ney element og sætter LinkedList.first = ney element og
        //det ney element,next = gamle.data. 



        //count() metode Countcheck (8 min) til at returnere antallet af elementer i listen
        //lave en counter variabel og sæt den til 0, og lave et while loop der kører så længe next ikke er null,
        //tag next og counter ++ indtil next er null, og returner counter
        //print() metode PrintCheck (5 min) til at printe listen ud.
        //lave et while loop der skriver data ud så længe next ikke er null
        //sort() metode SortedListCheck (13-60 min) Give den en liste, køre sort metoden, og derefter tjekke at listen er sorteret korrekt 
        //While(Sequential =false){
        //sequential = true;
        //(for x=0; x<linkedlist.count()-1;x++){
        //if (list[x] > list[x+1]){
        //a=list[x];
        //b=list[x+1];
        //c=a;
        //b=a;
        //a=c;
        //sequential = false;
        //}
        //}
        //}
        public Element first { get; set; }

        public Element? GetElement()
        {
            return first;
        }

        public void Add_first(int value)
        {
            if (first == null)
            {
                first = new Element(value, null);
            }
            else
            {
                Element newElement = new Element(value, null);
                newElement.next = first;
                first = newElement;
            }
        }
        public void RemoveFirst()
        {
            //removeFirst(data) metode (5-8 min)  removeFirstCheck Elementet før og efter, bekræftet.
            //tag first.next og gem dataen i en variabel og sæt first.next = null, 
            //tag derefter linkedlist.first = element hvor data = variabel
            if (first != null && first.next != null)
            {
                first = first.next;
                /* first.next = null; */
            }


        }
        public void Count() { }
        public void Print() { }

        public void Sort() { }
    }
}