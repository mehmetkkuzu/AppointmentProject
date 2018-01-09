using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaserGroup.Automotive.Data.Interface
{
    public interface IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }
    }
}
