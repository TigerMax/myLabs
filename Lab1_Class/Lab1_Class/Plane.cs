using System;

public interface Plane: Transport
{
    string type = "Aircraft";
    string name;

    public Plane(string n)
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
        return "Shhhhhh";
    }
    public string move() {
        return "Uuuueeeeew!";
    }
}
