'use client'
import {useEffect} from 'react';
import { BASE_URL, api } from "./../../../api"
import axios from 'axios';






export default function TryingToFetchData({idCarro}) {
  var url = BASE_URL;
  useEffect(() => {
    api.get(BASE_URL+'api/MainPage/ReturnCarById?id='+`${idCarro}`)
      .then(resposta =>{
        console.log(resposta.data)
      })
  }, [])


    return (
      <div>
       
        <p>resposta.data.name</p>
      </div>
    )
  }
