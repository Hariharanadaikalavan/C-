import React from 'react';
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap/dist/js/bootstrap'

import { Footer } from './Components/Footer/Footer';
import { Header } from './Components/Header/Header';
import { FooterAbout } from './Components/FooterAbout/FooterAbout';
import { BrowserRouter,Routes,Route } from 'react-router-dom';

function App() {
  return (
    <>


    {/* <BrowserRouter>
        <Routes>
            <Route path="/About" element={<FooterAbout/>}>

            </Route>
        </Routes>
    </BrowserRouter> */}
    <Header></Header>
    <Footer></Footer>
   

    </>
  );
}

export default App;
