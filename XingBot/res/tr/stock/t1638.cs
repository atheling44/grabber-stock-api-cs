﻿namespace XingBot.real.res.tr
{
    // 종목별잔량/사전공시 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1638InBlock
    {
        public string gubun1; // [string,    1] 구분                            StartPos 0, Length 1
        public string shcode; // [string,    6] 종목코드                        StartPos 2, Length 6
        public string gubun2; // [string,    1] 정렬                            StartPos 9, Length 1
    }

    public struct _t1638OutBlock
    {
        public long rank; // [long  ,    4] 순위                            StartPos 0, Length 4
        public string hname; // [string,   20] 한글명                          StartPos 5, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 26, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 35, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 37, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 46, Length 6
        public decimal sigatotrt; // [float ,  6.2] 시총비중                        StartPos 53, Length 6
        public long obuyvol; // [long  ,   12] 순매수잔량                      StartPos 60, Length 12
        public long buyrem; // [long  ,   12] 매수잔량                        StartPos 73, Length 12
        public long psgvolume; // [long  ,   12] 매수공시수량                    StartPos 86, Length 12
        public long sellrem; // [long  ,   12] 매도잔량                        StartPos 99, Length 12
        public long pdgvolume; // [long  ,   12] 매도공시수량                    StartPos 112, Length 12
        public long sigatot; // [long  ,   20] 시가총액                        StartPos 125, Length 20
        public string shcode; // [string,    6] 종목코드                        StartPos 146, Length 6
    }
}