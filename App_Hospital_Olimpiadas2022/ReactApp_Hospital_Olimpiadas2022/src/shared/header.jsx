import Hamburger from 'hamburger-react'
import { Link } from "react-router-dom";
import { Squash } from 'hamburger-react'
import '../styles/header.css'

export default function Header(){

    const openHamburguer = (e)=>{
        const links = document.querySelector(".links")
        console.log(links)
        if(links.className.includes("invisible")){
            links.classList.remove("invisible")
        }else{
            links.classList.add("invisible")
        }
    }

    return(
        <div className='header'>
            <div onClick={openHamburguer}>
            <Squash className='menu'></Squash>

            </div>
            <ul className='links invisible'>
                
                <li>
                    <Link to='/Llamadas'>Llamadas</Link>
                </li>
                <li>
                    <Link to='/Pacientes'>Pacientes</Link>
                </li>
                
            </ul>
        </div>
    )
}