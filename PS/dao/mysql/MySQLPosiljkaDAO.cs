﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using PS.dao;

namespace PS.dao.mysql
{
    class MySQLPosiljkaDAO : PosiljkaDAO
    {
        public bool delete(string id)
        {
            throw new NotImplementedException();
            //return true;
        }

        public bool insert(PosiljkaDTO posiljka)
        {
            throw new NotImplementedException();
           /* MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO posiljka VALUES(@posiljkaID, @poslovnicaSalje, @poslovnicaPrima, @jmb, " +
                    "@oznaka, @vrijeme, @vanVrece)";

                cmd.Parameters.AddWithValue("@posiljkaID", posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@poslovnicaSalje", posiljka.PoslovnicaSalje.PoslovnicaId);
                cmd.Parameters.AddWithValue("@poslovnicaPrima", posiljka.PoslovnicaPrima.PoslovnicaId);
                cmd.Parameters.AddWithValue("@jmb", posiljka.Zaposleni.Jmb);
                cmd.Parameters.AddWithValue("@oznaka", posiljka.Oznaka.Oznaka);
                cmd.Parameters.AddWithValue("@vrijeme", posiljka.Vrijeme);
                cmd.Parameters.AddWithValue("@vanVrece", posiljka.VanVerce);
                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                e.ErrorCode.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;*/
        }

        public List<PosiljkaDTO> posiljke()
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaDTO> lista = new List<PosiljkaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(vratiPosiljku(reader.GetInt32(0)));
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }

        public List<PosiljkaDTO> posiljke(DateTime datum)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaDTO> lista = new List<PosiljkaDTO>();

            MySqlCommand cmd = conn.CreateCommand();

            DateTime prijeSestMjeseci = datum.AddDays(-180);
            cmd.CommandText = "SELECT * FROM posiljka WHERE Vrijeme >= @datum";

            cmd.Parameters.AddWithValue("@datum", prijeSestMjeseci);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(vratiPosiljku(reader.GetInt32(0)));
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }

        public bool update(PosiljkaDTO posiljka)
        {
            throw new NotImplementedException();
        }

        public PosiljkaDTO vratiPosiljku(int posiljkaId)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PosiljkaDTO posiljka = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka WHERE posiljkaID = @posiljkaId";

            cmd.Parameters.AddWithValue("@posiljkaId", posiljkaId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PoslovnicaDAO pdao = new MySQLPoslovnicaDAO();
                PoslovnicaDTO pSalje = pdao.vratiPoslovnicu(reader.GetInt32(1));
                PoslovnicaDTO pPrima = pdao.vratiPoslovnicu(reader.GetInt32(2));

                ZaposleniDAO zdao = new MySQLZaposleniDAO();
                ZaposleniDTO zaposleni = zdao.vratiZaposlenog(reader.GetString(3));

                PosiljkaTipDAO ptdao = new MySQLPosiljkaTipDAO();
                PosiljkaTipDTO posiljkaTip = ptdao.vratiPosiljku(reader.GetString(4));

                posiljka = new PosiljkaDTO(reader.GetInt32(0), pSalje, pPrima, zaposleni, posiljkaTip,
                    reader.GetDateTime(5), reader.GetByte(6));
            }
            reader.Close();
            conn.Close();
            return posiljka;
            */
        }

    }
}
