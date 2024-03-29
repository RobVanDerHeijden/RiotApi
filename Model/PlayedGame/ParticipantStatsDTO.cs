﻿using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace RiotApi.Model
{
    public class ParticipantStatsDTO
    {
        public int ParticipantId { get; set; }
        public bool Win { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; } // Trinket
        public List<Item> ItemList { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int LargestKillingSpree { get; set; }
        public int LargestMultiKill { get; set; }
        public int KillingSprees { get; set; }
        public int LongestTimeSpentLiving { get; set; }
        public int DoubleKills { get; set; }
        public int TripleKills { get; set; }
        public int QuadraKills { get; set; }
        public int PentaKills { get; set; }
        public int UnrealKills { get; set; }
        public long TotalDamageDealt { get; set; }
        public long MagicDamageDealt { get; set; }
        public long PhysicalDamageDealt { get; set; }
        public long TrueDamageDealt { get; set; }
        public int LargestCriticalStrike { get; set; }
        public long TotalDamageDealtToChampions { get; set; }
        public long MagicDamageDealtToChampions { get; set; }
        public long PhysicalDamageDealtToChampions { get; set; }
        public long TrueDamageDealtToChampions { get; set; }
        public long TotalHeal { get; set; }
        public int TotalUnitsHealed { get; set; }
        public long DamageSelfMitigated { get; set; }
        public long DamageDealtToObjectives { get; set; }
        public long DamageDealtToTurrets { get; set; }
        public long VisionScore { get; set; }
        public long TimeCCingOthers { get; set; }
        public long TotalDamageTaken { get; set; }
        public long MagicalDamageTaken { get; set; }
        public long PhysicalDamageTaken { get; set; }
        public long TrueDamageTaken { get; set; }
        public int GoldEarned { get; set; }
        public int GoldSpent { get; set; }
        public int TurretKills { get; set; }
        public int InhibitorKills { get; set; }
        public int TotalMinionsKilled { get; set; }
        public int NeutralMinionsKilled { get; set; }
        public int NeutralMinionsKilledTeamJungle { get; set; }
        public int NeutralMinionsKilledEnemyJungle { get; set; }
        public int TotalTimeCrowdControlDealt { get; set; }
        public int ChampLevel { get; set; }
        public int VisionWardsBoughtInGame { get; set; }
        public int SightWardsBoughtInGame { get; set; }
        public int WardsPlaced { get; set; }
        public int WardsKilled { get; set; }
        public bool FirstBloodKill { get; set; }
        //public bool FirstBloodAssist { get; set; }
        public bool FirstTowerKill { get; set; }
        //public bool FirstTowerAssist { get; set; }
        public bool FirstInhibitorKill { get; set; }
        // Depricated Dominion variables
        //public bool FirstInhibitorAssist { get; set; }
        //public int CombatPlayerScore { get; set; }
        //public int ObjectivePlayerScore { get; set; }
        //public int TotalPlayerScore { get; set; }
        //public int TotalScoreRank { get; set; }
        //public int PlayerScore0 { get; set; }
        //public int PlayerScore1 { get; set; }
        //public int PlayerScore2 { get; set; }
        //public int PlayerScore3 { get; set; }
        //public int PlayerScore4 { get; set; }
        //public int PlayerScore5 { get; set; }
        //public int PlayerScore6 { get; set; }
        //public int PlayerScore7 { get; set; }
        //public int PlayerScore8 { get; set; }
        //public int PlayerScore9 { get; set; }

        // RUNES
        public int Perk0 { get; set; }
        public int Perk0Var1 { get; set; }
        public int Perk0Var2 { get; set; }
        public int Perk0Var3 { get; set; }
        public int Perk1 { get; set; }
        public int Perk1Var1 { get; set; }
        public int Perk1Var2 { get; set; }
        public int Perk1Var3 { get; set; }
        public int Perk2 { get; set; }
        public int Perk2Var1 { get; set; }
        public int Perk2Var2 { get; set; }
        public int Perk2Var3 { get; set; }
        public int Perk3 { get; set; }
        public int Perk3Var1 { get; set; }
        public int Perk3Var2 { get; set; }
        public int Perk3Var3 { get; set; }
        public int Perk4 { get; set; }
        public int Perk4Var1 { get; set; }
        public int Perk4Var2 { get; set; }
        public int Perk4Var3 { get; set; }
        public int Perk5 { get; set; }
        public int Perk5Var1 { get; set; }
        public int Perk5Var2 { get; set; }
        public int Perk5Var3 { get; set; }
        public int PerkPrimaryStyle { get; set; }
        public RunePath PrimaryRunePath { get; set; }
        public int PerkSubStyle { get; set; }
        public RunePath SecondaryRunePath { get; set; }
        // Flat Rune stats
        public int StatPerk0 { get; set; }
        public int StatPerk1 { get; set; }
        public int StatPerk2 { get; set; }
    }
}
