using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Airplane
    {
        public Airplane(AirplaneEngine engine, AirplaneLandingGear landingGear, AirplaneWing wing)
        {
            Engine = engine;
            LandingGear = landingGear;
            Wing = wing;
        }
        public AirplaneEngine Engine { get; private set; }
        public AirplaneLandingGear LandingGear { get; private set; }
        public AirplaneWing Wing { get; private set; }
        public string Destination { get; set; } = null;
        public void Fly()
        {
            
        }
    }
    class AirplaneWing
    {
        public AirplaneWing(string material, int weightKG)
        {
            Material = material;
            WeightKG = weightKG;
        }
        public string Material;
        public int WeightKG { get; set; }
    }
    class AirplaneEngine
    {
        public AirplaneEngine(int hp, int weightKG)
        {
            HP = hp;
            WeightKG = weightKG;
        }
        public int HP { get; private set; }
        public int WeightKG { get; private set; }
    }
    class AirplaneLandingGear
    {
        public AirplaneLandingGear(int heightCM, int weightKG)
        {
            HeightCM = heightCM;
            WeightKG = weightKG;
        }
        public int HeightCM { get; private set; }
        public int WeightKG { get; private set; }
    }
}
