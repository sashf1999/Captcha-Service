﻿using Captcha_Service.Addition;
using Captcha_Service.Enum.Rucaptcha;
using Captcha_Service.Exception.Rucaptcha;
using Captcha_Service.Models.Response.Rucaptcha;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Captcha_Service.Request
{
    partial class RucaptchaRequest
    {
        /// <summary>
        /// Переводим данные с байтов в текст
        /// </summary>
        /// <param name="request">Байт которые будем переводить в текст</param>
        /// <returns></returns>
        public  string ByteToString(WebRequest request)
        {
            using ( HttpWebResponse response = (HttpWebResponse)request.GetResponse() )
            using ( StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default, true, 8192) )
                return reader.ReadToEnd();
        }

        public ResponseInfoModels GetRequest(string url, Dictionary<string, object> data)
        {
            var request = WebRequest.Create(url + DictionaryConvert.Deserialization(data));
            var response = ByteToString(request);
            return CheckErrorInfo( response);
        }

        public bool DownloadFile(string Image, String Path)
        {
            bool CheckDownload = false;
            using ( WebClient Client = new WebClient() )
            {
                Client.DownloadFile(Image, Path);
                CheckDownload = true;
            }
            return CheckDownload;
        }

        private ResponseInfoModels CheckErrorInfo(string response)
        {
            var json = JsonConvert.Deserializ<ResponseInfoModels>(response);
            if ( json.status == 0 )
                throw new ErrorParamsRucaptchaException(json.request, ERROR.SUCCESS);
            else
                return json;
        }
    }
}
