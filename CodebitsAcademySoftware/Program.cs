using System;
using System.Collections;

namespace CodebitsAcademySoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Academy exhibit1 = new Academy("photograpy", "DADA MUNA", "Arts", "Floor 2", "Primary");
            Academy exhibit2 = new Academy("CashFlow Dynamics", "Moobs Homa", "Commerce", "Floor 4", "Higher");
            Academy exhibit3 = new Academy("Surgery", "Stava Tema", "Science", "Floor 1", "Labs");
            Academy exhibit4 = new Academy("Keyboard Links", "Beautiful Nubia", "Music", "Floor 4", "Primary");
            Academy exhibit5 = new Academy("Best Shots", "Muri Takalan", "Sports", "Floor 3", "Labs");
            Academy exhibit6 = new Academy("Award on Foregin Studies ", "Mr Ken Gena", "Foregin Studies", "Floor 5", "Labs");
            Academy exhibit7 = new Academy("Talent Hunt", "Ninle Jobs", "Drama", "Floor 8", "Primary");
            Academy exhibit8 = new Academy("Fiction Best", "Puag Gambi", "Fiction", "Floor 10", "Labs");
            Academy exhibit9 = new Academy("Thiller Gang", "Muga Beana", "Thiller&Action", "Floor 2", "Higher");
            Academy exhibit10 = new Academy("Science And Arts", "Munta Beean", "African Music", "Floor 6", "Primary");
            Academy exhibit11 = new Academy("Raggge Music", "Bob Marely", "Music", "Floor 5", "Labs");
            Academy exhibit12 = new Academy("Fine Arts", "Soul Teach", "Arts", "Floor 12", "Higher");
            Academy exhibit13 = new Academy("Applied Science", "Bod Tylor", "Physics", "Floor 9", "Primary");
            Academy exhibit14 = new Academy("Applied Science", "Bod Tylor", "Physics", "Floor 9", "Primary");
            Academy exhibit15 = new Academy("Applied Science", "Bod Tylor", "Physics", "Floor 9", "Primary");


            ArrayList arrayList = new ArrayList();
            arrayList.Add(exhibit1);
            arrayList.Add(exhibit2);
            arrayList.Add(exhibit3);
            arrayList.Add(exhibit4);
            arrayList.Add(exhibit5);
            arrayList.Add(exhibit6);
            arrayList.Add(exhibit7);
            arrayList.Add(exhibit8);
            arrayList.Add(exhibit9);
            arrayList.Add(exhibit10);
            arrayList.Add(exhibit11);
            arrayList.Add(exhibit12);
            arrayList.Add(exhibit13);
            arrayList.Add(exhibit14);
            arrayList.Add(exhibit15);

            foreach (var list in arrayList)
            {
                Console.WriteLine(list);
            }

            arrayList.RemoveAt(4);
            Console.WriteLine("==================Output after item 5 has been removed======================");

            foreach (var list in arrayList)
            {
                Console.WriteLine(list);
            }
        }
    }
}
