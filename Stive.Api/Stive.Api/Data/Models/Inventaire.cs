﻿
using System.ComponentModel.DataAnnotations;

namespace api.Data.Models
{
    public class Inventaire
    {

        public int Id { get; set; }

        public List<Articles>? ArticleId { get; set; }

        public int? Quantité { get; set; }

        public int? DifferenceStock { get; set; }
    }
}
