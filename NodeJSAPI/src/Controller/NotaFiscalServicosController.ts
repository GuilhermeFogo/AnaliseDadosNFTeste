import {Request, Response} from 'express';
import NotaFiscalServicoDTO from '../DTO/NotaFiscalServicoDTO';
class NotaFiscalServicosController {
    public async  Listartudo(req : Request, res: Response): Promise<Response>{
        const array =[];
        const nota =  new NotaFiscalServicoDTO({
            id_nota:"0",
            cod_verificacao:"dhdhcdih",
            data: new Date(2022,12,17),
            numero:'445987',
            prestador_cpf_cnpj: "4587458500",
            prestador_endereco:"scsjicojc",
            prestador_incricao_municipal:"123654 d",
            prestador_municipio: "sss",
            prestador_nome_rz: "Guilherme_LTDA",
            prestador_uf:"SP",
            tomador_cpf_cnpj:"48721263",
            tomador_endereco: "shcudsihcuishcuidjidsjcidoscjidsocjdsicdjdcidsc",
            tomador_incricao_municipal:"scscuishcusihcu",
            tomador_municipio:"123654788963",
            tomador_nome_rz: "IPSEN",
            tomador_uf:"SP"
        })
        array.push(nota)
        return await res.send(array);
    }

    public async InserirNota(req: Request, res: Response): Promise<Response> {
        try {
            const item: NotaFiscalServicoDTO = req.body;

            return await res.status(201).send(item)

        } catch (error) {
            return await res.status(500).send(error)
        }
    }
}

export default new NotaFiscalServicosController();