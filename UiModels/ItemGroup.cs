using System.Runtime.CompilerServices;

namespace UiModels
{
    public class ItemGroup
    {
        private int _id;

        public ItemGroup()
        {
            Items = new List<Item>();
        }

        public int Id {  get { return _id; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }

        public void setId(int id, [CallerMemberName] string caller = "") 
        {
            if (caller == "ConvertFromItemGroupEntity")
            {
                _id = id;
            }

        }
        
        public override string ToString()
        {
           return $"Id: {Id} Navxn: {Name} Beskrivelse: {Description}";
        }
    }

 
}
