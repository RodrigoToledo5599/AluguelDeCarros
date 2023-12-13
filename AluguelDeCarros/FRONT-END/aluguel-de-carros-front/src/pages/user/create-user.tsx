import Header from './../../app/components/Header/Header';

import './create-user.css';



export default function CreateUser(){

    return(
        <div className="formzao">
            <form method="post" className="form-itself">

                <input type="text" name="email" placeholder="Email"/><br /><br />
                <input type="text" name="nome" placeholder="Nome"/><br /><br />
                <input type="password" name="senha " placeholder="Senha" />

            </form>
            <div className="ocupando-espaço"></div>
        </div>
    )


}

