import React, { useState, useEffect } from 'react';
import { useNavigate } from "react-router-dom";
import Plotly from "react-plotly.js"

const container = {
    margin: '100px',
    padding: '100px',
    cursor: 'pointer',
    display: 'inline-block',
    borderRadius: '5px',
    width: '100px',
    height: '100px',
    border: '1px solid black',
    background: 'red'
}
const Click = () => {
    const navigate = useNavigate();
    return (
        <div>
            <div>the page created in from 2024 to {new Date().getFullYear()}</div>
            <button style={container} onClick={() => navigate("/plotly2d")}>2D</button>
            <button style={container} onClick={() => navigate("/plotly3d")}>3D</button>
        </div>
    )
}

export default Click
