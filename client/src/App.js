import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import React from 'react';
// Pages
import Home from './pages/Home';
import Categories from './pages/Categories';
import Category from './pages/Category';
import Game from './pages/Game';
import Games from './pages/Games';
import Platform from './pages/Platform';
import Platforms from './pages/Platforms';
// Components
import Navbar from './components/nav/Navbar';
import Footer from './components/Nav/Footer'; 

function App() {
  return (
    <div className = 'app'>
      <Router>
        <Navbar/>
        <Switch>
          <Route>
            
          </Route>
        </Switch>
        <Footer/>
      </Router>
    </div>
  );
}

export default App;
