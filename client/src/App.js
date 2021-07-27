import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import React from 'react';
// Pages
import Home from './pages/Home';
import Categories from './pages/Categories';
import Category from './pages/Category';
import Games from './pages/Games';
import Game from './pages/Game';
import Platform from './pages/Platform';
import Platforms from './pages/Platforms';
// Components
import Navbar from './components/Layout/Navbar';
import Footer from './components/Layout/Footer'; 

const App = () => {
  return (
    <div className = 'app'>
      <Router>
        <Navbar/>
        <Switch>
          <Route path='/'>
            <Home/>
          </Route>
          <Route path='/categories'>
            <Categories/>
          </Route>
          <Route path='/categories/:category'>
            <Category/>
          </Route>
          <Route path='/games'>
            <Games/>
          </Route>
          <Route path='/games/:game'>
            <Game/>
          </Route>
          <Route path='/platforms'>
            <Platforms/>
          </Route>
          <Route path='/platforms/:platform'>
            <Platform/>
          </Route>
        </Switch>
        <Footer/>
      </Router>
    </div>
  );
}

export default App;
