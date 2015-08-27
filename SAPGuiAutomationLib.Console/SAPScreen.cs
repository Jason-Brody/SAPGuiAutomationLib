﻿using SAPAutomation;
using SAPAutomation.Framework;
using SAPAutomation.Framework.Attributes;
using SAPFEWSELib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Young.Data;
using Young.Data.Attributes;

namespace SAPGuiAutomationLib
{
   
    public class GetCurrency : DataDriven
    {
        public GetCurrency()
        {
            //SAPTestHelper.Current.SAPGuiSession.StartTransaction("SE16");
        }

        
        public SC_230 SC230 { get; set; }

        
        //[Order(1)]
        //public SC_1000 SC1000 { get; set; }
        
        [Order(2)]
        public void GetCurrencyRate()
        {
            Console.WriteLine("Win");
            //SC1000.Execute();
        }
    }

    public class SC_100 : SAPGuiScreen
    {

    }

   
    public class SC_230 : SAPGuiScreen
    {
       
        public string TableName
        { 
            //get;set;
            get
            {
                return SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("DATABROWSE-TABLENAME").Text;
            }
            set
            {
                SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("DATABROWSE-TABLENAME").Text = value;
            }
        }

        
        public SC_1000 Process()
        {
            //Console.WriteLine("Process");
            SAPTestHelper.Current.MainWindow.SendKey(SAPKeys.Enter);
            return new SC_1000();
            
        }
    }

   
    public class SC_1000 : SAPGuiScreen
    {
        
        public string RateType
        {
            //get;
            //set;
            get
            {
                return SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I1-LOW").Text;
            }
            set
            {
                SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I1-LOW").Text = value;
            }
        }

        [ColumnBinding("CurFrom")]
        public string FromCurrency
        {
            //get;
            //set;
            get
            {
                return SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I2-LOW").Text;
            }
            set
            {
                SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I2-LOW").Text = value;
            }
        }

        [ColumnBinding("CurTo")]
        public string ToCurrency
        { 
            //get;set;
            get
            {
                return SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I3-LOW").Text;
            }
            set
            {
                SAPTestHelper.Current.MainWindow.FindByName<GuiCTextField>("I3-LOW").Text = value;
            }
        }

        [Order(1)]
        public void Execute()
        {
            //Console.WriteLine("Execute");
            SAPTestHelper.Current.MainWindow.FindByName<GuiButton>("btn[8]").Press();
        }
    }
}
