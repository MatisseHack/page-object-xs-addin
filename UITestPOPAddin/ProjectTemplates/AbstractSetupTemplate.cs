﻿using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;

namespace ${Namespace}
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public abstract class AbstractSetup
    {
        protected IApp app;
        protected Platform platform;

        protected bool OnAndroid { get; set; }
        protected bool OniOS { get; set; }

        protected AbstractSetup(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);

            OnAndroid = app.GetType() == typeof(AndroidApp);
            OniOS = app.GetType() == typeof(iOSApp);
        }
    }
}
