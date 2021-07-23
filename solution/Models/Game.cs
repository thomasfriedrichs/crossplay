using System.Collections.Generic;

namespace CrossPlay.Models
{
  public class Game
  {

    public Game()
    {
      Consoles = new List<Console>();
    }
    public int GameId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Link { get; set; }
    public List<Console> Consoles { get; set; }

    //  Windows 1
    //  Playstation 2
    //  XboxOne 3
    //  Mac 4
    //  Switch 5
    //  PlaystationVita 6
    //  Playstation3 7
    //  IOS 8
    //  Android 9
    //  XboxSeriesSX 10
    //  Playstation5 11
    //  Linux 12
    //  Wii 13
  }
}