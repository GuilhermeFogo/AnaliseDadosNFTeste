class Endereco {
    readonly Id_endereco:string
    readonly Rua: string;
    readonly CEP: string;
    readonly Complemento: string;
    readonly Bairro: string;
    readonly Cidade: string;
    constructor({id, rua, cep, complemento, bairro, cidade}: {id: string, rua: string, cep: string, complemento: string
    bairro: string, cidade: string}) {
        this.Bairro = bairro;
        this.CEP = cep;
        this.Cidade = cidade;
        this.Complemento = complemento;
        this.Id_endereco = id;
        this.Rua = rua
    }
}