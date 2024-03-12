﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public abstract class AggregateRoot : Entity
    {
        public readonly List<DomainEvent> _events = new();
        protected AggregateRoot() 
        {
            
        }

        public void LimpiarEventos()
        {
            _events.Clear();
        }        

        public IEnumerable<DomainEvent> GetEvents => _events;

        public void LanzarEvento(DomainEvent @event)
        {
            _events.Add(@event);
        }
        
    }
}
