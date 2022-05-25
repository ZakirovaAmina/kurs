using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelDatabaseImplement.Implements
{
    public class ConfStorage : IConfStorage
    {
        public List<ConfViewModel> GetFullList()
        {
            using var context = new HotelDatabase();
            return context.Confs
             .Include(rec => rec.ConfRooms)
             .ThenInclude(rec => rec.Room)
             .Include(x => x.Client)
             .Include(x => x.Employee)
            .Select(CreateModel)
            .ToList();
        }
        public List<ConfViewModel> GetFilteredList(ConfBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Confs.Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Room)
             .Include(x => x.Client)
             .Include(x => x.Employee).Where(rec => rec.ClientId == model.ClientId)
            .Select(CreateModel)

            .ToList();
        }
        public List<ConfViewModel> GetFilteredListEmployee(ConfBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Confs.Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Room)
             .Include(x => x.Client)
             .Include(x => x.Employee).Where(rec => rec.EmployeeId == model.EmployeeId)
            .Select(CreateModel)

            .ToList();
        }
        public List<ConfViewModel> GetFilteredListDate(ConfBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Confs.Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Room)
             .Include(x => x.Client)
             .Include(x => x.Employee).Where(rec => rec.Id.Equals(model.Id) || rec.DateConf >= model.DateFrom && rec.DateConf <= model.DateTo)
            .Select(CreateModel)

            .ToList();
        }
        public ConfViewModel GetElement(ConfBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            var conf = context.Confs
                .Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Room)
             .Include(x => x.Client)
             .Include(x => x.Employee)
            .FirstOrDefault(rec => rec.Id == model.Id)
            ;
            if (conf == null)
            {
                return null;
            }
            return CreateModel(conf);
        }
        public void Insert(ConfBindingModel model)
        {
            using var context = new HotelDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                CreateModel(model, new Conf(), context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                transaction.Rollback();
                throw;
            }
        }
        public void Update(ConfBindingModel model)
        {
            using var context = new HotelDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Confs.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(ConfBindingModel model)
        {
            using var context = new HotelDatabase();
            Conf element = context.Confs.FirstOrDefault(rec => rec.Id ==
            model.Id);
            if (element != null)
            {
                context.Confs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Conf CreateModel(ConfBindingModel model, Conf conf,
       HotelDatabase context)
        {
            conf.DateConf = model.ConfsDate;
            conf.ClientId=model.ClientId;
            conf.EmployeeId = model.EmployeeId;
            conf.Sum = model.Sum;
            if (conf.Id == 0)
            {
                context.Confs.Add(conf);
                context.SaveChanges();
            }
            if (model.Id !=0)
            {
                var confRooms = context.ConfRooms.Where(rec =>
               rec.ConfId == model.Id).ToList();
                // удалили те, которых нет в модели
                context.ConfRooms.RemoveRange(confRooms.Where(rec =>
               !model.ConfRooms.ContainsKey(rec.ConfId)).ToList());
                context.SaveChanges();
                context.SaveChanges();
            }
            // добавили новые
            foreach (var pc in model.ConfRooms)
            {
                context.ConfRooms.Add(new ConfRoom
                {
                    ConfId = conf.Id,
                    RoomId = pc.Key,
                });
                var temp = context.ConfRooms;
                context.SaveChanges();
            }
            return conf;
        }
        private static ConfViewModel CreateModel(Conf conf)
        {
            return new ConfViewModel
            {
                Id = conf.Id,
                ClientName = conf.Client.Name,
                EmployeeName= conf?.Employee?.Name,
                ClientId= conf.ClientId,
                EmployeeId= conf?.EmployeeId,
                Sum= conf.Sum,
                ConfsDate= conf.DateConf,
                ConfRooms = conf.ConfRooms
            .ToDictionary(recPC => recPC.Id,
            recPC => recPC.Room?.Name ) 
            };
        }
    }
}

