#include <Arduino.h>

const int PIN_IR = 2;
const int PIN_RESET = 3;
const int PIN_DEC = 4;
const int PIN_LED_ROSSO = 5;

const int segmenti[7] = {6, 7, 8, 9, 10, 11, 12};

const byte cifre[10] = {
  0b1111110,
  0b0110000,
  0b1101101,
  0b1111001,
  0b0110011,
  0b1011011,
  0b1011111,
  0b1110000,
  0b1111111,
  0b1111011
};

int contatore = 0;
int statoIR_precedente = LOW;

void mostraNumero(int n) {

  for (int i = 0; i < 7; i++) {

    digitalWrite(segmenti[i], (cifre[n] >> (6 - i)) & 1);

  }
}

void setup() {

  pinMode(PIN_IR, INPUT_PULLUP);

  pinMode(PIN_RESET, INPUT_PULLUP);
  pinMode(PIN_DEC, INPUT_PULLUP);

  pinMode(PIN_LED_ROSSO, OUTPUT);

  for (int i = 0; i < 7; i++) {

    pinMode(segmenti[i], OUTPUT);

  }

  mostraNumero(0);
}

void loop() {

  int statoIR = digitalRead(PIN_IR);

  if (statoIR == HIGH && statoIR_precedente == LOW) {

    if (contatore < 9) {

      contatore++;

    }
    else {

      digitalWrite(PIN_LED_ROSSO, HIGH);

    }

    mostraNumero(contatore);

    delay(200);
  }

  statoIR_precedente = statoIR;

  if (digitalRead(PIN_RESET) == LOW) {

    contatore = 0;

    digitalWrite(PIN_LED_ROSSO, LOW);

    mostraNumero(contatore);

    delay(200);
  }

  if (digitalRead(PIN_DEC) == LOW) {

    if (contatore > 0) {

      contatore--;

    }

    if (contatore < 9) {

      digitalWrite(PIN_LED_ROSSO, LOW);

    }

    mostraNumero(contatore);

    delay(200);
  }
}