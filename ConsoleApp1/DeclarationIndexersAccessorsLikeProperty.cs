using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class DeclarationIndexersAccessorsLikeProperty
  {
    public string[] TheMusicApp(string[] arr)
    {
      var genres = new MusicGenres(); 
      
      //var arr = new string[] { "Bluse", "Rock", "Hip Hop", "Contry", "Soul" };

      string[] arrResult = new string[5];
      for (int i = 0; i < 5; i++)
      {
        arrResult[i] = "Following: " + genres[i];
      }
      return arrResult;
    }
  }

  internal class MusicGenres
  {
    private string[] genres = new string[5];

        //declare an indexer

        // Your code starts here
        public string this [int indexer] 
        {
            get => genres[indexer];
            set => genres[indexer] = value;
        }

    }
}
