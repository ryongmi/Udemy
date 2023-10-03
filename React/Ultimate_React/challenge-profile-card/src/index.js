import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./styles.css";

function App() {
  return (
    <div className="card">
      <Avatar />
      <div className="data">
        <Intro />
        {/* Should contain one Skill component
        for each web dev skill that you have,
        customized with props */}
        <SkillList />
      </div>
    </div>
  );
}

function Avatar() {
  return <img className="avatar" src="ori.jpg" alt="ori" />;
}

function Intro() {
  return (
    <div>
      <h1>123</h1>
      <p>456</p>
    </div>
  );
}

function SkillList() {
  return (
    <div className="skill-list">
      <Skill name="HTML" img="☆" backColor={{ backgroundColor: "blue" }} />
      <Skill name="CSS" img="◆" backColor={{ backgroundColor: "red" }} />
      <Skill name="JS" img="★" backColor={{ backgroundColor: "yellow" }} />
    </div>
  );
}

function Skill(props) {
  return (
    <div className="skill" style={props.backColor}>
      <span>{props.name}</span>
      <span>{props.img}</span>
    </div>
  );
}

const rootElement = document.getElementById("root");
const root = createRoot(rootElement);

root.render(
  <StrictMode>
    <App />
  </StrictMode>
);
