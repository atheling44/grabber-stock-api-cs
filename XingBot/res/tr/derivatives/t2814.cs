﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // CME야간선물기간별투자자매매추이(차트) ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2814InBlock
    {
        public string gubun1; // [string,    1] 수치구분(1:수치2:누적)          StartPos 0, Length 1
        public string gubun2; // [string,    1] 단위구분(1:일2:주3:월)          StartPos 2, Length 1
        public string from_date; // [string,    8] 시작날짜                        StartPos 4, Length 8
        public string to_date; // [string,    8] 종료날짜                        StartPos 13, Length 8
    }

    struct _t2814OutBlock
    {
        public string mcode; // [string,    8] 시장코드                        StartPos 0, Length 8
        public string mname; // [string,   20] 시장명                          StartPos 9, Length 20
    }

    struct _t2814OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long sv_08; // [long  ,   12] 개인수량                        StartPos 9, Length 12
        public long sv_17; // [long  ,   12] 외인계수량(등록+미등록)         StartPos 22, Length 12
        public long sv_18; // [long  ,   12] 기관계수량                      StartPos 35, Length 12
        public long sv_01; // [long  ,   12] 증권수량                        StartPos 48, Length 12
        public long sv_03; // [long  ,   12] 투신수량                        StartPos 61, Length 12
        public long sv_04; // [long  ,   12] 은행수량                        StartPos 74, Length 12
        public long sv_02; // [long  ,   12] 보험수량                        StartPos 87, Length 12
        public long sv_05; // [long  ,   12] 종금수량                        StartPos 100, Length 12
        public long sv_06; // [long  ,   12] 기금수량                        StartPos 113, Length 12
        public long sv_07; // [long  ,   12] 기타수량                        StartPos 126, Length 12
        public long sv_00; // [long  ,   12] 사모펀드수량                    StartPos 139, Length 12
        public long sv_09; // [long  ,   12] 등록외국인수량                  StartPos 152, Length 12
        public long sv_10; // [long  ,   12] 미등록외국인수량                StartPos 165, Length 12
        public long sv_11; // [long  ,   12] 국가수량                        StartPos 178, Length 12
        public long sv_99; // [long  ,   12] 기타계수량(기타+국가)           StartPos 191, Length 12
        public double sa_08; // [double,   12] 개인금액                        StartPos 204, Length 12
        public double sa_17; // [double,   12] 외인계금액(등록+미등록)         StartPos 217, Length 12
        public double sa_18; // [double,   12] 기관계금액                      StartPos 230, Length 12
        public double sa_01; // [double,   12] 증권금액                        StartPos 243, Length 12
        public double sa_03; // [double,   12] 투신금액                        StartPos 256, Length 12
        public double sa_04; // [double,   12] 은행금액                        StartPos 269, Length 12
        public double sa_02; // [double,   12] 보험금액                        StartPos 282, Length 12
        public double sa_05; // [double,   12] 종금금액                        StartPos 295, Length 12
        public double sa_06; // [double,   12] 기금금액                        StartPos 308, Length 12
        public double sa_07; // [double,   12] 기타금액                        StartPos 321, Length 12
        public double sa_00; // [double,   12] 사모펀드금액                    StartPos 334, Length 12
        public double sa_09; // [double,   12] 등록외국인금액                  StartPos 347, Length 12
        public double sa_10; // [double,   12] 미등록외국인금액                StartPos 360, Length 12
        public double sa_11; // [double,   12] 국가금액                        StartPos 373, Length 12
        public double sa_99; // [double,   12] 기타계금액(기타+국가)           StartPos 386, Length 12
        public float jisu; // [float ,  7.2] 시장지수                        StartPos 399, Length 7
    }
}