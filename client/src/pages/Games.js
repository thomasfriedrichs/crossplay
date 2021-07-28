import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import baseUrl from '../services/Service';
import axios from 'axios';


const Games = () => {
  const [post, setPost] = React.useState(null);
  //const [error, setError] = React.useState(null);

  React.useEffect(() => {
    axios.get(`${baseUrl}/games`).then((response) => {
      setPost(response.data);
    });
  }, []);

  if (!post) return null;

  return (
    <div>
      <h1>{post.GameName}</h1>
    </div>
  )
};

export default Games;