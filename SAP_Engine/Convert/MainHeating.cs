﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BH.oM.Base.Attributes;

namespace BH.Engine.Environment.SAP
{
    public static partial class Convert
    {
        [Description("Convert SAP Heating to XML Main Heating.")]
        [Input("sapHeating", "SAP Heating object to convert.")]
        [Output("xmlMainHeating", "XML Main Heating object.")]
        public static BH.oM.Environment.SAP.XML.MainHeating ToXMLHeating(this BH.oM.Environment.SAP.Heating heating)
        {
            BH.oM.Environment.SAP.XML.MainHeating xmlMainHeating = new BH.oM.Environment.SAP.XML.MainHeating();
            xmlMainHeating.MainHeatingNumber = 1;
            xmlMainHeating.MainHeatingCategory = heating.Primary.HeatingDetails.HeatingGroup;
            xmlMainHeating.MainHeatingDataSource = heating.Primary.HeatingDetails.Source;
            xmlMainHeating.MainHeatingIndexNumber = null;//when implementing PCDB
            xmlMainHeating.IsCondensingBoiler = null;
            xmlMainHeating.GasOrOilBoilerType = null;
            xmlMainHeating.CombiBoilerType = null;
            xmlMainHeating.CaseHeatEmission = null;
            xmlMainHeating.HeatTransferToWater = null;
            xmlMainHeating.SolidFuelBoilerType = null;
            xmlMainHeating.MainHeatingCode = null;
            xmlMainHeating.MainFuelType = heating.Primary.HeatingFuel.Fuel;
            xmlMainHeating.MainHeatingControl = heating.Primary.HeatingControls.Controls;
            xmlMainHeating.HeatEmitterType = heating.Primary.HeatingDetails.Emitter;
            xmlMainHeating.UnderfloorHeatEmitterType = null;
            xmlMainHeating.MainHeatingFlueType = heating.Primary.BoilerInformation.FlueType;
            xmlMainHeating.IsFlueFanPresent = heating.Primary.BoilerInformation.FanFLued;
            xmlMainHeating.IsCentralHeatingPumpInHeatedSpace = heating.Primary.BoilerInformation.PumpInHeatedSpace;//only if wet system, Need to check these two
            xmlMainHeating.IsOilPumpInHeatedSpace = heating.Primary.BoilerInformation.PumpInHeatedSpace;// only if oil boiler
            xmlMainHeating.IsInterLockedSystem = heating.Primary.BoilerInformation.BoilerInterlock;
            xmlMainHeating.HasSeparateDelayedStart = heating.Primary.HeatingControls.DelayedStartThermostat;
            xmlMainHeating.HasLoadOrWeatherCompensation = null;
            xmlMainHeating.BoilerFuelFeed = null;
            xmlMainHeating.IsMainHeatingHETASApproved = heating.Primary.HETASApproved;
            xmlMainHeating.ElectricCPSUOperatingTemperature = null;
            xmlMainHeating.LoadOrWeatherCompensation = null;
            xmlMainHeating.MainHeatingFraction = heating.Primary.FractionOfHeat;
            xmlMainHeating.BurnerControl = null;
            xmlMainHeating.EfficiencyType = null;
            xmlMainHeating.MainHeatingEfficiencyWinter = null;
            xmlMainHeating.MainHeatingEfficiencySummer = null;
            xmlMainHeating.HasFGHRS = null;
            xmlMainHeating.FGHRSIndexNumber = null;
            xmlMainHeating.FGHRSEnergySource = null;
            xmlMainHeating.MainHeatingDeclaredValues = null;
            xmlMainHeating.StorageHeaters = null;
            xmlMainHeating.EmitterTemperature = null;
            xmlMainHeating.MCSInstalledHeatPump = heating.Primary.MCSCertificate;
            xmlMainHeating.CentralHeatingPumpAge = null;
            xmlMainHeating.CompensatingControllerIndexNumber = null;
            xmlMainHeating.TTZCIndexNumber = null;

            return xmlMainHeating;
        }
    }
}