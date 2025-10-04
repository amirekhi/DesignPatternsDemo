// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;
using DesignPatternsDemo.Patterns.Structural;

IItem mouse = new Mouse();
IItem keyboard = new Keyboard();
CompBox box = new CompBox();
CompBox box_2 = new CompBox();

box.AddItem(mouse);
box.AddItem(keyboard);
box_2.AddItem(box);
float totalPrice = box_2.GetPrice();
Console.WriteLine($"Total Price: {totalPrice}");