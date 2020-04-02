﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 현물 정상주문 ( SERVICE=CSPAT00600,ENCRYPT,SIGNATURE,HEADTYPE=B,CREATOR=김기종,CREDATE=2011/12/07 09:23:39 )
    struct _CSPAT00600InBlock1
    {
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 20, Length 8
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 28, Length 12
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 40, Length 16
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 56, Length 13
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 69, Length 1
        public string OrdprcPtnCode; // [OrdprcPtnCode,    2] 호가유형코드                    StartPos 70, Length 2
        public string MgntrnCode; // [MgntrnCode,    3] 신용거래코드                    StartPos 72, Length 3
        public string LoanDt; // [LoanDt,    8] 대출일                          StartPos 75, Length 8
        public string OrdCndiTpCode; // [OrdCndiTpCode,    1] 주문조건구분                    StartPos 83, Length 1
    }

    struct _CSPAT00600OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 33, Length 12
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 45, Length 16
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 61, Length 13
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 74, Length 1
        public string OrdprcPtnCode; // [OrdprcPtnCode,    2] 호가유형코드                    StartPos 75, Length 2
        public string PrgmOrdprcPtnCode; // [PrgmOrdprcPtnCode,    2] 프로그램호가유형코드            StartPos 77, Length 2
        public string StslAbleYn; // [StslAbleYn,    1] 공매도가능여부                  StartPos 79, Length 1
        public string StslOrdprcTpCode; // [StslOrdprcTpCode,    1] 공매도호가구분                  StartPos 80, Length 1
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 81, Length 2
        public string MgntrnCode; // [MgntrnCode,    3] 신용거래코드                    StartPos 83, Length 3
        public string LoanDt; // [LoanDt,    8] 대출일                          StartPos 86, Length 8
        public string MbrNo; // [MbrNo,    3] 회원번호                        StartPos 94, Length 3
        public string OrdCndiTpCode; // [OrdCndiTpCode,    1] 주문조건구분                    StartPos 97, Length 1
        public string StrtgCode; // [StrtgCode,    6] 전략코드                        StartPos 98, Length 6
        public string GrpId; // [GrpId,   20] 그룹ID                          StartPos 104, Length 20
        public long OrdSeqNo; // [OrdSeqNo  ,   10] 주문회차                        StartPos 124, Length 10
        public long PtflNo; // [PtflNo  ,   10] 포트폴리오번호                  StartPos 134, Length 10
        public long BskNo; // [BskNo  ,   10] 바스켓번호                      StartPos 144, Length 10
        public long TrchNo; // [TrchNo  ,   10] 트렌치번호                      StartPos 154, Length 10
        public long ItemNo; // [ItemNo  ,   10] 아이템번호                      StartPos 164, Length 10
        public string OpDrtnNo; // [OpDrtnNo,   12] 운용지시번호                    StartPos 174, Length 12
        public string LpYn; // [LpYn,    1] 유동성공급자여부                StartPos 186, Length 1
        public string CvrgTpCode; // [CvrgTpCode,    1] 반대매매구분                    StartPos 187, Length 1
    }

    struct _CSPAT00600OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 15, Length 9
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 24, Length 2
        public string OrdPtnCode; // [OrdPtnCode,    2] 주문유형코드                    StartPos 26, Length 2
        public string ShtnIsuNo; // [ShtnIsuNo,    9] 단축종목번호                    StartPos 28, Length 9
        public string MgempNo; // [MgempNo,    9] 관리사원번호                    StartPos 37, Length 9
        public long OrdAmt; // [OrdAmt  ,   16] 주문금액                        StartPos 46, Length 16
        public long SpareOrdNo; // [SpareOrdNo  ,   10] 예비주문번호                    StartPos 62, Length 10
        public long CvrgSeqno; // [CvrgSeqno  ,   10] 반대매매일련번호                StartPos 72, Length 10
        public long RsvOrdNo; // [RsvOrdNo  ,   10] 예약주문번호                    StartPos 82, Length 10
        public long SpotOrdQty; // [SpotOrdQty  ,   16] 실물주문수량                    StartPos 92, Length 16
        public long RuseOrdQty; // [RuseOrdQty  ,   16] 재사용주문수량                  StartPos 108, Length 16
        public long MnyOrdAmt; // [MnyOrdAmt  ,   16] 현금주문금액                    StartPos 124, Length 16
        public long SubstOrdAmt; // [SubstOrdAmt  ,   16] 대용주문금액                    StartPos 140, Length 16
        public long RuseOrdAmt; // [RuseOrdAmt  ,   16] 재사용주문금액                  StartPos 156, Length 16
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 172, Length 40
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 212, Length 40
    }
}