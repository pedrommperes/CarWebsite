﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWDataManager.Library
{
    class ConfigHelper
    {
        //TODO: Move this from congfig to the API
        public static decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool IsValidTaxRate = Decimal.TryParse(rateText, out decimal output);

            if (IsValidTaxRate == false)
            {
                //throw new ConfigurationErrorsException("The tax rate is not set up properly;");
            }

            return output;
        }
    }
}