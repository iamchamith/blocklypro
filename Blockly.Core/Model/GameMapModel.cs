using System.ComponentModel.DataAnnotations;

namespace Blockly.Core.Model
{
    public class GameMapModel
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        [EnumDataType(typeof(Enums.ControllerType))]
        public Enums.ControllerType ControllerType { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int Hight { get; set; }
        public int Width { get; set; }
    }
}
