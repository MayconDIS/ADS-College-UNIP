-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Funcionario (
Nome VARCHAR(10),
Id_Funcionario VARCHAR(10) PRIMARY KEY
)

CREATE TABLE Dependente (
Nome_Dependente VARCHAR(10),
Id_Dependente VARCHAR(10) PRIMARY KEY,
Id_Funcionario VARCHAR(10),
FOREIGN KEY(Id_Funcionario) REFERENCES Funcionario (Id_Funcionario)
)

