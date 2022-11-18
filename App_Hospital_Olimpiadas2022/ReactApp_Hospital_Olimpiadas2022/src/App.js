import logo from './logo.svg';
import './App.css';
import Login from './Pages/Login/login';
import Header from './shared/header';
import RegistrosLlamadas from './Pages/RegistrosLlamadas/registrosLlamadas';
import RegistrosPacientes from './Pages/RegistroPacientes/registrosPacientes'
import { Route, Routes, useNavigate  } from 'react-router-dom';
import { useState, useEffect } from 'react';

function App() {

  const [header, setHeader] = useState('')

  const [isLogged, setIsLogged] = useState(false)

  useEffect(() => {
    if(isLogged===true){
      setHeader(Header)
    }
  })


  return (
    <>
    {header}
      <Routes>
        <Route path="/" element={<Login setIsLogged={setIsLogged} isLogged={isLogged} />}/>
        <Route path="/Llamadas" element={<RegistrosLlamadas isLogged={isLogged} />}/>
        <Route path="/Pacientes" element={<RegistrosPacientes isLogged={isLogged} />}/>
      </Routes>
    </>
  
  );
}

export default App;
