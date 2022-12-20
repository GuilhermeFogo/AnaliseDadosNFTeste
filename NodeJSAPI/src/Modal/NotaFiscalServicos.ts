import { Tomador_PrestadorServico } from './Tomador_PrestadorServico';
export class NotaFiscalServico {
    private id_nota: string
    private numero: string;
    private data: Date;
    private cod_verificacao: string;
    private Tomador: Tomador_PrestadorServico;
    private Prestador: Tomador_PrestadorServico;


    constructor({ id_nota, numero, data, cod_verificacao, cpf_cnpj, nome_rz, endereco,
        incricao_municipal, municipio, uf }: {
            id_nota: string, numero: string, data: Date, cod_verificacao: string,
            cpf_cnpj: string, nome_rz: string, endereco: string, incricao_municipal: string,
            municipio: string, uf: string
        }) {
        this.id_nota = id_nota
            this.cod_verificacao = cod_verificacao;
        this.data = data;
        this.numero = numero;
        this.Prestador = new Tomador_PrestadorServico({
            cpf_cnpj: cpf_cnpj,
            endereco: endereco,
            incricao_municipal: incricao_municipal,
            municipio: municipio,
            nome_rz: nome_rz,
            uf: uf
        });
        this.Tomador = new Tomador_PrestadorServico({
            cpf_cnpj: cpf_cnpj,
            endereco: endereco,
            incricao_municipal: incricao_municipal,
            municipio: municipio,
            nome_rz: nome_rz,
            uf: uf
        })
    }

    
    public get Id_Nota() : string {
        return this.id_nota;
    }

    public get Numero() : string {
        return this.numero;
    }

    public get Data() : Date {
        return this.data;
    }

    public get Cod_Verifiador() : string {
        return this.cod_verificacao;
    }
    
    public get TomadorServico() : Tomador_PrestadorServico {
        return this.Tomador
    }
    public get PrestadorServico() : Tomador_PrestadorServico {
        return this.Prestador    }
}