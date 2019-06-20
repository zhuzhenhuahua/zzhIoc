using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void setUpResolveRules(ContainerBuilder builder)
        {
            var iRepository = Assembly.Load("IRepository");
            var repository = Assembly.Load("Repository");
            builder.RegisterAssemblyTypes(iRepository, repository)
             .Where(t => t.Name.EndsWith("Repository"))
             .AsImplementedInterfaces();

        }
    }
}
