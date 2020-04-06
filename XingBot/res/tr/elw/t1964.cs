﻿namespace XingBot.real.res
{
    // ELW 전광판 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1964InBlock
    {
        public string item; // [string,   12] 기초자산코드                    StartPos 0, Length 12
        public string issuercd; // [string,   12] 발행사                          StartPos 13, Length 12
        public string lastmonth; // [string,    6] 만기월물                        StartPos 26, Length 6
        public string elwopt; // [string,    1] 콜풋구분                        StartPos 33, Length 1
        public string atmgubun; // [string,    1] 머니구분                        StartPos 35, Length 1
        public string elwtype; // [string,    2] 권리행사방식                    StartPos 37, Length 2
        public string settletype; // [string,    2] 결제방법                        StartPos 40, Length 2
        public string elwexecgubun; // [string,    1] 행사기초자산구분                StartPos 43, Length 1
        public string fromrat; // [string,    5] 시작비율                        StartPos 45, Length 5
        public string torat; // [string,    5] 종료비율                        StartPos 51, Length 5
        public string volume; // [string,   12] 거래량                          StartPos 57, Length 12
    }

    public struct _t1964OutBlock1
    {
        public string shcode; // [string,    6] ELW코드                         StartPos 0, Length 6
        public string hname; // [string,   40] 종목명                          StartPos 7, Length 40
        public string item1; // [string,    6] 기초자산코드                    StartPos 48, Length 6
        public string itemnm; // [string,   20] 기초자산명                      StartPos 55, Length 20
        public string issuernmk; // [string,   40] 발행사                          StartPos 76, Length 40
        public string elwopt; // [string,    4] 콜풋구분                        StartPos 117, Length 4
        public long price; // [long  ,    8] 현재가                          StartPos 122, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 131, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 133, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 142, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 149, Length 12
        public decimal elwexec; // [float , 10.2] 행사가                          StartPos 162, Length 10
        public long jandatecnt; // [long  ,    8] 잔존일수                        StartPos 173, Length 8
        public decimal convrate; // [float ,  8.4] 전환비율                        StartPos 182, Length 8
        public string lastdate; // [string,    8] 최종거래일                      StartPos 191, Length 8
        public string mmsdate; // [string,    8] 행사개시일                      StartPos 200, Length 8
        public string payday; // [string,    8] 지급일                          StartPos 209, Length 8
        public long listing; // [long  ,    8] 발행수량                        StartPos 218, Length 8
        public string atmgbnm; // [string,   10] 머니구분                        StartPos 227, Length 10
        public decimal parity; // [float ,  6.2] 패리티                          StartPos 238, Length 6
        public decimal preminum; // [float , 10.2] 프리미엄                        StartPos 245, Length 10
        public decimal spread; // [float ,  3.2] 스프래드                        StartPos 256, Length 3
        public decimal berate; // [float ,  6.2] 손익분기율                      StartPos 260, Length 6
        public decimal capt; // [float ,  6.2] 자본지지율                      StartPos 267, Length 6
        public decimal gearing; // [float ,  6.2] 기어링                          StartPos 274, Length 6
        public decimal egearing; // [float ,  6.2] e기어링                         StartPos 281, Length 6
        public long itemprice; // [long  ,    8] 기초자산현재가                  StartPos 288, Length 8
        public string itemsign; // [string,    1] 기초자산전일대비구분            StartPos 297, Length 1
        public long itemchange; // [long  ,    8] 기초자산전일대비                StartPos 299, Length 8
        public decimal itemdiff; // [float ,  6.2] 기초자산등락율                  StartPos 308, Length 6
        public long itemvolume; // [long  ,   12] 기초자산거래량                  StartPos 315, Length 12
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 328, Length 12
        public decimal theoryprice; // [float , 10.2] 이론가                          StartPos 341, Length 10
        public decimal lp_rate; // [float ,  5.2] LP보유비율                      StartPos 352, Length 5
        public decimal impv; // [float ,  6.2] 내재변동성                      StartPos 358, Length 6
        public decimal delta; // [float , 10.6] 델타                            StartPos 365, Length 10
        public decimal theta; // [float , 10.6] 쎄타                            StartPos 376, Length 10
    }
}