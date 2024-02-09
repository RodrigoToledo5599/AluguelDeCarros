'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api";
import './CarsCollection.css'
import React from 'react';
import Cookies from 'universal-cookie';




function CarsCollection (){
    const cookies = new Cookies();

    var passo = 5;
    const [cars,setCars] = useState([]);
    const [begin, setBegin] = useState(0);
    const [end, setEnd] = useState(begin + passo);
    const url = BASE_URL+'api/MainPage/GetSomeOfTheCars?inicio='+`${begin}`+'&fim='+`${end}`;
    
    function decreasePage (){
        if(begin <= 0){}
        else{
          setBegin(begin - passo);
          setEnd(end - passo);
          // cookies.set("begin",begin);
        }
      }
    
      function increasePage(){
        setBegin(begin + passo);
        setEnd(end + passo);
        // cookies.set("end",end);
      }
    
    useEffect(()=>{
        api.get(url)
        .then(response =>{
            setCars(response.data)
        })
        



    },[]);


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

        <p>
        {begin}<br/>{end}
        </p>
        <button onClick={decreasePage}>voltar</button><br />
        <button onClick={increasePage}>prosseguir</button>
        </>
    )
}

export default CarsCollection;