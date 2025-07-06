using System.Threading.Tasks;

public class Scene01 : ScenesTemplate
{
    char[][] maps = new char[][] //desenho do mapa
{
    
            new char[] {'|', '-', '|', '-', '|'},
            new char[] {'|', ' ', '|', ' ', '|'},
            new char[] {'|', ' ', '+', ' ', '|'},
            new char[] {'|', ' ', ' ', ' ', '|'},
            new char[] {'|', '-', '-', '-', '|'}
};
    public async Task InitScene()
    {
        bool colision = false;
        string input;
        String falas =  "";
        Player player = new Player('@',"Player", 1,1);
        Merchant Jorge = new Merchant('$', "Seu jorge", 1,3);
        SpawProp(player);
        SpawProp(Jorge);
        this.SetRuning(true);
        do// desenha o mapa
        {
            Console.Clear();
            for (int i = 0; i < maps.Length; i++)//loop que desenha o mapa linha por linha
            {
                Console.Write("\n");
                for (int j = 0; j < maps[i].Length; j++)
                {
                    Console.Write(maps[i][j]);
                }
            }
            if(colision) Console.WriteLine("e: para interagir");
            Console.WriteLine(falas);
            input = Console.ReadLine();
            MovimentPlayer(input ,player ,Jorge ,colision );
            colision = LookforColisions(player, Jorge);
        } while (this.GetRuning());
    }
    public void SpawProp(Props prop)
    {
        maps[prop.posX][prop.posY] = prop.mesh;
    }

    public bool LookforColisions(Props player, Props mob)//vendo se o player colidiu com algo
    {
        if (maps[player.posX - 1][player.posY] == mob.mesh) return true;
        if (maps[player.posX + 1][player.posY] == mob.mesh) return true;
        if (maps[player.posX][player.posY - 1] == mob.mesh) return true;
        if (maps[player.posX][player.posY + 1] == mob.mesh) return true;
        if (maps[player.posX - 1][player.posY - 1] == mob.mesh) return true;
        if (maps[player.posX + 1][player.posY + 1] == mob.mesh) return true;
        if (maps[player.posX - 1][player.posY + 1] == mob.mesh) return true;
        if (maps[player.posX + 1][player.posY - 1] == mob.mesh) return true;
        return false; 
    }

    public void MovimentPlayer(string input, Player player,Merchant mob, bool colision)//setando os inputs de movimentação
    {
        if (input.Equals("w") || input.Equals("W")) //cima
        {
            if (maps[player.posX - 1][player.posY] == ' ')
            {
                maps[player.posX - 1][player.posY] = player.mesh;
                maps[player.posX][player.posY] = ' ';
                player.posX--;
            }
        }

        if (input.Equals("s") || input.Equals("S")) //baixo
        {
            if (maps[player.posX + 1][player.posY] == ' ')
            {
                maps[player.posX + 1][player.posY] = player.mesh;
                maps[player.posX][player.posY] = ' ';
                player.posX++;
            }
        }
        if (input.Equals("a") || input.Equals("A")) //esquerda
        {
            if (maps[player.posX][player.posY - 1] == ' ')
            {
                maps[player.posX][player.posY - 1] = player.mesh;
                maps[player.posX][player.posY] = ' ';
                player.posY--;
            }
        }
        if (input.Equals("d") || input.Equals("D")) //direita
        {
            if (maps[player.posX][player.posY + 1] == ' ')
            {
                maps[player.posX][player.posY + 1] = player.mesh;
                maps[player.posX][player.posY] = ' ';
                player.posY++;
            }
        }
        if (input.Equals('e') || input.Equals('E'))
        {
            if (colision)
            {
                this.falas = mob.Talk(this.falas);
            }
        }
    }
}
