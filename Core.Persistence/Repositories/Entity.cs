using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public class Entity<TId>
{
    public TId Id { get; set; } // Entitylerimiz için ortak bir Id yapısı
    public DateTime CreatedDate { get; set; } // Bir nesne oluştuduğunda CreatedDate olmalıdır. Bu yüzden nullable yapmıyoruz.
    public DateTime? UpddatedDate { get; set; } // Bir nesne oluştuduğunda UpddatedDate olmaz bu yüzden nullable olabilir.
    public DateTime? DeletedDate { get; set; } // Bir nesne oluştuduğunda DeletedDate olmaz bu yüzden nullable olabilir.
}
