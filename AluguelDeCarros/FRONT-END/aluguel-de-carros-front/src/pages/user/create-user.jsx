import {BASE_URL, api} from '../../api';
import React,{useState} from 'react';
import './create-user.css';


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

    const submitForm = async(e) => {
        e.preventDefault();
        const response = await fetch(url, {
            method:'POST',
            headers: { 'Content-Type': 'application/json'},
            body: JSON.stringify(formData)
        });
    }
        
    return(
        <>
        <div className="formzao">
            <form className="form-itself" onSubmit={submitForm}>
                <h3>Create Account</h3>
                <br />

                <input id="email" name="email" placeholder="E-mail"  onChange={(e) => setEmail(e.target.value)} /> <br /><br />
                <input id="name" name="name" placeholder="Nome"  onChange={(e) => setName(e.target.value)}/> <br /><br />
                <input id="password" name="password" placeholder="Senha" onChange={(e) => setPassword(e.target.value)} type="password"/> <br /><br />

                <button type="submit" >Enviar</button>
        
            </form>
        </div>
        </>
    )
};

