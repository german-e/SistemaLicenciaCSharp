using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public abstract class Entity
    {
        public Guid Id  { get; private set; }
        public DateTime CreateAt { get; private set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } 
        public Entity() 
        { 
            Id = Guid.NewGuid();
        }

        public Entity( Guid id )
        {
            if ( id == Guid.Empty ) 
            { 
                throw new ArgumentNullException( "El id no es válido" ); 
            }

            Id = id;
        }

        public void Update()
        {
            UpdateAt = DateTime.Now;
        }
    }
}
