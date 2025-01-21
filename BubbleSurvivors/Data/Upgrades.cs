using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSurvivors.Data
{
    public enum Weapon
    {
        Gun,
        Sword,
        Thumbtack,
    }

    public enum Passive
    {
        RangeUp,
        BouncingShots,
    }

    public class UpgradeData
    {
        public required string Name { get; set; }
        public int Level { get; set; } = 1;
    }

    public class WeaponData : UpgradeData
    {
        public Weapon Weapon { get; set; }
        public required string BulletSprite { get; set; }
        public decimal Damage { get; set; }
        public float Range { get; set; }
        public float BulletSpeed { get; set; }
        public float FireDelay { get; set; }
        public float BulletScale { get; set; }
        public float HitKnockback { get; set; }
        public float Accuracy { get; set; }
        public float BulletLifespan { get; set; }
        public int Pierces {  get; set; }
        public int Bounces { get; set; }
        
    }
}
