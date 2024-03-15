using System.Text.Json;
using System.IO.Hashing;

var data = new { Foo = "Bar" };

var bytes = JsonSerializer.SerializeToUtf8Bytes(data);
var hashedBytes = XxHash64.Hash(bytes);
var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

var json = JsonSerializer.Serialize(data);

Console.WriteLine($"{data} => {hash}");