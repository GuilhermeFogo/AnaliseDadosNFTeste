export class Usuario {
    readonly Id_user: string;
    readonly Nome: string;
    readonly Senha: string;
    readonly Role: string

    constructor({ id, nome, senha, role }: { id: string, nome: string, senha: string, role: string }) {
        this.Id_user = id;
        this.Nome = nome;
        this.Role = role;
        this.Senha = senha;
    }
}