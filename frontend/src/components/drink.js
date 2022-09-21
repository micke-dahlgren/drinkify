import React from 'react';
import './drink.css';

const Drink = ({drinkData}) => {
  

  return (
    <div className="drinkContainer">
      <div className="drinkHeroContainer">
        <img className="drinkImg" src={drinkData.strDrinkThumb} />
        <h1>{drinkData.strDrink}</h1>
      </div>
      <div className="detailsContainer">
        <div className="row left">

          <h3 className="instructionsHeading">Instructions</h3>
          <p className="instructions">{drinkData.strInstructions}</p>
        </div>

        <div className="row right">
          <h3>Ingredients</h3>
          <ul>
              { (drinkData.strIngredient1 !== null) ? <li><b>{drinkData.strIngredient1}</b> <span>{drinkData.strMeasure1}</span></li> : null}
              { (drinkData.strIngredient2 !== null) ? <li><b>{drinkData.strIngredient2}</b> <span>{drinkData.strMeasure2}</span></li> : null}
              { (drinkData.strIngredient3 !== null) ? <li><b>{drinkData.strIngredient3}</b> <span>{drinkData.strMeasure3}</span></li> : null}
              { (drinkData.strIngredient4 !== null) ? <li><b>{drinkData.strIngredient4}</b> <span>{drinkData.strMeasure4}</span></li> : null}
              { (drinkData.strIngredient5 !== null) ? <li><b>{drinkData.strIngredient5}</b> <span>{drinkData.strMeasure5}</span></li> : null}
              { (drinkData.strIngredient6 !== null) ? <li><b>{drinkData.strIngredient6}</b> <span>{drinkData.strMeasure6}</span></li> : null}
          </ul>
        </div>

      </div>
    </div>
  )
}


export default Drink;