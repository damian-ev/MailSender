﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Models
{
    class Server : I
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private int _Port = 25;
        public int Port
        {
            get => _Port;
            set
            {
                if (value < 0 || value > 65535)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Номер порта должен быть в диапазоне от 0 до 65535");
                _Port = value;
            }
        }
        public bool UseSSL { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
