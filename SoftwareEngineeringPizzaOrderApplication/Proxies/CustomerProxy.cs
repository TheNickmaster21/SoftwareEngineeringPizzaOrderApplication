using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringPizzaOrderApplication
{
    class CustomerProxy
    {
        PizzaApplicationDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;

        public CustomerProxy()
        {
            this.customerTableAdapter = new PizzaApplicationDatabaseDataSetTableAdapters.CustomerTableAdapter();
        }

        public void validateCustomer(Customer customer)
        {
            if (customer.phone_number == null && customer.phone_number != "")
            {
                throw new Exception("Customer must have a phone number!");
            }

            if (customer.first_name == null)
            {
                throw new Exception("Customer must have a first name!");
            }

            if (customer.last_name == null)
            {
                throw new Exception("Customer must have a last name!");
            }

            if (customer.address <= 0)
            {
                throw new Exception("Customer must have an address!");
            }
        }

        public Customer saveCustomer(Customer customer)
        {
            validateCustomer(customer);

            customerTableAdapter.Insert(
                customer.phone_number,
                customer.first_name,
                customer.last_name,
                customer.address,
                customer.card_type);

            return customer;
        }

        public Customer getCustomer(string phoneNumber)
        {
            try
            {
                PizzaApplicationDatabaseDataSet.CustomerRow customerRow =
                     customerTableAdapter.GetDataByPhoneNumber(phoneNumber).Last();

                if (customerRow != null)
                {
                    Customer customer = new Customer();
                    customer.phone_number = customerRow.phone_number;
                    customer.first_name = customerRow.first_name;
                    customer.last_name = customerRow.last_name;
                    customer.address = customerRow.address;
                    customer.card_type = customerRow.card_type;
                    customer.address = customerRow.address;

                    return customer;
                }
            }
            catch (Exception ex)
            {
                // meh
            }
            return null;
        }
    }
}
