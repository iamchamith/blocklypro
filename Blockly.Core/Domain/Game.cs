using System.ComponentModel.DataAnnotations;
namespace Blockly.Core.Domain
{
    public class Game: BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
