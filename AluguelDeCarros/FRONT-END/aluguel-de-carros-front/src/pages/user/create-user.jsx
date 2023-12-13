import Header from '../../app/components/Header/Header';
import {BASE_URL, api} from '../../api';

import './create-user.css';

//https://localhost:7136/api/Authentication/register


export default function CreateUser(){
    const url = BASE_URL+'/api/Authentication/register';





    return(
        <div className="formzao">
            <form method="post" className="form-itself" id="myForm">

                <input type="text" name="email" placeholder="Email"/> <br /><br />
                <input type="text" name="nome" placeholder="Nome"/> <br /><br />
                <input type="password" name="senha " placeholder="Senha" /> <br /><br />
                <button type="submit">Enviar</button>

            </form>
            <div className="ocupando-espaço"></div>
        </div>
    )


}

