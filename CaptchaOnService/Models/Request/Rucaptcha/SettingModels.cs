﻿using Captcha_Service.Enum.Rucaptcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha_Service.Models.Request.Rucaptcha
{
    public class SettingModels
    {
        /// <summary>
        /// 0 — не определено
        /// 1 — капча содержит только кириллицу
        /// 2 — капча содержит только латиницу
        /// </summary>
        public int? Language { get; set; }
        /// <summary>
        /// Код языка. 
        /// </summary>
        public string Lang { get; set; }
        /// <summary>
        /// 0 — выключен
        /// 1 — включен
        /// Если включен, то in.php добавит заголовок Access-Control-Allow-Origin:* в ответ.
        /// Используется для кроссдоменных AJAX-запросов из веб-приложений.
        /// </summary>
        public int? HeaderAcao { get; set; }
        /// <summary>
        /// URL для автоматической отправки ответа на капчу (callback).
        /// URL должен быть зарегистрирован на сервере.Больше информации здесь.
        /// </summary>
        public string Pingback { get; set; }

        /// <summary>
        /// Формат: логин:пароль@123.123.123.123:3128
        /// </summary>
        public string Proxy { get; set; } 
        /// <summary>
        /// Тип вашего прокси-сервера: HTTP, HTTPS, SOCKS4, SOCKS5.
        /// </summary>
        public PROXY_TYPE? Proxytype { get; set; } 
    }
}
