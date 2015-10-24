using System;

public class Plane: Transport
{
    string type = "Aircraft";
    string name;

    public Plane(string n)
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
        return "Shhhhhh";
    }
    public override string move() {
        return "Uuuueeeeew!";
    }
}
