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


namespace BH.oM.Environment.SAP
{
    [Description("Product type to query from database.")]  
    public enum TypeOfProduct { GasAndOilBoiler = 105, FlueGasHeatRecoverySystem = 313, MEVdc = 322, MEVcAndMVHR = 323, MVInUseFactors = 329, MVHRDuct = 341,
        WasteWaterHeatRecoverySystem = 353, HeatPump = 362, HeatingControls = 371, HeatingControlRequirements = 372, WarmAirSystem = 381, StorageHeaters = 391,
        CommunityHeatNetworks = 501 }
}
