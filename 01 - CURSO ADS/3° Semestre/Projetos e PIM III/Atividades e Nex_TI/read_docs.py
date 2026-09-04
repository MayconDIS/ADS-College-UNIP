import zipfile
import xml.etree.ElementTree as ET

def read_docx(path):
    try:
        with zipfile.ZipFile(path) as docx:
            tree = ET.XML(docx.read('word/document.xml'))
            text = []
            for p in tree.iter('{http://schemas.openxmlformats.org/wordprocessingml/2006/main}p'):
                texts = [node.text for node in p.iter('{http://schemas.openxmlformats.org/wordprocessingml/2006/main}t') if node.text]
                if texts:
                    text.append(''.join(texts))
            return '\n'.join(text)
    except Exception as e:
        return str(e)

print('--- DOCX: Atividade - Prof. Flavio.docx ---')
print(read_docx(r'C:\Users\mayco\Desktop\ATIVIDADES\Atividade - Prof. Flavio.docx'))

print('\n--- PDF: Banco de DAdos SQL ---')
pdf_path = r'C:\Users\mayco\Desktop\ATIVIDADES\Banco de DAdos SQL - Avaliação do projeto de BD para o PIM III (1).pdf'
try:
    import fitz
    doc = fitz.open(pdf_path)
    for page in doc:
        print(page.get_text())
except Exception as e:
    print(f"Fitz failed: {e}")
    try:
        from PyPDF2 import PdfReader
        reader = PdfReader(pdf_path)
        for page in reader.pages:
            print(page.extract_text())
    except Exception as e2:
        print(f"PyPDF2 failed: {e2}")
