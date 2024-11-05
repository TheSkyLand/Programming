import React from "react"

interface TrafficLightsProps{
    color: string;
}


const TrafficLights = ({color} : TrafficLightsProps) => {

        return(    <div style={{
            width: '100px',
            height: '100px',
            border: '1px solid',
            borderRadius: '50%',
            margin: '5px 5px 5px 20px',
            backgroundColor: color
        }}></div>)
}

export default TrafficLights