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
    [Description("Code which indicates the type of combi boiler.")]
    public enum TypeOfCombiBoiler {  InstantaneousNoStoreOrKeepHot = 1, PrimaryStorage = 2, SecondaryStorage = 3, CPSU = 4, 
        UntimedKeepHotByFuel = 5, TimedKeepHotByFuel = 6, UntimedKeepHotByElectricity = 7, TimedKeepHotByElectricity = 8, UntimedKeepHotByFuelAndElectricity = 9, 
        TimedKeepHotByFuelAndElectricity = 10 }
}

/*
 * private static string FromSAPToXML(this BH.oM.Environment.SAP.TypeOfCombiBoiler typeOfCombiBoiler)
{
	switch (typeOfCombiBoiler)
	{
		case BH.oM.Environment.SAP.TypeOfCombiBoiler.InstantaneousNoStoreOrKeepHot:
			return "1";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.PrimaryStorage:
			return "2";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.SecondaryStorage:
			return "3";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.CPSU:
			return "4";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.UntimedKeepHotByFuel:
			return "5";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.TimedKeepHotByFuel:
			return "6";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.UntimedKeepHotByElectricity:
			return "7";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.TimedKeepHotByElectricity:
			return "8";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.UntimedKeepHotByFuelAndElectricity:
			return "9";

		case BH.oM.Environment.SAP.TypeOfCombiBoiler.TimedKeepHotByFuelAndElectricity:
			return "10";

		default:
			return"";
	}
}
 */