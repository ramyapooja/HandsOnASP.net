using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Model
{
    public class SellerBo : IsellerBo
    {
        private List<Seller> slist;
        public SellerBo()
        {
            slist = new List<Seller>() { new Seller(1, "sai", "sai", "sai@gmail.com", "ongole", 11, "123ad"),
                new Seller(2, "ramya", "ramya", "ramya@gmail.com", "ongole", 11, "123ad") ,
            new Seller(3, "pooja", "pooja", "pooja@gmail.com", "ongole", 11, "123ad"),};
        }
        public Seller Search_Id(int s_id)
        {
            Seller e = slist.FirstOrDefault(e => e.s_id == s_id);
            return e;
        }
        public List<Seller> DisplayDetails()
        {
            return slist;
        }
    }
}
