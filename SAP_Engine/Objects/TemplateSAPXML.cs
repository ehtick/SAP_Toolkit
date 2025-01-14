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

//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Xml.Serialization;
//using System.ComponentModel;
//using BH.oM.Base;

//namespace BH.Engine.Environment.SAP
//{
//    // using System.Xml.Serialization;
//    // XmlSerializer serializer = new XmlSerializer(typeof(SAPReport));
//    // using (StringReader reader = new StringReader(xml))
//    // {
//    //    var test = (SAPReport)serializer.Deserialize(reader);
//    // }
//    [Serializable]
//    [XmlRoot(ElementName = "Contact-Address.")]
//    public class ContactAddress : IObject
//    {

//        [XmlElement(ElementName = "Address-Line-1.")]
//        public string AddressLine1 { get; set; }

//        [XmlElement(ElementName = "Address-Line-2.")]
//        public string AddressLine2 { get; set; }

//        [XmlElement(ElementName = "Post-Town.")]
//        public string PostTown { get; set; }

//        [XmlElement(ElementName = "Postcode.")]
//        public string Postcode { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Identification-Number.")]
//    public class IdentificationNumber : IObject
//    {

//        [XmlElement(ElementName = "Certificate-Number.")]
//        public string CertificateNumber { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Home-Inspector.")]
//    public class HomeInspector : IObject
//    {

//        [XmlElement(ElementName = "Name.")]
//        public string Name { get; set; }

//        [XmlElement(ElementName = "Notify-Lodgement.")]
//        public string NotifyLodgement { get; set; }

//        [XmlElement(ElementName = "Contact-Address.")]
//        public ContactAddress ContactAddress { get; set; }

//        [XmlElement(ElementName = "Web-Site.")]
//        public string WebSite { get; set; }

//        [XmlElement(ElementName = "E-Mail.")]
//        public string EMail { get; set; }

//        [XmlElement(ElementName = "Fax.")]
//        public string Fax { get; set; }

//        [XmlElement(ElementName = "Telephone.")]
//        public string Telephone { get; set; }

//        [XmlElement(ElementName = "Company-Name.")]
//        public string CompanyName { get; set; }

//        [XmlElement(ElementName = "Scheme-Name.")]
//        public string SchemeName { get; set; }

//        [XmlElement(ElementName = "Scheme-Web-Site.")]
//        public string SchemeWebSite { get; set; }

//        [XmlElement(ElementName = "Identification-Number.")]
//        public IdentificationNumber IdentificationNumber { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Address.")]
//    public class Address : IObject
//    {

//        [XmlElement(ElementName = "Address-Line-1.")]
//        public object AddressLine1 { get; set; }

//        [XmlElement(ElementName = "Post-Town.")]
//        public object PostTown { get; set; }

//        [XmlElement(ElementName = "Postcode.")]
//        public string Postcode { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Property.")]
//    public class Property : IObject
//    {

//        [XmlElement(ElementName = "Address.")]
//        public Address Address { get; set; }

//        [XmlElement(ElementName = "UPRN.")]
//        public int UPRN { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Related-Party-Disclosure.")]
//    public class RelatedPartyDisclosure : IObject
//    {

//        [XmlElement(ElementName = "Related-Party-Disclosure-Number.")]
//        public int RelatedPartyDisclosureNumber { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Report-Header.")]
//    public class ReportHeader : IObject
//    {

//        [XmlElement(ElementName = "RRN.")]
//        public string RRN { get; set; }

//        [XmlElement(ElementName = "Inspection-Date.")]
//        public string InspectionDate { get; set; }

//        [XmlElement(ElementName = "Report-Type.")]
//        public int ReportType { get; set; }

//        [XmlElement(ElementName = "Completion-Date.")]
//        public string CompletionDate { get; set; }

//        [XmlElement(ElementName = "Registration-Date.")]
//        public string RegistrationDate { get; set; }

//        [XmlElement(ElementName = "Status.")]
//        public string Status { get; set; }

