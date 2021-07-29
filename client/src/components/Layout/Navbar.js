import { NavLink } from "react-router-dom";
import React from "react";

const Navbar = () => {
  return (
    <div>
      <nav className='nav'>
        <div>
          <NavLink to='/'>
            CrossPlay
          </NavLink>
        </div>
        <div>
          <NavLink to={'/categories'}>
            Categories 
          </NavLink>
        <div>
        </div>
          <NavLink to={'/games'}>
            Games
          </NavLink>
        <div>
        </div>
          <NavLink to={'/platforms'}>
            Platforms 
          </NavLink>
        </div>
      </nav>
    </div>
  )
}

export default Navbar;