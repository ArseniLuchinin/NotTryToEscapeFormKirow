using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    class Player
    {
        public String Name;
        public int goodScore;
        public int badScore;
        public Player(String n) 
        {
            Name = n;
            goodScore = 0;
            badScore = 0;
        }
        public Player() 
        {
            Player p = JSONSaver.getLastPlayerOrCreate();
            Name = p.Name;
            goodScore = p.goodScore;
            badScore = p.badScore;
        }
        public Player(int i)
        {
            Name = "Player" + i.ToString();
            goodScore = 0;
            badScore = 0;
        }
    }
    internal class JSONSaver
    {
        public static Player newPlayer(String name)
        {
            try
            {
                String str = File.ReadAllText("Players.json");
                List<Player> players = JsonSerializer.Deserialize<List<Player>>(str);
                if(name == null)
                    return new Player(players.Count + 1);
                else
                {
                    foreach (var item in players)
                    {
                        if (item.Name == name)
                            throw new Exception();
                    }
                    return new Player(name);
                }
            }
            catch
            {
                return new Player(1);
            }

        }
        public static Player getLastPlayerOrCreate()
        {   
            using (FileStream file = new FileStream("Players.json", FileMode.OpenOrCreate))
            {
                try
                {
                    return JsonSerializer.Deserialize<Player>(file);
                }
                catch
                {
                    return newPlayer(null);
                }
                
            }
        }
    }
}
