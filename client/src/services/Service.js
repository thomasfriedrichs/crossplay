import http from '../http-common';
class DataService {
  getAllGames = () => {
    return http.get('api/crossplay/games');
  };

  getGame = id => {
    return http.get(`api/crossplay/games/${id}`);
  };

  getAllPlatforms = () => {
    return http.get('api/crossplay/platforms');
  };

  getPlatform = id => {
    return http.get(`api/crossplay/platforms/${id}`);
  };

  getAllCategories = () => {
    return http.get('api/crossplay/categories');
  };

  getCategory = id => {
    return http.get(`api/crossplay/categories/${id}`);
  };

  findByTitle = title => {
    return http.get(`/crossplay/games?GameName=${title}`);
  };
}


export default DataService; 
