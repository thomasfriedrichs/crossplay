import React from "react";
// import { Link } from "react-router-dom";
import client from '../services/Service';
// import axios from 'axios';


const Games = () => {
  const [post, setPost] = React.useState(null);
  const [error, setError] = React.useState(null);

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


  if (error) return `Error: ${error.message}`;
  if (!post) return null;

  return (
    <div>
      {console.log(post)}
      <h1>{post[0].gameName}</h1>
      <h1>hello world</h1>
      <p>hhhhhhhhhhhhhhhhhhh</p>
    </div>
  )
};

export default Games;