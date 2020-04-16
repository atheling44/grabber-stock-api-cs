﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using CsvHelper;
using DataLib.util;
using log4net;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.query
{
    public abstract class QueryBase : _IXAQueryEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("QueryBase");
        protected readonly IXAQuery _query;
        protected readonly ResModel _resModel;
        protected Action<string> _beforeAction = (szTrCode) => { Console.WriteLine(szTrCode + "empty beforeAction"); };
        public Action<string> BeforeAction { set => _beforeAction = value; }
        protected Action<string> _afterAction = (szTrCode) => { Console.WriteLine(szTrCode + "empty afterAction"); };
        public Action<string> AfterAction { set => _beforeAction = value; }
        protected FileInfo fi;


        public QueryBase(string szTrCode)
        {
            _resModel = ReadResFile.Read(Settings.Default.root_path + @"\Res\" + szTrCode + ".res");

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            _query = new XAQuery
            {
                ResFileName = Settings.Default.root_path + @"\Res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer)_query;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            Console.WriteLine("QueryEvents 생성자완료");
        }

        protected abstract void InBlock(string shcode, bool isNext = false);

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            _beforeAction(szTrCode);
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            //using (var writer = new StreamWriter(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv"))
            //using (var writer = new StreamWriter(fi.Open(FileMode.Append)))
            //using (var writer = new StreamWriter(fi.AppendWrite()))
            using (var writer = fi.AppendText())
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                OutBlock(_resModel, _query, csv);
            }
            _afterAction(szTrCode);
        }

        protected abstract void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer);

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            LOG.Info("_IXAQueryEvents.ReceiveMessage");
            LOG.Info(bIsSystemError);
            LOG.Info(nMessageCode);
            LOG.Info(szMessage);
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }
    }
}