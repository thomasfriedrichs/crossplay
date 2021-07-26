import http from '../http-common';

const getAllGames = () => {
  return http.get('api/games')
}


export default {
  getAllGames,
};