export default function Llamada(props){

    const ponerTipo=()=>{
        let valor='Regular'
        if(props.Emergencia===1){
            valor='Emergencia'
        }
        return valor
    }
    const ponerHorario =()=>{
        return props.Horario.substring(0, 5);
    }

    return(
        
        <div className="paciente_llamada">
            <p className="paciente_llamada_tipo">{ponerTipo()}</p>
            <p className="paciente_llamada_hora">{ponerHorario()}</p>
        </div>
    )
}