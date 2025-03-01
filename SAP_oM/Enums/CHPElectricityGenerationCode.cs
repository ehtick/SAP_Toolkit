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
    [Description("Code which indicates the CHP Electricity generation option (table 12f).")]
    public enum CHPElectricityGenerationCode { NewCHPExportOnly = 81, NewCHPFlexibleOperation = 82, NewCHPStandard = 83, ExistingCHP2015ExportOnly = 84, 
        ExistingCHP2015FlexibleOperation = 85, ExistingCHP2015Standard = 86, ExistingCHPPre2015ExportOnly = 87, 
        ExistingCHPPre2015FlexibleOperation = 88, ExistingCHPPre2015Standard = 89 }
}
/*
 * private static string FromSAPToXML(this BH.oM.Environment.SAP.CHPElectricityGenerationCode cHPElectricityGenerationCode)
{
	switch (cHPElectricityGenerationCode)
	{
		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.NewCHPExportOnly:
			return "81";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.NewCHPFlexibleOperation:
			return "82";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.NewCHPStandard:
			return "83";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHP2015ExportOnly:
			return "84";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHP2015FlexibleOperation:
			return "85";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHP2015Standard:
			return "86";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHPPre2015ExportOnly:
			return "87";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHPPre2015FlexibleOperation:
			return "88";

		case BH.oM.Environment.SAP.CHPElectricityGenerationCode.ExistingCHPPre2015Standard:
			return "89";

		default:
			return"";
	}
}
 */