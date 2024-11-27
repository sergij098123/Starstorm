//using Newtonsoft.Json;
using System.Text.Json;

namespace Game.json
{
    static public class Shop
    {
        public static async Task test(){
            string filePath = @"bin\Debug\net8.0\JSON\shops.json";
            using FileStream shopStream = Json.loadFile(filePath);
            shopJson shopData = 
                await JsonSerializer.DeserializeAsync<shopJson>(shopStream);
            await Task.Delay(2000);

            Console.WriteLine($"Balance: {shopJson.balance}");
        }
    }
    public class Json
    {
        public static FileStream loadFile(string filePath){
            using FileStream fileData = File.OpenRead(filePath);
            return fileData;
        }
    }
    public class shopJson{
        public static int balance{get; set;}
    }

}