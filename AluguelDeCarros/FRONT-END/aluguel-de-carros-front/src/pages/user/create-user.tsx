import Header from './../../app/components/Header/Header';





export default function CreateUser(){

    return(
        <form method="post">

            <input type="text" name="email" placeholder="Email"/><br /><br />
            <input type="text" name="nome" placeholder="Nome"/><br /><br />
            <input type="password" name="senha " placeholder="Senha" />
                        
        </form>
    )


}

