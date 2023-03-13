﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9Assignment_cgp27.Models
{
    public interface IPurchaseRepository
    {

        public IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase purchase);

    }
}
