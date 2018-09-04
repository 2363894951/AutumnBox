﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/28 23:37:15 (UTC +8:00)
** desc： ...
*************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.Basic.ManagedAdb
{
    public interface IAdbServer : IDisposable
    {
        bool AliveCheck();
        ushort Port { get; }
        void Start(ushort port = AdbProtocol.PORT);
        void Restart();
        void Kill();
    }
}