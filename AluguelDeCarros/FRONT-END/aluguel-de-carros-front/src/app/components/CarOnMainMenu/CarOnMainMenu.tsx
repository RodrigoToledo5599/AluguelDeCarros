'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api"

type Carro = {
  id: number;
  name: string;
  marca: number;
  alugado: boolean;
  valordia: number

}





export default function CarOnMainMenu({id} : Carro) {

  const [cars , setCars] = useState<Carro>();

  useEffect(() => {
    api.get(BASE_URL+'api/MainPage/ReturnCarById?id='+`${id}`)
      .then(resposta =>{
        setCars(resposta.data)
      })
  }, [])


  const checkAlugado = async () =>
  {
    if(cars?.alugado == false){
      return(
        <p>livre</p>
      )
    }
    else{
      <p>alugado</p>
    }
  }


    return (
      <div>
        
        <p>{cars?.name}</p>
        <p>{cars?.marca}</p>
        {checkAlugado()}
        <p>{cars?.name}</p>
      </div>
    )
  }
