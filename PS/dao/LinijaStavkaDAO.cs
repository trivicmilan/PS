﻿using PS.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dao
{
    interface LinijaStavkaDAO
    {
        int insert(LinijaStavkaDTO linija);
        List<LinijaStavkaDTO> stavke(int idLinija);
        void delete(LinijaStavkaDTO stavka);
    }
}
