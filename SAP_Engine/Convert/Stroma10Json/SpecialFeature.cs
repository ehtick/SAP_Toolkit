﻿using System;
using System.Collections.Generic;
using System.Text;

using BH.oM.Base;

namespace BH.Engine.Environment.SAP.Stroma10
{
    public static partial class Convert
    {
        public static List<BH.oM.Environment.SAP.Stroma10.SpecialFeature> ToSpecialFeatures(List<CustomObject> specialFeaturesObject)
        {
            if (specialFeaturesObject == null)
                return null;

            List<BH.oM.Environment.SAP.Stroma10.SpecialFeature> rtn = new List<BH.oM.Environment.SAP.Stroma10.SpecialFeature>();
            foreach (var value in specialFeaturesObject)
            {
                rtn.Add(ToSpecialFeature(value));
            }
            return rtn;
        }


        public static BH.oM.Environment.SAP.Stroma10.SpecialFeature ToSpecialFeature(CustomObject specialFeatureObject)
        {
            if (specialFeatureObject == null)
                return null;

            BH.oM.Environment.SAP.Stroma10.SpecialFeature sapSpecialFeature = new BH.oM.Environment.SAP.Stroma10.SpecialFeature();

            
            
            
            
            sapSpecialFeature.ID = System.Convert.ToInt32(specialFeatureObject.CustomData["Id"]);

            sapSpecialFeature.Description = specialFeatureObject.CustomData["Description"] as string;

            sapSpecialFeature.EnergySaved = System.Convert.ToDouble(specialFeatureObject.CustomData["EnergySaved"]);

            sapSpecialFeature.ID = System.Convert.ToInt32(specialFeatureObject.CustomData["Id"]);

            sapSpecialFeature.EnergyUsed = System.Convert.ToDouble(specialFeatureObject.CustomData["EnergyUsed"]);

            sapSpecialFeature.ID = System.Convert.ToInt32(specialFeatureObject.CustomData["Id"]);

            sapSpecialFeature.IncludeMonthly = System.Convert.ToBoolean(specialFeatureObject.CustomData["IncludeMonthly"]);

            sapSpecialFeature.MakeEmissionsOnly = System.Convert.ToBoolean(specialFeatureObject.CustomData["MakeEmissionsOnly"]);

            sapSpecialFeature.EmissionsAmount = System.Convert.ToDouble(specialFeatureObject.CustomData["EmissionsAmount"]);

            sapSpecialFeature.EmissionsAmountCreated = System.Convert.ToDouble(specialFeatureObject.CustomData["EmissionsAmountCreated"]);

            sapSpecialFeature.Month01 = System.Convert.ToDouble(specialFeatureObject.CustomData["M1"]);

            sapSpecialFeature.Month02 = System.Convert.ToDouble(specialFeatureObject.CustomData["M2"]);

            sapSpecialFeature.Month03 = System.Convert.ToDouble(specialFeatureObject.CustomData["M3"]);

            sapSpecialFeature.Month04 = System.Convert.ToDouble(specialFeatureObject.CustomData["M4"]);

            sapSpecialFeature.Month05 = System.Convert.ToDouble(specialFeatureObject.CustomData["M5"]);

            sapSpecialFeature.Month06 = System.Convert.ToDouble(specialFeatureObject.CustomData["M6"]);

            sapSpecialFeature.Month07 = System.Convert.ToDouble(specialFeatureObject.CustomData["M7"]);

            sapSpecialFeature.Month08 = System.Convert.ToDouble(specialFeatureObject.CustomData["M8"]);

            sapSpecialFeature.Month09 = System.Convert.ToDouble(specialFeatureObject.CustomData["M9"]);

            sapSpecialFeature.Month10 = System.Convert.ToDouble(specialFeatureObject.CustomData["M10"]);

            sapSpecialFeature.Month11 = System.Convert.ToDouble(specialFeatureObject.CustomData["M11"]);

            sapSpecialFeature.Month12 = System.Convert.ToDouble(specialFeatureObject.CustomData["M12"]);

            return sapSpecialFeature;
        }
    }
}
