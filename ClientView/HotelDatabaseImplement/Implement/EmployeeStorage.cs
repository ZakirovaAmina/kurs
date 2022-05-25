using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;
using HotelDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDatabaseImplement.Implements
{
    public class EmployeeStorage : IEmployeeStorage
    {
        public List<EmployeeViewModel> GetFullList()
        {
            using var context = new HotelDatabase();
            return context.Employees
            .Select(CreateModel)
            .ToList();
        }
        public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            return context.Employees
            .Where(rec => rec.Name.Contains(model.Name))
            .Select(CreateModel)
            .ToList();
        }
        public EmployeeViewModel GetElement(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new HotelDatabase();
            var employee = context.Employees
            .FirstOrDefault(rec => rec.Phone == model.Phone);
            if (employee == null)
            {
                return null;
            }
            return employee.Password == model.Password ? CreateModel(employee) : null;
        }
        public void Insert(EmployeeBindingModel model)
        {
            using var context = new HotelDatabase();
            Employee element = context.Employees.FirstOrDefault(rec => rec.Phone ==
           model.Phone);
            if (element != null)
            {
                throw new Exception("Телефон уже зарегистрирован");
            }
            context.Employees.Add(CreateModel(model, new Employee()));
            context.SaveChanges();
        }
        public void Update(EmployeeBindingModel model)
        {
            using var context = new HotelDatabase();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(EmployeeBindingModel model)
        {
            using var context = new HotelDatabase();
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Employee CreateModel(EmployeeBindingModel model, Employee
       employee)
        {
            employee.Password = model.Password;
            employee.Name = model.Name;
            employee.Mail = model.Email;
            employee.Phone = model.Phone;
            return employee;
        }
        private static EmployeeViewModel CreateModel(Employee employee)
        {
            return new EmployeeViewModel
            {
                Id = employee.Id,
                Email=employee.Mail,
                Name = employee.Name,
                Phone = employee.Phone
            };
        }
    }
}

