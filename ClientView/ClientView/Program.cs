using HotelBusinessLogic.Interfaces;
using HotelDatabaseImplement.Implements;
using HotelBusinessLogic.BusinessLogic;
using HotelBusinessLogic.ViewModels;
using Unity;
using System.Windows.Forms;
using System;
using Unity.Lifetime;
using HotelDatabaseImplement.Implement;
using HotelBusinessLogic.BusinessLogics;
using HotelBusinessLogic.BusinessLogic.OfficePackage;
using HotelBusinessLogic.BusinessLogic.OfficePackage.Implements;
using HotelBusinessLogic.BindingModels;
using System.Configuration;

namespace ClientView
{
    internal static class Program
    {

        private static IUnityContainer container = null;
        public static ClientViewModel client = null;
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
            currentContainer.RegisterType<ReportLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<PaymentLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmployeeLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ConfLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<RoomLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<MailWorker>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
