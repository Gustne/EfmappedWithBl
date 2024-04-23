namespace BuisnessLogic
{
    internal class ModelConverter
    {
        public UiModels.ItemGroup ConvertFromItemGroupEntity(EntityModels.ItemGroup itemGroupEntity)
        {
            UiModels.ItemGroup itemGroup = new UiModels.ItemGroup 
            { 
              Name = itemGroupEntity.Name,
              Description = itemGroupEntity.Description,
            };
            itemGroup.setId(itemGroupEntity.Id);

            foreach (EntityModels.Item item in itemGroupEntity.Items)
            {
                itemGroup.Items.Add(ConvertFromItemEntity(item));
            }
            return itemGroup;

        }

        public UiModels.Item ConvertFromItemEntity(EntityModels.Item itemEntity)
        {
            UiModels.Item item = new UiModels.Item
            {
                Name = itemEntity.Name,
                Description = itemEntity.Description,
                ItemGroupId = itemEntity.ItemGroupId,
                Price = itemEntity.Price,
                Stock = itemEntity.Stock
            };
            item.SetId(itemEntity.Id);

            return item;
        }

        public EntityModels.Item ConvertFromItemUI(UiModels.Item itemUi)
        {
            EntityModels.Item item = new EntityModels.Item
            {

                Name = itemUi.Name,
                Description = itemUi.Description,
                ItemGroupId = itemUi.ItemGroupId,
                Price = itemUi.Price,
                Stock = itemUi.Stock


            };

            if (itemUi.Id != 0)
            {
                item.Id = itemUi.Id;
            }
            return item;
        }

        public EntityModels.ItemGroup ConvertFromItemGroupUI(UiModels.ItemGroup itemGroupUI)
        {
            EntityModels.ItemGroup itemGroup = new EntityModels.ItemGroup
            {
                Name = itemGroupUI.Name,
                Description = itemGroupUI.Description,
            };

            if(itemGroupUI.Id != 0)
            {
                itemGroup.Id = itemGroupUI.Id;
            }

            foreach (UiModels.Item item in itemGroupUI.Items)
            {
                itemGroup.Items.Add(ConvertFromItemUI(item));
            }

            return itemGroup;
        }
    }
}
