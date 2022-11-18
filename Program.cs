using Newtonsoft.Json.Linq;

var client = new HttpClient();
var weatherURL = "https://api.openweathermap.org/data/2.5/weather?zip=43081&appid=d47c4a614013f7d95b8915308d8a82fc&units=imperial";
var weatherornot = client.GetStringAsync(weatherURL).Result;
var weather = JObject.Parse(weatherornot);
Console.WriteLine($"Hey, think it's cold where you are? Try spending some time in Columbus Ohio. Where it is currently {weather["main"]["temp"]} degrees!");
Console.WriteLine($"Don't worry though, wait a bit and it'll eventually get to {weather["main"]["temp_max"]} degrees before slipping face first into a frozen {weather["main"]["temp_min"]} degree abyss");




