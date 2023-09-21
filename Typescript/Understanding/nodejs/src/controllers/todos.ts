import { RequestHandler } from "express";
import { todo } from "../models/todo";

const Toto: todo[] = [];

export const createTodo: RequestHandler = (req, res, next) => {
  const text = (req.body as { text: string }).text;
  const newTodo = new todo(Math.random().toString(), text);
  Toto.push(newTodo);

  res.status(201).json({ message: "Create", newTodo: newTodo });
};

export const updateTodo: RequestHandler<{ id: string }> = (req, res, next) => {
  const todoId = req.params.id;
  const updateText = (req.body as { text: string }).text;

  res.status(201).json({ message: "Create", newTodo: updateText });
};
