﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Fournisseurs
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Telephone { get; set; }

        public string? Siret { get; set; }

        public string? Nom { get; set; }

    }
}
