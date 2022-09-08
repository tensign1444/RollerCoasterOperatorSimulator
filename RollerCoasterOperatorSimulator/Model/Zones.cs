using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterOperatorSimulator.Model
{
    public class Zones
    {
        List<Zone> zones; //List of all our zones

        /// <summary>
        /// Constructor which is instanitated
        /// </summary>
        public Zones()
        {
            zones = new List<Zone>();
            Intialize();
        }

        /// <summary>
        /// Intialize creates all the zones so we have places for the rockets.
        /// </summary>
        private void Intialize()
        {
            for(int i = 1; i <= 15; i++)
            {
                zones.Add(new Zone($"Zone {i}", i, false));        
            }
            zones.Add(new Zone($"Hold 2", 16, true));
            zones.Add(new Zone($"Hold 1", 17, true));
            zones.Add(new Zone($"Unload", 18, true));
            zones.Add(new Zone($"Load", 19, true));
            zones.Add(new Zone($"Ready", 20, true));
            zones.Add(new Zone($"Dispatch", 21, true));
            zones.Add(new Zone($"Storage", 22, true));
        }

        /// <summary>
        /// Gets the Zone by the index number
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Desired zone at specific index</returns>
        public Zone GetByIndex(int index)
        {
            return zones[index];
        }

        /// <summary>
        /// Get's a zone by the zone name, throws exception is the zone is not found
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Zone</returns>
        /// <exception cref="Exception"></exception>
        public Zone GetByName(string name)
        {
            foreach(Zone zone in zones)
            {
                if(zone.Name.Equals(name))
                    return zone;
            }
            throw new Exception("Zone not found.");
        }

        /// <summary>
        /// Get's a zone by the zone id. Throws exception if zone is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Zone GetByID(int id)
        {
            foreach (Zone zone in zones)
            {
                if (zone.Id.Equals(id))
                    return zone;
            }
            throw new Exception("Zone not found.");
        }
    }

    /// <summary>
    /// Zone class
    /// </summary>
    public class Zone
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public bool Occupied { get; set; }

        public Zone(string Name, int Id, bool Occupied = false)
        {
            this.Name = Name;
            this.Id = Id;
            this.Occupied = Occupied;
        }
    }
}
