﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MorseCode:IEntity
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
