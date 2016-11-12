using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace ${Namespace}
{
    public class Tests : AbstractSetup
    {
        public Tests(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void AppLaunches()
        {
            new FirstPage();
        }
    }
}
