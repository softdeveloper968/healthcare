﻿using GaHealthcareNurses.Providers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GaHealthcareNurses.BusinessCode
{
    public class BuisnessCode : IBusinessCode
    {
        IApiProvider _apiProvider;
        public BuisnessCode(IApiProvider apiProvider)
        {
            //To initialize service providers...
            _apiProvider = apiProvider;
            HttpClientHandler handler = new HttpClientHandler();
        }

        #region  Apis Definations
        //Login Api

        #endregion
    }
}
