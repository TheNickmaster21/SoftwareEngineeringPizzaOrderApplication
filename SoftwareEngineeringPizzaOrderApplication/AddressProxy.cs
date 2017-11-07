﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringPizzaOrderApplication
{
    class AddressProxy
    {
        PizzaApplicationDatabaseDataSetTableAdapters.AddressTableAdapter addressTableAdapter;

        public AddressProxy()
        {
            this.addressTableAdapter = new PizzaApplicationDatabaseDataSetTableAdapters.AddressTableAdapter();
        }

        public void validateAddress(Address address)
        {
            if (address.line_1 == null)
            {
                throw new Exception("Address must have a line 1!");
            }

            if (address.city == null)
            {
                throw new Exception("Address must have a city!");
            }

            if (address.state == null)
            {
                throw new Exception("Address must have a state!");
            }

            if (address.country == null)
            {
                throw new Exception("Address must have a country!");
            }

            if (address.postal_code == null)
            {
                throw new Exception("Address must have a postal code!");
            }
        }

        public Address saveAddress(Address address)
        {
            validateAddress(address);

            object id = addressTableAdapter.InsertAndReturnIdQuery(
                address.line_1,
                address.line_2,
                address.line_3,
                address.city,
                address.state,
                address.country,
                address.postal_code);

            address.Id = Decimal.ToInt32((decimal) id);

            return address;
        }
    }
}
