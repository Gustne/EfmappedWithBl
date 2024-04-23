using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Item
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public int  Stock {  get; set; }
        public double Price { get; set; }
        //foreign key
        public int ItemGroupId {  get; set; }
        //navigation prop
        public ItemGroup ItemGroup { get; set; }

    }
}
