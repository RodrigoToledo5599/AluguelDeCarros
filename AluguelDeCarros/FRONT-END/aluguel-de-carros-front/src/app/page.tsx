"use client"
import React,{useState} from 'react';
import Header from './components/Header/Header'
import CarsCollection from './components/CarsCollection/CarsCollection';
import Cookies from 'universal-cookie';
import { CookiesProvider, useCookies } from "react-cookie";

//import 'bootstrap/dist/css/bootstrap.min.css';
import './page.css'
import { Cookie } from 'next/font/google';


export default function Home() {

  const cookies = new Cookies();
  
  var passo = 5;
  const [begin, setBegin] = useState(0);
  const [end, setEnd] = useState(begin + passo);

  // cookies.set("begin",begin);
  // cookies.set("end",end);

  function decreasePage (){
    if(begin < 0){
      setBegin(0);
    }
    else{
      setBegin(begin - passo);
      setEnd(end - passo);
      cookies.set("begin",begin);
      window.location.reload();
    }
  }

  function increasePage(){
    setBegin(begin + passo);
    setEnd(end + passo);
    cookies.set("end",end);
    window.location.reload();
  }




  return (
    <body>
      <Header></Header>
        <div className='page-Content'>
          <CarsCollection></CarsCollection>
          <button onClick={decreasePage}>voltar</button><br />
          <button onClick={increasePage}>prosseguir</button>
        </div>
    </body>
    
  )
}
