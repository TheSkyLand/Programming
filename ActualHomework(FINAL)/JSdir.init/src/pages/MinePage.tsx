import * as React from 'react';


const MinePage = () => {
    const [counter, setCounter] = React.useState(50)

    const Click = () => {
        let p = counter + 50;
        setCounter(p);
    }
    return(
        <div>
            <span style={{color: counter % 3 ? 'black' : 'red'}}>Counter: {counter}</span>
            <button onClick={Click}>Increase Counter</button>
        </div>
    )
}


export default MinePage