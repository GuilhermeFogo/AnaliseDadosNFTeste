import { Router } from "express";
import UsuarioController from "./Controller/UsuarioController";
import NotaFiscalServicosController from './Controller/NotaFiscalServicosController';

const MinhasRotas = Router();

// Usuario
MinhasRotas.get("/api/UsuarioControler", UsuarioController.Listartudo);

//nota fical
MinhasRotas.post("/api/NotaFiscalServico",NotaFiscalServicosController.InserirNota)
MinhasRotas.get("/api/NotaFiscalServico",NotaFiscalServicosController.Listartudo)
  
export default MinhasRotas;