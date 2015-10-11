#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <libpq-fe.h>

char nowaKolumna[20];
int pomocniczaa=0;

void doSQL(PGconn *conn, char *command, int tmp){
  PGresult *result;
  printf("%s\n", command);
  result = PQexec(conn, command);
    if(strcmp(PQresStatus(PQresultStatus(result)),"PGRES_FATAL_ERROR")==0){
    printf("Nie wykonano operacji!\n");
  }else{
    printf("Udalo sie wykonac operacje!\n");
  }

    if(tmp==1){
    switch(PQresultStatus(result)) {
    case PGRES_TUPLES_OK:
    {
      int n = 0, m = 0;
      int nrows   = PQntuples(result);
      int nfields = PQnfields(result);
      printf("Liczba zwroconych wierszy   = %d\n", nrows);
      printf("Liczba zwroconych kolumn = %d\n", nfields);
      for(m = 0; m < nrows; m++) {
        for(n = 0; n < nfields; n++)
            printf(" %s = %s", PQfname(result, n),PQgetvalue(result,m,n));
            printf("\n");
        }
        }
    }
    PQclear(result);
    }
}

void tworzenieTabeli(){
  PGresult *result;
  PGconn   *conn;
  int tmp=0;

  conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
  if(PQstatus(conn) == CONNECTION_OK) {
    doSQL(conn, "CREATE TABLE pracownik(id_pracownik SERIAL PRIMARY KEY, imie VARCHAR(20), nazwisko VARCHAR(20), pesel CHAR(11), data_ur DATE, pensja MONEY)",tmp);
  }
  else
    printf("Bledne polaczenie z baza: %s\n", PQerrorMessage(conn));
    PQfinish(conn);
}

void usuwanieTabeli(){
  int tmp=0;
  PGresult *result;
  PGconn   *conn;
  conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
  if(PQstatus(conn) == CONNECTION_OK) {
    doSQL(conn, "DROP TABLE pracownik",tmp);
  }
  else
    printf("Bledne polaczenie z baza: %s\n", PQerrorMessage(conn));
    PQfinish(conn);
}

void dodawanieRekordow(){
    char kolumna[20];
    int tmp=0;
    int pomocnicza=0;
    PGresult *result;
    PGconn   *conn;
    char imie[20], nazwisko[20], pesel[11], data_ur[10], pensja[10], zapytanie[300];
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    while(pomocnicza!=9){
        if(pomocniczaa==0){
        printf("   imie = "); scanf("%s",imie);
        printf("   nazwisko = "); scanf("%s",nazwisko);
        printf("   pesel = "); scanf("%s",pesel);
        printf("   data urodzenia = "); scanf("%s",data_ur);
        printf("   pensja = "); scanf("%s",pensja);
        sprintf(zapytanie, "INSERT INTO pracownik(imie,nazwisko,pesel,data_ur,pensja) VALUES(\'%s\', \'%s\', \'%s\', \'%s\', \'%s\')",imie,nazwisko,pesel,data_ur,pensja);
        doSQL(conn, zapytanie, tmp);
        printf("Dodano rekord do tabeli. Aby zakonczyc wpisywanie rekordow wpisz 9.\n");
        scanf("%i", &pomocnicza);
        }
        if(pomocniczaa==1){
        printf("   imie = "); scanf("%s",imie);
        printf("   nazwisko = "); scanf("%s",nazwisko);
        printf("   pesel = "); scanf("%s",pesel);
        printf("   data urodzenia = "); scanf("%s",data_ur);
        printf("   pensja = "); scanf("%s",pensja);
        printf("   %s = ",nowaKolumna); scanf("%s", kolumna);
        sprintf(zapytanie, "INSERT INTO pracownik(imie,nazwisko,pesel,data_ur,pensja,%s) VALUES(\'%s\', \'%s\', \'%s\', \'%s\', \'%s\', \'%s\')",nowaKolumna,imie,nazwisko,pesel,data_ur,pensja,kolumna);
        doSQL(conn, zapytanie, tmp);
        printf("Aby zakonczyc wpisywanie rekordow wpisz 9.\n");
        scanf("%i", &pomocnicza);
        }
    }
    PQfinish(conn);
}

void wyswietlanieRekordow(){
    int tmp = 1;
    PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    doSQL(conn, "SELECT * FROM pracownik",tmp);
}

void modyfikowanieRekordu(){
    int tmp=1;
    int pomocnicza=0;
    char zapytanie[300], co[20], jak[20];
    int warunek;
    PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    while(pomocnicza!=9){
            printf("Co chcesz zmodyfikowac?\n"); scanf("%s",co);
            printf("Na co chcesz zmodyfikowac?\n"); scanf("%s",jak);
            printf("Jaki id_pracownik?\n"); scanf("%i",&warunek);
            sprintf(zapytanie, "UPDATE pracownik SET %s = \'%s\' WHERE id_pracownik = %i",co,jak,warunek);
            doSQL(conn, zapytanie, tmp);
            printf("Aby zakonczyc modyfikowanie wpisz 9.\n");
            scanf("%i", &pomocnicza);
    }
}

void usuwanieRekordu(){
    int tmp=1;
    int pomocnicza=0;
    char zapytanie[300];
    int warunek;
    PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    while(pomocnicza!=9){
            printf("Jaki id_pracownik ma byc usuniety?\n"); scanf("%i",&warunek);
            sprintf(zapytanie, "DELETE FROM pracownik WHERE id_pracownik = %i",warunek);
            doSQL(conn, zapytanie, tmp);
            printf("Aby zakonczyc usuwanie wpisz 9.\n");
            scanf("%i", &pomocnicza);
    }
}

