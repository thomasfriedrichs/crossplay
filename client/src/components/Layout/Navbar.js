import { Link } from "react-router-dom";
import React from "react";

function Navbar() {
  return (
    <div>
      <nav className='nav'>
        <a href='/'>
          CrossPlay
        </a>
        <div>
          <li>
            <Link to={'/categories'}>
              Categories 
            </Link>
          </li>
          <li>
            <Link to={'/games'}>
              Games
            </Link>
          </li>
          <li>
            <Link to={'/platforms'}>
              Platforms 
            </Link>
          </li>
        </div>
      </nav>
    </div>
  )
}

export default Navbar;