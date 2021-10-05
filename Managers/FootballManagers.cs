using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4SimpleRESTService.Models;
using Opgave1UnitTest;

namespace Assignment4SimpleRESTService.Managers
{
    public class FootballManagers 
    {
        private static int _nextId = 1;

        private static readonly List <FootballPlayer> Fbplayer = new List<FootballPlayer>
        {
            new FootballPlayer {Id = _nextId++, Name = "Mikkel Andersen", Price = 300, ShirtNumber = 12},
            new FootballPlayer {Id = _nextId++, Name = "Philip Rasmussen", Price = 500, ShirtNumber = 8},
            new FootballPlayer {Id = _nextId++, Name = "Morten Kejser", Price = 800, ShirtNumber = 4}

        };



        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Fbplayer);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public FootballPlayer GetById(int id)
        {
            return Fbplayer.Find(fbplayer => fbplayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newplayer)
        {
            newplayer.Id = _nextId++;
            Fbplayer.Add(newplayer);
            return newplayer;
        }
        public FootballPlayer Delete(int id)
        {
            FootballPlayer fbplayer = Fbplayer.Find(fbplayer1 => fbplayer1.Id == id);
            if (fbplayer == null) return null;
            Fbplayer.Remove(fbplayer);
            return fbplayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer fbplayer = Fbplayer.Find(fbplayer1 => fbplayer1.Id == id);
            if (fbplayer == null) return null;
            fbplayer.Name = updates.Name;
            fbplayer.Price = updates.Price;
            fbplayer.ShirtNumber = updates.ShirtNumber;
            return fbplayer;
        }
    }

}
