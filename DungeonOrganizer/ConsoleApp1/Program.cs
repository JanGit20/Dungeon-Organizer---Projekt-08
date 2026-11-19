using DungeonOrganizer.Items;
using DungeonOrganizer.World;
using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;
using DungeonOrganizer.Items;

using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
Item item = new Item("Mikstura", 15);
Weapon weapon = new Weapon("Miecz", 8);

InventoryItem inventoryItem = new InventoryItem("Mikstura", 15);
MapItem mapItem = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);

Console.WriteLine($"{weapon.Name} zadaje {weapon.Damage} obrażeń.");
Console.WriteLine($"Przedmiot: {inventoryItem.Name}, cena: {inventoryItem.Price}");
Console.WriteLine($"Symbol na mapie: {mapItem.Symbol}");

