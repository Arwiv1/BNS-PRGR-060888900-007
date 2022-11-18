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
        <div className="llamada">
            <p className="llamada_id">{props.IdPaciente}</p>
            <p className="llamada_nombre">{(props.NombreApellido)}</p>
            <p className="llamada_tipo">{ponerTipo()}</p>
            <p className="llamada_hora">{ponerHorario()}</p>
        </div>
    )
}