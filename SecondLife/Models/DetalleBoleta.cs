﻿namespace SecondLife.Models
{
    public class DetalleBoleta
    {
        public string num_det_bol { get; set; }
        public string num_bol { get; set; }
        public string id_prod { get; set; }
        public int cant_prod { get; set; }
        public decimal precio { get; set; }
        public decimal sub_tot { get; set; }

    }
}