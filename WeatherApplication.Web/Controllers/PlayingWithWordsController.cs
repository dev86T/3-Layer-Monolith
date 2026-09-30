using Microsoft.AspNetCore.Mvc;
using Service.ServiceInterfaces;
using WeatherApplication.Service.Enum;

namespace WeatherApplication.Web.Controllers;

public class PlayingWithWordsController : Controller
{
    private readonly IPlayingWithWordsService _playingWithWordsService;

    public PlayingWithWordsController(IPlayingWithWordsService playingWithWordsService)
    {
        _playingWithWordsService = playingWithWordsService;
    }
    /// <summary>
    ///     Playing with some text messages
    /// </summary>
    [HttpPost("playing-with-words")]
    public async Task<IActionResult> PlayingWithWords(PlayingWithWordsEnum wordsEnum, string word,
        CancellationToken cancellationToken)
    {
        var result = await _playingWithWordsService.GetNewWord(wordsEnum, word);
        return Ok(result);
    }
}