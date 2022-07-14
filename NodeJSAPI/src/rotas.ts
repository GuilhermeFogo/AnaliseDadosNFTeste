import { Router } from "express";
import UsuarioController from "./Controller/UsuarioController";

const MinhasRotas = Router();

// Usuario
MinhasRotas.get("/api/UsuarioControler", UsuarioController.Listartudo);

export default MinhasRotas;