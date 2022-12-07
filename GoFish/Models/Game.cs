using System.Collections.Generic;

namespace GoFish.Models
{
  public class Games
  {
    public string Name { get; set; }
    public Hand Hand { get; set; }

    public Game(string name)
    {
      Name = name;
      Hand = new Hand();
    }

    public string ToString()
    {
      string 
    }
  }
}