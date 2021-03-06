﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class CarDTO : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string CarColor { get; set; }
        public string ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
