﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TodoApi.Models
{
    /*
    public class TodoItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
    */
    public class DrinkGeneral
    {
        public string strDrink { get; set; }
        public string strDrinkThumb { get; set; }
        public string idDrink { get; set; }

        public long Id {get; set; }
    }

    public class DrinkResult
    {
        public List<DrinkGeneral> drinks { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class DrinkDetails
    {
        public long id { get; set; }
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strDrinkAlternate { get; set; }
        public string strDrinkES { get; set; }
        // public string strDrinkDE { get; set; }
        public string strDrinkFR { get; set; }
        [JsonProperty("strDrinkZH-HANS")]
        public string StrDrinkZHHANS { get; set; }
        [JsonProperty("strDrinkZH-HANT")]
        public string StrDrinkZHHANT { get; set; }
        public string strTags { get; set; }
        public string strVideo { get; set; }
        public string strCategory { get; set; }
        public string strIBA { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public string strInstructionsES { get; set; }
        // public string strInstructionsDE { get; set; }
        public string strInstructionsFR { get; set; }
        [JsonProperty("strInstructionsZH-HANS")]
        public string StrInstructionsZHHANS { get; set; }
        [JsonProperty("strInstructionsZH-HANT")]
        public string StrInstructionsZHHANT { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
        public string strMeasure7 { get; set; }
        public string strMeasure8 { get; set; }
        public string strMeasure9 { get; set; }
        public string strMeasure10 { get; set; }
        public string strMeasure11 { get; set; }
        public string strMeasure12 { get; set; }
        public string strMeasure13 { get; set; }
        public string strMeasure14 { get; set; }
        public string strMeasure15 { get; set; }
        public string strImageSource { get; set; }
        public string strImageAttribution { get; set; }
        public string strCreativeCommonsConfirmed { get; set; }
        public string dateModified { get; set; }
    }

    public class DrinkDetailResult
    {
        public List<DrinkDetails> drinkData { get; set; }
    }
}





