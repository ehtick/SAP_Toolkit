﻿using System;
using System.Collections.Generic;
using System.Text;

using BH.oM.Environment.SAP.Stroma10;
using BH.oM.Base;
using System.Linq;

namespace BH.Engine.Environment.SAP.Stroma10
{
    public static partial class Convert
    {
        public static Root ToRoot(CustomObject rootObject)
        {
            if (rootObject == null)
                return null;

            Root sapRoot = new Root();

            sapRoot.ID = System.Convert.ToInt32(rootObject.CustomData["Id"]);

            sapRoot.BHoM_Guid = Guid.Parse(rootObject.CustomData["Guid"] as string);

            sapRoot.DateTimeCreated = System.Convert.ToDateTime(rootObject.CustomData["DateTimeCreated"]);

            sapRoot.DateTimeSaved = System.Convert.ToDateTime(rootObject.CustomData["DateTimeSaved"]);

            sapRoot.UserID = System.Convert.ToInt32(rootObject.CustomData["UserId"]);

            sapRoot.Name = rootObject.Name;

            sapRoot.Reference = rootObject.CustomData["Reference"] as string;

            sapRoot.Dwellings = ToDwellings((rootObject.CustomData["Dwellings"] as List<object>).Cast<CustomObject>().ToList());

            sapRoot.Address = ToAddress(rootObject.CustomData["Address"] as CustomObject);

            sapRoot.ClientDetails = ToClientDetails(rootObject.CustomData["ClientDetails"] as CustomObject);

            sapRoot.Elements = ToElements(rootObject.CustomData["Elements"] as CustomObject);

            sapRoot.Assessor = ToAssessor(rootObject.CustomData["Assessor"] as CustomObject);

            sapRoot.DwellingCount = System.Convert.ToInt32(rootObject.CustomData["DwellingCount"]);

            return sapRoot;
        }

        public static Dictionary<string, object> FromRoot(Root obj)
        {
            Dictionary<string, object> rtn = new Dictionary<string, object>();

            if (obj == null)
                return null;

            rtn.Add("Id", obj.ID);

            rtn.Add("Guid", obj.BHoM_Guid.ToString());

            rtn.Add("DateTimeCreated", obj.DateTimeCreated.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

            rtn.Add("DateTimeSaved", obj.DateTimeSaved.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

            rtn.Add("UserId", obj.UserID);

            rtn.Add("Name", obj.Name);

            rtn.Add("Reference", obj.Reference);

            if (obj.Dwellings != null && obj.Dwellings.Any(x => x != null))

                rtn.Add("Dwellings", obj.Dwellings.Select(x => FromDwelling(x)).ToList());

            rtn.Add("Address", FromAddress(obj.Address));

            rtn.Add("ClientDetails", FromClientDetails(obj.ClientDetails));

            rtn.Add("Elements", FromElements(obj.Elements));

            rtn.Add("Assessor", FromAssessor(obj.Assessor));

            rtn.Add("DwellingCount", obj.DwellingCount);


            return rtn;
        }
    }
}
