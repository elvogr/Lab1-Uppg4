
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_Uppg4.Models
{
    public class BagareModel
    {
       
        public int Id { get; set; }
       
        public string Name { get; set; }

        public BagareModel()
        {
            Id = 0;
            Name = "Okänd bagare";
        }
        public BagareModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
