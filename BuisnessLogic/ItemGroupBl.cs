
using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiModels;
using DataAccess;

namespace BuisnessLogic
{
    public class ItemGroupBl
    {
        ItemGroupDa db;
        ModelConverter modelConverter;
        public ItemGroupBl() 
        {
            db = new ItemGroupDa();
            modelConverter = new ModelConverter();
        }
        
        public async Task<List<UiModels.ItemGroup>> GetAsync()
        {
            List<UiModels.ItemGroup> itemGroups = new List<UiModels.ItemGroup>();
            foreach (EntityModels.ItemGroup itemGroup in await db.GetAsync())
            {
                itemGroups.Add(modelConverter.ConvertFromItemGroupEntity(itemGroup));
            }

            return itemGroups;

        }

        public async Task<bool> CreateAsync(UiModels.ItemGroup uiItemGroup)
        {
            EntityModels.ItemGroup entityItemGroup = modelConverter.ConvertFromItemGroupUI(uiItemGroup);
            
            return await db.CreateAsync(entityItemGroup);
        }

        public async Task<bool> UpdateAsync(UiModels.ItemGroup uiItemGroup)
        {
            EntityModels.ItemGroup entityItemGroup = modelConverter.ConvertFromItemGroupUI(uiItemGroup);

            return await db.UpdateAsync(entityItemGroup);
        }

        public async Task<bool> DeleteAsync(UiModels.ItemGroup uiItemGroup)
        {
            EntityModels.ItemGroup entityItemGroup = modelConverter.ConvertFromItemGroupUI(uiItemGroup);

            return await db.DeleteAsync(entityItemGroup);
        }

    }
}
