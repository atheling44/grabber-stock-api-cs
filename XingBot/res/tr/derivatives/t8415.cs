﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물/옵션챠트(N분) ( ATTR,BLOCK,HEADTYPE=A )
    struct _t8415InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public long ncnt; // [long  ,    4] 단위(n분)                       StartPos 9, Length 4
        public long qrycnt; // [long  ,    4] 요청건수(최대-압축:2000비압축:5 StartPos 14, Length 4
        public string nday; // [string,    1] 조회영업일수(0:미사용1>=사용)   StartPos 19, Length 1
        public string sdate; // [string,    8] 시작일자                        StartPos 21, Length 8
        public string stime; // [string,    6] 시작시간(현재미사용)            StartPos 30, Length 6
        public string edate; // [string,    8] 종료일자                        StartPos 37, Length 8
        public string etime; // [string,    6] 종료시간(현재미사용)            StartPos 46, Length 6
        public string cts_date; // [string,    8] 연속일자                        StartPos 53, Length 8
        public string cts_time; // [string,   10] 연속시간                        StartPos 62, Length 10
        public string comp_yn; // [string,    1] 압축여부(Y:압축N:비압축)        StartPos 73, Length 1
    }

    struct _t8415OutBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public float jisiga; // [float ,  6.2] 전일시가                        StartPos 9, Length 6
        public float jihigh; // [float ,  6.2] 전일고가                        StartPos 16, Length 6
        public float jilow; // [float ,  6.2] 전일저가                        StartPos 23, Length 6
        public float jiclose; // [float ,  6.2] 전일종가                        StartPos 30, Length 6
        public long jivolume; // [long  ,   12] 전일거래량                      StartPos 37, Length 12
        public float disiga; // [float ,  6.2] 당일시가                        StartPos 50, Length 6
        public float dihigh; // [float ,  6.2] 당일고가                        StartPos 57, Length 6
        public float dilow; // [float ,  6.2] 당일저가                        StartPos 64, Length 6
        public float diclose; // [float ,  6.2] 당일종가                        StartPos 71, Length 6
        public float highend; // [float ,  6.2] 상한가                          StartPos 78, Length 6
        public float lowend; // [float ,  6.2] 하한가                          StartPos 85, Length 6
        public string cts_date; // [string,    8] 연속일자                        StartPos 92, Length 8
        public string cts_time; // [string,   10] 연속시간                        StartPos 101, Length 10
        public string s_time; // [string,    6] 장시작시간(HHMMSS)              StartPos 112, Length 6
        public string e_time; // [string,    6] 장종료시간(HHMMSS)              StartPos 119, Length 6
        public string dshmin; // [string,    2] 동시호가처리시간(MM:분)         StartPos 126, Length 2
        public long rec_count; // [long  ,    7] 레코드카운트                    StartPos 129, Length 7
    }

    struct _t8415OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public string time; // [string,   10] 시간                            StartPos 9, Length 10
        public float open; // [float ,  6.2] 시가                            StartPos 20, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 27, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 34, Length 6
        public float close; // [float ,  6.2] 종가                            StartPos 41, Length 6
        public long jdiff_vol; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 61, Length 12
        public long openyak; // [long  ,   12] 미결제약정                      StartPos 74, Length 12
    }
}