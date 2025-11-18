using System.Xml;

namespace Lab1_Uppg4.Models
{
    public class ReceptModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Foreign key för bagare ID
        public int BagareId { get; set; }

        public ReceptModel()
        {
            Id = 0;
            Name = "Okänt recept";
            BagareId = 0;
        }
        public ReceptModel(int id, string name, int bagareId)
        {
            Id = id;
            Name = name;
            BagareId = bagareId;
        }

    }
}
