using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModels.Models
{
   public  class User
    {
       public int Id { get; set; }

        //[StringLength(maximumLength: 50, ErrorMessage = "The property should not have more than {1} characters")]
        public string FirstName { get; set; }

        //[StringLength(maximumLength: 50, ErrorMessage = "The property should not have more than {1} characters")]
        public string LastName { get; set; }

        public string Gender { get; set; }

        public string AvatarUrl { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

       // public ICollection<Review> Reviews { get; set; }

       // public ICollection<Rating> Ratings { get; set; }
    }
}
