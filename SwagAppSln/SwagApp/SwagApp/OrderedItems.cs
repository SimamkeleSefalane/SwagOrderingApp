using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace SwagApp
{
    public class OrderedItems
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string TShirtSize { get; set; }

        public string DateOfOrder { get; set; }

        public string TShirtColor { get; set; }

        public string ShippingAddress { get; set; }

    }
}
