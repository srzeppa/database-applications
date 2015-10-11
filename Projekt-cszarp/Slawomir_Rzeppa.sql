use srzeppa;
GO






IF OBJECT_ID('wypozyczenie_samochod') IS NOT NULL DROP TABLE wypozyczenie_samochod;
GO

IF OBJECT_ID('wypozyczenie') IS NOT NULL DROP TABLE wypozyczenie;
GO

IF OBJECT_ID('adres') IS NOT NULL DROP TABLE adres;
GO

IF OBJECT_ID('klient') IS NOT NULL DROP TABLE klient;
GO

IF OBJECT_ID('pracownik') IS NOT NULL DROP TABLE pracownik;
GO

IF OBJECT_ID('samochod') IS NOT NULL DROP TABLE samochod;
GO


CREATE TABLE adres(
id_adres INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
miejscowosc VARCHAR(50) NOT NULL,
ulica VARCHAR(50) NOT NULL,
numer_domu INT NOT NULL,
numer_mieszkania INT,
kod_pocztowy CHAR(6) NOT NULL,
);
GO

CREATE TABLE klient(
id_klient INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
imie VARCHAR(50) NOT NULL,
nazwisko VARCHAR(50) NOT NULL,
pesel VARCHAR(11) NOT NULL,
data_ur DATE NOT NULL,
zdjecie IMAGE NOT NULL,
id_adres INT FOREIGN KEY REFERENCES adres(id_adres),
);
GO


CREATE TABLE samochod(
id_samochod INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nazwa VARCHAR(50) NOT NULL,
marka VARCHAR(50) NOT NULL,
przebieg INT NOT NULL,
rocznik DATE NOT NULL,
rodzaj_silnika VARCHAR(10) NOT NULL,
);
GO

CREATE TABLE wypozyczenie(
id_wypozyczenie INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
data_zakupu DATE NOT NULL,
data_zwrotu DATE NOT NULL,
cena DECIMAL(10,2) NOT NULL,
id_klient INT FOREIGN KEY REFERENCES klient(id_klient),
);
GO


CREATE TABLE wypozyczenie_samochod(
id_samochod INT FOREIGN KEY REFERENCES samochod(id_samochod),
id_wypozyczenie INT FOREIGN KEY REFERENCES wypozyczenie(id_wypozyczenie),
);
GO