//        [XmlElement(ElementName = "Language-Code.")]
//        public int LanguageCode { get; set; }

//        [XmlElement(ElementName = "Tenure.")]
//        public string Tenure { get; set; }

//        [XmlElement(ElementName = "Transaction-Type.")]
//        public int TypeOfTransaction { get; set; }

//        [XmlElement(ElementName = "Seller-Commission-Report.")]
//        public string SellerCommissionReport { get; set; }

//        [XmlElement(ElementName = "Property-Type.")]
//        public int PropertyType { get; set; }

//        [XmlElement(ElementName = "Home-Inspector.")]
//        public HomeInspector HomeInspector { get; set; }

//        [XmlElement(ElementName = "Property.")]
//        public Property Property { get; set; }

//        [XmlElement(ElementName = "Region-Code.")]
//        public int RegionCode { get; set; }

//        [XmlElement(ElementName = "Country-Code.")]
//        public string CountryCode { get; set; }

//        [XmlElement(ElementName = "Related-Party-Disclosure.")]
//        public RelatedPartyDisclosure RelatedPartyDisclosure { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Walls.")]
//    public class Walls : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Roof.")]
//    public class Roof : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Floor.")]
//    public class Floor : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Windows.")]
//    public class Windows : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Main-Heating.")]
//    public class MainHeating : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Number.")]
//        public int MainHeatingNumber { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Category.")]
//        public int MainHeatingCategory { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Fraction.")]
//        public int MainHeatingFraction { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Data-Source.")]
//        public int MainHeatingDataSource { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Index-Number.")]
//        public int MainHeatingIndexNumber { get; set; }

//        [XmlElement(ElementName = "Emitter-Temperature.")]
//        public int EmitterTemperature { get; set; }

//        [XmlElement(ElementName = "Central-Heating-Pump-Age.")]
//        public int CentralHeatingPumpAge { get; set; }

//        [XmlElement(ElementName = "Main-Fuel-Type.")]
//        public int MainFuelType { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Control.")]
//        public int MainHeatingControl { get; set; }

//        [XmlElement(ElementName = "Heat-Emitter-Type.")]
//        public int HeatEmitterType { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Flue-Type.")]
//        public int MainHeatingFlueType { get; set; }

//        [XmlElement(ElementName = "Is-Flue-Fan-Present.")]
//        public bool IsFlueFanPresent { get; set; }

//        [XmlElement(ElementName = "Is-Central-Heating-Pump-In-Heated-Space.")]
//        public bool IsCentralHeatingPumpInHeatedSpace { get; set; }

//        [XmlElement(ElementName = "Is-Interlocked-System.")]
//        public bool IsInterlockedSystem { get; set; }

//        [XmlElement(ElementName = "Has-Separate-Delayed-Start.")]
//        public bool HasSeparateDelayedStart { get; set; }

//        [XmlElement(ElementName = "Load-Or-Weather-Compensation.")]
//        public int LoadOrWeatherCompensation { get; set; }

//        [XmlElement(ElementName = "Has-FGHRS.")]
//        public bool HasFGHRS { get; set; }

//        [XmlElement(ElementName = "FGHRS-Index-Number.")]
//        public int FGHRSIndexNumber { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Main-Heating-Controls.")]
//    public class MainHeatingControls : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Secondary-Heating.")]
//    public class SecondaryHeating : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Hot-Water.")]
//    public class HotWater : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Lighting.")]
//    public class Lighting : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Air-Tightness.")]
//    public class AirTightness : IObject
//    {

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Energy-Efficiency-Rating.")]
//        public int EnergyEfficiencyRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Efficiency-Rating.")]
//        public int EnvironmentalEfficiencyRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Property-Summary.")]
//    public class PropertySummary : IObject
//    {

//        [XmlElement(ElementName = "Walls.")]
//        public oM.Environment.SAP.XML.Wall Walls { get; set; }

//        [XmlElement(ElementName = "Roof.")]
//        public oM.Environment.SAP.XML.Roof Roof { get; set; }

