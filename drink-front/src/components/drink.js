import React from 'react';
import './drink.css';

const Drink = ({drinkData}) => {
  

  return (
    <div className="drinkContainer">
        <img className="drinkImg" src={drinkData.strDrinkThumb} />
      <h2>{drinkData.strDrink}</h2>
      <h3>instructions</h3>
      <p>{drinkData.strInstructions}</p>
      <h4>ingredients</h4>
      <ul>
          <li>{drinkData.strIngredient1} <b>{drinkData.strMeasure1}</b></li>
          { (drinkData.strIngredient2 !== null) ? <li>{drinkData.strIngredient2} <b>{drinkData.strMeasure2}</b></li> : null}
          { (drinkData.strIngredient3 !== null) ? <li>{drinkData.strIngredient3} <b>{drinkData.strMeasure3}</b></li> : null}
      </ul>
    </div>
  )
}


export default Drink;