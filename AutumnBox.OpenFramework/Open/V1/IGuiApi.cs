﻿using AutumnBox.Basic.FlowFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutumnBox.OpenFramework.Open.V1
{
    /// <summary>
    /// GUI接口
    /// </summary>
    public interface IGuiApi
    {
        /// <summary>
        /// 显示一个选择窗口.并等待用户返回结果
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="msg">内容</param>
        /// <param name="btnLeft">左按钮文本,默认取消</param>
        /// <param name="btnRight">右按钮文本,默认确定</param>
        /// <returns></returns>
        bool? ShowChoiceBox(string title, string msg, string btnLeft = null, string btnRight = null);
        /// <summary>
        /// 显示消息窗口
        /// </summary>
        /// <param name="title">标题,建议使用模块名称</param>
        /// <param name="msg">信息</param>
        void ShowMessageBox(string title,string msg);
        /// <summary>
        /// 显示加载窗口
        /// </summary>
        /// <param name="completable">可被主动停止或可得知停止的类</param>
        void ShowLoadingWindow(ICompletable completable);
        /// <summary>
        /// 显示任意的窗口
        /// </summary>
        /// <param name="window"></param>
        void ShowWindow(Window window);
        /// <summary>
        /// 显示异常窗口
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="e">异常</param>
        void ShowExceptionBox(string title, Exception e);
        /// <summary>
        /// 获取界面语言代码 类似zh-CN
        /// </summary>
        /// <returns>语言代码</returns>
        string GetCurrentLanguageName();
    }
}
