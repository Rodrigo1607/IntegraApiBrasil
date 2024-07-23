﻿using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }

        public string? NomeAbreviado { get; set; }

        public int? Codigo { get; set; }

        public string? NomeCompleto { get; set; }

    }
}
