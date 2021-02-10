const BASE_URL = "http://localhost:5000/api/drink";

export const apiClient = {
  getDrink() {
    console.log('api-client: Fetching all todo tasks');
    return fetch(BASE_URL).then(result => result.json());
  },

};
