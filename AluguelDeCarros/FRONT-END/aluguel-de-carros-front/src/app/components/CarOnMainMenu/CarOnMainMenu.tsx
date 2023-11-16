
'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api"
import React from 'react';

import './CarOnMainMenu.css'

type Carro = {
  id: number;
  name: string;
  marca: number;
  alugado: boolean;
  valorDia: number;

}


type whatever ={
  text: string;
}




export default function CarOnMainMenu({id} : Carro,) {

  const [car , setCar] = useState<Carro>();

  useEffect(() => {
    api.get(BASE_URL+'api/MainPage/ReturnCarById?id='+`${id}`)
      .then(resposta =>{
        setCar(resposta.data)
      })
  },)

  var Textin = "";
  

  return (
    <div key={car?.id} className='CarIcon'>
      <a href=''>
        <div className='CarInfo'>
          
          {car?.name}<br/>
          {car?.marca}<br/>
          {car?.valorDia}<br/>
        </div>
        

      </a>
      </div>
      
      
  )
}
