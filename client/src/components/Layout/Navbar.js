import { NavLink } from "react-router-dom";
import React from "react";

const Navbar = () => {
  return (
    <div>
      <nav className='nav'>
        <NavLink to='/'>
          CrossPlay
        </NavLink>
        <NavLink to={'/categories'}>
          Categories 
        </NavLink>
        <NavLink to={'/games'}>
          Games
        </NavLink>
        <NavLink to={'/platforms'}>
          Platforms 
        </NavLink>
      </nav>
    </div>
  )
}

export default Navbar;