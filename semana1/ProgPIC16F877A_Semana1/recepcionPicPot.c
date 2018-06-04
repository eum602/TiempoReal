#include <16f877a.h>
#device ICD=TRUE
#device adc=12
#fuses HS,NOWDT,NOPROTECT,NOLVP 
#use delay(clock=10000000) 
#use rs232(baud=9600,parity=N,xmit=PIN_C6,rcv=PIN_C7,bits=8) 
#use FAST_IO(A) 
#use FAST_IO(B)
#use FAST_IO(C) 
//#byte port_b=6
void main()
{
   //int16 q;
   //char q;
   //char string[96];

  int16 q;//---------  1) No es la inicializacion
   setup_adc_ports(AN0);
   setup_adc(ADC_CLOCK_INTERNAL);
//printf("Tiempo");
//putc(0x3B);//envia punto y coma
//printf("Tension\r");
for(;;){
   set_adc_channel(0);  
   delay_us(20);
     q=read_adc();
  // q=(int16)2;
   printf("%4ld\r",q);
   //delay_ms(500);
   //q=getch();
   //q=2;
  // gets(string);
 //printf("%4ld",p++);//p se incrementa cada un segundo y se envia por usart
 //putc(0x3B);
//printf("%c\r",q);//q contiene el valor del convertidor ana / dig fila a fila
 //printf("%c",q);//datos en serie
 delay_ms(1000);
 //output_bit(PIN_D0,1);
output_toggle(PIN_D0);
delay_ms(200);// 2) Al agregrle esta linea el ADC envia un formato de 5 digitos (eg.00935)
output_toggle(PIN_D1);
 delay_ms(200);
  output_toggle(PIN_D2);
  delay_us(3000);
 
 }
}

