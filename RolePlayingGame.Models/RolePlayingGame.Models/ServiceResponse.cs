﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingGame.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = null;
    }
}