//        [XmlElement(ElementName = "Floor.")]
//        public Floor Floor { get; set; }

//        [XmlElement(ElementName = "Windows.")]
//        public Windows Windows { get; set; }

//        [XmlElement(ElementName = "Main-Heating.")]
//        public oM.Environment.SAP.XML.MainHeating MainHeating { get; set; }

//        [XmlElement(ElementName = "Main-Heating-Controls.")]
//        public MainHeatingControls MainHeatingControls { get; set; }

//        [XmlElement(ElementName = "Secondary-Heating.")]
//        public SecondaryHeating SecondaryHeating { get; set; }

//        [XmlElement(ElementName = "Hot-Water.")]
//        public HotWater HotWater { get; set; }

//        [XmlElement(ElementName = "Lighting.")]
//        public Lighting Lighting { get; set; }

//        [XmlElement(ElementName = "Air-Tightness.")]
//        public AirTightness AirTightness { get; set; }

//        [XmlElement(ElementName = "Has-Fixed-Air-Conditioning.")]
//        public bool HasFixedAirConditioning { get; set; }

//        [XmlElement(ElementName = "Has-Hot-Water-Cylinder.")]
//        public bool HasHotWaterCylinder { get; set; }

//        [XmlElement(ElementName = "Has-Heated-Separate-Conservatory.")]
//        public bool HasHeatedSeparateConservatory { get; set; }

//        [XmlElement(ElementName = "Dwelling-Type.")]
//        public string DwellingType { get; set; }

//        [XmlElement(ElementName = "Total-Floor-Area.")]
//        public int TotalFloorArea { get; set; }

//        [XmlElement(ElementName = "Multiple-Glazed-Percentage.")]
//        public int MultipleGlazedPercentage { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Lighting-Cost-Current.")]
//    public class LightingCostCurrent : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Lighting-Cost-Potential.")]
//    public class LightingCostPotential : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Heating-Cost-Current.")]
//    public class HeatingCostCurrent : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Heating-Cost-Potential.")]
//    public class HeatingCostPotential : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Hot-Water-Cost-Current.")]
//    public class HotWaterCostCurrent : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Hot-Water-Cost-Potential.")]
//    public class HotWaterCostPotential : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Energy-Use.")]
//    public class EnergyUse : IObject
//    {

//        [XmlElement(ElementName = "Energy-Rating-Average.")]
//        public int EnergyRatingAverage { get; set; }

//        [XmlElement(ElementName = "Energy-Rating-Current.")]
//        public int EnergyRatingCurrent { get; set; }

//        [XmlElement(ElementName = "Energy-Rating-Potential.")]
//        public int EnergyRatingPotential { get; set; }

//        [XmlElement(ElementName = "Environmental-Impact-Current.")]
//        public int EnvironmentalImpactCurrent { get; set; }

//        [XmlElement(ElementName = "Environmental-Impact-Potential.")]
//        public int EnvironmentalImpactPotential { get; set; }

//        [XmlElement(ElementName = "Energy-Consumption-Current.")]
//        public int EnergyConsumptionCurrent { get; set; }

//        [XmlElement(ElementName = "Energy-Consumption-Potential.")]
//        public int EnergyConsumptionPotential { get; set; }

//        [XmlElement(ElementName = "CO2-Emissions-Current.")]
//        public string CO2EmissionsCurrent { get; set; }

//        [XmlElement(ElementName = "CO2-Emissions-Potential.")]
//        public string CO2EmissionsPotential { get; set; }

//        [XmlElement(ElementName = "CO2-Emissions-Current-Per-Floor-Area.")]
//        public int CO2EmissionsCurrentPerFloorArea { get; set; }

//        [XmlElement(ElementName = "Lighting-Cost-Current.")]
//        public LightingCostCurrent LightingCostCurrent { get; set; }

//        [XmlElement(ElementName = "Lighting-Cost-Potential.")]
//        public LightingCostPotential LightingCostPotential { get; set; }

