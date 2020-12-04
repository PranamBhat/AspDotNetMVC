﻿#region licence
// The MIT License (MIT)
// 
// Filename: AutofacDi.cs
// Date Created: 2020/05/20
// 
// Copyright (c) 2020 Pranam Bhat (www.selectiveanalytics.com & www.thereformedprogrammer.net)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
using System.Runtime.CompilerServices;
using Autofac;
using ServiceLayer.Startup;

[assembly: InternalsVisibleTo("Tests")]

namespace SampleWebApp.Infrastructure
{
    internal static class AutofacDi
    {

        private static IContainer _container;

        internal static IContainer SetupDependency()
        {

            var builder = new ContainerBuilder();
            Load(builder);

            _container = builder.Build();

            return _container;
        }

        private static void Load(ContainerBuilder builder)
        {
            //register the service layer, which then registers all other dependencies in the rest of the system
            builder.RegisterModule(new ServiceLayerModule());
        }
    }
}