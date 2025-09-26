// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

var box = new Box();
var subscriber = new Subscriber();
var subscriber2 = new Subscriber_2();
box.Subscribe(subscriber.OnDataChanged);
box.Subscribe(subscriber2.OnDataChanged);
box.ChangeContent("New Content");