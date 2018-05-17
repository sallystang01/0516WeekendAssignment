using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Tutorials
{
    class CellPhone
    {
        // Fields
        private string _brand; // The phone's brand
        private string _model; // The phone's model
        private decimal _price; // Retail price

        // Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // Brand property

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }

        }

        // Mo0del Property

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        // Price Property

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        } 

    }
}
