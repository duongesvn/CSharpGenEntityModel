using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class TempPatron
    {
        public string MaPa { get; set; }
        public string TenPa { get; set; }
        public decimal? ChiPhi { get; set; }
        public string NhomVt { get; set; }
        public string MaVt { get; set; }
        public string TenVt { get; set; }
        public string Dvt { get; set; }
        public decimal? TiLeTron { get; set; }
        public decimal? TiLeHong { get; set; }
        public string GhiChu { get; set; }
        public int Id { get; set; }
    }
}
