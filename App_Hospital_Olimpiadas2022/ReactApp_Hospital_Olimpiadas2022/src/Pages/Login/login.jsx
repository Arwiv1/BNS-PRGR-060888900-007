import { useEffect, useState } from 'react'
import '../../styles/login.css'
import {useNavigate  } from 'react-router-dom';

export default function Login(props){

    const navigate = useNavigate()

    const [usuario, setUsuario]=useState('')

    const [contrasena, setContrasena]=useState('')

    const [error, setError]= useState('')
    
    const confirmar = (e) =>{
        e.preventDefault()
        fetch(`https://oltec5.herokuapp.com/usuarios/${usuario}/${contrasena}`)
        .then((response) => response.json())
        .then((data) => {
            console.log(data)
            if(data===true){
                navigate("/Llamadas")
                props.setIsLogged(true);
            }else{
                setError(<p className='error'>Usuario o contraseña incorrectos</p>)
            }
            });
        }

    return(
        <div>
            <h1 className="title_login">Bienvenido al registro de llamadas hospitalarias</h1>
            <form className='login_form' action="" onSubmit={confirmar}>
                <label className="label_usuario" htmlFor="">Usuario</label>
                <input className="input_usuario" onInput={(e) => setUsuario(e.target.value)} type="text" name="" id="" />
                <label className="label_contraseña" htmlFor="">Contraseña</label>
                <input className="input_contraseña" onInput={(e) => setContrasena(e.target.value)} type="text" name="" id="" />
                <button className='submit_login_form' type="submit">Confirmar</button>
            </form>
            {error}
        </div>
    )
}