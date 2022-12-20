export class Tomador_PrestadorServico {
    private cpf_cnpj: string;
    private nome_rz: string;
    private endereco: string;
    private incricao_municipal: string;
    private municipio: string;
    private uf:string

    constructor({ cpf_cnpj, nome_rz, endereco, incricao_municipal, municipio, uf}:
        { cpf_cnpj: string, nome_rz: string, endereco: string, incricao_municipal: string, 
            municipio: string, uf:string }) {
        this.cpf_cnpj = cpf_cnpj;
        this.endereco = endereco;
        this.incricao_municipal = incricao_municipal;
        this.nome_rz = nome_rz;
        this.municipio = municipio;
        this.uf =uf
    }

    public get CPF_CNPJ(): string {
        return this.cpf_cnpj;
    }

    public get Nome_RZ(): string {
        return this.nome_rz;
    }

    public get Endereco(): string {
        return this.endereco
    }
    public get Inscricao_municipal(): string {
        return this.incricao_municipal
    }


    public get Municipio(): string {
        return this.municipio
    }
    
    public get UF() : string {
        return this.uf
    }
    
}