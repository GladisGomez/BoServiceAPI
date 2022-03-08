using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConfiguracionEdset
    {
        public ConfiguracionEdset()
        {
            ClientGroups = new HashSet<ClientGroups>();
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
            MailsEnvioEdset = new HashSet<MailsEnvioEdset>();
        }

        public int Id { get; set; }
        public bool EnAutomatico { get; set; }
        public int Periodicidad { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public DateTime FechaInicio { get; set; }
        public int CorteFijo { get; set; }
        public int PeriodoGracia { get; set; }
        public bool AgruparVencimiento { get; set; }
        public bool DesgloseIeps { get; set; }
        public bool SinResumen { get; set; }
        public bool SinSaldoFinal { get; set; }
        public string NumRegIdTrib { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ConfiguracionEdUsoDeCfdi { get; set; }

        public virtual UsoDeCfdiset ConfiguracionEdUsoDeCfdiNavigation { get; set; }
        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
        public virtual ICollection<MailsEnvioEdset> MailsEnvioEdset { get; set; }
    }
}
