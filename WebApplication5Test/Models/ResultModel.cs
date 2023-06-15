﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5Test.Models
{
    public class ResultModel
    {
        public HttpStatusCodeResult Status { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}