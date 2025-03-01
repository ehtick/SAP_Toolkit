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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Environment.SAP;
using BH.Engine.Geometry;
using System.ComponentModel;
using BH.oM.Base.Attributes;

namespace BH.Engine.Environment.SAP
{
    public static partial class Create
    {
        [Description("Converts lists of thermal bridge curves to lists of lengths of thermal bridges.")]
        [Input("thermalBridgesCurves","ThermalBridgeLength objects.")]
        [Output("thermalBridgeLengths", "ThermalBridgeLengthObjects.")]
        public static List<ThermalBridgeLengths> ThermalBridgeLengths(List<ThermalBridgesCurves> thermalBridgesCurves)
        {
            List<ThermalBridgeLengths> thermalBridges = new List<ThermalBridgeLengths>();

            for (int x = 0; x < thermalBridgesCurves.Count; x++)
            {
                ThermalBridgesCurves thermalBridgeCurves = thermalBridgesCurves[x];
                ThermalBridgeLengths thermalBridge = new ThermalBridgeLengths();
                thermalBridge.DwellingName = thermalBridgeCurves.Name;
                thermalBridge.Reference = thermalBridgeCurves.Reference;
                thermalBridge.ID = thermalBridgeCurves.ID;

                thermalBridge.E2 = thermalBridgeCurves.ExternalJunctions.E2.Select(y => y.Length()).Sum();
                thermalBridge.E3 = thermalBridgeCurves.ExternalJunctions.E3.Select(y => y.Length()).Sum();
                thermalBridge.E4 = thermalBridgeCurves.ExternalJunctions.E4.Select(y => y.Length()).Sum();
                thermalBridge.E7 = thermalBridgeCurves.ExternalJunctions.E7.Select(y => y.Length()).Sum();

                if (thermalBridgeCurves.ExternalJunctions.E23 != null)
                    thermalBridge.E23 = thermalBridgeCurves.ExternalJunctions.E23.Select(y => y.Length()).Sum();
                //*******************************************************
                //if (thermalBridgeCurves.ExternalJunctions.E10 != null)
                //{
                //    thermalBridge.E10 = thermalBridgeCurves.ExternalJunctions.E10.Select(y => y.Length()).Sum();
                //}
                //*********************************************************
                if (thermalBridgeCurves.ExternalJunctions.E15 != null)
                    thermalBridge.E15 = thermalBridgeCurves.ExternalJunctions.E15.Select(y => y.Length()).Sum();

                if (thermalBridgeCurves.ExternalJunctions.E16 != null)
                    thermalBridge.E16 = thermalBridgeCurves.ExternalJunctions.E16.Select(y => y.Length()).Sum();

                if (thermalBridgeCurves.ExternalJunctions.E17 != null)
                    thermalBridge.E17 = thermalBridgeCurves.ExternalJunctions.E17.Select(y => y.Length()).Sum();

                if (thermalBridgeCurves.ExternalJunctions.E18 != null)
                    thermalBridge.E18 = thermalBridgeCurves.ExternalJunctions.E18.Select(y => y.Length()).Sum();

                if (thermalBridgeCurves.ExternalJunctions.E25 != null)
                    thermalBridge.E25 = thermalBridgeCurves.ExternalJunctions.E25.Select(y => y.Length()).Sum();
                thermalBridges.Add(thermalBridge);
            }

            return thermalBridges;
        }
    }
}


