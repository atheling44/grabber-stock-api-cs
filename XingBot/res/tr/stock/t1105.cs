﻿namespace XingBot.res
{
    // 주식 피봇/디마크 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1105InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _t1105OutBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public long pbot; // [long  ,    8] 피봇                            StartPos 7, Length 8
        public long offer1; // [long  ,    8] 1차저항                         StartPos 16, Length 8
        public long supp1; // [long  ,    8] 1차지지                         StartPos 25, Length 8
        public long offer2; // [long  ,    8] 2차저항                         StartPos 34, Length 8
        public long supp2; // [long  ,    8] 2차지지                         StartPos 43, Length 8
        public long stdprc; // [long  ,    8] 기준가격                        StartPos 52, Length 8
        public long offerd; // [long  ,    8] D저항                           StartPos 61, Length 8
        public long suppd; // [long  ,    8] D지지                           StartPos 70, Length 8
    }
}