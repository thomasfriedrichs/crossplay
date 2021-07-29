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
    <div className="app">
      <Router>
        <Navbar/>
        <Switch>
          <Route exact path="/" component={Home}/>
          <Route path="/categories" component={Categories}/>
          <Route path="/categories/:category" component={Category}/>
          <Route path="/games" component={Games}/>  
          <Route path="/games/:game" component={Game}/>
          <Route path="/platforms" component={Platforms}/>
          <Route path="/platforms/:platform" component={Platform}/>
        </Switch>
      </Router>
      <Footer />
    </div>
  );
}

export default App;
