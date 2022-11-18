import Llamada from './llamada'
import '../../styles/registrosLlamadas.css'
import { useEffect, useState } from 'react'
import { Navigate } from 'react-router-dom'
import { ThreeCircles } from 'react-loader-spinner'
const React = require('react')

export default function RegistrosLlamadas(props){
    
    let [llamadas, setLlamadas]= useState(<ThreeCircles color='grey'></ThreeCircles>)
    
    useEffect(()=>{
        getLlamados();
    }, [])

    const getLlamados = ()=>{
        fetch('https://oltec5.herokuapp.com/llamados')
            .then((response) => response.json())
            .then((data) => {
                let elements = [];
           
                data.forEach(llamada => {
                    elements.push(<Llamada NombreApellido={llamada.NombreApellido}
                        IdPaciente={llamada.Idpaciente} Emergencia={llamada.Emergencia} Horario={llamada.Inicio_llamado}/>);
                    });
                console.log(elements)
                let mainContainer = React.createElement("div", {},elements);
                console.log(mainContainer)
                setLlamadas(mainContainer)
                console.log(llamadas)
            });
    
        }

    if(!props.isLogged){
        Navigate('/')
        
    }else{
        return(
            <div>
                {llamadas}
            </div>
        )

    }

}