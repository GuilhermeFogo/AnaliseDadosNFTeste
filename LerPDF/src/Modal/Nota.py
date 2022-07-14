class Nota:
    CNPJEmpresa: str
    CEP: str
    ValortotalProdudo: str
    Imposto_ICMS: str

    def __init__(self, CNPJEmpresa: str, CEP: str, ValorTotalProduto: str, 
    ValorTotalNota: str):
        self.CNPJEmpresa = CNPJEmpresa,
        self.ValortotalNota = ValorTotalNota,
        self.ValortotalProdudo = ValorTotalProduto
        self.CEP = CEP
