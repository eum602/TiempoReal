#ifndef _DS18B20_LIB_H_
   #define   _DS18B20_LIB_H_   true

#define ONE_WIRE_PIN pin_c5
#define   pinSensor   5

void         onewire_reset(void);
void         onewire_write(unsigned int);
unsigned int   onewire_read(void);

void onewire_reset() {
   set_tris_c(get_tris_c()&~(1<<pinSensor));
    output_low(ONE_WIRE_PIN);
    delay_us(500);
    set_tris_c(get_tris_c()|(1<<pinSensor));
    delay_us(500);
}

void onewire_write(int8 data) {
    int8 count;
    for(count = 0; count < 8; ++count) {
       set_tris_c(get_tris_c()&~(1<<pinSensor));
        output_low(ONE_WIRE_PIN);
        delay_us(2);
        output_bit(ONE_WIRE_PIN, shift_right(&data, 1, 0));
        delay_us(60);
        set_tris_c(get_tris_c()|(1<<pinSensor));
        delay_us(2);
    }
}

int onewire_read() {
    int count, data;

    for(count = 0; count < 8; ++count) {
       set_tris_c(get_tris_c()&~(1<<pinSensor));
        output_low(ONE_WIRE_PIN);
        delay_us(2);
        set_tris_c(get_tris_c()|(1<<pinSensor));
        delay_us(8);
        shift_right(&data, 1, input_state(ONE_WIRE_PIN));
        delay_us(120);
    }
    return data;
}

float ds18b20Read() {
    volatile   unsigned   int      temp1=0,temp2=0;
    volatile   signed      long    temp3=0;
    volatile   float            resultado=0;

    onewire_reset();
    onewire_write(0xCC);            //Skip ROM, address all devices
    onewire_write(0x44);            //Start temperature conversion
    
    onewire_reset();
    onewire_write(0xCC);            //Skip ROM, address all devices
    onewire_write(0xBE);            //Read scratchpad
    temp1 = onewire_read();
    temp2 = onewire_read();
    temp3 = make16(temp2, temp1);
      resultado = (float) temp3 / 16.0;    //Calculation for DS18B20 pasos de 0.1° grados
      //resultado = (float) temp3 / 2.0;    //Calculation for DS18B20 pasos de 0.5° grados
    return   resultado;
}

 #endif
