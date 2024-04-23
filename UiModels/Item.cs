using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UiModels
{
    public class Item
    {   
        private int _id;
        public int Id
        {
            get { return _id; }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        //foreign key
        public int ItemGroupId { get; set; }

        public void SetId(int id, [CallerMemberName] string caller = "")
        {
            if (caller == "ConvertFromItemEntity")
            {
                _id = id;
            }
        }

       
        public override string ToString()
        {
            return $"Id: {Id} Navn: {Name} Beskrivelse: {Description} LagerStatus: {Stock} Pris: {Price}";
        }
    }
}
