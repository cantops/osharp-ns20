﻿// -----------------------------------------------------------------------
//  <copyright file="OSharpCorePack.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-23 15:19</last-date>
// -----------------------------------------------------------------------

using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using OSharp.Core.Options;
using OSharp.Dependency;
using OSharp.Reflection;


namespace OSharp.Core.Packs
{
    /// <summary>
    /// OSharp核心模块
    /// </summary>
    public class OSharpCorePack : OsharpPack
    {
        /// <summary>
        /// 获取 模块级别
        /// </summary>
        public override PackLevel Level => PackLevel.Core;

        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddSingleton<IAllAssemblyFinder, AppDomainAllAssemblyFinder>();
            services.AddSingleton<IConfigureOptions<OSharpOptions>, OSharpOptionsSetup>();

            return services;
        }
    }
}