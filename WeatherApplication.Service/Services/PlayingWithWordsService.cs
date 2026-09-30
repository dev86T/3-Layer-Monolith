using Service.ServiceInterfaces;
using WeatherApplication.Service.Enum;

namespace WeatherApplication.Service;

public class PlayingWithWordsService : IPlayingWithWordsService
{
    public async Task<string> GetNewWord(
        PlayingWithWordsEnum wordsEnum,
        string word)
    {
        switch (wordsEnum)
        {
            case PlayingWithWordsEnum.ToUpper:
                return word.ToUpper();

            case PlayingWithWordsEnum.ToLower:
                return word.ToLower();

            case PlayingWithWordsEnum.Palindrome:
                return CheckThePalindrome(word).ToString();

            default:
                throw new ArgumentOutOfRangeException(nameof(wordsEnum));
        }
    }

    public bool CheckThePalindrome(string word)
    {
        return word.SequenceEqual(word.Reverse());
    }
}