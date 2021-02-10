import React from 'react';

const BackEndData = () => {
  return (
    <div>
      <p>{GetDrink()}</p>
    </div>
  )
}

const URL = "http://localhost:5000/api/drink";

const GetDrink = () => {
  console.log("hej")
  const promise = fetch(URL).then(result => result.json());
  console.log(promise);
  return promise.value.drinks;
}

export default BackEndData;