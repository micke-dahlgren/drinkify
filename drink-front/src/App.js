import {useEffect, useState} from 'react';
import Drink from './components/drink';
import { apiClient } from './api/api-client';
import reactDom from 'react-dom';
import './App.css';


function App() {

  const [drinkData, setDrinkData]= useState([]);
  
  function getRandDrink(){
    apiClient
    .getDrink()
    .then(res => setDrinkData(res.drinks[0]));
  }

  useEffect(() => {
    getRandDrink();
  },[]);

  return (
    <div className="App">
      <Drink drinkData={drinkData}/>
      <button onClick={() => getRandDrink()}>Another!</button>
    </div>
    
  );
}

export default App;
