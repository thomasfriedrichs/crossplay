import React from "react";
import SingleGame from "../components/Games/SingleGame";
// import { Link } from "react-router-dom";
import client from '../services/Service';
// import axios from 'axios';


const Games = () => {
  const [post, setPost] = React.useState(null);
  // const [error, setError] = React.useState(null);

  // React.useEffect(() => {
  //   axios.get(`${baseUrl}/games`).then((response) => {
  //     setPost(response.data);
  //   }).catch(error => {
  //     setError(error);
  //   });
  // }, []);

  // const client = axios.create({
  //   baseURL: "https://jsonplaceholder.typicode.com/posts" 
  // });

  React.useEffect(() => {
    async function getPost() {
      const response = await client.get("/games");
      setPost(response.data);
    } 
    getPost();
  }, []);


  // if (error) return `Error: ${error.message}`;
  // if (!post) return null;

  return (
    <div>
      <p></p>
      <SingleGame/>
    </div>
  )
};

export default Games;