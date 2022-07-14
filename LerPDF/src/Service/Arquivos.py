import os
import re
import PyPDF2

class Arquivos:
    caminho: str
    nomefile: str

    def __init__(self,nomefile:str):
        self.caminho = "Nota"
        self.nomefile = nomefile
        self.Padroes()

    def LendoPDF(self):
        caminhoFull = "./"+self.caminho+"/"+ self.nomefile
        pdf_file = open(caminhoFull, 'rb')
        read_pdf = PyPDF2.PdfFileReader(pdf_file)
        read_pdf = PyPDF2.PdfFileReader(pdf_file)
        page = read_pdf.getPage(0)
        page_content = page.extractText()
        return page_content

    def Padroes(self):
        if(self.PastaExiste()== False):
            self.CriarPastapdrao()
            

    def CriarPastapdrao(self):
        try:
            os.mkdir(self.caminho)
        except:
            print("Erro ao criar a pasta padão")
        
    def PastaExiste(self):
        return os.path.exists(self.caminho)