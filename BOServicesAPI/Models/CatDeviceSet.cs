using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CatDeviceSet
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public string Quantity { get; set; }
        public int? AppointmentServiceCatDevice { get; set; }
        public int? CatDeviceTagType { get; set; }
        public int? CatDeviceMeterType { get; set; }
        public int? CatDeviceTipoGps { get; set; }
        public int? CatDeviceReaderType { get; set; }
        public int? CatDeviceBatteryType { get; set; }
        public int? CatDeviceGasStation { get; set; }
        public int? CatDeviceGrttype1 { get; set; }
        public int? VehicleCatDevice1 { get; set; }

        public virtual AppointmentServiceSet AppointmentServiceCatDeviceNavigation { get; set; }
        public virtual BatteryTypeSet CatDeviceBatteryTypeNavigation { get; set; }
        public virtual GasStations CatDeviceGasStationNavigation { get; set; }
        public virtual GrttypeSet CatDeviceGrttype1Navigation { get; set; }
        public virtual MeterTypes CatDeviceMeterTypeNavigation { get; set; }
        public virtual ReaderTypeSet CatDeviceReaderTypeNavigation { get; set; }
        public virtual TagTypes CatDeviceTagTypeNavigation { get; set; }
        public virtual TipoGpsSet CatDeviceTipoGpsNavigation { get; set; }
        public virtual Vehicles VehicleCatDevice1Navigation { get; set; }
    }
}
