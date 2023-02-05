using Newtonsoft.Json.Linq;

var client = new HttpClient();
var zip = 43081;
string apikey = File.ReadAllText("appsettings.json");
var key = JObject.Parse(apikey).GetValue("DefaultKey").ToString();
var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={key}&units=imperial";
var weatherornot = client.GetStringAsync(weatherURL).Result;
var weather = JObject.Parse(weatherornot);
Console.WriteLine($"Hey, think it's cold where you are? Try spending some time in Columbus Ohio. Where it is currently {weather["main"]["temp"]} degrees!");
Console.WriteLine($"Don't worry though, wait a bit and it'll eventually get to {weather["main"]["temp_max"]} degrees before slipping face first into a frozen {weather["main"]["temp_min"]} degree abyss");




