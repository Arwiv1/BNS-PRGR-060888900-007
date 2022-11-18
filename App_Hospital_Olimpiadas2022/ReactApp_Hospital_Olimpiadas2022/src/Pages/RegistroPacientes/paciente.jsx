import Llamada from "./llamada"
import { useEffect, useState } from 'react'
const React = require('react')

export default function Paciente(props){

    let [llamadas, setLlamadas]= useState()
    
    useEffect(()=>{
        getLlamadas();
    }, [])

    const getLlamadas = ()=>{
        fetch('https://oltec5.herokuapp.com/llamados/'+props.IdPaciente)
            .then((response) => response.json())
            .then((data) => {
                let elements = [];
           
                data.forEach(paciente => {
                    elements.push(<Llamada Emergencia={paciente.Emergencia}
                        Horario={paciente.Inicio_llamado}/>);
                    });
                let mainContainer = React.createElement("div", {},elements);
                console.log(mainContainer)
                setLlamadas(mainContainer)
            });
    
        }


    const verElemento = (e) =>{
        const contenido=e.target.parentElement.parentElement.querySelector(".contenido")
        console.log(contenido.className)
        if(contenido.className.includes("invisible")){
            contenido.classList.remove("invisible")
            e.target.classList.add("desplegado")
        }else{
            contenido.classList.add("invisible")
            e.target.classList.remove("desplegado")
        }
    }

    return(
        <div className="tarjeta_usuario">
        <div className="usuario">
            <p className="usuario_id">{props.IdPaciente}</p>
            <p className="usuario_id">{props.NombreApellido}</p>
            <div className="botonDesplegar" onClick={verElemento}>V</div>
        </div>
        <div className="contenido invisible">
            {llamadas}
        </div>
        </div>
    )
}