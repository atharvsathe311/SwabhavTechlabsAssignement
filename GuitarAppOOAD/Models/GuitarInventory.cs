using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    public class GuitarInventory
    {
        public List<Guitar> Guitars { get; set; } = new List<Guitar>();

        public void AddGuitar(string serialNumber, double guitarPrice, GuitarSpecifications guitarSpecifications)
        {
            Guitars.Add(new Guitar(serialNumber, guitarPrice, guitarSpecifications));
        }

        public Guitar GetGuitar(string serialNumber)
        {
            Guitar guitar = null;

            foreach (var guitarFound in Guitars)
            {
                if(guitarFound.SerialNumber == serialNumber)
                {
                    guitar = guitarFound;
                }
            }
            return guitar;
        }


        public List<Guitar> SearchForGuitar(GuitarSpecifications searchGuitarSpecs)
        {
            List<Guitar> searchForGuitars = new List<Guitar>();

            foreach (Guitar guitar in Guitars)
            {
                if((guitar!=null) && guitar.Specifications.GuitarIsMatching(searchGuitarSpecs))
                {
                    searchForGuitars.Add(guitar);
                }
            }

            if (searchForGuitars.Count > 0)
                return searchForGuitars;
            
            return null;
        }
    }
}
