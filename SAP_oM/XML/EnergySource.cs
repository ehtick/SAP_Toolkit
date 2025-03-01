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
using BH.oM.Environment.SAP.Stroma10;

namespace BH.oM.Environment.SAP.XML
{
    [Serializable]
    [XmlRoot(ElementName = "SAP-Energy-Source", IsNullable = false)]
    public class EnergySource : IObject
    {
        [Description(".")]
        [XmlElement("PV-Arrays")]
        public virtual PhotovoltaicArrays PhotovoltaicArrays { get; set; } = null;

        [Description(".")]
        [XmlElement(ElementName = "Wind-Turbines")]
        public virtual WindTurbines WindTurbines { get; set; } = null;

        [Description(".")]
        [XmlElement(ElementName = "Electricity-Tariff")]
        public virtual string ElectricityTariff { get; set; } = "1";

        [Description(".")]
        [XmlElement(ElementName = "Hydro-Electric-Generation")]
        public virtual double HydroElectricGeneration { get; set; } = 0;

        [Description(".")]
        [XmlElement(ElementName = "Hydro-Electric-Certificate")]
        public virtual string HydroElectricCertificate { get; set; } = null;

        [Description(".")]
        [XmlElement(ElementName = "Hydro-Electric-Generation-Months")]
        public virtual HydroElectricGenerationMonths HydroElectricGenerationMonths { get; set; } = null;

        [Description(".")]
        [XmlElement(ElementName = "Is-Hydro-Output-Connected-To-Dwelling-Meter")]
        public virtual bool IsHydroOutputConnectedToDwellingMeter { get; set; } = false;

    }
}


