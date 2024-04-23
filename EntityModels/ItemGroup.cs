namespace EntityModels
{
    public class ItemGroup
    {
        public ItemGroup()
        {
            Items = new List<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
    }
}
