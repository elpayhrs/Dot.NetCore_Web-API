﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Registration.Models;

namespace Registration.DataAccess
{
    public class Files
    {
        public RequstinfoRes[] GetReg()
        {
            //return new ReadFile<Bank>().Get(@"\banks.json");
            return new ReadFiles<RequstinfoRes>().Get(@"/Response.json");
        }
    }
}
