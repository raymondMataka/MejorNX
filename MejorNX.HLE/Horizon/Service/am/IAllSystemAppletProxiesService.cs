﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MejorNX.HLE.Horizon.Service.am
{
    public class IAllSystemAppletProxiesService : ICommand
    {
        public IAllSystemAppletProxiesService()
        {
            Calls = new Dictionary<ulong, ServiceCall>()
            {

            };
        }
    }
}
