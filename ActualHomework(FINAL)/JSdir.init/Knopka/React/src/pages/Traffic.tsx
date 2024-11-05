import React from "react";
import TrafficLights from "../components/TrafficLights";

const Traffic = () => {

    return (<div>
        <TrafficLights 
        color="red"/>
                <TrafficLights 
        color="yellow"/>
                <TrafficLights 
        color="green"/>

    </div>
    )
}

export default Traffic;