using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    internal class GameSetUpFactory
    {
        internal static RoadLines CreateRoadLines(params PictureBox[] lines)
        {
            return new RoadLines(lines);
        }

        internal static RoadLinesCoordinator CreateRoadLinesCoordinator()
        {
            return new RoadLinesCoordinator();
        }

        internal static Enemy CreateEnemy(params PictureBox[] enemy)
        {
            return new Enemy(enemy);
        }

        internal static EnemysCoordinator CreateEnemysCoordinator()
        {
            return new EnemysCoordinator();
        }

        internal static Coin CreateCoin(params PictureBox[] coin)
        {
               return new Coin(coin);
        }
        internal static CoinsCoordinator CreateCoinsCoordinator()
        {
            return new CoinsCoordinator();
        }

    }
}
