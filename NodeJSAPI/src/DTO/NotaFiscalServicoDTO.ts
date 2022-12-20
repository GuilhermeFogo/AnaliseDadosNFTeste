export default class NotaFiscalServicoDTO {
    private id_nota: string
    private numero: string;
    private data: Date;
    private cod_verificacao: string;
    //prestador
    private prestador_cpf_cnpj: string;
    private prestador_nome_rz: string;
    private prestador_endereco: string;
    private prestador_incricao_municipal: string;
    private prestador_municipio: string;
    private prestador_uf: string
    // tomador
    private tomador_cpf_cnpj: string;
    private tomador_nome_rz: string;
    private tomador_endereco: string;
    private tomador_incricao_municipal: string;
    private tomador_municipio: string;
    private tomador_uf: string

    constructor({ id_nota, numero, data, cod_verificacao, prestador_cpf_cnpj, prestador_nome_rz,
        prestador_endereco, prestador_incricao_municipal, prestador_municipio, prestador_uf,
        tomador_cpf_cnpj, tomador_nome_rz, tomador_endereco, tomador_incricao_municipal,
        tomador_municipio, tomador_uf }: {
            id_nota: string, numero: string, data: Date, cod_verificacao: string,
            prestador_cpf_cnpj: string, prestador_nome_rz: string, prestador_endereco: string, prestador_incricao_municipal: string,
            prestador_municipio: string, prestador_uf: string, tomador_cpf_cnpj: string,
            tomador_nome_rz: string, tomador_endereco: string, tomador_incricao_municipal: string,
            tomador_municipio: string, tomador_uf: string
        }) {
        this.id_nota = id_nota;
        this.numero = numero;
        this.data = data;
        this.cod_verificacao = cod_verificacao;
        this.prestador_cpf_cnpj = prestador_cpf_cnpj;
        this.prestador_endereco = prestador_endereco
        this.prestador_incricao_municipal = prestador_incricao_municipal;
        this.prestador_nome_rz = prestador_nome_rz;
        this.prestador_uf = prestador_uf;
        this.prestador_municipio = prestador_municipio;
        this.tomador_cpf_cnpj = tomador_cpf_cnpj;
        this.tomador_endereco = tomador_endereco;
        this.tomador_incricao_municipal = tomador_incricao_municipal;
        this.tomador_municipio = tomador_municipio;
        this.tomador_nome_rz = tomador_nome_rz;
        this.tomador_uf = tomador_uf;
    }



    public get Id_nota(): string {
        return this.id_nota
    }


    public get Numero(): string {
        return this.numero
    }

    public get Data(): Date {
        return this.data
    }

    public get Cod_Verificao(): string {
        return this.cod_verificacao
    }

    public get Prestador_CPF_CNPJ(): string {
        return this.prestador_cpf_cnpj
    }


    public get Prestador_Endereco(): string {
        return this.prestador_endereco;
    }

    public get Prestador_Incricao_Municipal(): string {
        return this.prestador_incricao_municipal
    }

    public get Prestador_Nome_rz(): string {
        return this.prestador_nome_rz;
    }

    public get Prestador_Municipio(): string {
        return this.prestador_municipio;
    }


    public get Tomador_Cpf_Cnpj(): string {
        return this.tomador_cpf_cnpj;
    }


    public get Tomador_Nome_rz(): string {
        return this.tomador_nome_rz;
    }


    public get Tomador_Endereco(): string {
        return this.tomador_endereco;
    }
    
    public get Tomador_Incricao_Municipal() : string {
        return this.tomador_incricao_municipal;
    }

    
    public get Tomador_Municipio() : string {
        return this.tomador_municipio;
    }
    
    
    public get Tomador_UF() : string {
        return this.tomador_uf
    }
    
}