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
  const [count, setCount] = useState(0);
  const [step, setStep] = useState(1);

  function addCount() {
    setCount((c) => c + step);
  }
  function maCount() {
    setCount((c) => c - step);
  }

  function handleChangeRange(value) {
    setStep(Number(value));
  }

  function handleChangeCount(value) {
    setCount(Number(value));
  }

  function handleResetData() {
    setCount(0);
    setStep(1);
  }

  return (
    <>
      <input
        type="range"
        min="0"
        max="10"
        value={step}
        onChange={(e) => handleChangeRange(e.target.value)}
      />
      <span>{step}</span>

      <div>
        <button onClick={maCount}>-</button>
        <input
          type="text"
          value={count}
          onChange={(e) => handleChangeCount(e.target.value)}
        />
        <button onClick={addCount}>+</button>
      </div>
      <Datestring count={count} />
      {(count !== 0 || step !== 1) && (
        <div>
          <input type="button" value="Reset" onClick={handleResetData} />
        </div>
      )}
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
