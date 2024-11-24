using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PhoneStore;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using Newtonsoft.Json;
using Fluent.Infrastructure.FluentModel;

public class ProductController : Controller
{
    

    

    // Метод для создания JSON-файла при загрузке
    public ActionResult GenerateJsonFile()
    {

        using (var _context = new ApplicationDbContext())
        {
            try
            {
                // Получение данных из базы данных
                var products = _context.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Manufacturer,
                        p.Year,
                        p.Memory,
                        p.Price
                    })
                    .ToList();

                // Преобразование данных в JSON
                string json = JsonConvert.SerializeObject(products, Formatting.Indented);

                // Путь для сохранения файла
                string filePath = Microsoft.AspNetCore.Server.MapPath("~/App_Data/products.json");

                // Создание файла
                System.IO.File.WriteAllText(filePath, json);

                return Content($"JSON файл успешно создан: {filePath}");
            }
            catch (Exception ex)
            {
                return Content($"Ошибка при создании JSON файла: {ex.Message}");
            }
        }
    }
}
