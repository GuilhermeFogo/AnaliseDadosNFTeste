import  express, { Application, Express, Router } from "express";
import MinhasRotas from "../src/rotas"
export class StartAPI {
    public server: Application;
    constructor() {
        this.server = express();
        this.Middware();
        this.rotas(MinhasRotas);
    }

    private Middware(){
        this.server.use(express.json());
    }

    private rotas(rota: Router){
        this.server.use(rota)
    }
}