using System;

public class MainMenu
{
    string tittle;
    int option;

    public MainMenu()
    {
        this.tittle = "RPG do @";
        this.option = 0;

    }
    public void RenderMenu()
    {
        bool runing = true;
        string input;
        do
        {
            Console.WriteLine("|--------------------|");
            Console.WriteLine("|--------RPG-@-------|");
            Console.WriteLine("|-----1--jogar-------|");
            Console.WriteLine("|-----2--opção-------|");
            Console.WriteLine("|--------------------|");
            Console.WriteLine("Digite sua opção: ");
            input = Console.ReadLine();
            option = int.Parse(input);
            switch (option)
            {
                case 1:
                    Scene01 scene = new Scene01();
                    scene.InitScene();
                    break;
                case 2:
                    runing = false;
                    break;
                default:
                    Console.WriteLine("Comando inválido");
                    break;
            }
        } while (runing);

    }
}
