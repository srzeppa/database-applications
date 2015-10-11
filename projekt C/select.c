//wyswietlanie zawartosci tabeli wraz z rozmiarem pola
#include <stdlib.h>
#include <libpq-fe.h>

void doSQL(PGconn *conn, char *command)
{
  PGresult *result;

//  printf("%s\n", command);

  result = PQexec(conn, command);
//  printf("status is %s\n", PQresStatus(PQresultStatus(result)));
//  printf("#rows affected %s\n", PQcmdTuples(result));
//  printf("result message: %s\n", PQresultErrorMessage(result));

  switch(PQresultStatus(result)) {
  case PGRES_TUPLES_OK:
    {
      int m, n;
      int nrows = PQntuples(result);
      int nfields = PQnfields(result);
      printf("number of rows returned = %d\n", nrows);
      printf("number of fields returned = %d\n", nfields);
      for(m = 0; m < nrows; m++) {
	for(n = 0; n < nfields; n++)
	  printf(" %s = %s(%d),", 
		 PQfname(result, n), 
		 PQgetvalue(result, m, n),
		 // rozmiar pola w bajtach
		 PQgetlength(result, m, n));
	printf("\n");
      }
    }
  }
  PQclear(result);
}
 
int main()
{
  PGresult *result;
  PGconn *conn;

  conn = PQconnectdb("host=localhost port=5432 dbname=nazwa user=login password=haslo");
  if(PQstatus(conn) == CONNECTION_OK) {
    printf("connection made\n");

    doSQL(conn, "DROP TABLE number");
    doSQL(conn, "CREATE TABLE number(value INTEGER,name VARCHAR)");
    doSQL(conn, "INSERT INTO number values(42, 'The Answer')");
    doSQL(conn, "INSERT INTO number values(29, 'My Age')");
    doSQL(conn, "INSERT INTO number values(29, 'Anniversary')");
    doSQL(conn, "INSERT INTO number values(66, 'Clickety-Click')");
    doSQL(conn, "SELECT * FROM number");
  }
  else 
    printf("connection failed: %s\n", PQerrorMessage(conn));

  PQfinish(conn);
  return EXIT_SUCCESS;
}

