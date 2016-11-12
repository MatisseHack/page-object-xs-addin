using System;
using Xamarin.UITest;

namespace ${Namespace}
{
    public class AppInitializer
    {
        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppInitializer.App' not set. Call 'AppInitializer.StartApp(platform)' before trying to access it.");
                return app;
            }
        }

        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                app = ConfigureApp
                    .Android
                    //.ApkFile("../../../my.apk")
                    .StartApp();
            }
            else
            {
                app = ConfigureApp
                    .iOS
                    //.AppBundle("../../../my.app")
                    //.InstalledApp("com.company.app")
                    .StartApp();
            }

            return app;
        }
    }
}
