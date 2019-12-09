using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using Data.Interfaces;
using Model;

namespace Data.Contexts.SQL
{
    public class SummonerSQLContext : ISummonerSQLContext
    {
        private readonly DBConnection _dbConnection = new DBConnection();

        public Summoner GetSummonerByName(string region, string summonerName)
        {
            Summoner summoner = new Summoner();
            try
            {
                using (SqlConnection conn = _dbConnection.SqlConnection)
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("SELECT * " +
                                       "FROM Summoner " +
                                       "WHERE region = @Region " +
                                       "AND summonerName = @SummonerName", conn))
                    {
                        cmd.Parameters.AddWithValue("@Region", region);
                        cmd.Parameters.AddWithValue("@SummonerName", summonerName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                summoner = new Summoner
                                {
                                    //PreferedPosition = (Position)reader["PreferedPosition"],
                                    //PreferedClass = (Tag)reader["PreferedClass"],
                                    AccountId = (string)reader["accountId"],
                                    SummonerId = (string)reader["summonerId"],
                                    Name = (string)reader["summonerName"],
                                    Region = (string)reader["region"],
                                    ProfileIconId = (int)reader["profileIconId"],
                                    SummonerLevel = (int)reader["summonerLevel"],
                                    RevisionDateTime = (DateTime)reader["revisionDate"],
                                    HighestPreviousRank = reader["highestPreviousRank"]?.ToString(),
                                    LastUpdated = (DateTime)reader["lastUpdated"]
                                };
                                //int nextLevel = player.PlayerLevel + 1;
                                //player.ExperienceNeededForNextLevel = (int)Math.Pow((nextLevel * 5), 2);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return summoner;
        }

        public SummonerPlayedGamesList GetSummonerPlayedGames(string region, string summonerIdAccount)
        {
            SummonerPlayedGamesList summonerPlayedGamesList = new SummonerPlayedGamesList();

            try
            {

                using (SqlConnection conn = _dbConnection.SqlConnection)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PlayedGame", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Player player = new Player
                                //{
                                //    PlayerId = (int)reader["PlayerID"],
                                //    Username = (string)reader["username"],
                                //    Password = (string)reader["password"],
                                //    PlayerLevel = (int)reader["playerLevel"],
                                //    Experience = (int)reader["experience"],
                                //    SkillPoints = (int)reader["skillPoints"],
                                //    Money = (decimal)reader["money"],
                                //    Income = (decimal)reader["income"],
                                //    Energy = (int)reader["energy"],
                                //    MaxEnergy = (int)reader["maxEnergy"],
                                //    RealName = reader["realName"]?.ToString(),
                                //    Country = reader["country"]?.ToString(),
                                //    City = reader["city"]?.ToString()
                                //};
                                //player.ExperienceNeededForNextLevel = (player.PlayerLevel * 5) ^ 2;
                                //playerList.Add(player);
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return summonerPlayedGamesList;
        }

        public PlayedGame GetPlayedGameInfoFromId(string region, long gameId)
        {
            throw new NotImplementedException();
        }

        public List<Rank> GetSummonerRanks(string region, string encryptedSummonerId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetRegions()
        {
            List<string> regions = new List<string>();

            try
            {
                using (SqlConnection conn = _dbConnection.SqlConnection)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Region", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                String region = (string)reader["name"];
                                regions.Add(region);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return regions;
        }

        public Champion GetChampionInfoFromId(int championId)
        {
            throw new NotImplementedException();
        }

        public SummonerSpell GetSummonerSpellInfoFromId(int summonerSpellId)
        {
            throw new NotImplementedException();
        }

        public Item GetItemInfoFromId(int itemId)
        {
            throw new NotImplementedException();
        }

        public RunePath GetRunePathInfoFromId(int runePathId)
        {
            throw new NotImplementedException();
        }

        public QueueType GetQueueTypeInfoFromId(int queueTypeId)
        {
            throw new NotImplementedException();
        }

        public Position GetPositionFromRoleAndLane(string role, string lane)
        {
            throw new NotImplementedException();
        }
    }
}
