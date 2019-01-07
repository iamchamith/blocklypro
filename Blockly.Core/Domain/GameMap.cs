using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blockly.Core.Domain
{
    public class GameMap:BaseEntity
    {
        public int GameId { get; set; }
        [EnumDataType(typeof(Enums.ControllerType))]
        public Enums.ControllerType ControllerType { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int Hight { get; set; }
        public int Width { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }
    }
}
