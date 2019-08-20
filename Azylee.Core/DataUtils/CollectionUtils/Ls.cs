﻿//************************************************************************
//      author:     yuzhengyang
//      date:       2018.3.27 - 2018.6.3
//      desc:       工具描述
//      Copyright (c) yuzhengyang. All rights reserved.
//************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azylee.Core.DataUtils.CollectionUtils
{
    /// <summary>
    /// ListTool
    /// </summary>
    public static class Ls
    {
        /// <summary>
        /// 列表至少有一个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool Ok<T>(IEnumerable<T> list)
        {
            return ListTool.HasElements(list);
        }

        /// <summary>
        /// 列表至少有一个元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool ok<T>(IEnumerable<T> list)
        {
            return ListTool.HasElements(list);
        }
    }
}
