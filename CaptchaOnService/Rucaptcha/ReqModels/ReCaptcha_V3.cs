﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha_Service.Rucaptcha.ReqModels
{
    public class ReCaptcha_V3 : Setting
    {
        public string Page_url { get; set; }
        public string Google_key { get; set; }
        public string Action { get; set; } = "verify";
    }
}
