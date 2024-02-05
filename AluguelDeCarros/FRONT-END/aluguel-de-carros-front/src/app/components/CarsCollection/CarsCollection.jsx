'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api";
import './CarsCollection.css'
import React from 'react';
import Cookies from 'universal-cookie';




function CarsCollection (){
    const cookies = new Cookies();
    // var begin;
    // var end;
    // var {begin,end} = props;

    const url = BASE_URL+'api/MainPage/GetSomeOfTheCars?inicio='+`${cookies.get('begin')}`+'&fim='+`${cookies.get('end')}`;
    const [cars,setCars] = useState([]);
    
    
    
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
        {cookies.get('begin')}<br></br>
        {cookies.get('end')}
        </>
    )
}

export default CarsCollection;