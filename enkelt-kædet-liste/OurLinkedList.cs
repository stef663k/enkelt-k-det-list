namespace enkelt_kædet_liste
{
    public class OurLinkedList
    {
        // First element som variabel 
        private Element first { get; set; }
        //get the first element in our linked list
        public Element? GetElement()
        {
            return first;
        }

        public void Add_first(int value)
        {
            //Add_first(data) metode (13 min) AddCheck før og efter, bekræftet.
            //checker om der er en first, hvis ikke så sætter first til at være et nye element.
            //Hvis der er en first så skabber vi det ney element og sætter LinkedList.first = ney element og
            //det ney element,next = gamle.data. 
            //Hvor ikke lave et 

            //Gruppe 6 comment:
            //Hvorfor dette null check? er den ikke irelevant?
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

            //Gruppe 6 comment:
            //Hvorfor checke for next i dette scenerie? 
            //dette ville lave en fejl 
            //hvis der kun er et element i listen.
            if (first != null && first.next != null)
            {
                first = first.next;
            }


        }
        public int Count()
        {
            //count() metode Countcheck (8 min) til at returnere antallet af elementer i listen
            //lave en counter variabel og sæt den til 0, og lave et while loop der kører så længe next ikke er null,
            //tag next og counter ++ indtil next er null, og returner counter

            //Gruppe 6 comment:
            //Super!
            int count = 0;
            Element currentElement = first;
            while (currentElement != null)
            {
                currentElement = currentElement.next;
                count++;
            }
            return count;

        }
        public string Print()
        {
            //print() metode PrintCheck (5 min) til at printe listen ud.
            //lave et while loop der skriver data ud så længe next ikke er null

            //Gruppe 6 comment:
            //Super!
            string returnstring = "";
            Element currentElement = first;
            while (currentElement != null)
            {
                if (returnstring == "")
                {
                    returnstring += currentElement.data;
                }
                else
                {
                    returnstring += ", " + currentElement.data;
                }
                currentElement = currentElement.next;
            }
            return returnstring;
        }

        public string Sort()
        {
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
            string returnstring = "";
            Element currentElement = first;
            bool sorted = false;

            while (sorted == false)
            {
                sorted = true;
                currentElement = first;
                while (currentElement.next != null)
                {
                    if (currentElement.data < currentElement.next.data)
                    {
                        int tempholder = currentElement.data;
                        currentElement.data = currentElement.next.data;
                        currentElement.next.data = tempholder;
                        sorted = false;
                    }
                    currentElement = currentElement.next;
                }
            }

            //Gruppe 6 comment:
            //Hvorfor en ny print methode?
            currentElement = first;
            while (currentElement != null)
            {
                if (returnstring == "")
                {
                    returnstring += currentElement.data;
                }
                else
                {
                    returnstring += ", " + currentElement.data;
                }
                currentElement = currentElement.next;
            }
            return returnstring;
        }
            //Gruppe 6 comment:
            //Super!
        public void RemoveElementAt(int removeIndex)
        {
            Element currentElement = first;
            int count = 1;
            while (currentElement != null)
            {
                if (count == removeIndex - 1)
                {
                    currentElement.next = currentElement.next.next;
                    break;
                }
                else
                {
                    currentElement = currentElement.next;
                    count++;
                }
            }
        }
        //Gruppe 6 comment:
        //Hvorfor else statement?
        public int? IndexOf(int value)
        {
            Element currentElement = first;
            int count = 1;
            while (currentElement.next != null)
            {
                if (currentElement.data == value)
                {
                    return count;
                }
                else
                {
                    currentElement = currentElement.next;
                    count++;
                }
            }
            return null;
        }
        //Gruppe 6 comment:
        //count=1? Hvor i alverden ikke starte den på 0? kan da kun give unødvendige problemer.
        public void Add_At(int value, int indexof)
        {
            Element currentElement = first;
            int count = 1;
            while (currentElement != null)
            {
                if (count == indexof - 1)
                {
                    Element newElement = new Element(value, null);
                    newElement.next = currentElement.next;
                    currentElement.next = newElement;
                    break;
                }
                else
                {
                    currentElement = currentElement.next;
                    count++;
                }
            }
        }
    }
}