using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDatabaseImplement.Implements
{
    public class RoomStorage : IRoomStorage
    {
        public List<RoomViewModel> GetFullList()
        {
            using var context = new HotelDatabase();
            return context.Rooms
            .Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Conf)
            .Select(CreateModel)
            .ToList();
        }
        public List<RoomViewModel> GetFilteredList(RoomBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Rooms
            .Where(rec => rec.Name.Contains(model.Name))
              .Include(rec => rec.ConfRooms)
            .ThenInclude(rec => rec.Conf)
            .Select(CreateModel)
            .ToList();
        }
        public RoomViewModel GetElement(RoomBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            var room = context.Rooms
            .FirstOrDefault(rec => rec.Id == model.Id);
            if (room == null)
            {
                return null;
            }
            return CreateModel(room);
        }
        public void Insert(RoomBindingModel model)
        {
            using var context = new HotelDatabase();

            context.Rooms.Add(CreateModel(model, new Room()));
            context.SaveChanges();
        }
        public void Update(RoomBindingModel model)
        {
            using var context = new HotelDatabase();
            var element = context.Rooms.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(RoomBindingModel model)
        {
            using var context = new HotelDatabase();
            Room element = context.Rooms.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Rooms.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Room CreateModel(RoomBindingModel model, Room
       room)
        {
            room.Cost = model.Cost;
            room.Name = model.Name;
            return room;
        }
        private static RoomViewModel CreateModel(Room room)
        {
            return new RoomViewModel
            {
                Id = room.Id,
                Cost= room.Cost,
                Name = room.Name,
                ConfRooms = room.ConfRooms
            .ToDictionary(x => x.Id, x => (x.ConfId, x.Conf.DateConf))
            };
        }
    }
}
