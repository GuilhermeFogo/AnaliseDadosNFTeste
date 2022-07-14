import express from 'express';
import { StartAPI } from './index';

const app = new StartAPI();

app.server.listen(8080,()=>{
  console.log("Funcionando na porta 8080");
});