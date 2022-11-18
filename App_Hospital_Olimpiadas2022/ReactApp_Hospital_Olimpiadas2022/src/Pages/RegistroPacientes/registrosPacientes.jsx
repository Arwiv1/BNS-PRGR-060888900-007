import Paciente from './paciente'
import '../../styles/registrosPacientes.css'
import { useEffect, useState } from 'react'
import { Navigate } from 'react-router-dom'
import { ThreeCircles } from 'react-loader-spinner'
const React = require('react')

export default function RegistrosPacientes(props){

    let [pacientes, setPacientes]= useState(<ThreeCircles color='grey'></ThreeCircles>)
    
    useEffect(()=>{
        getPacientes();
    }, [])

    const getPacientes = ()=>{
        fetch('https://oltec5.herokuapp.com/pacientes')
            .then((response) => response.json())
            .then((data) => {
                let elements = [];
           
                data.forEach(paciente => {
                    elements.push(<Paciente NombreApellido={paciente.NombreApellido}
                        IdPaciente={paciente.Idpaciente}/>);
                    });
                let mainContainer = React.createElement("div", {},elements);
                console.log(mainContainer)
                setPacientes(mainContainer)
            });
    
        }

    if(!props.isLogged){
        Navigate('/')
        
    }else{
        return(
            <div>
                {pacientes}
            </div>
        )

    }

}