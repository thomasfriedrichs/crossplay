import axios from "axios";

// import http from '../http-common';

//   const getAllGames = () => {
//     return http.get('api/crossplay/games');
//   };

//   const getGame = id => {
//     return http.get(`api/crossplay/games/${id}`);
//   };

//   const getAllPlatforms = () => {
//     return http.get('api/crossplay/platforms');
//   };

//   const getPlatform = id => {
//     return http.get(`api/crossplay/platforms/${id}`);
//   };

//   const getAllCategories = () => {
//     return http.get('api/crossplay/categories');
//   };

//   const getCategory = id => {
//     return http.get(`api/crossplay/categories/${id}`);
//   };

//   const findByTitle = title => {
//     return http.get(`/crossplay/games?GameName=${title}`);
//   };

// const baseUrl = "http://localhost:5000/api/crossplay";


const client = axios.create({
  baseURL: "http://localhost:5000/api/crossplay" 
});

export default client;

// export {
//   getAllGames,
//   getGame,
//   getAllPlatforms,
//   getPlatform,
//   getAllCategories,
//   getCategory,
//   findByTitle
// }
