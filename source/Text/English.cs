using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPAdventureGame
{
    public class English : Language
    {
        public English()
        {
            ChooseYourName = "Hello, what is your name?";
            NoNameSet = "No name given, please enter your name.";
            Welcome = "Welcome {0} to your OOP Adventure!";
            DefaultRoomName = "Room {0} ({1},{2})";
            DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
            ActionError = "You can't do that.";
            Go = "Go";
            GoError = "You can't go that way.";
            WhatToDo = "What do you want to do?";
            Quit = "quit";
            RoomNew = "You entered {0}.";
            RoomOld = "You returned to {0}.";
            And = "and";
            Comma = ",";
            Space = " ";
            RoomDescriptions = new List<string>
            {
                "normal",
                "cold",
                "warm",
                "dark",
                "bright",
                "scary",
                "strange"
            };
            NoItem = "You don't have {0}";
        }
    }
}