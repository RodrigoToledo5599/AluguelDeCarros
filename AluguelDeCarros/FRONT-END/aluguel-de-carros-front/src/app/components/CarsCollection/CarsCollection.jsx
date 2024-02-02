'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api";
import './CarsCollection.css'
import React from 'react';




function CarsCollection (){
    
    const passo = 5;
    const [begin, setBegin] = useState(0);
    const [end, setEnd] = useState(passo);
    
    const url = BASE_URL+'api/MainPage/GetSomeOfTheCars?inicio='+`${begin}`+'&fim='+`${end}`;
    const [cars,setCars] = useState([]);
    
    
    
    useEffect(()=>{
        api.get(url)
        .then(response =>{
            setCars(response.data)
        })    
    },[]);
    

    function decreasePage (){
        if(begin == 0){
          passo == passo;
        }
        else{
          window.location.reload();
          setBegin(begin - passo);
          setEnd(end - passo);
        }
      }
    
      function increasePage(){
        window.location.reload();
        setBegin(begin + passo);
        setEnd(end + passo);
      }


    return(
        <>
        {cars.map( car =>(
            <div key={car.id} className='carIcon'>
                <div className='pictureSpace'>
                    <p>espaço reservado futuramente para as imagens</p>
                </div>
                <div className='carInfo'>
                    <table>
                        <tr>
                            {car.name}
                        </tr>

                        <tr>
                            {car.marca}
                        </tr>
                        <tr>
                           R$ {car.valorDia}/dia
                        </tr>
                        <tr>
                            <button className='alugarButton'>
                                <h1>ALUGAR</h1>
                            </button>

                        </tr>
                    </table>
                </div>
            </div>
        ))}
        {begin} <br />
        {end}
        <button onClick={decreasePage}>voltar</button><br />
        <button onClick={increasePage}>prosseguir</button>
        </>
    )
}

export default CarsCollection;