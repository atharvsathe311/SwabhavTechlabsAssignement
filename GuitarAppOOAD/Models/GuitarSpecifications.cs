using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    public class GuitarSpecifications
    {
        public GuitarBuilder GuitarBuilder { get; set; }
        public string GuitarModel { get; set; }
        public GuitarType GuitarType { get; set; }
        public GuitarWood BackWood { get; set; }
        public GuitarWood TopWood { get; set; }
        public int NumberOfStrings  { get; set; }
        public GuitarSpecifications()
        { }

        public GuitarSpecifications(int  numberOfStrings, GuitarBuilder builder, string model, GuitarType type, GuitarWood backWood, GuitarWood topWood)
        {
            this.NumberOfStrings = numberOfStrings;
            this.GuitarType = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.GuitarBuilder = builder;
            this.GuitarModel = model;
        }


        public bool GuitarIsMatching(GuitarSpecifications specifications)
        {
            if((specifications.NumberOfStrings == NumberOfStrings) &&
               (specifications.GuitarModel.ToLower() == GuitarModel.ToLower())&&
               (specifications.GuitarType == GuitarType)&&
               (specifications.BackWood == BackWood)&&
               (specifications.TopWood == TopWood))
            {
                return true;
            }
            return false;
        }
    }
}
