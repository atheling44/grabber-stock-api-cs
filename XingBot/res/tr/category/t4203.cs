﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.category
{
    // 업종차트(종합) ( ATTR,BLOCK,HEADTYPE=A )
    struct _t4203InBlock
    {
        public string shcode; // [string,    3] 단축코드                        StartPos 0, Length 3
        public string gubun; // [string,    1] 주기구분(0:틱1:분2:일3:주4:월)  StartPos 4, Length 1
        public long ncnt; // [long  ,    4] 틱개수                          StartPos 6, Length 4
        public long qrycnt; // [long  ,    4] 건수                            StartPos 11, Length 4
        public string tdgb; // [string,    1] 당일구분(0:전체1:당일만)        StartPos 16, Length 1
        public string sdate; // [string,    8] 시작일자                        StartPos 18, Length 8
        public string edate; // [string,    8] 종료일자                        StartPos 27, Length 8
        public string cts_date; // [string,    8] 연속일자                        StartPos 36, Length 8
        public string cts_time; // [string,   10] 연속시간                        StartPos 45, Length 10
        public string cts_daygb; // [string,    1] 연속당일구분(0:연속전체1:연속당 StartPos 56, Length 1
    }

    struct _t4203OutBlock
    {
        public string shcode; // [string,    3] 단축코드                        StartPos 0, Length 3
        public float jisiga; // [float ,  7.2] 전일시가                        StartPos 4, Length 7
        public float jihigh; // [float ,  7.2] 전일고가                        StartPos 12, Length 7
        public float jilow; // [float ,  7.2] 전일저가                        StartPos 20, Length 7
        public float jiclose; // [float ,  7.2] 전일종가                        StartPos 28, Length 7
        public long jivolume; // [long  ,   12] 전일거래량                      StartPos 36, Length 12
        public float disiga; // [float ,  7.2] 당일시가                        StartPos 49, Length 7
        public float dihigh; // [float ,  7.2] 당일고가                        StartPos 57, Length 7
        public float dilow; // [float ,  7.2] 당일저가                        StartPos 65, Length 7
        public float diclose; // [float ,  7.2] 당일종가                        StartPos 73, Length 7
        public long disvalue; // [long  ,   12] 당일거래대금                    StartPos 81, Length 12
        public string cts_date; // [string,    8] 연속일자                        StartPos 94, Length 8
        public string cts_time; // [string,   10] 연속시간                        StartPos 103, Length 10
        public string cts_daygb; // [string,    1] 연속당일구분                    StartPos 114, Length 1
    }

    struct _t4203OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public string time; // [string,    6] 시간                            StartPos 9, Length 6
        public float open; // [float ,  7.2] 시가                            StartPos 16, Length 7
        public float high; // [float ,  7.2] 고가                            StartPos 24, Length 7
        public float low; // [float ,  7.2] 저가                            StartPos 32, Length 7
        public float close; // [float ,  7.2] 종가                            StartPos 40, Length 7
        public long jdiff_vol; // [long  ,   12] 거래량                          StartPos 48, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 61, Length 12
    }
}