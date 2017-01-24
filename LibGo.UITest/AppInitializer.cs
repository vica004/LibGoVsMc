using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace LibGo.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
                FileInfo fi = new FileInfo(currentFile);
                string dir = fi.Directory.Parent.Parent.Parent.FullName;
                string _path = Path.Combine(dir, "LibGo/LibGo.Droid", "bin", "Release", "LibGo.Droid.APK");
                return ConfigureApp.Android.ApkFile(_path).StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

