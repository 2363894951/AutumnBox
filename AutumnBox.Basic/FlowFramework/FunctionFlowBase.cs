﻿/* =============================================================================*\
*
* Filename: FunctionFlow
* Description: 
*
* Version: 1.0
* Created: 2017/11/24 20:45:39 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/

namespace AutumnBox.Basic.FlowFramework
{
    public abstract class FunctionFlowBase
    {
        public static event FinishedEventHandler<FlowResult> AnyFinished;
        protected static void OnAnyFinished(object sender, FinishedEventArgs<FlowResult> e) {
            AnyFinished?.Invoke(sender, e);
        }
        protected internal static bool AnyFinishedRegistered => (AnyFinished != null);
    }
}
