import {Request, Response} from 'express';
class UsuarioController {
    public async  Listartudo(req : Request, res: Response): Promise<Response>{
        let a =["Guilherme", "Neide", "fernanda", "mariana"];
        return await res.send(a);
    }

    
}

export default new UsuarioController();