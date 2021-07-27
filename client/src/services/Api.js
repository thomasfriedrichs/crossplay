const makeDbCall = (database) => {
  fetch(`https://http://localhost:5000/api/crossplay/${database}`)
    .then(response => response.json())
    .then(
      (jsonifiedResponse) => {
        this.setState({
          isLoaded: true,
          headlines: jsonifiedResponse.results
        });
      })
      .catch((error) => {
        this.setState({
          isLoaded: true,
          error
        });
      });
}

const makeIdCall = (database, id) => {
  fetch(`https://http://localhost:5000/api/crossplay/${database}/${id}`)
    .then(response => response.json())
    .then(
      (jsonifiedResponse) => {
        this.setState({
          isLoaded: true,
          headlines: jsonifiedResponse.results
        });
      })
      .catch((error) => {
        this.setState({
          isLoaded: true,
          error
        });
      });
}

export default makeDbCall;
export default makeIdCall;