using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageRoll
{
    class hero
    {
        public float health = 100;
        public float armor = 20;
        public float fireResist = 15;
        public float coldResist = 0;
        public float lightResist = 90;
        public float damage = 15;
    }

    public class attackRoll
    {
        public bool isCrit = false;

        public float critStrikeChance = 19.9f;
        public float critMult = 206;

        public float physicalDamage;
        public float fireDamage;
        public float coldDamage;
        public float lightDamage;

        public attackRoll()
        {
            Random r = new Random();
            float critRoll = float.Parse(r.NextDouble().ToString());

            critRoll *= 100;

            if (critRoll <= critStrikeChance)
            {
                isCrit = true;
                
                physicalDamage = r.Next(1, 10) * critMult / 100;
                fireDamage = r.Next(1, 10) * critMult / 100;
                coldDamage = r.Next(1, 10) * critMult / 100;
                lightDamage = r.Next(1, 10) * critMult / 100;
            }
            else
            {
                physicalDamage = r.Next(1, 10);
                fireDamage = r.Next(1, 10);
                coldDamage = r.Next(1, 10);
                lightDamage = r.Next(1, 10);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Run();
                Console.ReadLine();
            }
        }

        static public void Run()
        {
            hero h = new hero();
            attackRoll a = new attackRoll();
            DamageRoller.calcDamage(h, a);
        }
    }
}
