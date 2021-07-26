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
            </Link>
          </li>
        </div>
      </nav>
    </div>
  )
}

export default Navbar;