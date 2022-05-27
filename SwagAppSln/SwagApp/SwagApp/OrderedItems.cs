using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace SwagApp
{
    public class OrderedItems
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Size { get; set; }


    }

}
