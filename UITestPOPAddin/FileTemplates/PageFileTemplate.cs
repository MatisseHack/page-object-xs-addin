using System;
using NUnit.Framework;
using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ${Namespace}
{
    public class ${Name} : BasePage
    {
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = null,
            iOS = null
        };

        public ${Name}()
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
