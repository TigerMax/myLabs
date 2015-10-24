using System;

public class Boat : Transport
{  string type = "Naval";
    string name;

    public Boat(string n)
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
        return "Splash";
    }
    public override string move() {
        return "Wroom!";
    }
}
