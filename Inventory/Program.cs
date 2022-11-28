using Inventory.InventoryFiles;
using Inventory.Item;
using Inventory.Utilites;

Console.ForegroundColor = ConsoleColor.Green;

//Creating Items
ItemProfile itemOne, itemTwo, itemThree, itemFour, itemFive;

itemOne = ItemCreator.CreateAndReturnItem("Freezer 9000", "The Best Freezer!",
    ItemType.Fridge, new ItemDimension(24, 60, 24), 5_000, "Savvy Inc.", 456789123, 2222, 1000001);

itemTwo = ItemCreator.CreateAndReturnItem("Microwave 10000", "The Best Microwave!",
    ItemType.Microwave, new ItemDimension(12, 12, 20), 500, "Savvy Inc.", 54789214, 2222, 1000002);

itemThree = ItemCreator.CreateAndReturnItem("Washer 5000", "The Best Washer!",
    ItemType.Washer, new ItemDimension(24, 36, 36), 900, "Savvy Inc.", 84568798, 2222, 1000003);

itemFour = ItemCreator.CreateAndReturnItem("Washer 200", "The Okay Washer!",
    ItemType.Washer, new ItemDimension(24, 36, 36), 500, "Savvy Inc.", 84568775, 2222, 1000004);

itemFive = ItemCreator.CreateAndReturnItem("Microwave 500", "The Okay Microwave!",
    ItemType.Microwave, new ItemDimension(12, 16, 26), 320, "Savvy Inc.", 54789200, 2222, 1000005);

//Creating Inventory List
InventoryList myList = new();

//Operations for Inventory
InventoryOperations inventoryOperations = new(myList);

//Adding to Inventory List
inventoryOperations.AddItem(itemOne);
inventoryOperations.AddItem(itemTwo);
inventoryOperations.AddItem(itemThree);
inventoryOperations.AddItem(itemFour);
inventoryOperations.AddItem(itemFive);

Logger.Log("Reading Inventory");
inventoryOperations.ReadInventoryList();

Console.ReadKey();
