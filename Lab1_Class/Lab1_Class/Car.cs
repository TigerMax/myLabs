using System;

public class Car : Transport
{
    string type = "Ground";
    string name;

    public Car(string n)
    {
        name = n;
    }
    public string getName() {
        return name;
    }
    public string getType() {
        return type;
    }
    public string makeSound() {
        return "Beep";
    }
    public string move() {
        return "Wroom!";
    }
}
