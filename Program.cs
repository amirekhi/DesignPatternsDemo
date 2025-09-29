// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

List<Client> clients = new List<Client>();
Client vipCustomer = new VipCustomer("amir", "amir@gmail.com");
Client RegCustomer = new RegularCustomer("jhonDoe", "doe@gmail.com");
IVisitor emailClients = new EmailCustomers();

clients.Add(vipCustomer);
clients.Add(RegCustomer);

foreach (var client in clients)
{
    client.Execute(emailClients);
}
