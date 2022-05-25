using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.BusinessLogic;
using HotelBusinessLogic.BusinessLogic.OfficePackage;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Implements;
using HotelBusinessLogic.BusinessLogics;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Implement;
using HotelDatabaseImplement.Implements;

namespace EmployeeView
{
    internal static class Program
    {
        private static IUnityContainer container = null;
        public static EmployeeViewModel employee = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IPaymentStorage, PaymentStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientStorage, ClientStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeStorage, EmployeeStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRoomStorage, RoomStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IConfStorage, ConfStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportToWord, SaveToWord>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportToExcel, SaveToExcel>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportToPdf, SaveToPdf>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<PaymentLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmployeeLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ConfLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<RoomLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<MailWorker>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container.Resolve<MailWorker>().MailConfig(new MailConfigBindingModel()
            {
                MailLogin = ConfigurationManager.AppSettings["MailLogin"],
                MailPassword =
         ConfigurationManager.AppSettings["MailPassword"],
                SmtpClientHost =
         ConfigurationManager.AppSettings["SmtpClientHost"],
                SmtpClientPort =
         Convert.ToInt32(ConfigurationManager.AppSettings["SmtpClientPort"]),
                PopHost = ConfigurationManager.AppSettings["PopHost"],
                PopPort =
         Convert.ToInt32(ConfigurationManager.AppSettings["PopPort"])
            });
            Application.Run(Container.Resolve<FormRegistration>());
        }
    }
}
