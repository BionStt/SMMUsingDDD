﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Ddd
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
