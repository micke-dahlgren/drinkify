using System;
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
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public object strDrinkAlternate { get; set; }
        public object strDrinkES { get; set; }
        public object strDrinkDE { get; set; }
        public object strDrinkFR { get; set; }
        [JsonProperty("strDrinkZH-HANS")]
        public object StrDrinkZHHANS { get; set; }
        [JsonProperty("strDrinkZH-HANT")]
        public object StrDrinkZHHANT { get; set; }
        public object strTags { get; set; }
        public object strVideo { get; set; }
        public string strCategory { get; set; }
        public object strIBA { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public object strInstructionsES { get; set; }
        public string strInstructionsDE { get; set; }
        public object strInstructionsFR { get; set; }
        [JsonProperty("strInstructionsZH-HANS")]
        public object StrInstructionsZHHANS { get; set; }
        [JsonProperty("strInstructionsZH-HANT")]
        public object StrInstructionsZHHANT { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public object strIngredient6 { get; set; }
        public object strIngredient7 { get; set; }
        public object strIngredient8 { get; set; }
        public object strIngredient9 { get; set; }
        public object strIngredient10 { get; set; }
        public object strIngredient11 { get; set; }
        public object strIngredient12 { get; set; }
        public object strIngredient13 { get; set; }
        public object strIngredient14 { get; set; }
        public object strIngredient15 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public object strMeasure6 { get; set; }
        public object strMeasure7 { get; set; }
        public object strMeasure8 { get; set; }
        public object strMeasure9 { get; set; }
        public object strMeasure10 { get; set; }
        public object strMeasure11 { get; set; }
        public object strMeasure12 { get; set; }
        public object strMeasure13 { get; set; }
        public object strMeasure14 { get; set; }
        public object strMeasure15 { get; set; }
        public object strImageSource { get; set; }
        public object strImageAttribution { get; set; }
        public string strCreativeCommonsConfirmed { get; set; }
        public string dateModified { get; set; }
    }

    public class DrinkDetailResult
    {
        public List<DrinkDetails> drinkData { get; set; }
    }
}





