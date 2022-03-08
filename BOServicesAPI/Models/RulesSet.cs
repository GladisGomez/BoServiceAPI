using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class RulesSet
    {
        public RulesSet()
        {
            AllowedStationSet = new HashSet<AllowedStationSet>();
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            HorarySet = new HashSet<HorarySet>();
            RulesClientSet = new HashSet<RulesClientSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public int LimitDayCost { get; set; }
        public int LimitDayVolume { get; set; }
        public int LimitWeekCost { get; set; }
        public int LimitWeekVolume { get; set; }
        public int LimitMonthCost { get; set; }
        public int LimitMonthVolume { get; set; }
        public int? MaxChargesAllowed { get; set; }
        public int? MaxChargesRangeMinutes { get; set; }
        public int? LimitChargeCost { get; set; }
        public int? LimitChargeVolume { get; set; }
        public int? ContingencyMaxCost { get; set; }
        public int? ContingencyMaxVolume { get; set; }
        public int FirstDayOfWeek { get; set; }
        public string NumTransactionExternal { get; set; }
        public int? LimitWeekAccumulationThreshold { get; set; }
        public int? LimitMonthAccumulationThreshold { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int RulesFuelType { get; set; }

        public virtual FuelTypes RulesFuelTypeNavigation { get; set; }
        public virtual ICollection<AllowedStationSet> AllowedStationSet { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<HorarySet> HorarySet { get; set; }
        public virtual ICollection<RulesClientSet> RulesClientSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
