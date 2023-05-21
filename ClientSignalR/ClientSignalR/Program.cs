using Microsoft.AspNetCore.SignalR.Client;
using System.Xml;

var connection = new HubConnectionBuilder()
    .WithUrl("https://localhost:7035/MainHub")
    .Build();

//connection.On<string>("ClientMessage", message =>
//{
//    Console.WriteLine(message);
//});

await connection.StartAsync();

while (true)
{
    var message = Console.ReadLine();
    await connection.InvokeAsync("AddToCompanyGroup","1");
}