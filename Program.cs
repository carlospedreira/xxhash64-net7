using System.Text.Json;
using System.IO.Hashing;

var data = new { Foo = "Bar" };

var json = JsonSerializer.Serialize(data);
var bytes = JsonSerializer.SerializeToUtf8Bytes(data);

var hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();

Console.WriteLine($"{data} => {hash}");