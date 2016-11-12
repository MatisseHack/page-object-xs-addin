using System;
using NUnit.Framework;
using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ${Namespace}
{
    public class FirstPage : BasePage
    {
        public FirstPage()
            : base(null, null)
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
