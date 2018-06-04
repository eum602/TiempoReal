#include <18F4550.h>

#device adc=10       //Resolucion 8BITS
#use delay(clock=10000000)    //Oscilador de 10Mz
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7,bits=8,parity=N)  // Configuracion de la comunicacion serial
#fuses HS,NOPROTECT,NOWDT,NOLVP//,CPUDIV1,nomclr     // Configuracion de los Fuses
//#fuses NODEBUG, BROWNOUT,NOCPD,NOWRT
#use FAST_IO(A) 
#use FAST_IO(B)
#use FAST_IO(D)
// Lectura ADC
 int16 send;//,send1;

// FUNCION PRINCIPAL
void main()
{ //set_tris_a(0xFF);
  //output_a(0x00);
 //setup_port_A(all_analog);
   setup_adc_ports(AN0_TO_AN3|vss_vdd);
   setup_adc(adc_clock_internal);
 while(TRUE){
 
 set_adc_channel(0);
 delay_us(10);
 send=Read_ADC();
 delay_us(100);
 printf("%4ld\r",send); 
  //setup_adc_ports(AN0_TO_AN3|vss_vdd);
  delay_ms(100);
 
 
 }
}


