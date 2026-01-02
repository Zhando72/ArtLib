using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ArtLib
{
    public class ArtsRepository
    {
        private int NextId = 0;
        List<Art> artsList = new List<Art>();


        public List<Art> GetAll()
        {
            return artsList;
        }

        public Art GetById(int Id)
        {
            foreach (Art A in artsList)
            {
                if (Id == A.id)
                {
                    return A;
                }
            }
            return null;
        }

        public void add(int price, string artName, string artType)
        {
            Art art = new Art(NextId, price, artName, artType);
            artsList.Add(art);
            NextId++;
        }

        public void delete(int Id)
        {
            foreach (Art A in artsList)
            {
                if (Id == A.id)
                {
                    artsList.Remove(A);
                }
            }
        }
    }
}
