using System;
using NUnit.Framework;
using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ${Namespace}
{
    public class FirstPage : BasePage
    {
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = null,
            iOS = null
        };

        public FirstPage()
        {
            if (OnAndroid)
            {
            }

            if (OniOS)
            {
            }
        }
    }
}
