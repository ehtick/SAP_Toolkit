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
    [Description("Details about the use of immersion.")]
    public class Immersion : BHoMObject
    {
        [Description("Is heat pump assisted by immersion.")]
        public virtual bool UseOfImmersion { get; set; } = false;

        [Description("Is heat pump installed to MIS standard?.")]
        public virtual bool? InstalledToMIS { get; set; } = null;

        [Description("Heat pump immersion.")]
        public virtual string HeatExchangerArea { get; set; } = null;

        [Description(".")]
        public virtual bool SummerImmersion { get; set; } = false;

        [Description(".")]
        public virtual TypeOfImmersion Type { get; set; } = new TypeOfImmersion();
    }
}
