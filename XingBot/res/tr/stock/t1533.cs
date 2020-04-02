﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 특이테마 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1533InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public long chgdate; // [long  ,    2] 대비일자                        StartPos 2, Length 2
    }

    struct _t1533OutBlock
    {
        public string tmname; // [string,   36] 테마명                          StartPos 0, Length 36
        public long totcnt; // [long  ,    4] 전체                            StartPos 37, Length 4
        public long upcnt; // [long  ,    4] 상승                            StartPos 42, Length 4
        public long dncnt; // [long  ,    4] 하락                            StartPos 47, Length 4
        public float uprate; // [float ,  6.2] 상승비율                        StartPos 52, Length 6
        public float diff_vol; // [float , 10.2] 거래증가율                      StartPos 59, Length 10
        public float avgdiff; // [float ,  6.2] 평균등락율                      StartPos 70, Length 6
        public float chgdiff; // [float ,  6.2] 대비등락율                      StartPos 77, Length 6
        public string tmcode; // [string,    4] 테마코드                        StartPos 84, Length 4
    }
}