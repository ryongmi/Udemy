import express, { Request, Response, NextFunction } from "express";
import todosRouter from "./routes/todos.js";

const app = express();

app.use("/todos", todosRouter);

app.use((error: Error, req: Request, res: Response, next: NextFunction) => {
  res.status(500).json({ message: error.message });
});

app.listen(3000);
