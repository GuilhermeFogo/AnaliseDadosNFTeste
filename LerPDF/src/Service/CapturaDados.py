import re


class CapituraDados:
    page_content: str

    def __init__(self, conteudo):
        self.page_content = conteudo


    def CapiturandoValorTotalProduto(self):
        txt = self.page_content
        regex = "[0-9]{0,2}[.]?[0-9]{3},[0-9]{2}"
        matchs = re.findall(regex, txt)
        valor = matchs
        return valor

    def CapiturandoCNPJ(self):
        #14.878.453/0002-00
        txt = self.page_content
        regexCNPJ = "[0-9]{2}.[0-9]{3}.[0-9]{3}/[0-9]{4}-[0-9]{2}"
        cnpj = re.findall(regexCNPJ, txt)
        meuCNPJ = cnpj
        return meuCNPJ

    def CapiturandoCEP(self):
        #09.030-030
        txt = self.page_content
        regexCEP ="[0-9]{2}.[0-9]{3}-[0-9]{3}"
        match = re.findall(regexCEP,txt)
        valor = match
        return valor