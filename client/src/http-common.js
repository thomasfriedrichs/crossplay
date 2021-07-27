import axios from "axios";

export default axios.create({
  baseURL: "http://localhost:5000/api/crossplay",
  headers: {
    "Content-type": "application/json"
  }
});