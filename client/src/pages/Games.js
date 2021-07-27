import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import * as DataService from '../services/Service';

const Games = () => {
  
  const retrieveGames = () => {
    DataService.getAllGames()
      .then((response) => {
        this.setState({
          items: response.data,
        });
        console.log(response.data);
      })
      .catch((e) => {
        console.log(e);
      });
  }

  console.log(retrieveGames());

  return (
    <div>

    </div>
  )
};

export default Games;