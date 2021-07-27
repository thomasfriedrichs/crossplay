import http from '../http-common';

const getAllGames = () => {
  return http.get('api/games/allgames');
};

const getGame = id => {
  return http.get(`api/games/${id}`);
};


export default {
  getAllGames,
  getGame,
};