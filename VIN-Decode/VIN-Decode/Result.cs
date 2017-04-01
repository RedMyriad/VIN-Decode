using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VIN_Decode
{
    [DataContract]
    public class Result
    {
        //All Possible data that will or will not be included

        [DataMember]
        public string ABS { get; set; }
        [DataMember]
        public string AEB { get; set; }
        [DataMember]
        public string AdaptiveCruiseControl { get; set; }
        [DataMember]
        public string AdaptiveHeadlights { get; set; }
        [DataMember]
        public string AdditionalErrorText { get; set; }
        [DataMember]
        public string AirBagLocCurtain { get; set; }
        [DataMember]
        public string AirBagLocFront { get; set; }
        [DataMember]
        public string AirBagLocKnee { get; set; }
        [DataMember]
        public string AirBagLocSeatCushion { get; set; }
        [DataMember]
        public string AirBagLocSide { get; set; }
        [DataMember]
        public string Artemis { get; set; }
        [DataMember]
        public string AxleConfiguration { get; set; }
        [DataMember]
        public string Axles { get; set; }
        [DataMember]
        public string BasePrice { get; set; }
        [DataMember]
        public string BatteryA { get; set; }
        [DataMember]
        public string BatteryA_to { get; set; }
        [DataMember]
        public string BatteryCells { get; set; }
        [DataMember]
        public string BatteryInfo { get; set; }
        [DataMember]
        public string BatteryKWh { get; set; }
        [DataMember]
        public string BatteryKWh_to { get; set; }
        [DataMember]
        public string BatteryModules { get; set; }
        [DataMember]
        public string BatteryPacks { get; set; }
        [DataMember]
        public string BatteryType { get; set; }
        [DataMember]
        public string BatteryV { get; set; }
        [DataMember]
        public string BatteryV_to { get; set; }
        [DataMember]
        public string BedLengthIN { get; set; }
        [DataMember]
        public string BedType { get; set; }
        [DataMember]
        public string BlindSpotMon { get; set; }
        [DataMember]
        public string BodyCabType { get; set; }
        [DataMember]
        public string BodyClass { get; set; }
        [DataMember]
        public string BrakeSystemDesc { get; set; }
        [DataMember]
        public string BrakeSystemType { get; set; }
        [DataMember]
        public string BusFloorConfigType { get; set; }
        [DataMember]
        public string BusLength { get; set; }
        [DataMember]
        public string BusType { get; set; }
        [DataMember]
        public string CAFEBodyType { get; set; }
        [DataMember]
        public string CAFEMake { get; set; }
        [DataMember]
        public string CAFEModel { get; set; }
        [DataMember]
        public string CashForClunkers { get; set; }
        [DataMember]
        public string ChargerLevel { get; set; }
        [DataMember]
        public string ChargerPowerKW { get; set; }
        [DataMember]
        public string CoolingType { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string CurbWeightLB { get; set; }
        [DataMember]
        public string CustomMotorcycleType { get; set; }
        [DataMember]
        public string DestinationMarket { get; set; }
        [DataMember]
        public string DisplacementCC { get; set; }
        [DataMember]
        public string DisplacementCI { get; set; }
        [DataMember]
        public string DisplacementL { get; set; }
        [DataMember]
        public string Doors { get; set; }
        [DataMember]
        public string DriveType { get; set; }
        [DataMember]
        public string DriverAssist { get; set; }
        [DataMember]
        public string ESC { get; set; }
        [DataMember]
        public string EVDriveUnit { get; set; }
        [DataMember]
        public string ElectrificationLevel { get; set; }
        [DataMember]
        public string EngineConfiguration { get; set; }
        [DataMember]
        public string EngineCycles { get; set; }
        [DataMember]
        public string EngineCylinders { get; set; }
        [DataMember]
        public string EngineHP { get; set; }
        [DataMember]
        public string EngineHP_to { get; set; }
        [DataMember]
        public string EngineKW { get; set; }
        [DataMember]
        public string EngineManufacturer { get; set; }
        [DataMember]
        public string EngineModel { get; set; }
        [DataMember]
        public string EntertainmentSystem { get; set; }
        [DataMember]
        public string EquipmentType { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public string ForwardCollisionWarning { get; set; }
        [DataMember]
        public string FuelInjectionType { get; set; }
        [DataMember]
        public string FuelTypePrimary { get; set; }
        [DataMember]
        public string FuelTypeSecondary { get; set; }
        [DataMember]
        public string GVWR { get; set; }
        [DataMember]
        public string LaneDepartureWarning { get; set; }
        [DataMember]
        public string LaneKeepSystem { get; set; }
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        public string ManufacturerId { get; set; }
        [DataMember]
        public string ManufacturerType { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string ModelYear { get; set; }
        [DataMember]
        public string MotorcycleChassisType { get; set; }
        [DataMember]
        public string MotorcycleSuspensionType { get; set; }
        [DataMember]
        public string NCAPBodyType { get; set; }
        [DataMember]
        public string NCAPMake { get; set; }
        [DataMember]
        public string NCAPModel { get; set; }
        [DataMember]
        public string NCICCode { get; set; }
        [DataMember]
        public string NCSABodyType { get; set; }
        [DataMember]
        public string NCSAMake { get; set; }
        [DataMember]
        public string NCSAModel { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public string OtherBusInfo { get; set; }
        [DataMember]
        public string OtherEngineInfo { get; set; }
        [DataMember]
        public string OtherMotorcycleInfo { get; set; }
        [DataMember]
        public string OtherRestraintSystemInfo { get; set; }
        [DataMember]
        public string OtherTrailerInfo { get; set; }
        [DataMember]
        public string ParkAssist { get; set; }
        [DataMember]
        public string PlantCity { get; set; }
        [DataMember]
        public string PlantCompanyName { get; set; }
        [DataMember]
        public string PlantCountry { get; set; }
        [DataMember]
        public string PlantState { get; set; }
        [DataMember]
        public string PossibleValues { get; set; }
        [DataMember]
        public string Pretensioner { get; set; }
        [DataMember]
        public string RearVisibilityCamera { get; set; }
        [DataMember]
        public string SeatBeltsAll { get; set; }
        [DataMember]
        public string SeatRows { get; set; }
        [DataMember]
        public string Seats { get; set; }
        [DataMember]
        public string Series { get; set; }
        [DataMember]
        public string Series2 { get; set; }
        [DataMember]
        public string SteeringLocation { get; set; }
        [DataMember]
        public string SuggestedVIN { get; set; }
        [DataMember]
        public string TopSpeedMPH { get; set; }
        [DataMember]
        public string TrackWidth { get; set; }
        [DataMember]
        public string TractionControl { get; set; }
        [DataMember]
        public string TrailerBodyType { get; set; }
        [DataMember]
        public string TrailerLength { get; set; }
        [DataMember]
        public string TrailerType { get; set; }
        [DataMember]
        public string TransmissionSpeeds { get; set; }
        [DataMember]
        public string TransmissionStyle { get; set; }
        [DataMember]
        public string Trim { get; set; }
        [DataMember]
        public string Trim2 { get; set; }
        [DataMember]
        public string Turbo { get; set; }
        [DataMember]
        public string VIN { get; set; }
        [DataMember]
        public string ValveTrainDesign { get; set; }
        [DataMember]
        public string VehicleType { get; set; }
        [DataMember]
        public string WheelBaseLong { get; set; }
        [DataMember]
        public string WheelBaseShort { get; set; }
        [DataMember]
        public string WheelBaseType { get; set; }
        [DataMember]
        public string WheelSizeFront { get; set; }
        [DataMember]
        public string WheelSizeRear { get; set; }

        [DataMember]
        public string Wheels { get; set; }
        [DataMember]
        public string Windows { get; set; }
    }
}
