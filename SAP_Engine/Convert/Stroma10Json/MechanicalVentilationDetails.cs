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
using System.Text;
using BH.oM.Base;
using BH.oM.Environment.SAP.Stroma10;

namespace BH.Engine.Environment.SAP.Stroma10
{
    public static partial class Convert
    {
        public static BH.oM.Environment.SAP.Stroma10.MechanicalVentilationDetails ToMechanicalVentilationDetails(CustomObject mechanicalVentilationDetailsObject)
        {
            if (mechanicalVentilationDetailsObject == null)
                return null;
            BH.oM.Environment.SAP.Stroma10.MechanicalVentilationDetails sapMechanicalVentilationDetails = new BH.oM.Environment.SAP.Stroma10.MechanicalVentilationDetails();
            sapMechanicalVentilationDetails.ID = System.Convert.ToInt32(mechanicalVentilationDetailsObject.CustomData["Id"]);
            sapMechanicalVentilationDetails.ProductName = mechanicalVentilationDetailsObject.CustomData["ProductName"] as string;
            sapMechanicalVentilationDetails.DuctingType = System.Convert.ToInt32(mechanicalVentilationDetailsObject.CustomData["DuctingType"]);
            sapMechanicalVentilationDetails.SpecificFanPower = System.Convert.ToDouble(mechanicalVentilationDetailsObject.CustomData["Sfp"]);
            sapMechanicalVentilationDetails.HeatExchangerEfficiency = System.Convert.ToDouble(mechanicalVentilationDetailsObject.CustomData["Hee"]);
            sapMechanicalVentilationDetails.DuctProductID = (mechanicalVentilationDetailsObject.CustomData["DuctProductId"] as string);
            return sapMechanicalVentilationDetails;
        }

        public static Dictionary<string, object> FromMechanicalVentilationDetails(MechanicalVentilationDetails obj)
        {
            Dictionary<string, object> rtn = new Dictionary<string, object>();
            if (obj == null)
                return null;
            rtn.Add("Id", obj.ID);
            rtn.Add("ProductName", obj.ProductName);
            rtn.Add("DuctingType", obj.DuctingType);
            rtn.Add("Sfp", obj.SpecificFanPower);
            rtn.Add("Hee", obj.HeatExchangerEfficiency);
            rtn.Add("DuctProductId", obj.DuctProductID);
            return rtn;
        }
    }
}
