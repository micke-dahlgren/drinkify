import React from 'react';

const URL = "http://localhost:5000/api/drink";

const BackEndData = () => {
  const result = GetDrink(URL)

  return (
    <div>
      <p>asd</p>
    </div>
  )
}

async function GetDrink(URL) {
    const promise = fetch(URL).then(result => result.json().then(res => res.drinks[0].strDrink));
    console.log(promise)
    return promise
}

// const GetDrink = () => {
//   console.log("hej")
//   const promise = fetch(URL).then(result => result.json().then(res => res.drinks[0].strDrink));
//   console.log(promise);
//   // return promise;
// }

export default BackEndData;