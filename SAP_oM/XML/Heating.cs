/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BH.oM.Base;
using System.Xml.Serialization;

namespace BH.oM.Environment.SAP.XML
{
    [Serializable]
    [XmlRoot(ElementName = "SAP-Heating", IsNullable = false)]
    public class Heating : IObject
    {
        [Description("The type of Water Heating present in the Property.")]
        [XmlElement("Water-Heating-Code")]
        public virtual string WaterHeatingCode { get; set; } = null;

        [Description("The type of fuel used to power the central heating e.g. Gas, Electricity.  Not used if water system is main or secondary system.")]
        [XmlElement("Water-Fuel-Type")]
        public virtual string WaterFuelType { get; set; } = null;

        [Description("Hot water cylinder?")]
        [XmlElement("Has-Hot-Water-Cylinder")]
        public virtual bool? HasHotWaterCylinder { get; set; } = null;

        [Description("Category of heating system for the secondary heating system.")]
        [XmlElement("Secondary-Heating-Category")]
        public virtual string SecondaryHeatingCategory { get; set; } = null;

        [Description("Source of secondary heating system data; only if secondary heating system.")]
        [XmlElement("Secondary-Heating-Data-Source")]
        public virtual string SecondaryHeatingDataSource { get; set; } = null;

        [Description("Type of secondary heating present in the property; only if required and if heating data source is SAP table.")]
        [XmlElement("Secondary-Heating-Code")]
        public virtual string SecondaryHeatingCode { get; set; } = null;

        [Description("The type of fuel used to power the secondary heating e.g. Gas, Electricity; only if required.")]
        [XmlElement("Secondary-Fuel-Type")]
        public virtual string SecondaryFuelType { get; set; } = null;

        [Description("Secondary flue type; only if secondary efficiency is manufacturer declaration and if there is a flue.")]
        [XmlElement("Secondary-Heating-Flue-Type")]
        public virtual string SecondaryHeatingFlueType { get; set; } = null;

        [Description("The type of thermal store; not used if main heating system is community heating scheme.")]
        [XmlElement("Thermal-Store")]
        public virtual string ThermalStore { get; set; } = null;

        [Description("Fixed air conditioning?")]
        [XmlElement("Has-Fixed-Air-Conditioning")]
        public virtual bool? HasFixedAirConditioning { get; set; } = null;

        [Description("The type of immersion heating; only if immersion.")]
        [XmlElement("Immersion-Heating-Type")]
        public virtual string ImmersionHeatingType { get; set; } = null;

        [Description("Heat pump assisted by immersion?  Only if main heating is heat pump and water heating from heat pump.")]
        [XmlElement("Is-Heat-Pump-Assisted-By-Immersion")]
        public virtual bool? IsHeatPumpAssistedByImmersion { get; set; } = null;

        [Description("Immersion for summer use?  Only if main heating is solid fuel fire or room heater with boiler.")]
        [XmlElement("Is-Immersion-For-Summer-Use")]
        public virtual bool? IsImmersionForSummerUse { get; set; } = null;

        [Description("Secondary heating appliance is HETAS approved?  Only if solid fuel.")]
        [XmlElement("Is-Secondary-Heating-HETAS-Approved")]
        public virtual bool? IsSecondaryHeatingHETASApproved { get; set; } = null;

        [Description("Hot water store size in litres; if there is a hot water store.  Store refers to hot water store type which can be cylinder (if thermal store is 'none'), hot-water only thermal store or integrated thermal store.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater.")]
        [XmlElement("Hot-Water-Store-Size")]
        public virtual string HotWaterStoreSize { get; set; } = null;

        [Description("Used when a heat pump is associated with a separate and specified hot water vessel.")]
        [XmlElement("Hot-Water-Store-Heat-Transfer-Area")]
        public virtual string HotWaterStoreHeatTransferArea { get; set; } = null;

        [Description("The source of the hot water store heat loss information; if there is a hot water store.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater.")]
        [XmlElement("Hot-Water-Store-Heat-Loss-Source")]
        public virtual string HotWaterStoreHeatLossSource { get; set; } = null;

        [Description("Hot water store declared loss in kWh/day; only if there is a hot water store and if manufacturer declared loss.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater.")]
        [XmlElement("Hot-Water-Store-Heat-Loss")]
        public virtual string HotWaterStoreHeatLoss { get; set; } = null;

        [Description("Hot water store insulation; only if there is a hot water store and if loss from SAP table.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater.")]
        [XmlElement("Hot-Water-Store-Insulation-Type")]
        public virtual string HotWaterStoreInsulationType { get; set; } = null;

        [Description("Hot water store insulation thickness in mm; only if there is a hot water store and if loss from SAP table.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater.")]
        [XmlElement("Hot-Water-Store-Insulation-Thickness")]
        public virtual string HotWaterInsulationThickness { get; set; } = null;

