﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_YJC(string futcode)
        {
            string szTrCode = "YJC";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_YJC(string szTrCode)
        {
            _YJC_OutBlock outData;
            outData.ychetime = _realDict[szTrCode].GetFieldData("OutBlock", "ychetime");
            outData.yeprice = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}