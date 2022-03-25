using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository db = new PersonRepository();

        //public string ExeEnum()
        //{
        //    AccountType goldAccount;
        //    AccountType platinumAccount;
        //    goldAccount = AccountType.Checking;
        //    platinumAccount = AccountType.Deposit;
        //    string res1 = String.Format("Тип банковского счета {0}", goldAccount);
        //    string res2 = String.Format("Тип банковского счета {0}", platinumAccount); 
        //    string res = res1 + " " + res2; 
        //    return res;
        //}

        //public string ExeStruct()
        //{
        //    BankAccount goldBankAccount;
        //    goldBankAccount.accType = AccountType.Checking; 
        //    goldBankAccount.accBal = (decimal)3200.00;
        //    goldBankAccount.accNo = 123;
        //    string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);
        //    return res;
        //}
        //public string ExeTriangle()
        //{
        //    Triangle tr1 = new Triangle(3, 5, 6);
        //    string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}", tr1.Name, tr1.Area);
        //    return sq1;
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
            ViewData["Mes"] = "хорошего настроения"; 
            //ViewBag.res = ExeTriangle();
            return View();
        }



        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }
        public ViewResult OutputData() 
        { 
            ViewBag.Pers = db.GetAllResponses; 
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson"); 
        }
        //public string Index(string hel)
        //{ 
        //    string Greeting = Models.ModelClass.ModelHello() + ", " + hel;
        //    return Greeting; 
        //}
    }
}
