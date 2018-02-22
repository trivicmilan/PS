﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dao.mysql
{
    class MySQLDAOFactory : DAOFactory
    {
        public override KartaZakljuckaDAO getKartaZakljuckaDAO()
        {
            return new MySQLKartaZakljuckaDAO();
        }

        public override OdjavaONeispravnostiDAO getOdjavaONeispravnostiDAO()
        {
            return new MySQLOdjavaONeispravnostiDAO();
        }

        public override VrecaDAO getVrecaDAO()
        {
            return new MySQLVrecaDAO();
        }

        public override KorisnickiNalogDAO getKorisnickiNalogDAO()
        {
            return new MySQLKorisnickiNalogDAO();
        }

        public override PosiljkaDAO getPosiljkaDAO()
        {
            return new MySQLPosiljkaDAO();
        }

        public override PosiljkaTipDAO getPosiljkaTipDAO()
        {
            return new MySQLPosiljkaTipDAO();
        }

        public override PoslovnicaDAO getPoslovnicaDAO()
        {
            return new MySQLPoslovnicaDAO();
        }

        public override PosiljkaStatusDAO getPosiljkaStatusDAO()
        {
            return new MySQLPosiljkaStatusDAO();
        }

        public override MjestoDAO getMjestoDAO()
        {
            return new MySQLMjestoDAO();
        }

        public override ZaposleniDAO getZapsleniDAO()
        {
            return new MySQLZaposleniDAO();
        }
    }
}