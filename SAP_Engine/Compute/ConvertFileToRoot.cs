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
using System.IO;
using System.Text;
using BH.oM.Environment.SAP.Stroma10;
using BH.oM.Base;
using System.ComponentModel;

namespace BH.Engine.Environment.SAP
{
    public static partial class Compute
    {
        [Description("A method for converting a stroma json file to a BHoM object - probably defunct.")]

        public static Root ConvertFileToRoot(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadToEnd();
            sr.Close();
            CustomObject obj = BH.Engine.Serialiser.Convert.FromJson(line) as CustomObject;
            return BH.Engine.Environment.SAP.Stroma10.Convert.ToRoot(obj);
        }
    }
}
