﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac.Extras.Moq;
using Hanlin.Common.Utils;
using NUnit.Framework;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;

namespace Hanlin.Tests
{
    public class TestsBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected string BasePath { get; set; }
        public string AssetsFolder { get; set; }
        
        protected Stack<string> PathSegments { get; set; }
        protected AutoMock AutoMock { get; set; }

        public TestsBase()
        {
/*            BasicConfigurator.Configure(new ConsoleAppender
            {
                Layout = new SimpleLayout()
            });*/

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo("log4net.config"));

            AssetsFolder = "TestCases";
            PathSegments = new Stack<string>();
            BuildBasePath();
        }

        protected string PathTo(string filename)
        {
            return Path.Combine(BasePath, filename); 
        }

        protected string PathToOutput(string filename)
        {
            return Path.Combine(BasePath, PathEx.AppendToPath(filename, "_output"));
        }

        [SetUp]
        protected virtual void Setup()
        {
            ConfigureAssetsPath();

            AutoMock = AutoMock.GetLoose();
        }

        protected virtual void ConfigureAssetsPath()
        {
        }

        protected void PushPath(params string[] segments)
        {
            foreach (var path in segments)
            {
                PathSegments.Push(path);
            }
            BuildBasePath();
        }

        protected void UsePath(params string[] segments)
        {
            PathSegments.Clear();
            PushPath(segments);
            BuildBasePath();
        }

        private void BuildBasePath()
        {
            var parts = new List<string>(new [] { Directory.GetCurrentDirectory(), AssetsFolder });

            parts.AddRange(PathSegments.Reverse());

            BasePath = Path.Combine(parts.ToArray());

            Log.Info("Asset base path: " + BasePath);
        }

        protected static string RandomText()
        {
            return Guid.NewGuid().ToString();
        }
    }
}