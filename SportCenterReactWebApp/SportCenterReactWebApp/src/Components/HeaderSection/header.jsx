import { useEffect } from "react";
import "./header.css";

function Header() {
    useEffect(() => {
        const navbar = document.querySelector('#header .container');
    
        const handleScroll = () => {
          if (window.scrollY > 1) { // 50px'den fazla scroll yapıldığında
            navbar.classList.add('scrolled');
          } else {
            navbar.classList.remove('scrolled');
          }
        };
    
        window.addEventListener('scroll', handleScroll);
    
        // Cleanup: scroll event'ini bileşen kaldırıldığında temizle
        return () => {
          window.removeEventListener('scroll', handleScroll);
        };
      }, []);
    
  return (
    <>
        <header id="header">
          <div className="container">
              <div className="logo">
                  <img src="src/assets/images/logo.png" alt="logo" />
              </div>
              <button className="menu-toggle" id="menu-toggle">&#9776;</button>
              <nav className="navbar" id="navbar">
                  <button className="menu-close">x</button>
                  <ul className="navbar-nav">
                      <li className="nav-item">
                          <a className="nav-link" href="#header">Home</a>
                      </li>
                      <li className="nav-item">
                          <a className="nav-link" href="#classes">Classes</a>
                      </li>
                      <li className="nav-item">
                          <a className="nav-link" href="#trainer">Trainer</a>
                      </li>
                      <li className="nav-item">
                          <a className="nav-link" href="#review">Review</a>
                      </li>
                      <li className="nav-item">
                          <a className="nav-link" href="#contact">Contact</a>
                      </li>
                      <li className="nav-item cta">
                          <a className="nav-link join-btn" href="#join-us">JOIN US</a>
                      </li>
                  </ul>
              </nav>
          </div>
          <img src="src/assets/images/hero-man.jpg" alt="Background Image" />
          <div className="text-overlay">
              <h5>POWERFULL</h5>
              <h2>Group Practice With Trainer</h2>
              <p>
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Amet velit voluptas, fugiat harum repellendus similique libero nam dignissimos sint perspiciatis, natus nihil consequuntur dolore debitis voluptates vel commodi animi veritatis!
              </p>
              <button className="btn btn-signup">Sign Up</button>
              <button className=" btn btn-details">Details</button>
          </div>
      </header>
        <section className="section section-ice-blue">
            <div className="container">
                <div className="row">
                    <div className="box">
                        <p>325</p>
                        <p>Course</p>
                    </div>
                    <div className="box">
                        <p>405</p>
                        <p>Work Out</p>
                    </div>
                    <div className="box">
                        <p>305</p>
                        <p>Working Hour</p>
                    </div>
                    <div className="box">
                        <p>705</p>
                        <p>Happy Client</p>
                    </div>
                </div>
            </div>
        </section>
    </>
    
  )
}

export default Header