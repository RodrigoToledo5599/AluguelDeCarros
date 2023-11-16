'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api"
import {Car} from './../CarOnMainMenu/CarOnMainMenu'

import './CarsCollection.css'
import React from 'react';




function CarsCollection (props){
    var comeco;
    var fim;
    var {comeco , fim} = props


    const url = BASE_URL+'api/MainPage/GetSomeOfTheCars?inicio='+`${comeco}`+'&fim='+`${fim}`;
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
            <div key={car.id} className='carMenu'>
                <table>

                    <tr>
                        {car.name}
                    </tr>

                    <tr>
                        {car.marca}
                    </tr>
                    <tr>
                        {car.valorDia}
                    </tr>
                
                </table>
                
            </div>
        ))}
        </>
    )
}

export default CarsCollection;