import Header from '../../app/components/Header/Header';
import {BASE_URL, api} from '../../api';
import {useState} from 'react';
import { FormEvent } from 'react'

import './create-user.css';
import { request } from 'http';

//https://localhost:7136/api/Authentication/register


export default function CreateUser(){
    const url = BASE_URL+'api/Authentication/register';
    
    
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const formData = {
        "email": email,
        "name": name,
        "password": password
    }

    const formData2 = {
        "email": "machoalfa@gmaiadqwwqwl.com",
        "name": "Rodrigo Toledo ",
        "password": "fDs1@yp"
    }

    const submitForm = async(e) => {
        e.preventDefault();
        const response = await fetch(url, {
            method:'POST',
            headers: { 'Content-Type': 'application/json'},
            body: JSON.stringify(formData2)
        });
    }
        
    
    
    return(
        <>
        <div className="formzao">
            <form className="form-itself" onSubmit={submitForm}>

                <input id="email" name="email" placeholder="Email"  onChange={(e) => setEmail(e.target.value)} /> <br /><br />

                <input id="name" name="name" placeholder="Nome"  onChange={(e) => setName(e.target.value)}/> <br /><br />
                
                <input id="password" name="password" placeholder="Senha" onChange={(e) => setPassword(e.target.value)} type="password"/> <br /><br />
                

                <button type="submit" >Enviar</button>
        
            </form>
            <div className="ocupando-espaço"></div>
        </div>
        </>
    )
    
};

