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
using System.Linq;
using BH.oM.Base;
using BH.oM.Environment.SAP.Stroma10;

namespace BH.Engine.Environment.SAP.Stroma10
{
    public static partial class Convert
    {
        public static List<BH.oM.Environment.SAP.Stroma10.InteriorWall> ToInteriorWalls(List<CustomObject> interiorWallsObject)
        {
            if (interiorWallsObject == null)
                return null;
            List<BH.oM.Environment.SAP.Stroma10.InteriorWall> rtn = new List<BH.oM.Environment.SAP.Stroma10.InteriorWall>();
            foreach (var value in interiorWallsObject)
            {
                rtn.Add(ToInteriorWall(value));
            }

            return rtn;
        }

        public static BH.oM.Environment.SAP.Stroma10.InteriorWall ToInteriorWall(CustomObject interiorWallObject)
        {
            if (interiorWallObject == null)
                return null;
            BH.oM.Environment.SAP.Stroma10.InteriorWall sapInteriorWall = new BH.oM.Environment.SAP.Stroma10.InteriorWall();
            sapInteriorWall.ID = System.Convert.ToInt32(interiorWallObject.CustomData["Id"]);
            sapInteriorWall.BHoM_Guid = (Guid.Parse(interiorWallObject.CustomData["Guid"] as string));
            sapInteriorWall.Name = interiorWallObject.Name;
            sapInteriorWall.Type = System.Convert.ToInt32(interiorWallObject.CustomData["Type"]);
            sapInteriorWall.Construction = System.Convert.ToInt32(interiorWallObject.CustomData["Construction"]);
            sapInteriorWall.Area = System.Convert.ToDouble(interiorWallObject.CustomData["Area"]);
            sapInteriorWall.UValueStart = System.Convert.ToDouble(interiorWallObject.CustomData["UValueStart"]);
            sapInteriorWall.UValue = System.Convert.ToDouble(interiorWallObject.CustomData["UValue"]);
            sapInteriorWall.ResultantUValue = System.Convert.ToDouble(interiorWallObject.CustomData["Ru"]);
            sapInteriorWall.Curtain = System.Convert.ToBoolean(interiorWallObject.CustomData["Curtain"]);
            sapInteriorWall.ManualInputKappa = System.Convert.ToBoolean(interiorWallObject.CustomData["OverRideK"]);
            sapInteriorWall.Kappa = System.Convert.ToDouble(interiorWallObject.CustomData["K"]);
            sapInteriorWall.Dims = ToDims((interiorWallObject.CustomData["Dims"] as List<object>).Cast<CustomObject>().ToList());
            ;
            sapInteriorWall.UValueSelectionID = System.Convert.ToInt32(interiorWallObject.CustomData["UValueSelectionId"]);
            sapInteriorWall.UValueSelected = System.Convert.ToBoolean(interiorWallObject.CustomData["UValueSelected"]);
            sapInteriorWall.EnergyPerformanceCertificateDescription = interiorWallObject.CustomData["EpcDescription"] as string;
            sapInteriorWall.LoftInsulation = interiorWallObject.CustomData["LoftInsulation"] as string;
            return sapInteriorWall;
        }

        public static Dictionary<string, object> FromInteriorWall(InteriorWall obj)
        {
            Dictionary<string, object> rtn = new Dictionary<string, object>();
            if (obj == null)
                return null;
            rtn.Add("Id", obj.ID);
            rtn.Add("Guid", obj.BHoM_Guid.ToString());
            rtn.Add("Name", obj.Name);
            rtn.Add("Type", obj.Type);
            rtn.Add("Construction", obj.Construction);
            rtn.Add("Area", obj.Area);
            rtn.Add("UValueStart", obj.UValueStart);
            rtn.Add("UValue", obj.UValue);
            rtn.Add("Ru", obj.ResultantUValue);
            rtn.Add("Curtain", obj.Curtain);
            rtn.Add("OverRideK", obj.ManualInputKappa);
            rtn.Add("K", obj.Kappa);
            if (obj.Dims != null && obj.Dims.Any(x => x != null))
                rtn.Add("Dims", obj.Dims.Select(x => FromDim(x)).ToList());
            else
            {
                List<object> temp = new List<object>();
                rtn.Add("Dims", temp);
            }

            rtn.Add("UValueSelectionId", obj.UValueSelectionID);
            rtn.Add("UValueSelected", obj.UValueSelected);
            rtn.Add("EpcDescription", obj.EnergyPerformanceCertificateDescription);
            rtn.Add("LoftInsulation", obj.LoftInsulation);
            return rtn;
        }
    }
}
