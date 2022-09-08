using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterOperatorSimulator.Model
{
    public class Rockets
    {
        List<Rocket> rockets; //List of all our ROCKETS
        Zones zones;
        /// <summary>
        /// Constructor which is instanitated
        /// </summary>
        public Rockets(Zones zones)
        {
            rockets = new List<Rocket>(); 
            this.zones = zones;
            Intialize();
        }

        /// <summary>
        /// Intialize creates all the zones so we have places for the rockets.
        /// </summary>
        private void Intialize()
        {
            rockets.Add(new Rocket(1, zones.GetByName("Dispatch"),false));
            rockets.Add(new Rocket(2, zones.GetByName("Ready"), false));
            rockets.Add(new Rocket(3, zones.GetByName("Load"), false));
            rockets.Add(new Rocket(4, zones.GetByName("Unload"), false));
            rockets.Add(new Rocket(5, zones.GetByName("Hold 1"), false)); ;
            rockets.Add(new Rocket(6, zones.GetByName("Hold 2"), false));

            for (int i = 1; i <= 12; i++)
            {
                rockets.Add(new Rocket(i, zones.GetByName("Storage"), true));
            }
        }
    }
    
    public class Rocket
    {
        public int Id { get; set; }

        public bool inStorage { get; set; }

        public Zone OccupiedZone { get; set; }

        public Rocket(int Id, Zone OccupiedZone, bool inStorage = false)
        {
            this.Id = Id;
            this.inStorage = inStorage;
        }
    }
}
