using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLib
{
    public class Art
    {
        #region Properties
        private int Id, Price;
        private string ArtName, ArtType;
        #endregion

        public int id { get; }
        public int price { get; }
        public string artName { get; }
        public string artType { get; }

        public Art(int id, int price, string artName, string artType)
        {
            Id = id;
            Price = price;
            ArtName = artName;
            ArtType = artType;
        }

        public override string ToString()
        {
            return $"The art {ArtName} has an ID of {Id}. It is the type {ArtType}, and will cost {Price}";
        }
    }
}
