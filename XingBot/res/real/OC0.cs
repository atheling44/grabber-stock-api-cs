﻿namespace XingBot.real.res
{
    // KOSPI200옵션체결 ( ATTR, KEY=8, GROUP=1 )
    public struct _OC0_InBlock
    {
        public string optcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _OC0_OutBlock
    {
        public string chetime; // [string,    6] 체결시간                        StartPos 0, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public decimal change; // [float ,  6.2] 전일대비                        StartPos 9, Length 6
        public decimal drate; // [float ,  6.2] 등락율                          StartPos 16, Length 6
        public decimal price; // [float ,  6.2] 현재가                          StartPos 23, Length 6
        public decimal open; // [float ,  6.2] 시가                            StartPos 30, Length 6
        public decimal high; // [float ,  6.2] 고가                            StartPos 37, Length 6
        public decimal low; // [float ,  6.2] 저가                            StartPos 44, Length 6
        public string cgubun; // [string,    1] 체결구분                        StartPos 51, Length 1
        public long cvolume; // [long  ,    6] 체결량                          StartPos 53, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 60, Length 12
        public long value; // [long  ,   12] 누적거래대금                    StartPos 73, Length 12
        public long mdvolume; // [long  ,   12] 매도누적체결량                  StartPos 86, Length 12
        public long mdchecnt; // [long  ,    8] 매도누적체결건수                StartPos 99, Length 8
        public long msvolume; // [long  ,   12] 매수누적체결량                  StartPos 108, Length 12
        public long mschecnt; // [long  ,    8] 매수누적체결건수                StartPos 121, Length 8
        public decimal cpower; // [float ,  9.2] 체결강도                        StartPos 130, Length 9
        public decimal offerho1; // [float ,  6.2] 매도호가1                       StartPos 140, Length 6
        public decimal bidho1; // [float ,  6.2] 매수호가1                       StartPos 147, Length 6
        public long openyak; // [long  ,    8] 미결제약정수량                  StartPos 154, Length 8
        public decimal k200jisu; // [float ,  6.2] KOSPI200지수                    StartPos 163, Length 6
        public decimal eqva; // [float ,  7.2] KOSPI등가                       StartPos 170, Length 7
        public decimal theoryprice; // [float ,  6.2] 이론가                          StartPos 178, Length 6
        public decimal impv; // [float ,  6.2] 내재변동성                      StartPos 185, Length 6
        public long openyakcha; // [long  ,    8] 미결제약정증감                  StartPos 192, Length 8
        public decimal timevalue; // [float ,  6.2] 시간가치                        StartPos 201, Length 6
        public string jgubun; // [string,    2] 장운영정보                      StartPos 208, Length 2
        public long jnilvolume; // [long  ,   12] 전일동시간대거래량              StartPos 211, Length 12
        public string optcode; // [string,    8] 단축코드                        StartPos 224, Length 8
    }
}