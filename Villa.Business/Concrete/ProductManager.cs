﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.DataAccsess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
        {
        }
    }
}
