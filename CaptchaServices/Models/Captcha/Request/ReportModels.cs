﻿using Captcha_Service.Additions;
using Captcha_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha_Service.Models.Captcha.Request
{
    public class ReportModels
    {
        /// <summary>
        /// Указан по умолчанию
        /// get — получить ответ на капчу
        /// </summary>
        public string Action { get; set; } 
        /// <summary>
        /// ID капчи, полученный от in.php.
        /// </summary>
        public string Id { get; set; }

        public ReportModels(string id, string action ) 
        {
            this.Id = id;
            this.Action = action;
        }

        public override string ToString()
        {
            var data = new Dictionary<string, object>()
            {
                ["action"] = this.Action,
                ["id"] = this.Id,
            };
            return Converts.StringToDictionary(data); 
        }
    }
}
