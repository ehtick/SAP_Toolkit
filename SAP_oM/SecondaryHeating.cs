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
    [Description("Secondary Heating.")]
    public class SecondaryHeating : BHoMObject
    {
        [Description(".")]
        public virtual SecondaryHeatingDetails HeatingDetails { get; set; } = new SecondaryHeatingDetails();

        [Description(".")]
        public virtual HeatingDeclared HeatingDeclaredValues { get; set; } = new HeatingDeclared();

        [Description(".")]
        public virtual TypeOfHeatingFuel Fuel { get; set; } = new TypeOfHeatingFuel();

        [Description(".")]
        public virtual bool? HETASApproved { get; set; } = null;

        [Description(".")]
        public virtual string Efficiency { get; set; } = null;

    }
}
