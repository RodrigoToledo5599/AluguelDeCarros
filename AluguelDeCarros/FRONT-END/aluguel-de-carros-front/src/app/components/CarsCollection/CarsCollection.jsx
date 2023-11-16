'use client'
import {useEffect,useState} from 'react';
import { BASE_URL, api } from "../../../api"
import {Car} from './../CarOnMainMenu/CarOnMainMenu'

import './CarsCollection.css'
import React from 'react';




function CarsCollection (){
    const url = BASE_URL+'api/MainPage/GetAllCars';
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
                        {car.id}    
                    </tr>

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