using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ItemGroupDa
    {
        ItemGroupDbContext db;
        public ItemGroupDa()
        {
            try
            {
                db = new ItemGroupDbContext();
            }
            catch (Exception)
            {

            }

        }

        public async Task<List<ItemGroup>> GetAsync()
        {

            try
            {
                return await db.ItemGroups
                    .Include(i => i.Items)
                    .ToListAsync();
            }
            catch (Exception)
            {

                return new List<ItemGroup>();
            }

        }

        public async Task<ItemGroup> GetAsync(int id)
        {
            try
            {
                return await db.ItemGroups
                .Include(item => item.Items)
                .FirstOrDefaultAsync(i => i.Id == id);
            }
            catch (Exception)
            {

                return new ItemGroup();
            }


        }

        public async Task<bool> CreateAsync(ItemGroup itemGroup)
        {
            try
            {
                db.ItemGroups.Add(itemGroup);
                int rowsAffected = await db.SaveChangesAsync();
                if (rowsAffected > 0) return true;
                else return false;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<bool> UpdateAsync(ItemGroup itemGroup)
        {
            try
            {
                db.ItemGroups.Update(itemGroup);
                int rowsAffected = await db.SaveChangesAsync();
                if (rowsAffected > 0) return true;
                else return false;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<bool> DeleteAsync(ItemGroup itemGroup)
        {
            try
            {
                ItemGroup deleteIg = db.ItemGroups.FirstOrDefault(i => i.Id == itemGroup.Id);
                if (deleteIg != null)
                {
                    db.ItemGroups.Remove(deleteIg);
                    int rowsAffected = await db.SaveChangesAsync();
                    if (rowsAffected > 0) return true;
                    else return false;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