//        [XmlElement(ElementName = "Heating-Cost-Current.")]
//        public HeatingCostCurrent HeatingCostCurrent { get; set; }

//        [XmlElement(ElementName = "Heating-Cost-Potential.")]
//        public HeatingCostPotential HeatingCostPotential { get; set; }

//        [XmlElement(ElementName = "Hot-Water-Cost-Current.")]
//        public HotWaterCostCurrent HotWaterCostCurrent { get; set; }

//        [XmlElement(ElementName = "Hot-Water-Cost-Potential.")]
//        public HotWaterCostPotential HotWaterCostPotential { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Improvement-Details.")]
//    public class ImprovementDetails : IObject
//    {

//        [XmlElement(ElementName = "Improvement-Number.")]
//        public int ImprovementNumber { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Typical-Saving.")]
//    public class TypicalSaving : IObject
//    {

//        [XmlAttribute(AttributeName = "currency.")]
//        public string Currency { get; set; }

//        [XmlText]
//        public int Text { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Improvement.")]
//    public class Improvement : IObject
//    {

//        [XmlElement(ElementName = "Sequence.")]
//        public int Sequence { get; set; }

//        [XmlElement(ElementName = "Improvement-Category.")]
//        public int ImprovementCategory { get; set; }

//        [XmlElement(ElementName = "Green-Deal-Category.")]
//        public string GreenDealCategory { get; set; }

//        [XmlElement(ElementName = "Improvement-Type.")]
//        public string ImprovementType { get; set; }

//        [XmlElement(ElementName = "Improvement-Details.")]
//        public ImprovementDetails ImprovementDetails { get; set; }

//        [XmlElement(ElementName = "Typical-Saving.")]
//        public TypicalSaving TypicalSaving { get; set; }

//        [XmlElement(ElementName = "Indicative-Cost.")]
//        public string IndicativeCost { get; set; }

//        [XmlElement(ElementName = "Energy-Performance-Rating.")]
//        public int EnergyPerformanceRating { get; set; }

//        [XmlElement(ElementName = "Environmental-Impact-Rating.")]
//        public int EnvironmentalImpactRating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Suggested-Improvements.")]
//    public class SuggestedImprovements : IObject
//    {

//        [XmlElement(ElementName = "Improvement.")]
//        public Improvement Improvement { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "LZC-Energy-Sources.")]
//    public class LZCEnergySources : IObject
//    {

//        [XmlElement(ElementName = "LZC-Energy-Source.")]
//        public int LZCEnergySource { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "RHI-New-Dwelling.")]
//    public class RHINewDwelling : IObject
//    {

//        [XmlElement(ElementName = "Space-Heating.")]
//        public int SpaceHeating { get; set; }

//        [XmlElement(ElementName = "Water-Heating.")]
//        public int WaterHeating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Renewable-Heat-Incentive.")]
//    public class RenewableHeatIncentive : IObject
//    {

//        [XmlElement(ElementName = "RHI-New-Dwelling.")]
//        public RHINewDwelling RHINewDwelling { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Energy-Assessment.")]
//    public class EnergyAssessment : IObject
//    {

//        [XmlElement(ElementName = "Assessment-Date.")]
//        public string AssessmentDate { get; set; }

//        [XmlElement(ElementName = "Property-Summary.")]
//        public PropertySummary PropertySummary { get; set; }

//        [XmlElement(ElementName = "Energy-Use.")]
//        public EnergyUse EnergyUse { get; set; }

//        [XmlElement(ElementName = "Suggested-Improvements.")]
//        public SuggestedImprovements SuggestedImprovements { get; set; }

//        [XmlElement(ElementName = "LZC-Energy-Sources.")]
//        public LZCEnergySources LZCEnergySources { get; set; }

//        [XmlElement(ElementName = "Renewable-Heat-Incentive.")]
//        public RenewableHeatIncentive RenewableHeatIncentive { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Opening-Type.")]
//    public class SAPOpeningType : IObject
//    {

//        [XmlElement(ElementName = "Name.")]
//        public string Name { get; set; }

