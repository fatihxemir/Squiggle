﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Squiggle.Core.Chat.Transport.Host
{
    public class ChatHostProxyFactory
    {
        static Dictionary<IPEndPoint, ChatHostProxy> proxies = new Dictionary<IPEndPoint, ChatHostProxy>();

        public static ChatHostProxy Get(IPEndPoint endpoint)
        {
            lock (proxies)
            {
                ChatHostProxy proxy;
                if (!proxies.TryGetValue(endpoint, out proxy))
                    proxies[endpoint] = proxy = new ChatHostProxy(endpoint);
                return proxy;
            }
        }
    }
}