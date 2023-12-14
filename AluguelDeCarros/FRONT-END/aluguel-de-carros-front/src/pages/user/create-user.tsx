import Header from '../../app/components/Header/Header';
import {BASE_URL, api} from '../../api';
import {useState} from 'react';
import { FormEvent } from 'react'

import './create-user.css';
import { request } from 'http';

//https://localhost:7136/api/Authentication/register


export default function CreateUser(){
    const url = BASE_URL+'/api/Authentication/register';
    interface usuario{
        name: string
        password : string
        email: string
    }

    
    async function onSubmit() {
        const response = await api.post(url,{




        })
            .then((response) => console.log(response))
            .catch((error) => console.log(error)); 
        console.log("YEAHHHHHH LET'S GOOOOO")
      }




    return(
        <>
        <div className="formzao">
            <form className="form-itself" onSubmit={onSubmit}>

                <input  name="email" placeholder="Email"/> <br /><br />
                <input  name="name" placeholder="Nome"/> <br /><br />
                <input  name="password" placeholder="Senha" /> <br /><br />
                <button type="submit" >Enviar</button>

        
            </form>
            <div className="ocupando-espaço"></div>
        </div>
        </>
    )


}

