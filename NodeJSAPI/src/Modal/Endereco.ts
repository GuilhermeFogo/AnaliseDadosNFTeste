class Endereco {
    private readonly id_endereco:string
    private readonly rua: string;
    private readonly cep: string;
    private readonly complemento: string;
    private readonly bairro: string;
    private readonly cidade: string;
    private readonly estado: string;
    
    constructor({id, rua, cep, complemento, bairro, cidade, estado}: {id: string, rua: string, cep: string, complemento: string
    bairro: string, cidade: string, estado:string}) {
        this.bairro = bairro;
        this.cep = cep;
        this.cidade = cidade;
        this.complemento = complemento;
        this.id_endereco = id;
        this.rua = rua;
        this.estado = estado;
    }

    
    public get Estado() : string {
        return this.estado; 
    }

    public get Bairro() : string {
        return this.bairro; 
    }

    
    public get Rua() : string {
        return this.rua;
    }
    
    
}