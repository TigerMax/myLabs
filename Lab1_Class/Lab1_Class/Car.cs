using System;

public class Car : Transport
{
    string type = "Ground";
    string name;

    public Car(string n)
    {
        name = n;
    }
    public override string getName() {
        return name;
    }
    public override string getType() {
        return type;
    }
    public override string makeSound() {
        return "Beep";
    }
    public override string move() {
        return "Wroom!";
    }
}
