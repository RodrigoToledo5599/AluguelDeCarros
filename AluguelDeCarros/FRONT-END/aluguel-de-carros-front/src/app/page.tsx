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




  return (
    <body>
      <Header></Header>
        <div className='page-Content'>
          <CarsCollection></CarsCollection>
        </div>
    </body>
    
  )
}
