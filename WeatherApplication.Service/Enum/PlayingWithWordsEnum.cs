using System.Text.Json.Serialization;

namespace WeatherApplication.Service.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PlayingWithWordsEnum
{
    ToUpper = 1,
    ToLower = 2,
    Palindrome = 3
}