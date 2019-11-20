﻿using SimpleMvvmToolkit.Express;

namespace SimpleMvvmToolkit.Samples.WPF.Core.Models
{
    public class Customer : ModelBase<Customer>
    {
        private int _customerId;
        public int CustomerId
        {
            get => _customerId;
            set
            {
                _customerId = value;
                NotifyPropertyChanged(m => m.CustomerId);
            }
        }

        private string _customerName;
        public string CustomerName
        {
            get => _customerName;
            set
            {
                _customerName = value;
                NotifyPropertyChanged(m => m.CustomerName);
            }
        }

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                NotifyPropertyChanged(m => m.City);
            }
        }
    }
}