using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{   
    struct PlayerBuffer
    {
        public String Name { get; set; }
        public int goodScore { get; set; }
        public int badScore { get; set; }
    }

    class Player
    {
        public String Name { get; set; }
        public int goodScore { get; set; }
        public int badScore { get; set; }
        public Player(String n) 
        {
            Name = n;
            goodScore = 0;
            badScore = 0;
            foreach (var item in JSONSaver.getPlayers())
            {
                if (item.Name == n)
                {
                    goodScore = item.goodScore;
                    badScore = item.badScore;
                    break;
                }
            }
            
        }
        public Player(PlayerBuffer p)
        {
            Name = p.Name;
            goodScore = p.goodScore;
            badScore = p.badScore;
        }
        public Player() 
        {
            PlayerBuffer p = JSONSaver.getLastPlayerOrCreate();
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
        public PlayerBuffer asBuffer()
        {
            return new PlayerBuffer
            {
                Name = Name,
                goodScore = goodScore,
                badScore = badScore
            };
        }

        public static int compare(Player a, Player b)
        {
            double AscorCof = a.goodScore / a.badScore;
            double BscorCof = b.goodScore / b.badScore;
            if (AscorCof > BscorCof) 
                return -1;
            else if (AscorCof < BscorCof) 
                return 1;
            else 
                return 0;
        }
    }
    static class JSONSaver
    {   
        private static List<Player> players;
        private const string LastPlayerFileName = @"..\..\..\Resources\LastPlayers.json";
        private const string RecordsFileName = @"..\..\..\Resources\Players.json";
        //public static Player newPlayer(String name)
        //{
        //    try
        //    {
        //        String str = File.ReadAllText(RecordsFileName);
        //        players = JsonSerializer.Deserialize<List<Player>>(str);
        //        if(name == null)
        //            return new Player(players.Count + 1);
        //        else
        //        {
        //            try
        //            {
        //                return (from p in players
        //                        where p.Name == name
        //                        select p).Single();
        //            }
        //            catch
        //            {
        //                return new Player(name);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return new Player(1);
        //    }

        //}
        public static PlayerBuffer getLastPlayerOrCreate()
        {   
            String str = File.ReadAllText(LastPlayerFileName);
            PlayerBuffer p = JsonSerializer.Deserialize<PlayerBuffer>(str);
            return p;
        }

        public static void SvaeLastPlayer(Player played)
        {   
            String str = JsonSerializer.Serialize(played);
            File.WriteAllText(LastPlayerFileName, str);
            
        }
        public static void saveRecords(List<Player> records)
        {
            String str = JsonSerializer.Serialize<List<Player>>(records);
            File.WriteAllText(RecordsFileName ,str);
        }
        public static List<Player> getPlayers()
        {
            List<Player> records = new List<Player>();
            String str = File.ReadAllText(RecordsFileName);
            if (str == "")
                return records;
            List<PlayerBuffer> r = JsonSerializer.Deserialize<List<PlayerBuffer>>(str);
            foreach (var item in r)
                records.Add(new Player(item));
            return records;
        }
        public static List<Player> getRecords()
        {
            List<Player> records = getPlayers();
            records.Sort(Player.compare);
            return records;
        }
        public static List<Player> getRecords(Player p)
        {
            List<Player> records = getPlayers();
            foreach (var item in records)
            {
                if(item.Name == p.Name)
                {
                    item.goodScore = p.goodScore;
                    item.badScore = p.badScore;
                    records.Sort(Player.compare);
                    return records;
                }
            }

            records.Add(p);
            records.Sort(Player.compare);
            return records;
        }

        private static void addToEnd(Player played) // Врят ли пригодится, но можно добавлять если не существовало.
        {
            String str = JsonSerializer.Serialize(played);
            str += ']';
            str = ", " + str;
            using (FileStream stream = new FileStream(RecordsFileName, FileMode.Open))
            {
                stream.Seek(0, SeekOrigin.End);
                stream.Seek(stream.Position - 1, SeekOrigin.Begin);
                stream.Write(Encoding.UTF8.GetBytes(str));
            }
        }
    }
}
