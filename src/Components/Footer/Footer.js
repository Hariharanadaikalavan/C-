import React from "react";
import '../Footer/Footer.css'
import { FooterAbout } from "../FooterAbout/FooterAbout";
import { Link } from "react-router-dom";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faInstagram,faTwitter } from '@fortawesome/free-brands-svg-icons';
import { faFacebook,faYoutube } from '@fortawesome/free-brands-svg-icons';



export function Footer(){
    return(
        <>
      
      <div id="Footerfirsthalf" className='d-flex flex-column justify-content-center align-items-center col-12'>
                        <div><h1 className='text-light px-5'>Get Started with infrastructure <h1 className="text-center">and</h1> sustainable industrialization</h1></div>
                      
          </div>
 {/* ============================================================================================= */}

          <div id="Footersecondhalf" className="text-center">


<div className="d-lg-flex text-light justify-content-lg-around ">
          <div id="about" className='pt-4 p-2'><button className='btn text-light'><h2>About </h2><p>What's behind the boards</p></button></div>
          <div id="about" className='pt-4 p-2'><button className='btn text-light'><h2>PUBLICATIONS</h2><p>Learn about open roles on the <br/>Trello team</p></button></div>
          <div id="about" className='pt-4 '><button className='btn text-light'><h2>EVENTS</h2><p>Download the Trello App for your <br/>Desktop or Mobile devices</p></button></div>
         <div id="about" className='pt-4 p-2'><button className='btn text-light'><h2>CONTACT US</h2><p>Need anything?Get in touch and <br/>we can help</p></button></div>
</div>


 {/* ============================================================================================= */}
 
 <div style={{ borderTop: "2px solid #fff ", marginLeft: 20, marginRight: 20 }}></div>
 
       {/* ============================================================================================= */}


          <div className='d-lg-flex justify-content-lg-evenly text-start  p-1   '>
          <div className='d-lg-flex text-light gap-5 p-2 '>
                {/* <div><FontAwesomeIcon icon={faGlobe} flip /> English <select><option></option><option>Tamil</option><option>English</option></select></div>   */}
              <div><button className='btn text-light'>Privacy Policy</button></div>
               <div><button className='btn text-light'>Terms</button></div>
                <div><button className='btn text-light'>Copyright&copy;Hariharan Adaikkalavan</button></div>
          </div>
          
        
          <div className='d-lg-flex gap-5  d-flex justify-content-center p-2'>  
                          <div className='fs-1' id="instaicon"><a href="https://www.instagram.com/TheGlobalGoals/" className='text-white'><FontAwesomeIcon icon={faInstagram}  /></a><h6 id="instatxt" className='bg-dark text-light p-2'>Instagram</h6></div>
                         <div className='fs-1 text-white' id="faceicon"><a href="https://www.facebook.com/theglobalgoals" className='text-white'><FontAwesomeIcon icon={faFacebook}  /></a><h6 id="facetxt" className='bg-dark text-light p-2'>Facebook</h6></div>
                         <div className='fs-1 text-white' id="twiticon"><a href="https://twitter.com/TheGlobalGoals" className='text-white'><FontAwesomeIcon icon={faTwitter}  /></a><h6 id='twitxt' className='bg-dark text-light p-2'> Twitter</h6></div>
                         <div className='fs-1 text-white' id="youicon"><a href="https://www.youtube.com/channel/UCRfuAYy7MesZmgOi1Ezy0ng" className='text-white'><FontAwesomeIcon icon={faYoutube}  /></a><h6 id="youtxt"className='bg-dark text-light p-2'>Youtube</h6></div>
          </div>
          </div>
{/* ================================================================================================= */}
    </div>
        </>
    );
}