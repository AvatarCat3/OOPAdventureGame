using OOPAdventureGame;

var name = "";
var input = "";
var player = new Player("No Name");
var run = true;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);

name = Console.ReadLine();

while(name == ""){
    Console.WriteLine(Text.Language.NoNameSet);
    name = Console.ReadLine();
}
    player = new Player(name);
    Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);
house.CreateRooms(3, 3);
house.DecorateRooms();

Actions.Instance.Register(new Go(house));

house.GoToStartingRoom();

Room lastRoom = null;

while(run)
{
    if(lastRoom != house.CurrentRoom){
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }

    Console.WriteLine(Text.Language.WhatToDo);

    input = Console.ReadLine().ToLower();

    if(input == Text.Language.Quit){
        run = false;
    }else{
        Actions.Instance.Execute(input.Split(" "));
    }
}