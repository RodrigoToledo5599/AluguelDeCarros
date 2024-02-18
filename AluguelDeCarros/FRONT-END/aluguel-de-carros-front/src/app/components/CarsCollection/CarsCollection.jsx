'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api";
import './CarsCollection.css'
import React from 'react';
import Cookies from 'universal-cookie';




function CarsCollection (){

    const url = BASE_URL+'api/MainPage/GetAllCars';
    const cookies = new Cookies();

    const passo = 8;
    const [begin,setBegin] = useState(0);
    const [end,setEnd] = useState(begin + passo);
    const [cars,setCars] = useState([]);
    
    function decreasePage (){
        if(begin > 0)
        {
            
            setBegin(begin - passo);
            setEnd(end - passo);
        }
    }
    
    function increasePage(){
        
        setBegin(begin + passo);
        setEnd(end + passo);
    }
    
    useEffect(()=>{
        api.get(url)
        .then(response =>{
            setCars(response.data)
            // setCars(response.data.slice(begin,end))
        })

    },[]);

    return(
        <>
        {cars.map(car =>(
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

        
        {/* <button onClick={increasePage}>prosseguir</button>
        <button onClick={decreasePage}>voltar</button><br /> */}
        </>
    )
}

export default CarsCollection;