using MvvmApp.Wpf.Infrastructure.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Wpf;
public class Program
{
    [STAThread]
    static void Main(string[] _)
    {
        var applicationService = new ApplicationService();
        applicationService.Initialize();
        //var app = new App();
        //app.InitializeComponent();
        //app.Run();
    }
}
