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

    // public bool Windows { get; set; }
    // public bool Playstation { get; set; }
    // public bool XboxOne { get; set; }
    // public bool Mac { get; set; }
    // public bool Switch { get; set; }
    // public bool PlaystationVita { get; set; }
    // public bool Playstation3 { get; set; }
    // public bool IOS { get; set; }
    // public bool Android { get; set; }
    // public bool XboxSeriesSX { get; set; }
    // public bool Playstation5 { get; set; }
    // public bool Linux { get; set; }
    // public bool Wii { get; set; }
  }
}