import "./App.css";
import { useState } from "react";

function App() {
  return (
    <div className="App">
      <Counter />
    </div>
  );
}

function Counter() {
  const [step, setStep] = useState(1);
  const [count, setCount] = useState(0);

  function addStep() {
    setStep((s) => s + 1);
  }
  function maStep() {
    setStep((s) => s - 1);
  }

  function addCount() {
    setCount((c) => c + step);
  }
  function maCount() {
    setCount((c) => c - step);
  }

  return (
    <>
      <div>
        <button onClick={maStep}>-</button>
        <span>
          <strong>Step: {step}</strong>
        </span>
        <button onClick={addStep}>+</button>
      </div>
      <div>
        <button onClick={maCount}>-</button>
        <span>
          <strong>Count: {count}</strong>
        </span>
        <button onClick={addCount}>+</button>
      </div>
      <Datestring count={count} />
    </>
  );
}

function Datestring({ count }) {
  const date = new Date();
  date.setDate(date.getDate() + count);

  let dateString;
  if (count === 0) {
    dateString = `Today is ${new Date().toDateString()}`;
  } else if (count < 0) {
    dateString = `${count} days ago was ${date.toDateString()}`;
  } else {
    dateString = `${count} days from today is ${date.toDateString()}`;
  }

  return (
    <div>
      <p>
        <strong>{dateString}</strong>
      </p>
    </div>
  );
}

export default App;
