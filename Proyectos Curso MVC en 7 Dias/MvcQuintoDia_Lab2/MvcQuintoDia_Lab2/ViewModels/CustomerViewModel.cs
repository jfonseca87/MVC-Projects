using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcQuintoDia_Lab2.Models;

namespace MvcQuintoDia_Lab2.ViewModels
{
    public class CustomerViewModel
    {
        private Customer customer = new Customer();

        public string txtName
        {
            get { return customer.CustomerName; }
            set { customer.CustomerName = value; }
        }

        public double txtAmount
        {
            get { return customer.Amount; }
            set { customer.Amount = value; }
        }

        public string lblCustomerLevelColor
        {
            get
            {
                if (customer.Amount > 2000)
                {
                    return "red";
                }else if (customer.Amount > 1500)
                {
                    return "orange";
                }
                else { return "yellow"; }
            }
        }
    }
}