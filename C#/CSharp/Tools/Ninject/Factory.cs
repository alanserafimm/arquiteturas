﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CSharp.Tools.Ninject
{
    public class Factory
    {
        private static void Init() { }
        public static object InstanceOf(string typeName) => InstanceOf(Type.GetType(typeName));
        public static TConvertModel InstanceOf<TConvertModel>(Type type) => (TConvertModel)InstanceOf(type);
        public static object InstanceOf(Type type) { return GlobalConfiguration.Configuration.DependencyResolver.GetService(type); }
        public static TModel InstanceOf<TModel>() { return (TModel)GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(TModel)); }
    }
}