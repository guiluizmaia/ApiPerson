using System.ComponentModel.DataAnnotations.Schema;

namespace IntegraçãoBD.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
