using System.ComponentModel.DataAnnotations;

namespace CMCS.Models
{
    public class Claim
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Surname { get; set; }
        public string Module { get; set; }

      
        public int Hours { get; set; }

        public int Rates { get; set; }

         
    }
}


