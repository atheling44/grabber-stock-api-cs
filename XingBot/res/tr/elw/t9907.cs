﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    // 만기월조회 ( BLOCK,HEADTYPE=A )
    struct _t9907InBlock
    {
        public string dummy; // [string,    1] DUMMY                           StartPos 0, Length 1
    }

    struct _t9907OutBlock1
    {
        public string lastym; // [string,    6] 만기월                          StartPos 0, Length 6
        public string lastnm; // [string,   10] 만기월명                        StartPos 6, Length 10
    }
}