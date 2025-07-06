using System;

public class Player : Props
{
    int health;

    public Player(char mesh, string name)
    {
        this.health = 100;
        this.mesh = mesh;
        this.name = name;
    }
    public Player(char mesh, string name,int posX,int posY)
    {
        this.mesh = mesh;
        this.name = name;
        this.posX = posX;
        this.posY = posY;
    }

    public void TakeDamage(int damage)
    {
        this.health -= damage;
    }
    /**
    * author: Henrique
    * sobre: função para recuperar vida
    * PS: função feita usando o conceito do this
    */
    public void Gainhealth(int heal)
    {
        this.health += heal;
    }
}