//        [XmlElement(ElementName = "Description.")]
//        public string Description { get; set; }

//        [XmlElement(ElementName = "Data-Source.")]
//        public int DataSource { get; set; }

//        [XmlElement(ElementName = "Type.")]
//        public int Type { get; set; }

//        [XmlElement(ElementName = "Glazing-Type.")]
//        public int GlazingType { get; set; }

//        [XmlElement(ElementName = "U-Value.")]
//        public string UValue { get; set; }

//        [XmlElement(ElementName = "Solar-Transmittance.")]
//        public double SolarTransmittance { get; set; }

//        [XmlElement(ElementName = "Frame-Factor.")]
//        public double FrameFactor { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Opening-Types.")]
//    public class SAPOpeningTypes : IObject
//    {

//        [XmlElement(ElementName = "SAPOpeningType.")]
//        public List<SAPOpeningType> SAPOpeningType { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Opening.")]
//    public class SAPOpening : IObject
//    {

//        [XmlElement(ElementName = "Name.")]
//        public int Name { get; set; }

//        [XmlElement(ElementName = "Type.")]
//        public string Type { get; set; }

//        [XmlElement(ElementName = "Location.")]
//        public string Location { get; set; }

//        [XmlElement(ElementName = "Orientation.")]
//        public int Orientation { get; set; }

//        [XmlElement(ElementName = "Width.")]
//        public string Width { get; set; }

//        [XmlElement(ElementName = "Height.")]
//        public string Height { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Openings.")]
//    public class SAPOpenings : IObject
//    {

//        [XmlElement(ElementName = "SAPOpening.")]
//        public List<SAPOpening> SAPOpening { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Floor-Dimension.")]
//    public class SAPFloorDimension : IObject
//    {

//        [XmlElement(ElementName = "Storey.")]
//        public int Storey { get; set; }

//        [XmlElement(ElementName = "Description.")]
//        public object Description { get; set; }

//        [XmlElement(ElementName = "Floor-Type.")]
//        public int FloorType { get; set; }

//        [XmlElement(ElementName = "Total-Floor-Area.")]
//        public double TotalFloorArea { get; set; }

//        [XmlElement(ElementName = "Storey-Height.")]
//        public string StoreyHeight { get; set; }

//        [XmlElement(ElementName = "Heat-Loss-Area.")]
//        public double HeatLossArea { get; set; }

//        [XmlElement(ElementName = "U-Value.")]
//        public double UValue { get; set; }

//        [XmlElement(ElementName = "Kappa-Value.")]
//        public int KappaValue { get; set; }

//        [XmlElement(ElementName = "Kappa-Value-From-Below.")]
//        public int KappaValueFromBelow { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Floor-Dimensions.")]
//    public class SAPFloorDimensions : IObject
//    {

//        [XmlElement(ElementName = "SAPFloorDimension.")]
//        public List<SAPFloorDimension> SAPFloorDimension { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Roof.")]
//    public class SAPRoof : IObject
//    {

//        [XmlElement(ElementName = "Name.")]
//        public string Name { get; set; }

//        [XmlElement(ElementName = "Description.")]
//        public object Description { get; set; }

//        [XmlElement(ElementName = "Roof-Type.")]
//        public int RoofType { get; set; }

//        [XmlElement(ElementName = "Total-Roof-Area.")]
//        public double TotalRoofArea { get; set; }

//        [XmlElement(ElementName = "U-Value.")]
//        public double UValue { get; set; }

//        [XmlElement(ElementName = "Kappa-Value.")]
//        public int KappaValue { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Roofs.")]
//    public class SAPRoofs : IObject
//    {

//        [XmlElement(ElementName = "SAP-Roof.")]
//        public oM.Environment.SAP.XML.Roof SAPRoof { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Wall.")]
//    public class SAPWall : IObject
//    {

//        [XmlElement(ElementName = "Name.")]
//        public string Name { get; set; }

//        [XmlElement(ElementName = "Description.")]
//        public object Description { get; set; }

