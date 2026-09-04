//Programa simples que implementa comunicação com a porta serial
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>  // biblioteca geral do windows contendo CreateFile, ReadFile, etc
#include<string.h>    // biblioteca de manipulaçao de stings ( strcpy, strcat, etc)
int main(int argc, char *argv[]){    
    char         le;
    char         str[500];
    char         INBUFFER[500];
    char         porta[50];
    DWORD        bytes_read    = 0;    // numero de bytes lidos 
    DWORD        bytes_written = 0;    // numero de bytes escritos
    HANDLE       comport      = NULL;  // Handle COM port
    int           bStatus;
    DCB          comSettings;          // Armazena configuracoes da porta
    COMMTIMEOUTS CommTimeouts;         // Armazena configuracoes de timeouts
    strcpy(&INBUFFER[0],"\0");         // zera o vetor INBUFFER copiando "\0"
    strcpy(porta,"\\\\.\\");           // copia \\.\ no string porta
    strcat(porta,"COM1");              // concatena "COMX" na string porta
    printf("%s\n",porta);
    
    if ((comport =  CreateFile(porta,             // Cria a porta comX:
                    GENERIC_READ | GENERIC_WRITE, // for reading and writing
                    0,                            // exclusive access
                    NULL,                         // no security attributes
                    OPEN_EXISTING,              
                    //0,
                    FILE_ATTRIBUTE_NORMAL,
                    NULL)) == INVALID_HANDLE_VALUE)
    {
     printf("falhou a ");
    }
    printf("criação da porta \n");
    
    // configura os  timeouts em milisegundos
    CommTimeouts.ReadIntervalTimeout         = 0; 
    CommTimeouts.ReadTotalTimeoutMultiplier  = 0; 
    CommTimeouts.ReadTotalTimeoutConstant    = 100;
    CommTimeouts.WriteTotalTimeoutMultiplier = 0;
    CommTimeouts.WriteTotalTimeoutConstant   = 100;
    bStatus = SetCommTimeouts(comport,&CommTimeouts);
    if (bStatus == 0){
        printf("falhou o "); } // error processing code goes here
    printf("SetCommTimeouts \n");
    
    // configura os parametros d comunicação
    bStatus =GetCommState(comport, &comSettings); // obtem os parametros atuais
    if (bStatus == 0){
        printf("falhou o ");}  // error processing code goes here
    printf("GetCommState \n");
    printf("BaudRate StopBits ByteSize Parity fParity\n");
    printf("%i %i %i %i %i \n",comSettings.BaudRate, comSettings.StopBits, comSettings.ByteSize,
                                                       comSettings.Parity, comSettings.fParity);
    comSettings.BaudRate = 4800;           // Set Port parameters.
    comSettings.StopBits = ONESTOPBIT;
    comSettings.ByteSize = 8;
    comSettings.Parity   = NOPARITY;
    comSettings.fParity  = FALSE;
    printf("%i %i %i %i %i \n",comSettings.BaudRate, comSettings.StopBits, comSettings.ByteSize,
                                                       comSettings.Parity, comSettings.fParity);
    bStatus = SetCommState(comport, &comSettings);
    if (bStatus == 0){
      printf("falhou o "); } 
    printf("SetCommState \n");
    bStatus =GetCommState(comport, &comSettings);
    if (bStatus == 0){
        printf("falhou o ");}  // error processing code goes here
    printf("GetCommState \n");
    
    printf("%i %i %i %i %i \n",comSettings.BaudRate, comSettings.StopBits, comSettings.ByteSize,
                                                    comSettings.Parity, comSettings.fParity);
    
    printf("Digite o texto a ser enviado");
    // leitura da porta
    strcpy(&INBUFFER[0],"\0");
    bStatus = ReadFile(comport,   // Handle
                &INBUFFER,            // Incoming data
                500,                  // Number of bytes to read
                &bytes_read,          // Number of bytes read
                NULL);
    if (bStatus == 0){ printf("falhou o ");}
    INBUFFER[bytes_read]='\0';        // termina o bufer lido com \0
    printf("ReadFile %i >\n%s",bytes_read,INBUFFER); //imprime o numero de byte lidos e a entrada

    // escrever na porta
    printf("Insira uma string:\n");
    fflush( stdin );
    strcpy(&str[0],"\0");
    gets(str);
    strcat(str,"\n\0");
    bStatus = WriteFile(comport,              // Handle
                    &str,                     // string de escrita
                    strlen(str),              // Number of bytes to write
                    &bytes_written,           // Number of bytes written
                    NULL);
    if (bStatus == 0) { printf("falhou o ");} 
    printf("WriteFile %i %s", bytes_written, str );
    

  CloseHandle(comport);
  system("PAUSE");	
  return 0;
}
