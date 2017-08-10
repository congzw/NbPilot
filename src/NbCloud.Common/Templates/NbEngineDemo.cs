using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;

namespace NbCloud.Common.Templates
{
    public class NbEngineDemo
    {
        public static void Run()
        {
            var nbRazorEngineService = NbEngine.Razor;
            Demo01(nbRazorEngineService);
            Demo02(nbRazorEngineService);
            Demo03(nbRazorEngineService);
            Demo04(nbRazorEngineService);
        }

        private static void Demo01(INbRazorEngineService service)
        {
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            var renderTemplate = service.Render(template, new { Name = "World" });
            Console.WriteLine(renderTemplate);
        }

        private static void Demo02(INbRazorEngineService service)
        {
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            var renderTemplate = service.Render(template, new Foo { Name = "World" });
            Console.WriteLine(renderTemplate);
        }

        private static void Demo03(INbRazorEngineService service)
        {
            var ns = typeof(Foo).FullName;
            string template = String.Format(@"@model {0}
Hello @Model.Name, welcome to RazorEngine!", ns);
            var renderTemplate = service.Render(template, new Foo { Name = "World" });
            Console.WriteLine(renderTemplate);
        }

        private static void Demo04(INbRazorEngineService service)
        {
            var ns = typeof(Foo).FullName;
            string template = String.Format(@"@model {0}
Hello @Model.Name, welcome to RazorEngine!", ns);
            try
            {
                var renderTemplate = service.Render(template, new { Name = "World" });
                Console.WriteLine(renderTemplate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool UsingAppDomainFinished()
        {
            if (AppDomain.CurrentDomain.IsDefaultAppDomain())
            {
                // RazorEngine cannot clean up from the default appdomain...
                Console.WriteLine("Switching to secound AppDomain, for RazorEngine...");
                AppDomainSetup adSetup = new AppDomainSetup();
                adSetup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                var current = AppDomain.CurrentDomain;
                var strongNames = new StrongName[0];

                var domain = AppDomain.CreateDomain(
                    "MyMainDomain", null,
                    current.SetupInformation, new PermissionSet(PermissionState.Unrestricted),
                    strongNames);

                var location = Assembly.GetExecutingAssembly().Location;
                if (location != null)
                {
                    domain.ExecuteAssembly(location); ;
                }

                // RazorEngine will cleanup. 
                AppDomain.Unload(domain);
                return true;
            }
            return false;
        }

        private static void SetupRazor()
        {
            //var config = new TemplateServiceConfiguration();
            //config.Language = Language.CSharp;
            //config.EncodedStringFactory = new RawStringFactory(); // Raw string encoding.
            ////config.EncodedStringFactory = new HtmlEncodedStringFactory(); // Html encoding.

            //config.Debug = false;
            //var service = RazorEngineService.Create(config);
            //Engine.Razor = service;
        }
    }

    public class Foo
    {
        public string Name { get; set; }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        if (NbEngineDemo.UsingAppDomainFinished())
    //        {
    //            //clear and exist
    //            return;
    //        }

    //        NbEngineDemo.Run();
    //        Console.Read();
    //    }
    //}
}