        [Description("Thermal store connected to boiler by no more than 1.5 m of insulated pipework?  Only if thermal store.  Not applicable if combi boiler or instantaneous water heater.")]
        [XmlElement("Is-Thermal-Store-Near-Boiler")]
        public virtual bool? IsThermalStoreNearBoiler { get; set; } = null;

        [Description("Thermal store or CPSU in airing cupboard?  Only if (a) boiler with integrated or hot-water-only thermal store, or (b) main heating is CPSU.")]
        [XmlElement("Is-Thermal-Store-Or-CPSU-In-Airing-Cupboard")]
        public virtual bool? IsThermalStoreOrCPSUInAiringCupboard { get; set; } = null;

        [Description("Hot water cylinder thermostat?  Not applicable if combi boiler or instantaneous water heater.")]
        [XmlElement("Has-Cylinder-Thermostat")]
        public virtual bool? HasCylinderThermostat { get; set; } = null;

        [Description("Hot water cylinder in heated space?  Not applicable if combi boiler or instantaneous water heater.")]
        [XmlElement("Is-Cylinder-In-Heated-Space")]
        public virtual bool? IsCylinderInHeatedSpace { get; set; } = null;

        [Description(">Hot water separately timed?  Not applicable if combi boiler or instantaneous water heater.")]
        [XmlElement("Is-Hot-Water-Separately-Timed")]
        public virtual bool? IsHotWaterSeperatlyTimed { get; set; } = null;

        [Description("")]
        [XmlElement("SAP-Community-Heating-Systems")]
        public virtual CommunityHeatingSystems CommunityHeatingSystems { get; set; } = new CommunityHeatingSystems();

        [Description("")]
        [XmlElement("Main-Heating-Details")]
        public virtual MainHeatingDetails MainHeatingDetails { get; set; } = new MainHeatingDetails();

        [Description("")]
        [XmlElement("SAP-Heating-Design-Water-Use")]
        public virtual string HeatingDesignWaterUse { get; set; } = null;

        [Description("")]
        [XmlElement("Main-Heating-Systems-Interaction")]
        public virtual string MainHeatingSystemsInteraction { get; set; } = null;

        [Description("Use when manufacturer’s declared values.")]
        [XmlElement("Secondary-Heating-Declared-Values")]
        public virtual HeatingDeclaredValues SecondaryHeatingDeclaredValues { get; set; } = new HeatingDeclaredValues();

        [Description("Not applicable to combi boiler or instantaneous water heater.")]
        [XmlElement("Primary-Pipework-Insulation")] 
        public virtual string PrimaryPipeworkInsulation { get; set; } = null;

        [Description("")]
        [XmlElement("Solar-Heating-Details")]
        public virtual SolarHeatingDetails SolarHeatingDetails { get; set; } = new SolarHeatingDetails();

        [Description("Waste Water Heat Recovery System.")]
        [XmlElement("Instantaneous-WWHRS")] 
        public virtual InstantaneousWWHRS InstantaneousWHRS { get; set; } = new InstantaneousWWHRS();

        [Description("")]
        [XmlElement("Storage-WWHRS")] 
        public virtual StorageWWHRS StorageWHRS { get; set; } = new StorageWWHRS();

        public bool ShouldSerializeHasHotWaterCylinder()
        {
            return HasHotWaterCylinder.HasValue;
        }
        public bool ShouldSerializeHasFixedAirConditioning()
        {
            return HasFixedAirConditioning.HasValue;
        }
        public bool ShouldSerializeIsHeatPumpAssistedByImmersion()
        {
            return IsHeatPumpAssistedByImmersion.HasValue;
        }
        public bool ShouldSerializeIsImmersionForSummerUse()
        {
            return IsImmersionForSummerUse.HasValue;
        }
        public bool ShouldSerializeIsSecondaryHeatingHETASApproved()
        {
            return IsSecondaryHeatingHETASApproved.HasValue;
        }
        public bool ShouldSerializeIsThermalStoreNearBoiler()
        {
            return IsThermalStoreNearBoiler.HasValue;
        }
        public bool ShouldSerializeIsThermalStoreOrCPSUInAiringCupboard()
        {
            return IsThermalStoreOrCPSUInAiringCupboard.HasValue;
        }
        public bool ShouldSerializeHasCylinderThermostat()
        {
            return HasCylinderThermostat.HasValue;
        }
        public bool ShouldSerializeIsCylinderInHeatedSpace()
        {
            return IsCylinderInHeatedSpace.HasValue;
        }
        public bool ShouldSerializeIsHotWaterSeperatlyTimed()
        {
            return IsHotWaterSeperatlyTimed.HasValue;
        }
    }
}

