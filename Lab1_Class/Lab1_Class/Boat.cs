using System;

public class Boat
{  string type = "Naval";
    string name;

    public Boat(string n)
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
        return "Splash";
    }
    public string move() {
        return "Wroom!";
    }
}
