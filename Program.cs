// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

var dataSource = new DataSource();
var sheet = new Sheet(dataSource);
var chart = new Chart(dataSource);

dataSource.Data = new List<int> { 1, 2, 3 };