using WeatherApplication.Service.Enum;

namespace Service.ServiceInterfaces;

public interface IPlayingWithWordsService
{
    public Task<string> GetNewWord(PlayingWithWordsEnum wordsEnum, string word);
    public bool CheckThePalindrome(string word);
}