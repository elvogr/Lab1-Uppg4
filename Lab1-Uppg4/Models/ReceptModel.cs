using System.Xml;

namespace Lab1_Uppg4.Models
{
    public class ReceptModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Foreign key för bagare ID
        public string BagareNamn { get; set; }

        public ReceptModel()
        {
            Id = 0;
            Name = "Okänt recept";
            BagareNamn = "Okänd bagare";
        }
        public ReceptModel(int id, string name, string bagareNamn)
        {
            Id = id;
            Name = name;
            BagareNamn = bagareNamn;
        }

    }
}