//        [XmlElement(ElementName = "Wall-Type.")]
//        public int WallType { get; set; }

//        [XmlElement(ElementName = "Total-Wall-Area.")]
//        public double TotalWallArea { get; set; }

//        [XmlElement(ElementName = "U-Value.")]
//        public double UValue { get; set; }

//        [XmlElement(ElementName = "Kappa-Value.")]
//        public int KappaValue { get; set; }

//        [XmlElement(ElementName = "Is-Curtain-Walling.")]
//        public bool IsCurtainWalling { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Walls.")]
//    public class SAPWalls : IObject
//    {

//        [XmlElement(ElementName = "SAPWall.")]
//        public List<oM.Environment.SAP.XML.Wall> SAPWall { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Thermal-Bridge.")]
//    public class SAPThermalBridge : IObject
//    {

//        [XmlElement(ElementName = "Thermal-Bridge-Type.")]
//        public string ThermalBridgeType { get; set; }

//        [XmlElement(ElementName = "Length.")]
//        public double Length { get; set; }

//        [XmlElement(ElementName = "Psi-Value.")]
//        public double PsiValue { get; set; }

//        [XmlElement(ElementName = "Psi-Value-Source.")]
//        public int PsiValueSource { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Thermal-Bridges.")]
//    public class SAPThermalBridges : IObject
//    {

//        [XmlElement(ElementName = "Thermal-Bridge-Code.")]
//        public int ThermalBridgeCode { get; set; }

//        [XmlElement(ElementName = "SAPThermalBridge.")]
//        public List<oM.Environment.SAP.XML.ThermalBridge> SAPThermalBridge { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Building-Part.")]
//    public class SAPBuildingPart : IObject
//    {

//        [XmlElement(ElementName = "Building-Part-Number.")]
//        public int BuildingPartNumber { get; set; }

//        [XmlElement(ElementName = "Identifier.")]
//        public string Identifier { get; set; }

//        [XmlElement(ElementName = "Construction-Year.")]
//        public int ConstructionYear { get; set; }

//        [XmlElement(ElementName = "Overshading.")]
//        public int Overshading { get; set; }

//        [XmlElement(ElementName = "SAP-Openings.")]
//        public SAPOpenings SAPOpenings { get; set; }

//        [XmlElement(ElementName = "SAP-Floor-Dimensions.")]
//        public SAPFloorDimensions SAPFloorDimensions { get; set; }

//        [XmlElement(ElementName = "SAP-Roofs.")]
//        public SAPRoofs SAPRoofs { get; set; }

//        [XmlElement(ElementName = "SAP-Walls.")]
//        public SAPWalls SAPWalls { get; set; }

//        [XmlElement(ElementName = "SAP-Thermal-Bridges.")]
//        public SAPThermalBridges SAPThermalBridges { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Building-Parts.")]
//    public class SAPBuildingParts : IObject
//    {

//        [XmlElement(ElementName = "SAP-Building-Part.")]
//        public SAPBuildingPart SAPBuildingPart { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Ventilation.")]
//    public class SAPVentilation : IObject
//    {

//        [XmlElement(ElementName = "Open-Fireplaces-Count.")]
//        public int OpenFireplacesCount { get; set; }

//        [XmlElement(ElementName = "Open-Flues-Count.")]
//        public int OpenFluesCount { get; set; }

//        [XmlElement(ElementName = "Extract-Fans-Count.")]
//        public int ExtractFansCount { get; set; }

//        [XmlElement(ElementName = "PSV-Count.")]
//        public int PSVCount { get; set; }

//        [XmlElement(ElementName = "Flueless-Gas-Fires-Count.")]
//        public int FluelessGasFiresCount { get; set; }

//        [XmlElement(ElementName = "Pressure-Test.")]
//        public int PressureTest { get; set; }

//        [XmlElement(ElementName = "Air-Permeability.")]
//        public int AirPermeability { get; set; }

//        [XmlElement(ElementName = "Sheltered-Sides-Count.")]
//        public int ShelteredSidesCount { get; set; }

