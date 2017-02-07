using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace ${Namespace}
{
    public class Tests : BaseTestFixture
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
