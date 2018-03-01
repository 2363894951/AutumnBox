﻿/* =============================================================================*\
*
* Filename: IForceStoppable
* Description: 
*
* Version: 1.0
* Created: 2017/11/24 17:22:52 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/

namespace AutumnBox.Basic.FlowFramework
{
    /// <summary>
    /// 可被强制停止的
    /// </summary>
    public interface IForceStoppable
    {
        /// <summary>
        /// 强制停止
        /// </summary>
        void ForceStop();
    }
}
