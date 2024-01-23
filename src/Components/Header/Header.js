import React from "react";
import '../Header/Header.css'
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faMagnifyingGlass } from "@fortawesome/free-solid-svg-icons";
export function Header(){
    return(
        <>
        <div className="d-lg-flex  m-5">
         <div className="header col-5 w-75">
        <img src={require('../Header/logo.PNG')} className='col-6 col-sm-12 col-lg-8 header text-center'  alt="carasol-1"/>
        </div>
        
        <div className="d-flex mt-5">
        <div>
            <input placeholder="  Search......." type="text"></input>

        </div>
        <div className="search"><button>
        <FontAwesomeIcon icon={faMagnifyingGlass} /></button>
        </div>
        </div>
        </div>



       
       

 <hr></hr>


<div>
<div id="carouselExampleInterval" className="carousel slide" data-bs-ride="carousel">
  <div className="carousel-inner">
    <div className="carousel-item active" data-bs-interval="1000">
      <img src={require('../Header/caroselone.PNG')} className="d-block w-100" alt="..."/>
    </div>
    <div className="carousel-item" data-bs-interval="2000">
      <img src={require('../Header/caroseltwo.PNG')} className="d-block w-100" alt="..."/>
    </div>
  </div>
  <button className="carousel-control-prev" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="prev">
    <span className="carousel-control-prev-icon" aria-hidden="true"></span>
    <span className="visually-hidden">Previous</span>
  </button>
  <button className="carousel-control-next" type="button" data-bs-target="#carouselExampleInterval" data-bs-slide="next">
    <span className="carousel-control-next-icon" aria-hidden="true"></span>
    <span className="visually-hidden">Next</span>
  </button>
</div>

</div>

        </>
    );
}