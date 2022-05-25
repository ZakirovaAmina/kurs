using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Models;

namespace HotelDatabaseImplement.Implement
{
    public class ClientStorage:IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using var context = new HotelDatabase();
            return context.Clients
            .Select(CreateModel)
            .ToList();
        }
        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Clients
            .Where(rec => rec.Name.Contains(model.Name))
            .Select(CreateModel)
            .ToList();
        }
        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            var client = context.Clients
            .FirstOrDefault(rec => rec.Phone == model.Phone);
            if (client == null)
            {
                return null;
            }
            return client.Password == model.Password ? CreateModel(client) : null;
        }
        public void Insert(ClientBindingModel model)
        {
            using var context = new HotelDatabase();
            Client element = context.Clients.FirstOrDefault(rec => rec.Phone ==
           model.Phone);
            if (element != null)
            {
                throw new Exception("Телефон уже зарегистрирован");
            }
            context.Clients.Add(CreateModel(model, new Client()));
            context.SaveChanges();
        }
        public void Update(ClientBindingModel model)
        {
            using var context = new HotelDatabase();
            var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(ClientBindingModel model)
        {
            using var context = new HotelDatabase();
            Client element = context.Clients.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Clients.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Client CreateModel(ClientBindingModel model, Client
       client)
        {
            client.Password = model.Password;
            client.Mail = model.Email;
            client.Name = model.Name;
            client.Phone = model.Phone;
            return client;
        }
        private static ClientViewModel CreateModel(Client client)
        {
            return new ClientViewModel
            {
                Id = client.Id,
                Name = client.Name,
                Email=client.Mail,
                Phone = client.Phone
            };
        }
    }
}
