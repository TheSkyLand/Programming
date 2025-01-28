#include <Servo.h>
#include <IRremote.h>
Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards
int irPin = 11;

IRrecv irReciver(irPin);  // указываем вывод, к которому подключён приёмник

decode_results results;
int pos = 0;  // variable to store the servo position

void setup() {
  Serial.begin(9600);
  irReciver.enableIRIn();  // запускаем приём
  myservo.attach(9);       // attaches the servo on pin 9 to the servo object
}

void loop() {

  if (irReciver.decode(&results)) {  // если данные пришли
    Serial.println(results.value);
    Serial.println(results.value, HEX);
    Serial.println(pos);
    if (results.value = 4294967295) {
      irReciver.resume();  // принимаем следующую команду
      pos += 180;          // goes from 180 degrees to 0 degrees
      myservo.write(pos);  // tell servo to go to position in variable 'pos'
    }
    if (results.value = 4034314555) {
      irReciver.resume();  // принимаем следующую команду
      pos = 0;             // goes from 180 degrees to 0 degrees
      myservo.write(pos);  // tell servo to go to position in variable 'pos'
      delay(5);
    }
    irReciver.resume();
  }
}