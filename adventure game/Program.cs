Console.WriteLine("welcome to the adventure game");
Console.WriteLine("Enter your character name: ");
string playerName = Console.ReadLine();
Console.WriteLine("choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();
Console.WriteLine($"you, {playerName} the {characterType} find yourself at the edge of the forest");
Console.WriteLine("Do you enter the forest or camp outside?(Enter/Camp)");
string choice1 = Console.ReadLine();
if(choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely entered the forest");
}
else
{
    Console.WriteLine("You decided to wait for the daylight.");
}
bool gameContinues = true;
while (gameContinues)
{
    Console.WriteLine("Left or Right?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();
        if(fightChoice.ToLower() == "fight")
        {
          Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast");
                if (luck > 8)
                {
                    Console.WriteLine("You get the treasure");
                }
            }
            else
            {
                Console.WriteLine("You're dead");
                gameContinues = false;
            }
        }
    }
}