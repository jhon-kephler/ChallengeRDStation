using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.Service
{
    public class CustomerSuccessService
    {
        public int customerSuccessBalancing(List<CustomerSuccess> css, List<CustomerSuccess> customer, List<int> csway)
        {
            List<ClientCS> ListClientCS = new List<ClientCS>();

            List<CustomerSuccess> customerAUX = customer.OrderBy(x => x.customerLevel).ToList();
            List<CustomerSuccess> cssAUX = css.OrderBy(x => x.customerLevel).ToList();

            foreach (var item in cssAUX)
            {
                if (!csway.Contains(item.idCustomer))
                {
                    ListClientCS.Add(
                   new ClientCS
                   {
                       CS = item,
                       clients = customerAUX.Where(x => x.customerLevel <= item.customerLevel).ToList()
                   });

                    customerAUX = customerAUX.Where(x => x.customerLevel > item.customerLevel).ToList();
                }
            }

            var custumerId = ListClientCS.MaxBy(x => x.clients.Count);

            var qty = ListClientCS.Where(x => x.clients.Count == custumerId.clients.Count).Count();

            if (qty == 1)
            {
                return custumerId.CS.idCustomer;
            }

            return 0;
        }
    }

}
