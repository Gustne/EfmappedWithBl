
using System.Threading;
using DataAccess;
using BuisnessLogic;
using UiModels;

ItemGroupBl db = new ItemGroupBl();

ItemGroup newItemGroup = new ItemGroup { Name = "Alkohol", Description = "Alkholafdeling der har både vin og sprut" };

newItemGroup.Items.Add(new Item { Name = "Gordons Gin", Description = "Klassik engelsk dry gin", Price = 99.99, Stock = 200 });

Console.WriteLine(await db.CreateAsync(newItemGroup));

Thread.Sleep(5000);

List<ItemGroup> itemGroups = await db.GetAsync();

foreach (ItemGroup itemGroup in itemGroups)
{
    Console.WriteLine(itemGroup.ToString());
}


ItemGroup iGroup = itemGroups[0];

iGroup.Items[0].Stock = 21;


iGroup.setId(123);
Console.WriteLine(iGroup);


Console.WriteLine(await db.UpdateAsync(iGroup));


Console.WriteLine(itemGroups[0]);

db = new ItemGroupBl();

/*Console.WriteLine(await db.DeleteAsync(itemGroups[0]));
*/