using System;
using System.Collections.Generic;
using System.Text;

namespace CodebitsAcademySoftware
{
    class Academy
    {
        public string NameOfExhibit { get; set; }
        public string NameOfPerson { get; set; }
        public string NameOfSubject { get; set; }
        public string FloorOfExhibition { get; set; }
        public string NameOfBuilding { get; set; }

        public Academy(string nameExhbt, string person, string subject, string floorname, string buildingName)
        {
            NameOfExhibit = nameExhbt;
            NameOfPerson = person;
            NameOfSubject = subject;
            FloorOfExhibition = floorname;
            NameOfBuilding = buildingName;
        }

        public override string ToString()
        {
            return $"Name Of Exhibit : {NameOfExhibit}\n Name Of Person: {NameOfPerson}\n Name Of Subject: {NameOfSubject}\n Floor :{FloorOfExhibition}\n Building:{NameOfBuilding}";

        }
    }
}
