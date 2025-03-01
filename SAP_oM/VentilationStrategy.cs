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
using System.Xml.Serialization;
using BH.oM.Base;

namespace BH.oM.Environment.SAP
{
    [Description("Strategy for the ventilation of the dwelling.")]
    public class VentilationStrategy : BHoMObject
    {
        [Description("The type of ventilation.")]
        public virtual TypeOfVentilation Type { get; set; } = TypeOfVentilation.NaturalIntermittentExtractFans;

        [Description("Is mechanical vent an approved installer scheme.")]
        public virtual bool? ApprovedInstallation { get; set; } = true;

        [Description("Source of mechanical ventilation data.")]
        public virtual VentilationDataSource MechVentDataSource { get; set; } = VentilationDataSource.ManufacturerDeclaration;

        [Description("Number of wet rooms, including the kitchen; if mech vent data from manufacturer declaration or database (MEV c, MV, MVHR).")]
        public virtual string numberWetRooms { get; set; } = "0";

        [Description("Mechanical vent duct insulation; if MVHR.")]
        public virtual TypeofDuctInsulation DuctInsulationType { get; set; } = TypeofDuctInsulation.NotInsulated;

        [Description("Mechanical vent duct insulation; if MVHR.")]//check
        public virtual DuctInsulationLevel DuctInsulationLevel { get; set; } = DuctInsulationLevel.Level1;

        [Description("Mechanical vent ducts index number; if applicable.")]
        public virtual string MechVentSystemIndexNumber { get; set; } = null;

        [Description("If mechanical ventilation, extra details is needed.")]
        public virtual MechanicalVentilationDetails MechVentDetails { get; set; } = null;

        [Description("Additional information about the fans.")]
        public virtual ExtraFanDetails ExtraFanDetails { get; set; } = null;
    }
}
