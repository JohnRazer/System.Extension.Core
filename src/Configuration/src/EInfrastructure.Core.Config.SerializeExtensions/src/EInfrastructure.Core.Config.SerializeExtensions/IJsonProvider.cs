﻿// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using EInfrastructure.Core.Configuration.Ioc;

namespace EInfrastructure.Core.Config.SerializeExtensions
{
    /// <summary>
    /// Json 序列化基础类库
    /// </summary>
    public interface IJsonProvider : IIdentify, IDependency
    {
        /// <summary>
        /// jason序列化
        /// </summary>
        /// <param name="o"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        string Serializer(object o, bool format = false);

        /// <summary>
        /// jason反序列化
        /// </summary>
        /// <param name="s"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        object Deserialize(string s, Type type);
    }
}