//        [XmlElement(ElementName = "Ventilation-Type.")]
//        public int VentilationType { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Main-Heating-Details.")]
//    public class MainHeatingDetails : IObject
//    {

//        [XmlElement(ElementName = "Main-Heating.")]
//        public MainHeating MainHeating { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Heating.")]
//    public class SAPHeating : IObject
//    {

//        [XmlElement(ElementName = "Main-Heating-Details.")]
//        public MainHeatingDetails MainHeatingDetails { get; set; }

//        [XmlElement(ElementName = "Secondary-Heating-Category.")]
//        public int SecondaryHeatingCategory { get; set; }

//        [XmlElement(ElementName = "Secondary-Heating-Data-Source.")]
//        public int SecondaryHeatingDataSource { get; set; }

//        [XmlElement(ElementName = "Secondary-Fuel-Type.")]
//        public int SecondaryFuelType { get; set; }

//        [XmlElement(ElementName = "Secondary-Heating-Code.")]
//        public int SecondaryHeatingCode { get; set; }

//        [XmlElement(ElementName = "Secondary-Heating-Flue-Type.")]
//        public int SecondaryHeatingFlueType { get; set; }

//        [XmlElement(ElementName = "Is-Secondary-Heating-HETAS-Approved.")]
//        public bool IsSecondaryHeatingHETASApproved { get; set; }

//        [XmlElement(ElementName = "Has-Fixed-Air-Conditioning.")]
//        public bool HasFixedAirConditioning { get; set; }

//        [XmlElement(ElementName = "Water-Heating-Code.")]
//        public int WaterHeatingCode { get; set; }

//        [XmlElement(ElementName = "Water-Fuel-Type.")]
//        public int WaterFuelType { get; set; }

//        [XmlElement(ElementName = "Has-Hot-Water-Cylinder.")]
//        public bool HasHotWaterCylinder { get; set; }

//        [XmlElement(ElementName = "Thermal-Store.")]
//        public int ThermalStore { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Energy-Source.")]
//    public class SAPEnergySource : IObject
//    {

//        [XmlElement(ElementName = "Wind-Turbines-Count.")]
//        public int WindTurbinesCount { get; set; }

//        [XmlElement(ElementName = "Wind-Turbine-Terrain-Type.")]
//        public int WindTurbineTerrainType { get; set; }

//        [XmlElement(ElementName = "Fixed-Lighting-Outlets-Count.")]
//        public int FixedLightingOutletsCount { get; set; }

//        [XmlElement(ElementName = "Low-Energy-Fixed-Lighting-Outlets-Count.")]
//        public int LowEnergyFixedLightingOutletsCount { get; set; }

//        [XmlElement(ElementName = "Low-Energy-Fixed-Lighting-Outlets-Percentage.")]
//        public int LowEnergyFixedLightingOutletsPercentage { get; set; }

//        [XmlElement(ElementName = "Electricity-Tariff.")]
//        public int ElectricityTariff { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Property-Details.")]
//    public class SAPPropertyDetails : IObject
//    {

//        [XmlElement(ElementName = "Property-Type.")]
//        public int PropertyType { get; set; }

//        [XmlElement(ElementName = "Built-Form.")]
//        public int BuiltForm { get; set; }

//        [XmlElement(ElementName = "Living-Area.")]
//        public double LivingArea { get; set; }

//        [XmlElement(ElementName = "Orientation.")]
//        public int Orientation { get; set; }

//        [XmlElement(ElementName = "Conservatory-Type.")]
//        public int ConservatoryType { get; set; }

//        [XmlElement(ElementName = "Is-In-Smoke-Control-Area.")]
//        public string IsInSmokeControlArea { get; set; }

//        [XmlElement(ElementName = "SAP-Opening-Types.")]
//        public SAPOpeningTypes SAPOpeningTypes { get; set; }

//        [XmlElement(ElementName = "SAP-Building-Parts.")]
//        public SAPBuildingParts SAPBuildingParts { get; set; }

