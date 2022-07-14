from src.Service.CapturaDados import CapituraDados
from src.Service.Arquivos import Arquivos


class Main:

    def main():
        continua = True
        while(continua):
            print("1 - Executar | 0-Sair")
            desicao = input("Descida")
            if(desicao == ""):
                print("Tente novamnte")
            elif(desicao == "0"):
                continua = False
                print("Saindo")
            elif (desicao == "1"):
                arquivo = Arquivos("notaFiscal.pdf")
                dadosNota = arquivo.LendoPDF()
                helperNota = CapituraDados(dadosNota)
                cnpj = helperNota.CapiturandoCNPJ()
                valorProduto = helperNota.CapiturandoValorTotalProduto()
                CEp = helperNota.CapiturandoCEP()
                print( "CNPJS: ",cnpj, " Valores:", valorProduto, "CEP:", CEp)
                print("Valor Produto:",valorProduto[0], "ICMS:", valorProduto[1], "Valor total nota:", valorProduto[2])
    if __name__ == '__main__':
        main()
