﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAPAutomation
{
    public class ScreenData
    {
        public ScreenData()
        {
            this.SAPGuiElements = new List<SAPGuiElement>();
        }

        public ScreenData(string SystemName,string Transaction,string Program,int ScreenNumber,string ActiveWindow):this()
        {
            this.SystemName = SystemName;
            this.Transaction = Transaction;
            this.ScreenNumber = ScreenNumber;
            this.Program = Program;
            this.ActiveWindow = ActiveWindow;
        }
        public string SystemName { get; set; }

        public string Transaction { get; set; }

        public int ScreenNumber { get; set; }

        public string Program { get; set; }

        public string ActiveWindow { get; set; }

        public List<SAPGuiElement> SAPGuiElements { get; private set; }
    }
}