//        [XmlElement(ElementName = "SAP-Ventilation.")]
//        public SAPVentilation SAPVentilation { get; set; }

//        [XmlElement(ElementName = "SAP-Heating.")]
//        public SAPHeating SAPHeating { get; set; }

//        [XmlElement(ElementName = "SAP-Energy-Source.")]
//        public SAPEnergySource SAPEnergySource { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP2012-Data.")]
//    public class SAP2012Data : IObject
//    {

//        [XmlElement(ElementName = "Data-Type.")]
//        public int DataType { get; set; }

//        [XmlElement(ElementName = "SAP-Property-Details.")]
//        public SAPPropertyDetails SAPPropertyDetails { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "Insurance-Details.")]
//    public class InsuranceDetails : IObject
//    {

//        [XmlElement(ElementName = "Insurer.")]
//        public string Insurer { get; set; }

//        [XmlElement(ElementName = "Policy-No.")]
//        public int PolicyNo { get; set; }

//        [XmlElement(ElementName = "Effective-Date.")]
//        public string EffectiveDate { get; set; }

//        [XmlElement(ElementName = "Expiry-Date.")]
//        public string ExpiryDate { get; set; }

//        [XmlElement(ElementName = "PI-Limit.")]
//        public int PILimit { get; set; }
//    }
//    [Serializable]
//    [XmlRoot(ElementName = "SAP-Report", IsNullable = false, Namespace = "http://www.epcregister.com/xsd/sap")]
//    public class SAPReport : XMLPrintObject, IResultObject
//    {

//        [XmlElement(ElementName = "Schema-Version-Original.")]
//        public string SchemaVersionOriginal { get; set; }

//        [XmlElement(ElementName = "SAP-Version.")]
//        public double SAPVersion { get; set; }

//        [XmlElement(ElementName = "SAP-Data-Version.")]
//        public double SAPDataVersion { get; set; }

//        [XmlElement(ElementName = "PCDF-Revision-Number.")]
//        public int PCDFRevisionNumber { get; set; }

//        [XmlElement(ElementName = "Calculation-Software-Name.")]
//        public string CalculationSoftwareName { get; set; }

//        [XmlElement(ElementName = "Calculation-Software-Version.")]
//        public string CalculationSoftwareVersion { get; set; }

//        [XmlElement(ElementName = "Report-Header.")]
//        public ReportHeader ReportHeader { get; set; }

//        [XmlElement(ElementName = "Energy-Assessment.")]
//        public EnergyAssessment EnergyAssessment { get; set; }

//        [XmlElement(ElementName = "SAP2012-Data.")]
//        public BH.oM.Environment.SAP.XML.SAP10Data SAP10Data { get; set; }
//        //public BH.oM.Environment.SAP.XML.SAP2012Data SAP2012Data { get; set; }

//        [XmlElement(ElementName = "Insurance-Details.")]
//        public InsuranceDetails InsuranceDetails { get; set; }

//        [XmlElement(ElementName = "ExternalDefinitions-Revision-Number.")]
//        public string ExternalDefinitionsRevisionNumber { get; set; }

//        [XmlAttribute(AttributeName = "xsi.")]
//        public string Xsi { get; set; }

//        [XmlAttribute(AttributeName = "xmlns.")]
//        public string Xmlns { get; set; }

//        [XmlAttribute(AttributeName = "schemaLocation.")]
//        public string SchemaLocation { get; set; }

//        [XmlText]
//        public string Text { get; set; }

//    }

//    public class XMLPrintObject : IBHoMObject
//    {
//        [XmlIgnore]
//        public virtual Guid BHoM_Guid { get; set; }

//        [XmlIgnore]
//        public virtual string Name { get; set; }

//        [XmlIgnore]
//        public virtual FragmentSet Fragments { get; set; }

//        [XmlIgnore]
//        public virtual HashSet<string> Tags { get; set; }

//        [XmlIgnore]
//        public virtual Dictionary<string, object> CustomData { get; set; }
//    }
//}


