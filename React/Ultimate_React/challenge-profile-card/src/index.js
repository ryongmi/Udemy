import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./styles.css";

const skills = [
  {
    skill: "HTML+CSS",
    level: "advanced",
    color: "#2662EA",
  },
  {
    skill: "JavaScript",
    level: "advanced",
    color: "#EFD81D",
  },
  {
    skill: "Web Design",
    level: "advanced",
    color: "#C3DCAF",
  },
  {
    skill: "Git and GitHub",
    level: "intermediate",
    color: "#E84F33",
  },
  {
    skill: "React",
    level: "advanced",
    color: "#60DAFB",
  },
  {
    skill: "Svelte",
    level: "beginner",
    color: "#FF3B00",
  },
];

const emoji = {
  advanced: "☆",
  intermediate: "◆",
  beginner: "★",
};

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
      {skills.map((skill) => (
        <Skill skillObj={skill} key={skill.skill} />
      ))}
      {/* 
      <Skill name="HTML" img="☆" backColor={{ backgroundColor: "blue" }} />
      <Skill name="CSS" img="◆" backColor={{ backgroundColor: "red" }} />
      <Skill name="JS" img="★" backColor={{ backgroundColor: "yellow" }} /> */}
    </div>
  );
}

function Skill(props) {
  return (
    <div className="skill" style={{ backgroundColor: props.skillObj.color }}>
      <span>{props.skillObj.skill}</span>
      <span>
        {emoji[props.skillObj.level]}
        {/* {skillObj.level === "advanced"
          ? "☆"
          : skillObj.level === "intermediate"
          ? "◆"
          : "★"} */}
      </span>
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
