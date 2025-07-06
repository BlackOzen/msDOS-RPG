using System;
public class Merchant : Props//define Merchant como classe
{
    String[] falas = {
        "O que gostaria de comprar?",
        "Bem vindo, De uma olhada nos produtos",
    };
    public Merchant(String name, char mesh)
    {
        this.name = name;
        this.mesh = mesh;
    }
    public Merchant(char mesh, String name, int posX, int posY)
    {
        this.mesh = mesh;
        this.name = name;
        this.posX = posX;
        this.posY = posY;
    }
    public String Talk(String falas)
    {
        if (falas == "")
        { 
            return this.falas[0];
        }
        return "";
    }
}
