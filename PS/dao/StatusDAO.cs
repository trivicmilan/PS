﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface StatusDAO
    {
        StatusDTO vratiStatus(int v);
    }
}
