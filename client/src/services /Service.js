import http from '../http-common';

const getAllGames = () => {
  return http.get('/games')
}


export default {
  getAllGames,
};