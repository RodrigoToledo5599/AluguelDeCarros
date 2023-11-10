'use client'
import {useEffect} from 'react';
import { BASE_URL, api } from "./../../../api"
import axios from 'axios';






export default function TryingToFetchData() {
    
  useEffect(() => {
    axios.get('https://localhost:7136/api/MainPage/ReturnCarById?id=5')
      .then(resposta =>{
        console.log(resposta.data)
      })
  }, [])


    return (
      <div>
       
        <p>data.marca</p>
      </div>
    )
  }
