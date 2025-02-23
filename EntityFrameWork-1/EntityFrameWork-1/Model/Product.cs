﻿namespace EntityFrameWork_1.Model
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductId { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}
