//Servo motor library
#include <Servo.h>

int soil_SensorPin1 = A0;
int pumpPin = 11;
int sensorValue = 0;
int ldrtopr = A1;
int ldrtopl = A2;
int ldrbotr = A3;
int ldrbotl = A4;

int topl = 0;
int topr = 0; 
int botl = 0;
int botr = 0;

//Declare two servos

Servo servo_updown;
Servo servo_rightleft;

int current_position = 0;
int current_position2 = 0;
int home_position_for_updown = 90;
int home_position_for_rightleft = 90;
int threshold_value = 30;  // measurement sensitivity


void setup() {
Serial.begin(9600);
pinMode(pumpPin, OUTPUT);
servo_updown.attach(5);             //Servo motor up-down movement
servo_rightleft.attach(6);          //Servo motor right-left movement

servo_updown.write(home_position_for_updown);
servo_rightleft.write(home_position_for_rightleft);

current_position = servo_updown.read();
Serial.println(current_position);
current_position2 = servo_rightleft.read();
Serial.println(current_position2);
}

void loop() {
// put your main code here, to run repeatedly:
sensorValue = analogRead(soil_SensorPin1);
Serial.println("Sensor Value: ");
Serial.println(sensorValue);
delay(2000);

if (sensorValue < 450) {
    digitalWrite(pumpPin, HIGH);
    Serial.println("Turning Pump on");
    delay(1000);             // turn on the pump if the sensor reading is below the threshold
    digitalWrite(pumpPin, LOW);
  }

//capturing analog values of each LDR
topr= analogRead(ldrtopr);         //capturing analog value of top right LDR
topl= analogRead(ldrtopl);         //capturing analog value of top left LDR
botr= analogRead(ldrbotr);         //capturing analog value of bot right LDR
botl= analogRead(ldrbotl);         //capturing analog value of bot left LDR

Serial.print("TOP RIGHT LDR: ");
Serial.println(topr);
delay(1000);
Serial.print("TOP LEFT LDR: ");
Serial.println(topl);
delay(1000);
Serial.print("BOTTOM RIGHT LDR: ");
Serial.println(botr);
delay(1000);
Serial.print("BOTTOM LEFT LDR: " );
Serial.println(botl);
delay(1000);

int avgtop = (topr + topl) / 2;     //average  of top LDRs
int avgbot = (botr + botl) / 2;     //average of bottom LDRs
int avgleft = (topl + botl) / 2;    //average of left LDRs
int avgright  = (topr + botr) / 2;   //average of right LDRs

Serial.print("Average top: ");
Serial.println(avgtop);
delay(1000);
Serial.print("Average bottom: ");
Serial.println(avgbot);
delay(1000);
Serial.print("Average right: ");
Serial.println(avgright);
delay(1000);
Serial.print("Average left: ");
Serial.println(avgleft);
delay(1000);

//Get the different  
int diffelev = avgtop - avgbot;      //Get the different average between  LDRs top and LDRs bot
int diffazi = avgright - avgleft;    //Get the different  average between LDRs right and LDRs left
int current_position;

//left-right movement of  solar tracker
if (servo_updown.read() < 160 && servo_rightleft.read() < 160 && servo_updown.read() > 20 && servo_rightleft.read() > 20)
 {
  if (abs(diffelev) >= threshold_value) //Change position only if light difference is bigger then the threshold_value
  {
    if (avgtop > avgbot) {
      current_position = servo_updown.read();
      Serial.print(current_position);
      Serial.println(" Degrees");
      delay(1000);
      Serial.print("Average top is greater - MOVING TOP DOWN: ");
      Serial.println(avgtop);
      delay(1500);
      servo_updown.write(current_position + 15);
      delay(500);
      }
    if (avgtop < avgbot) {
      current_position = servo_updown.read();
      Serial.print(current_position);
      Serial.println(" Degrees");
      delay(1000);
      Serial.print("Average bottom is greater - MOVING BOTTOM UP: ");
      Serial.println(avgbot);
      delay(1500);
      servo_updown.write(current_position  - 15);
      delay(500);
      }
  }
  if (abs(diffazi) >= threshold_value) {
    if (avgright > avgleft) {
      current_position = servo_rightleft.read();
      Serial.print(current_position);
      Serial.println(" Degrees");
      delay(1000);
      Serial.print("Average Right is greater - MOVING LEFT: ");
      Serial.println(avgright);
      delay(1500);
      servo_rightleft.write((servo_rightleft.read()  + 15));
      delay(500);
      }
    if (avgright < avgleft) {
      current_position = servo_rightleft.read();
      Serial.print(current_position);
      Serial.println(" Degrees");
      delay(1000);
      Serial.print("Average Left is greater - MOVING RIGHT: ");
      Serial.println(avgleft);
      delay(1500);
      servo_rightleft.write((servo_rightleft.read()  - 15));
      delay(500);
      }
  }
 }
 if (servo_updown.read() > 160)
  {
  servo_updown.write((servo_updown.read() - 10));
  Serial.println("GREATER THAN 160 degrees up/down- MOVING BACK: ");
  delay(500);
  }
 if (servo_updown.read() < 20)
  {
  servo_updown.write((servo_updown.read() + 10));
  Serial.println("LESS THAN 20 degrees up/down - MOVING BACK: ");
  delay(500);
  }
if (servo_rightleft.read() > 160)
  {
  servo_rightleft.write((servo_rightleft.read() - 10));
  Serial.println("GREATER THAN 160 degrees right/left - MOVING BACK: ");
  delay(500);
  }
if (servo_rightleft.read() < 20)
  {
    servo_rightleft.write((servo_rightleft.read() + 10));
    Serial.println("LESS THAN 20 degrees right/left - MOVING BACK: ");
    delay(500);
  }
}