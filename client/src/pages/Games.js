import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import getAllGames  from '../services/Service';

const Games = () => {
  // const retrieveGames = () => {
  //   getAllGames()
  //     .then(response => {
  //       setGames(response.data);
  //       console.log(response.data);
  //     })
  //     .catch(e => {
  //       console.log(e);
  //     });
  // };

  console.log(getAllGames());

  return (
    <div>

    </div>
  )
};

export default Games;