﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("api/drink")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private readonly DrinkContext _context;

        public DrinkController(DrinkContext context)
        {
            _context = context;

            if (_context.Drinks.Count() == 0)
            {
 
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.

                _context.SaveChanges();
            }
        }


        [HttpGet]
        public async Task<DrinkDetailResult> Get()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage
                {RequestUri = new Uri("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Non_Alcoholic"), Method = HttpMethod.Get};
            var response = await httpClient.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<DrinkResult>(json);
            
            var drinkList = data.Drinks;
            var drinkListLen = drinkList.Count;
            
            //så här kallar man random i C# tydligen.
            Random rnd = new Random(); 
            int randomIndex = rnd.Next(0, drinkListLen - 1);
            
            var retDrink = drinkList[randomIndex];
            var id = retDrink.idDrink;

            request = new HttpRequestMessage
                { RequestUri = new Uri("https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=" + id), Method = HttpMethod.Get };
            response = await httpClient.SendAsync(request);
            json = await response.Content.ReadAsStringAsync();


            var drink = JsonConvert.DeserializeObject<DrinkDetailResult>(json);

            Console.WriteLine("\n\n --------------------");
            Console.WriteLine(drink.drinks);
            Console.WriteLine(" -------------------- \n\n");

            return drink;
        }

    }


}