using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
     
        public string MessageRezult;
        public Product Product { get; set; }
        public void OnGet()
        {
            MessageRezult = "Для товара можно определить скидку";
        }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "Переданы некорректные данные. Повторите ввод";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
            Product.Price = price;
            Product.Name = name;
        }
        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price - price * (decimal?)discont / 100;
            MessageRezult = $"Для товара {name} с ценой {price} и скидкой {discont} получится {result}";
            Product.Price = price;
            Product.Name = name;
        }
        public void OnPostOnlinePay(string name, decimal? price, string onlinePay)
        {
            Product = new Product();
            if (onlinePay == "Да")
                MessageRezult = $"Для товара {name} с ценой {price} производится безналичная оплата";
            else if (onlinePay == "Нет")
                MessageRezult = $"Для товара {name} с ценой {price} производится оплата наличными";
            else
                MessageRezult = $"Неккоректный ввод данных";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
