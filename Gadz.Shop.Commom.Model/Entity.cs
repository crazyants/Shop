﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadz.Shop.Commom.Model {
    public abstract class Entity : IEntity {
        public Identity Id => throw new NotImplementedException();
    }
}