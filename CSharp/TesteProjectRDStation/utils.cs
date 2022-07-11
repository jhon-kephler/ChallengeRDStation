using CSharp.Model;
using CSharp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProjectRDStation
{
    public class utils
    {
        public List<CustomerSuccess> buildSizeEntities(int size, int score)
        {
            List<CustomerSuccess> list = new List<CustomerSuccess>();
            for (int i = 0; i < size; i++)
            {
                list.Add(new CustomerSuccess { idCustomer = i + 1, customerLevel = score });
            }
            return list;
        }

        public List<CustomerSuccess> mapEntities(List<int> Score)
        {
            List<CustomerSuccess> customerSuccesses = new List<CustomerSuccess>();
            int i = 0;
            foreach (var item in Score)
            {
                customerSuccesses.Add(new CustomerSuccess
                {
                    idCustomer = ++i,
                    customerLevel = item
                });
            }

            return customerSuccesses;

        }

        public List<CustomerSuccess> ListSeq(int count, int startat)
        {
            List<CustomerSuccess> customerSuccesses = new List<CustomerSuccess>();
            for (int i = 1; i <= count; i++)
            {
                customerSuccesses.Add(new CustomerSuccess
                {
                    idCustomer = i,
                    customerLevel = startat
                });
                startat++;
            }
            return customerSuccesses;
        }
    }
}
