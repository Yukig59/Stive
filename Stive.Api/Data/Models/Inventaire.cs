﻿namespace api.Data.Models
{
    public class Inventaire
    {
        public int Id { get; set; }

        public Articles ArticleId { get; set; }

        public int Quantité { get; set; }

        public int DifferenceStock { get; set; }
    }
}