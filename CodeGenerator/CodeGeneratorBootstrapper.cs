﻿using System.Windows;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace CodeGenerator
{
    public class CodeGeneratorBootstrapper : UnityBootstrapper
    {
        CallbackLogger _callbackLogger = new CallbackLogger();
        protected override System.Windows.DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void InitializeModules()
        {
            IModule moduleA = Container.Resolve<ListViewModule.StudentListViewModule>();
            moduleA.Initialize(); 
        }

        protected override ILoggerFacade CreateLogger()
        {
            return this._callbackLogger;
        }
    }
}