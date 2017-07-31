using NUnit.Runner.Services;
using System;

namespace nunit.runner.tests.Tizen.Tizen
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            var nunitApp = new NUnit.Runner.App();

            nunitApp.Options = new TestOptions
            {
                AutoRun = true,
                CreateXmlResultFile = false
            };

            LoadApplication(nunitApp);
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }
}
