using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Model
{
    public class Champion
    {
        public int  Ket { get; set; }
        public string KeyName { get; set; }
        public string ChampionName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Hp { get; set; }
        public float HpPerLevel { get; set; }
        public float Mp { get; set; }
        public float MpPerLevel { get; set; }
        public float Armor { get; set; }
        public float ArmorPerLevel { get; set; }
        public float MagicResist { get; set; }
        public float MagicResistPerLevel { get; set; }
        public float AttackDamage { get; set; }
        public float AttackDamagePerLevel { get; set; }
        public float AttackSpeed { get; set; }
        public float AttackSpeedPerLevel { get; set; }
        public int AttackRange { get; set; }
        public int MoveSpeed { get; set; }
        public Tag Tag { get; set; }
    }
}
