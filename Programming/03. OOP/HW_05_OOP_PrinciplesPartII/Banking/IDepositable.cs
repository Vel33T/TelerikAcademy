﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public interface IDepositable
    {
        void Deposit(double amount);
    }
}
