using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageRoll
{
    class DamageRoller
    {  
        public static float calcDamage(hero h, attackRoll a) 
        {
            //Physical Damage
            float returnedPhys = calcPhysResist(h.armor, a.physicalDamage);
            float finalPhys = a.physicalDamage - (a.physicalDamage * returnedPhys);
            
            //Fire Damage
            float returnedFire = calcFireResist(h.fireResist, a.fireDamage);
            float finalFire = a.fireDamage - (a.fireDamage * returnedFire);

            //Cold Damage
            float returnedCold = calcColdResist(h.coldResist, a.coldDamage);
            float finalCold = a.coldDamage - (a.coldDamage * returnedCold);

            //Light Damage
            float returnedLight = calclightResist(h.lightResist, a.lightDamage);
            float finalLight = a.lightDamage - (a.lightDamage * returnedLight);

            //Calc Total
            float total = finalPhys + finalFire + finalCold + finalLight;

            if (a.isCrit)
                Console.WriteLine("**CRITICAL HIT**");

            Console.WriteLine("Physical Damage: {0}", finalPhys);
            Console.WriteLine("Fire Damage: {0}", finalFire);
            Console.WriteLine("Cold Damage: {0}", finalCold);
            Console.WriteLine("Light Damage: {0}", finalLight);
            Console.WriteLine("Total Damage: {0}", total);

            return total;
        }

        public static float calcPhysResist(float armor, float damage)
        {
            float damageTaken = armor / (armor + (12 * damage));
            return damageTaken;
        }

        public static float calcFireResist(float fireResist, float fireDamage)
        {
            float damageTaken = fireResist / (fireResist + (12 * fireDamage));
            return damageTaken;
        }

        public static float calcColdResist(float coldResist, float coldDamage)
        {
            float damageTaken = coldResist / (coldResist + (12 * coldDamage));
            return damageTaken;
        }

        public static float calclightResist(float lightResist, float lightDamage)
        {
            float damageTaken = lightResist / (lightResist + (12 * lightDamage));
            return damageTaken;
        }
    }
}