void dodawanieKolumny(){
    int tmp=1;
    int pomocnicza=0;
    char warunek[20], typ[20], zapytanie[200];
    PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    while(pomocnicza!=9){
        printf("Jak ma nazywac sie nowa kolumna?\n"); scanf("%s",warunek);
        printf("Jakiego typu ma byc nowa kolumna?\n"); scanf("%s",typ);
        sprintf(zapytanie, "ALTER TABLE pracownik ADD COLUMN %s %s",warunek,typ);
        doSQL(conn, zapytanie, tmp);
        printf("Aby zakonczyc usuwanie wpisz 9.\n");
        scanf("%i", &pomocnicza);
        strcpy(nowaKolumna,warunek);
        pomocniczaa=1;
    }
}

void wyswietlanieJakoHTML(){
  PGresult *result;
  PGconn *conn;
  conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    if(PQstatus(conn) == CONNECTION_OK){
    result = PQexec(conn, "SELECT * FROM pracownik");
    if(PQresultStatus(result)==PGRES_TUPLES_OK)
    {
      FILE *stdout;
      char nazwaPliku[30];
      printf("Wprowadz nazwe pliku: ");
      scanf("%s",nazwaPliku);
      stdout=fopen(nazwaPliku,"a+");
      PQprintOpt pqp;
      pqp.header = 1;
      pqp.align = 1;
      pqp.html3 = 1;
      pqp.expanded = 0;
      pqp.pager = 0;
      pqp.fieldSep = "";
      pqp.tableOpt = "align=center";
      pqp.caption = "Lista pracowników.";
      pqp.fieldName = NULL;
 	  fprintf(stdout,"<!DOCTYPE html><HTML><HEAD></HEAD><BODY>\n");
      PQprint(stdout, result, &pqp);
      fprintf(stdout,"</BODY></HTML>\n");
      printf("Tabela zapisana do pliku HTML");
      fclose(stdout);
    }
  }
}

void tworzenieWyzwalacza(){
	int tmp=1;
	PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    doSQL(conn, "CREATE OR REPLACE FUNCTION sprawdz_pensje() RETURNS TRIGGER AS $$ BEGIN IF NEW.pensja < '1000' OR NEW.pensja > '5000' THEN RAISE EXCEPTION 'PENSJA NIE MIESCI SIE W PRZEDZIALE'; END IF; RETURN NEW; END; $$ LANGUAGE 'plpgsql';",tmp);
    doSQL(conn, "CREATE TRIGGER praciwnik_insert BEFORE INSERT ON pracownik FOR EACH ROW EXECUTE PROCEDURE sprawdz_pensje();",tmp);
    doSQL(conn, "CREATE TRIGGER pracownik_update BEFORE UPDATE ON pracownik FOR EACH ROW EXECUTE PROCEDURE sprawdz_pensje();",tmp);
}

void usuwanieWyzwalacza(){
	int tmp=1;
	PGresult *result;
    PGconn   *conn;
    conn = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");
    doSQL(conn, "DROP FUNCTION sprawdz_pensja() CASCADE;",tmp);
}

int main(int argc,char *argv[]){

    int przycisk=100;
    PGconn *myconnection = PQconnectdb("host=localhost port=5432 dbname=srzeppa user=srzeppa password=123456");

    if (argc > 1){ //argc to nic innego jak liczba argumentow wyrazona w int
    int tmp=1;
    FILE *plik;
    plik=fopen(argv[1], "r"); // argv[0] to jest ./connect a [1] to juz nazwa pliku
    char zapytanie[1000];
    int i;
    if(plik == NULL){
	printf("ERROR 404 \n");
	}
	else{
	printf("Pobieranie danych z pliku.");
	for (i=0; feof(plik)==0; i++){
        sleep(1);
		fscanf(plik, "%[^\n] \n", zapytanie);
		doSQL(myconnection, zapytanie,tmp);
		}
	}
    fclose(plik);
    }

  if(PQstatus(myconnection) == CONNECTION_OK) {
    printf("Polaczono z baza danych:\n");
    printf("PGDBNAME   = %s\n",PQdb(myconnection));
    printf("PGUSER     = %s\n",PQuser(myconnection));
    printf("PGPASSWORD = ********\n");
    printf("PGHOST     = %s\n",PQhost(myconnection));
    printf("PGPORT     = %s\n",PQport(myconnection));
    printf("OPTIONS    = %s\n",PQoptions(myconnection));
  }
  else
    printf("connection failed: %s\n", PQerrorMessage(myconnection));

  while(przycisk!=0){
    printf("\n\nMENU:\n1- Tworzenie tabeli\n2- Usuwanie tabeli\n3- Dodawanie rekordow\n4- Wyswietlanie rekordow\n5- Modyfikowanie rekordow\n6- Usuniecie pojedynczego rekordu\n7- Dodawanie kolumny\n8- Wyswietlanie jako tabela HTML\n9- Tworzenie wyzwalacza\n10- Usuwanie wyzwalacza\n0- Wyjscie\n\n\n");
    scanf("%i", &przycisk);
    if(przycisk==1) tworzenieTabeli();
    if(przycisk==2) usuwanieTabeli();
    if(przycisk==3) dodawanieRekordow();
    if(przycisk==4) wyswietlanieRekordow();
    if(przycisk==5) modyfikowanieRekordu();
    if(przycisk==6) usuwanieRekordu();
    if(przycisk==7) dodawanieKolumny();
    if(przycisk==8) wyswietlanieJakoHTML();
    if(przycisk==9) tworzenieWyzwalacza();
    if(przycisk==10) usuwanieWyzwalacza();
    if(przycisk==0) PQfinish(myconnection);
  }
  return 0;
}
