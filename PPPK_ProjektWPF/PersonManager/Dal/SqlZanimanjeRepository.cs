using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Zadatak.Models;
using Zadatak.Utils;

namespace Zadatak.Dal
{
    class SqlzanimanjeRepository : IRepository<Zanimanje>
    {

        private const string IDZanimanjeParam = "@IDZanimanje";
        private const string NazivParam = "@naziv";

        private static readonly string cs = EncryptionUtils.Decrypt(ConfigurationManager.ConnectionStrings["cs"].ConnectionString, "fru1tc@k3");

        private Zanimanje Readzanimanje(SqlDataReader dr) => new Zanimanje
        {
            IDZanimanje = (int)dr[nameof(Zanimanje.IDZanimanje)],
            Naziv = dr[nameof(Zanimanje.Naziv)].ToString()

        };

        public void Add(Zanimanje zanimanje)
        {
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "AddZanimanje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(NazivParam, zanimanje.Naziv);

                    SqlParameter IDZanimanje = new SqlParameter(IDZanimanjeParam, SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(IDZanimanje);
                    cmd.ExecuteNonQuery();
                    zanimanje.IDZanimanje = (int)IDZanimanje.Value;
                }
            }
        }

        public void Delete(Zanimanje zanimanje)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DeleteZanimanje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IDZanimanjeParam, zanimanje.IDZanimanje);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IList<Zanimanje> GetAll()
        {
            IList<Zanimanje> zanimanjes = new List<Zanimanje>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GetZanimanje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            zanimanjes.Add(Readzanimanje(dr));
                        }
                    }
                }
            }
            return zanimanjes;
        }

        public Zanimanje Get(int IDZanimanje)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "GetZanimanjeOsobe";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IDZanimanjeParam, IDZanimanje);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return Readzanimanje(dr);
                        }
                    }
                }
            }
            throw new Exception("zanimanje does not exist");
        }
   

        public void Update(Zanimanje zanimanje)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UpdateZanimanje";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(NazivParam, zanimanje.Naziv);

                    cmd.Parameters.AddWithValue(IDZanimanjeParam, zanimanje.IDZanimanje);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
