﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CQRSHelper
{
    public interface IHandleCommand<Tcommand>
    {
        IEnumerable Handle(Tcommand c);
    }
}
