﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha_Service.Enum
{
    public enum Method
    {
        /// <summary>
        /// Говорит о том, что вы отправляете изображение с помощью multipart-фомы
        /// </summary>
        post,
        /// <summary>
        /// Определяет, что вы решаете ReCaptcha V2 с помощью нового метода
        /// </summary>
        userrecaptcha,
        /// <summary>
        /// funcaptcha — указывает, что вы решаете FunCaptcha с помощью токена
        /// </summary>
        funcaptcha,
    }
}
