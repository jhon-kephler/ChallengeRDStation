using CSharp.Model;
using CSharp.Service; 

namespace TesteProjectRDStation
{
    public class UnitTest
    {
        [Fact]
        public void Scenario1()
        {
            CustomerSuccessService Service = new CustomerSuccessService();

            List<CustomerSuccess> css = new List<CustomerSuccess>();
            List<CustomerSuccess> customer = new List<CustomerSuccess>();

            css.Add(new CustomerSuccess
            {
                idCustomer = 1,
                customerLevel = 60
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 2,
                customerLevel = 20
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 3,
                customerLevel = 95
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 4,
                customerLevel = 75
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 1,
                customerLevel = 90
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 2,
                customerLevel = 20
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 3,
                customerLevel = 70
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 4,
                customerLevel = 40
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 5,
                customerLevel = 60
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 6,
                customerLevel = 10
            });

            List<int> csAway = new List<int>();
            csAway.Add(2);
            csAway.Add(4);

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(1, list);
        }

        [Fact]
        public void Scenario2()
        {
            CustomerSuccessService Service = new CustomerSuccessService();

            List<CustomerSuccess> css = new List<CustomerSuccess>();
            List<CustomerSuccess> customer = new List<CustomerSuccess>();

            css.Add(new CustomerSuccess
            {
                idCustomer = 1,
                customerLevel = 60
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 2,
                customerLevel = 20
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 3,
                customerLevel = 95
            });
            css.Add(new CustomerSuccess
            {
                idCustomer = 4,
                customerLevel = 75
            });

            customer.Add(new CustomerSuccess
            {
                idCustomer = 1,
                customerLevel = 95
            });
            customer.Add(new CustomerSuccess
            {
                idCustomer = 2,
                customerLevel = 60
            });


            List<int> csAway = new List<int>();
            csAway.Add(2);
            csAway.Add(4);


            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(0, list);
        }

        [Fact]
        public void Scenario3()
        {
            CustomerSuccessService Service = new CustomerSuccessService();
            utils utils = new utils();

            var css = utils.ListSeq(999, 1);
            var customer = utils.buildSizeEntities(10000, 998);
            List<int> csAway = new List<int>();
            csAway.Add(999);

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(998, list);
        }

        [Fact]
        public void Scenario4()
        {
            utils utils = new utils();
            CustomerSuccessService Service = new CustomerSuccessService();

            List<int> scores = new List<int>();
            int[] int_arr = { 1, 2, 3, 4, 5, 6 };
            scores.AddRange(int_arr);
            var css = utils.mapEntities(scores);

            scores = new List<int>();
            int[] int_arr2 = { 10, 10, 10, 20, 20, 30, 30, 30, 20, 60 };
            scores.AddRange(int_arr2);
            var customer = utils.mapEntities(scores);


            List<int> csAway = new List<int>();

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(0, list);
        }

        [Fact]
        public void Scenario5()
        {
            utils utils = new utils();
            CustomerSuccessService Service = new CustomerSuccessService();

            List<int> scores = new List<int>();
            int[] int_arr = { 100, 2, 3, 3, 4, 5 };
            scores.AddRange(int_arr);
            var css = utils.mapEntities(scores);

            scores = new List<int>();
            int[] int_arr2 = { 10, 10, 10, 20, 20, 30, 30, 30, 20, 60 };
            scores.AddRange(int_arr2);
            var customer = utils.mapEntities(scores);


            List<int> csAway = new List<int>();

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(1, list);
        }

        [Fact]
        public void Scenario6()
        {
            utils utils = new utils();
            CustomerSuccessService Service = new CustomerSuccessService();

            List<int> scores = new List<int>();
            int[] int_arr = { 100, 99, 88, 3, 4, 5 };
            scores.AddRange(int_arr);
            var css = utils.mapEntities(scores);

            scores = new List<int>();
            int[] int_arr2 = { 10, 10, 10, 20, 20, 30, 30, 30, 20, 60 };
            scores.AddRange(int_arr2);
            var customer = utils.mapEntities(scores);


            List<int> csAway = new List<int>();
            csAway.Add(1);
            csAway.Add(2);
            csAway.Add(3);

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(0, list);
        }

        [Fact]
        public void Scenario7()
        {
            utils utils = new utils();
            CustomerSuccessService Service = new CustomerSuccessService();

            List<int> scores = new List<int>();
            int[] int_arr = { 100, 99, 88, 3, 4, 5 };
            scores.AddRange(int_arr);
            var css = utils.mapEntities(scores);

            scores = new List<int>();
            int[] int_arr2 = { 10, 10, 10, 20, 20, 30, 30, 30, 20, 60 };
            scores.AddRange(int_arr2);
            var customer = utils.mapEntities(scores);


            List<int> csAway = new List<int>();
            csAway.Add(4);
            csAway.Add(5);
            csAway.Add(6);

            var list = Service.customerSuccessBalancing(css, customer, csAway);

            Assert.Equal(3, list);
        }

    }
}