import * as React from "react";

const MainPage = () => {
  const [counter, setConter] = React.useState(3);


  const test = () => {
    let p = counter + Math.random();
    setConter(p);
  }

  return (
    <div style={{
      width: '900 px',
      margin: '0 auto',
      padding: '10 px',
      fontSize: '10 px',
    }}>Hamster coin:<span style={{ color: counter % 5 ? 'red' : 'blue'}}>{counter}</span>
    <button onClick={test}>Тапай хамяка</button>
    {
      counter % 5 ?
      null
      :
      <p>
        делится без остатка на 5
      </p>
    }
    </div>
  )
}

export default MainPage