const int butPinRight = 6;
const int butPinLeft = 7; 

void setup() {
  Serial.begin(9600);

  pinMode(butPinRight, INPUT);
  pinMode(butPinLeft, INPUT);

  digitalWrite(butPinRight, HIGH);
  digitalWrite(butPibutPinLeftn2, HIGH);
}

void loop() {
  if (digitalRead(butPinRight) == LOW) {
    Serial.write(1);
    Serial.flush();
    delay(20);
  }

  if (digitalRead(butPinLeft) == LOW) {
    Serial.println("RIGHT");
    Serial.write(2);
    Serial.flush();
    delay(20);
  }

}