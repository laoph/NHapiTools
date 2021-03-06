using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Base.Model;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Message;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapiTools.Base;

namespace NHapiTools.Model.V231.Group
{
    /// <summary>
    /// Extention methods
    /// </summary>
    public static class GroupExtensions
    {
        #region Extension methods
        /// <summary>
        /// Get SERVICE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_SERVICE> GetAllSERVICERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Add a new SQM_S25_RESOURCES to SERVICE
        /// </summary>
        public static SQM_S25_SERVICE AddSERVICE(this SQM_S25_RESOURCES message)
        {
            return message.GetSERVICE(message.SERVICERepetitionsUsed);
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Add a new SQM_S25_RESOURCES to GENERAL_RESOURCE
        /// </summary>
        public static SQM_S25_GENERAL_RESOURCE AddGENERAL_RESOURCE(this SQM_S25_RESOURCES message)
        {
            return message.GetGENERAL_RESOURCE(message.GENERAL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Add a new SQM_S25_RESOURCES to PERSONNEL_RESOURCE
        /// </summary>
        public static SQM_S25_PERSONNEL_RESOURCE AddPERSONNEL_RESOURCE(this SQM_S25_RESOURCES message)
        {
            return message.GetPERSONNEL_RESOURCE(message.PERSONNEL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SQM_S25_RESOURCES
        /// </summary>
        public static List<SQM_S25_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SQM_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQM_S25_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Add a new SQM_S25_RESOURCES to LOCATION_RESOURCE
        /// </summary>
        public static SQM_S25_LOCATION_RESOURCE AddLOCATION_RESOURCE(this SQM_S25_RESOURCES message)
        {
            return message.GetLOCATION_RESOURCE(message.LOCATION_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRO_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRO_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRO_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRO_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRO_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRO_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQP_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQP_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQP_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQP_I04_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQP_I04_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGR_RGR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGR_RGR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGR_RGR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGR_RGR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGR_RGR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O01_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O01_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RDE_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RDE_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RDE_O01_PATIENT
        /// </summary>
        public static List<RDE_O01_INSURANCE> GetAllINSURANCERecords(this RDE_O01_PATIENT message)
        {
            return message.GetAllRecords<RDE_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RDE_O01_PATIENT to INSURANCE
        /// </summary>
        public static RDE_O01_INSURANCE AddINSURANCE(this RDE_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RDE_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDE_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDE_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDE_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RDE_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RDE_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RCI_I05_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RCI_I05_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RAR_RAR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RAR_RAR_DEFINITION
        /// </summary>
        public static List<RAR_RAR_ORDER> GetAllORDERRecords(this RAR_RAR_DEFINITION message)
        {
            return message.GetAllRecords<RAR_RAR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RAR_RAR_DEFINITION to ORDER
        /// </summary>
        public static RAR_RAR_ORDER AddORDER(this RAR_RAR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPT_PCL_PATIENT
        /// </summary>
        public static List<PPT_PCL_PATHWAY> GetAllPATHWAYRecords(this PPT_PCL_PATIENT message)
        {
            return message.GetAllRecords<PPT_PCL_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATIENT to PATHWAY
        /// </summary>
        public static PPT_PCL_PATHWAY AddPATHWAY(this PPT_PCL_PATIENT message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new PEX_P07_RX_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this PEX_P07_RX_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to LCH
        /// </summary>
        public static LCH AddLCH(this MFN_M05_MF_LOCATION message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("LRLRepetitionsUsed", "GetLRL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LRL Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<LRL> GetAllLRLRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<LRL>("LRLRepetitionsUsed", "GetLRL");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to LRL
        /// </summary>
        public static LRL AddLRL(this MFN_M05_MF_LOCATION message)
        {
            return message.GetLRL(message.LRLRepetitionsUsed);
        }

        /// <summary>
        /// Get MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static IEnumerable GetMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            object[] result = message.GetRecords("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_LOC_DEPT Records from MFN_M05_MF_LOCATION
        /// </summary>
        public static List<MFN_M05_MF_LOC_DEPT> GetAllMF_LOC_DEPTRecords(this MFN_M05_MF_LOCATION message)
        {
            return message.GetAllRecords<MFN_M05_MF_LOC_DEPT>("MF_LOC_DEPTRepetitionsUsed", "GetMF_LOC_DEPT");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOCATION to MF_LOC_DEPT
        /// </summary>
        public static MFN_M05_MF_LOC_DEPT AddMF_LOC_DEPT(this MFN_M05_MF_LOCATION message)
        {
            return message.GetMF_LOC_DEPT(message.MF_LOC_DEPTRepetitionsUsed);
        }

        /// <summary>
        /// Get CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static IEnumerable GetCSPRecords(this CRM_C01_PATIENT message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from CRM_C01_PATIENT
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this CRM_C01_PATIENT message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Add a new CRM_C01_PATIENT to CSP
        /// </summary>
        public static CSP AddCSP(this CRM_C01_PATIENT message)
        {
            return message.GetCSP(message.CSPRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from VXU_V04_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this VXU_V04_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from VXU_V04_ORDER
        /// </summary>
        public static List<VXU_V04_OBSERVATION> GetAllOBSERVATIONRecords(this VXU_V04_ORDER message)
        {
            return message.GetAllRecords<VXU_V04_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new VXU_V04_ORDER to OBSERVATION
        /// </summary>
        public static VXU_V04_OBSERVATION AddOBSERVATION(this VXU_V04_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SIU_S12_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SIU_S12_PATIENT to OBX
        /// </summary>
        public static OBX AddOBX(this SIU_S12_PATIENT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SIU_S12_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SIU_S12_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SIU_S12_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SIU_S12_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SIU_S12_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPA_I08_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPA_I08_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I12_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I12_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from REF_I12_OBSERVATION
        /// </summary>
        public static List<REF_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this REF_I12_OBSERVATION message)
        {
            return message.GetAllRecords<REF_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Add a new REF_I12_OBSERVATION to RESULTS_NOTES
        /// </summary>
        public static REF_I12_RESULTS_NOTES AddRESULTS_NOTES(this REF_I12_OBSERVATION message)
        {
            return message.GetRESULTS_NOTES(message.RESULTS_NOTESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPR_PC1_ORDER_DETAIL
        /// </summary>
        public static List<PPR_PC1_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPR_PC1_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PPR_PC1_ORDER_OBSERVATION AddORDER_OBSERVATION(this PPR_PC1_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<PPP_PCB_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<PPP_PCB_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to PATHWAY_ROLE
        /// </summary>
        public static PPP_PCB_PATHWAY_ROLE AddPATHWAY_ROLE(this PPP_PCB_PATHWAY message)
        {
            return message.GetPATHWAY_ROLE(message.PATHWAY_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPP_PCB_PATHWAY
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPP_PCB_PATHWAY message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPP_PCB_PATHWAY
        /// </summary>
        public static List<PPP_PCB_PROBLEM> GetAllPROBLEMRecords(this PPP_PCB_PATHWAY message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY to PROBLEM
        /// </summary>
        public static PPP_PCB_PROBLEM AddPROBLEM(this PPP_PCB_PATHWAY message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OSR_Q06_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OSR_Q06_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORN_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORN_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORN_O02_RESPONSE
        /// </summary>
        public static List<ORN_O02_ORDER> GetAllORDERRecords(this ORN_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORN_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORN_O02_RESPONSE to ORDER
        /// </summary>
        public static ORN_O02_ORDER AddORDER(this ORN_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ODT Records from ORD_O02_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this ORD_O02_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from ORD_O02_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this ORD_O02_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Add a new ORD_O02_ORDER_TRAY to ODT
        /// </summary>
        public static ODT AddODT(this ORD_O02_ORDER_TRAY message)
        {
            return message.GetODT(message.ODTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O02_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O02_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O02_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O02_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O02_ORDER_TRAY to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O02_ORDER_TRAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new BAR_P01_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this BAR_P01_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get SERVICE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_SERVICE> GetAllSERVICERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Add a new SIU_S12_RESOURCES to SERVICE
        /// </summary>
        public static SIU_S12_SERVICE AddSERVICE(this SIU_S12_RESOURCES message)
        {
            return message.GetSERVICE(message.SERVICERepetitionsUsed);
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Add a new SIU_S12_RESOURCES to GENERAL_RESOURCE
        /// </summary>
        public static SIU_S12_GENERAL_RESOURCE AddGENERAL_RESOURCE(this SIU_S12_RESOURCES message)
        {
            return message.GetGENERAL_RESOURCE(message.GENERAL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Add a new SIU_S12_RESOURCES to LOCATION_RESOURCE
        /// </summary>
        public static SIU_S12_LOCATION_RESOURCE AddLOCATION_RESOURCE(this SIU_S12_RESOURCES message)
        {
            return message.GetLOCATION_RESOURCE(message.LOCATION_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SIU_S12_RESOURCES
        /// </summary>
        public static List<SIU_S12_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SIU_S12_RESOURCES message)
        {
            return message.GetAllRecords<SIU_S12_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Add a new SIU_S12_RESOURCES to PERSONNEL_RESOURCE
        /// </summary>
        public static SIU_S12_PERSONNEL_RESOURCE AddPERSONNEL_RESOURCE(this SIU_S12_RESOURCES message)
        {
            return message.GetPERSONNEL_RESOURCE(message.PERSONNEL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRE_O02_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRE_O02_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRE_O02_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRE_O02_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRE_O02_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RRE_O02_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRE_O02_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRE_O02_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRE_O02_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRE_O02_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRE_O02_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RRE_O02_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I04_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I04_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I04_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPI_I04_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPI_I04_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPI_I01_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPI_I01_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RDO_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDO_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDO_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDO_O01_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RDO_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RDO_O01_ORDER_DETAIL
        /// </summary>
        public static List<RDO_O01_OBSERVATION> GetAllOBSERVATIONRecords(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RDO_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RDO_O01_ORDER_DETAIL to OBSERVATION
        /// </summary>
        public static RDO_O01_OBSERVATION AddOBSERVATION(this RDO_O01_ORDER_DETAIL message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCI_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCI_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCI_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RCI_I05_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RCI_I05_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAS_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O01_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O01_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAS_O01_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RAS_O01_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RAS_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAS_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAS_O01_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAS_O01_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RAS_O01_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RAS_O01_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PTR_PCF_ORDER_DETAIL
        /// </summary>
        public static List<PTR_PCF_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PTR_PCF_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PTR_PCF_ORDER_OBSERVATION AddORDER_OBSERVATION(this PTR_PCF_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPG_PCG_ORDER_DETAIL
        /// </summary>
        public static List<PPG_PCG_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPG_PCG_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PPG_PCG_ORDER_OBSERVATION AddORDER_OBSERVATION(this PPG_PCG_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ASSOCIATED_RX_ADMIN Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetASSOCIATED_RX_ADMINRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("ASSOCIATED_RX_ADMINRepetitionsUsed", "GetASSOCIATED_RX_ADMIN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ASSOCIATED_RX_ADMIN Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<PEX_P07_ASSOCIATED_RX_ADMIN> GetAllASSOCIATED_RX_ADMINRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<PEX_P07_ASSOCIATED_RX_ADMIN>("ASSOCIATED_RX_ADMINRepetitionsUsed", "GetASSOCIATED_RX_ADMIN");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_PERSON to ASSOCIATED_RX_ADMIN
        /// </summary>
        public static PEX_P07_ASSOCIATED_RX_ADMIN AddASSOCIATED_RX_ADMIN(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetASSOCIATED_RX_ADMIN(message.ASSOCIATED_RX_ADMINRepetitionsUsed);
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_PERSON to PRB
        /// </summary>
        public static PRB AddPRB(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetPRB(message.PRBRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_ASSOCIATED_PERSON
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_PERSON to OBX
        /// </summary>
        public static OBX AddOBX(this PEX_P07_ASSOCIATED_PERSON message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from CSU_C09_STUDY_OBSERVATION
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this CSU_C09_STUDY_OBSERVATION message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_OBSERVATION to OBX
        /// </summary>
        public static OBX AddOBX(this CSU_C09_STUDY_OBSERVATION message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this VXX_V02_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from VXX_V02_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this VXX_V02_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new VXX_V02_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this VXX_V02_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRG_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRG_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRG_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRG_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRG_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRG_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O01_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O01_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O01_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O01_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGV_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O01_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O01_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGV_O01_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RGV_O01_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from REF_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this REF_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new REF_I12_RESULTS_NOTES to NTE
        /// </summary>
        public static NTE AddNTE(this REF_I12_RESULTS_NOTES message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPT_PCL_ORDER_DETAIL
        /// </summary>
        public static List<PPT_PCL_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPT_PCL_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PPT_PCL_ORDER_OBSERVATION AddORDER_OBSERVATION(this PPT_PCL_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PATHWAY_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PATHWAY_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PATHWAY_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PATHWAY_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_PATHWAY_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_PATHWAY_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PPP_PCB_PROBLEM_ROLE AddPROBLEM_ROLE(this PPP_PCB_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PPP_PCB_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PPP_PCB_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_GOAL> GetAllGOALRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to GOAL
        /// </summary>
        public static PPP_PCB_GOAL AddGOAL(this PPP_PCB_PROBLEM message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PPP_PCB_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPP_PCB_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPP_PCB_PROBLEM
        /// </summary>
        public static List<PPP_PCB_ORDER> GetAllORDERRecords(this PPP_PCB_PROBLEM message)
        {
            return message.GetAllRecords<PPP_PCB_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM to ORDER
        /// </summary>
        public static PPP_PCB_ORDER AddORDER(this PPP_PCB_PROBLEM message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static IEnumerable GetPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            object[] result = message.GetRecords("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_CAUSE Records from PEX_P07_PEX_OBSERVATION
        /// </summary>
        public static List<PEX_P07_PEX_CAUSE> GetAllPEX_CAUSERecords(this PEX_P07_PEX_OBSERVATION message)
        {
            return message.GetAllRecords<PEX_P07_PEX_CAUSE>("PEX_CAUSERepetitionsUsed", "GetPEX_CAUSE");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_OBSERVATION to PEX_CAUSE
        /// </summary>
        public static PEX_P07_PEX_CAUSE AddPEX_CAUSE(this PEX_P07_PEX_OBSERVATION message)
        {
            return message.GetPEX_CAUSE(message.PEX_CAUSERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORR_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE
        /// </summary>
        public static NTE AddNTE(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE2
        /// </summary>
        public static NTE AddNTE2(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE2(message.NTE2RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static IEnumerable GetNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            object[] result = message.GetRecords("NTE3RepetitionsUsed", "GetNTE3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE3 Records from NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT
        /// </summary>
        public static List<NTE> GetAllNTE3Records(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetAllRecords<NTE>("NTE3RepetitionsUsed", "GetNTE3");
        }

        /// <summary>
        /// Add a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT to NTE3
        /// </summary>
        public static NTE AddNTE3(this NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT message)
        {
            return message.GetNTE3(message.NTE3RepetitionsUsed);
        }

        /// <summary>
        /// Get CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static IEnumerable GetCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            object[] result = message.GetRecords("CM2RepetitionsUsed", "GetCM2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CM2 Records from MFN_M06_MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static List<CM2> GetAllCM2Records(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            return message.GetAllRecords<CM2>("CM2RepetitionsUsed", "GetCM2");
        }

        /// <summary>
        /// Add a new MFN_M06_MF_PHASE_SCHED_DETAIL to CM2
        /// </summary>
        public static CM2 AddCM2(this MFN_M06_MF_PHASE_SCHED_DETAIL message)
        {
            return message.GetCM2(message.CM2RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from DOC_T12_RESULT
        /// </summary>
        public static IEnumerable GetOBXRecords(this DOC_T12_RESULT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from DOC_T12_RESULT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this DOC_T12_RESULT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new DOC_T12_RESULT to OBX
        /// </summary>
        public static OBX AddOBX(this DOC_T12_RESULT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P01_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P01_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A01_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A01_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQM_S25_REQUEST
        /// </summary>
        public static List<SQM_S25_RESOURCES> GetAllRESOURCESRecords(this SQM_S25_REQUEST message)
        {
            return message.GetAllRecords<SQM_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SQM_S25_REQUEST to RESOURCES
        /// </summary>
        public static SQM_S25_RESOURCES AddRESOURCES(this SQM_S25_REQUEST message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRG_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRG_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRG_O02_RESPONSE
        /// </summary>
        public static List<RRG_O02_ORDER> GetAllORDERRecords(this RRG_O02_RESPONSE message)
        {
            return message.GetAllRecords<RRG_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRG_O02_RESPONSE to ORDER
        /// </summary>
        public static RRG_O02_ORDER AddORDER(this RRG_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRD_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRD_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRD_O02_RESPONSE
        /// </summary>
        public static List<RRD_O02_ORDER> GetAllORDERRecords(this RRD_O02_RESPONSE message)
        {
            return message.GetAllRecords<RRD_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRD_O02_RESPONSE to ORDER
        /// </summary>
        public static RRD_O02_ORDER AddORDER(this RRD_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRA_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRA_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRA_O02_RESPONSE
        /// </summary>
        public static List<RRA_O02_ORDER> GetAllORDERRecords(this RRA_O02_RESPONSE message)
        {
            return message.GetAllRecords<RRA_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRA_O02_RESPONSE to ORDER
        /// </summary>
        public static RRA_O02_ORDER AddORDER(this RRA_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQI_I03_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQI_I03_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQI_I03_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQI_I03_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQI_I03_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQI_I03_INSURANCE> GetAllINSURANCERecords(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQI_I03_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQI_I03_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQI_I03_INSURANCE AddINSURANCE(this RQI_I03_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGR_RGR_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RGR_RGR_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGR_RGR_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RGR_RGR_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RDS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDS_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDS_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RDS_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RDS_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RAS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RAS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RAS_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RAS_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RAS_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RAS_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PRR_PC5_PROBLEM_ROLE AddPROBLEM_ROLE(this PRR_PC5_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_PATHWAY Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_PATHWAYRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_PATHWAYRepetitionsUsed", "GetPROBLEM_PATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_PATHWAY Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_PATHWAY> GetAllPROBLEM_PATHWAYRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_PATHWAY>("PROBLEM_PATHWAYRepetitionsUsed", "GetPROBLEM_PATHWAY");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to PROBLEM_PATHWAY
        /// </summary>
        public static PRR_PC5_PROBLEM_PATHWAY AddPROBLEM_PATHWAY(this PRR_PC5_PROBLEM message)
        {
            return message.GetPROBLEM_PATHWAY(message.PROBLEM_PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PRR_PC5_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PRR_PC5_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_GOAL> GetAllGOALRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to GOAL
        /// </summary>
        public static PRR_PC5_GOAL AddGOAL(this PRR_PC5_PROBLEM message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PRR_PC5_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PRR_PC5_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PRR_PC5_PROBLEM
        /// </summary>
        public static List<PRR_PC5_ORDER> GetAllORDERRecords(this PRR_PC5_PROBLEM message)
        {
            return message.GetAllRecords<PRR_PC5_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM to ORDER
        /// </summary>
        public static PRR_PC5_ORDER AddORDER(this PRR_PC5_PROBLEM message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPR_PC1_GOAL
        /// </summary>
        public static List<PPR_PC1_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to GOAL_ROLE
        /// </summary>
        public static PPR_PC1_GOAL_ROLE AddGOAL_ROLE(this PPR_PC1_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPR_PC1_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPR_PC1_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPR_PC1_GOAL
        /// </summary>
        public static List<PPR_PC1_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPR_PC1_GOAL message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PPR_PC1_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PPR_PC1_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from OSR_Q06_RESPONSE
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OSR_Q06_RESPONSE message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OSR_Q06_RESPONSE
        /// </summary>
        public static List<OSR_Q06_OBSERVATION> GetAllOBSERVATIONRecords(this OSR_Q06_RESPONSE message)
        {
            return message.GetAllRecords<OSR_Q06_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new OSR_Q06_RESPONSE to OBSERVATION
        /// </summary>
        public static OSR_Q06_OBSERVATION AddOBSERVATION(this OSR_Q06_RESPONSE message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OSR_Q06_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OSR_Q06_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OSR_Q06_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OSR_Q06_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OSR_Q06_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OSR_Q06_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from OSR_Q06_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this OSR_Q06_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from OSR_Q06_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this OSR_Q06_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new OSR_Q06_OBSERVATION to CTI
        /// </summary>
        public static CTI AddCTI(this OSR_Q06_OBSERVATION message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from ORU_R01_PATIENT_RESULT
        /// </summary>
        public static List<ORU_R01_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetAllRecords<ORU_R01_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT_RESULT to ORDER_OBSERVATION
        /// </summary>
        public static ORU_R01_ORDER_OBSERVATION AddORDER_OBSERVATION(this ORU_R01_PATIENT_RESULT message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORN_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORN_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORM_O01_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORM_O01_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORM_O01_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORM_O01_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORM_O01_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from OMS_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMS_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMS_O01_ORDER_DETAIL
        /// </summary>
        public static List<OMS_O01_OBSERVATION> GetAllOBSERVATIONRecords(this OMS_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<OMS_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new OMS_O01_ORDER_DETAIL to OBSERVATION
        /// </summary>
        public static OMS_O01_OBSERVATION AddOBSERVATION(this OMS_O01_ORDER_DETAIL message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_CLOCK message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_CLOCK
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_CLOCK message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_CLOCK to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_CLOCK message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this BAR_P05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from BAR_P05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this BAR_P05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new BAR_P05_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this BAR_P05_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A01_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A01_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A01_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A01_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A01_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_RESULTS_NOTES
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_RESULTS_NOTES message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I12_RESULTS_NOTES to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I12_RESULTS_NOTES message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQI_I02_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQI_I02_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQI_I02_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQI_I02_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQI_I02_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQI_I02_INSURANCE> GetAllINSURANCERecords(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQI_I02_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQI_I02_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQI_I02_INSURANCE AddINSURANCE(this RQI_I02_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQI_I01_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQI_I01_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQI_I01_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQI_I01_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQI_I01_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQA_I08_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQA_I08_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQA_I08_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQA_I08_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQA_I08_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DISPENSE Records from RDR_RDR_ORDER
        /// </summary>
        public static IEnumerable GetDISPENSERecords(this RDR_RDR_ORDER message)
        {
            object[] result = message.GetRecords("DISPENSERepetitionsUsed", "GetDISPENSE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DISPENSE Records from RDR_RDR_ORDER
        /// </summary>
        public static List<RDR_RDR_DISPENSE> GetAllDISPENSERecords(this RDR_RDR_ORDER message)
        {
            return message.GetAllRecords<RDR_RDR_DISPENSE>("DISPENSERepetitionsUsed", "GetDISPENSE");
        }

        /// <summary>
        /// Add a new RDR_RDR_ORDER to DISPENSE
        /// </summary>
        public static RDR_RDR_DISPENSE AddDISPENSE(this RDR_RDR_ORDER message)
        {
            return message.GetDISPENSE(message.DISPENSERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PRR_PC5_PATIENT
        /// </summary>
        public static List<PRR_PC5_PROBLEM> GetAllPROBLEMRecords(this PRR_PC5_PATIENT message)
        {
            return message.GetAllRecords<PRR_PC5_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PRR_PC5_PATIENT to PROBLEM
        /// </summary>
        public static PRR_PC5_PROBLEM AddPROBLEM(this PRR_PC5_PATIENT message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<PPV_PCA_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PPV_PCA_PROBLEM_ROLE AddPROBLEM_ROLE(this PPV_PCA_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPV_PCA_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPV_PCA_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPV_PCA_PROBLEM
        /// </summary>
        public static List<PPV_PCA_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPV_PCA_PROBLEM message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPV_PCA_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PPV_PCA_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PPV_PCA_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPV_PCA_ORDER_DETAIL
        /// </summary>
        public static List<PPV_PCA_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPV_PCA_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPV_PCA_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PPV_PCA_ORDER_OBSERVATION AddORDER_OBSERVATION(this PPV_PCA_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from PIN_I07_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this PIN_I07_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from PIN_I07_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this PIN_I07_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new PIN_I07_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this PIN_I07_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from OMD_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMD_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMD_O01_PATIENT
        /// </summary>
        public static List<OMD_O01_INSURANCE> GetAllINSURANCERecords(this OMD_O01_PATIENT message)
        {
            return message.GetAllRecords<OMD_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new OMD_O01_PATIENT to INSURANCE
        /// </summary>
        public static OMD_O01_INSURANCE AddINSURANCE(this OMD_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMD_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMD_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMD_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMD_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMD_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMD_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get ODT Records from OMD_O01_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetODTRecords(this OMD_O01_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("ODTRepetitionsUsed", "GetODT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODT Records from OMD_O01_ORDER_TRAY
        /// </summary>
        public static List<ODT> GetAllODTRecords(this OMD_O01_ORDER_TRAY message)
        {
            return message.GetAllRecords<ODT>("ODTRepetitionsUsed", "GetODT");
        }

        /// <summary>
        /// Add a new OMD_O01_ORDER_TRAY to ODT
        /// </summary>
        public static ODT AddODT(this OMD_O01_ORDER_TRAY message)
        {
            return message.GetODT(message.ODTRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O01_ORDER_TRAY
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O01_ORDER_TRAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O01_ORDER_TRAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O01_ORDER_TRAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O01_ORDER_TRAY to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O01_ORDER_TRAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ODS Records from OMD_O01_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this OMD_O01_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from OMD_O01_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this OMD_O01_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Add a new OMD_O01_DIET to ODS
        /// </summary>
        public static ODS AddODS(this OMD_O01_DIET message)
        {
            return message.GetODS(message.ODSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMD_O01_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this OMD_O01_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMD_O01_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMD_O01_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMD_O01_DIET to NTE
        /// </summary>
        public static NTE AddNTE(this OMD_O01_DIET message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from OMD_O01_DIET
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMD_O01_DIET message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMD_O01_DIET
        /// </summary>
        public static List<OMD_O01_OBSERVATION> GetAllOBSERVATIONRecords(this OMD_O01_DIET message)
        {
            return message.GetAllRecords<OMD_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new OMD_O01_DIET to OBSERVATION
        /// </summary>
        public static OMD_O01_OBSERVATION AddOBSERVATION(this OMD_O01_DIET message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_APP_STATS to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_APP_STATS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get MF_PHASE_SCHED_DETAIL Records from MFN_M06_MF_CLIN_STUDY
        /// </summary>
        public static IEnumerable GetMF_PHASE_SCHED_DETAILRecords(this MFN_M06_MF_CLIN_STUDY message)
        {
            object[] result = message.GetRecords("MF_PHASE_SCHED_DETAILRepetitionsUsed", "GetMF_PHASE_SCHED_DETAIL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all MF_PHASE_SCHED_DETAIL Records from MFN_M06_MF_CLIN_STUDY
        /// </summary>
        public static List<MFN_M06_MF_PHASE_SCHED_DETAIL> GetAllMF_PHASE_SCHED_DETAILRecords(this MFN_M06_MF_CLIN_STUDY message)
        {
            return message.GetAllRecords<MFN_M06_MF_PHASE_SCHED_DETAIL>("MF_PHASE_SCHED_DETAILRepetitionsUsed", "GetMF_PHASE_SCHED_DETAIL");
        }

        /// <summary>
        /// Add a new MFN_M06_MF_CLIN_STUDY to MF_PHASE_SCHED_DETAIL
        /// </summary>
        public static MFN_M06_MF_PHASE_SCHED_DETAIL AddMF_PHASE_SCHED_DETAIL(this MFN_M06_MF_CLIN_STUDY message)
        {
            return message.GetMF_PHASE_SCHED_DETAIL(message.MF_PHASE_SCHED_DETAILRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A04_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A04_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A04_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A04_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A04_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A04_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_SCHEDULE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATIENT Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetPATIENTRecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("PATIENTRepetitionsUsed", "GetPATIENT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATIENT Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<SRR_S01_PATIENT> GetAllPATIENTRecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<SRR_S01_PATIENT>("PATIENTRepetitionsUsed", "GetPATIENT");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to PATIENT
        /// </summary>
        public static SRR_S01_PATIENT AddPATIENT(this SRR_S01_SCHEDULE message)
        {
            return message.GetPATIENT(message.PATIENTRepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SRR_S01_SCHEDULE
        /// </summary>
        public static List<SRR_S01_RESOURCES> GetAllRESOURCESRecords(this SRR_S01_SCHEDULE message)
        {
            return message.GetAllRecords<SRR_S01_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SRR_S01_SCHEDULE to RESOURCES
        /// </summary>
        public static SRR_S01_RESOURCES AddRESOURCES(this SRR_S01_SCHEDULE message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQI_I01_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQI_I01_INSURANCE> GetAllINSURANCERecords(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQI_I01_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQI_I01_INSURANCE AddINSURANCE(this RQI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGV_O01_COMPONENTS
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O01_COMPONENTS message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O01_COMPONENTS
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O01_COMPONENTS message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGV_O01_COMPONENTS to RXC
        /// </summary>
        public static RXC AddRXC(this RGV_O01_COMPONENTS message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O01_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O01_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O01_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O01_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O01_COMPONENTS to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O01_COMPONENTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RGR_RGR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RGR_RGR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RGR_RGR_DEFINITION
        /// </summary>
        public static List<RGR_RGR_ORDER> GetAllORDERRecords(this RGR_RGR_DEFINITION message)
        {
            return message.GetAllRecords<RGR_RGR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RGR_RGR_DEFINITION to ORDER
        /// </summary>
        public static RGR_RGR_ORDER AddORDER(this RGR_RGR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O01_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O01_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O01_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O01_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O01_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O01_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDS_O01_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O01_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O01_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O01_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDS_O01_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RDS_O01_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RDS_O01_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RDS_O01_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RDS_O01_ORDER
        /// </summary>
        public static List<RDS_O01_OBSERVATION> GetAllOBSERVATIONRecords(this RDS_O01_ORDER message)
        {
            return message.GetAllRecords<RDS_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RDS_O01_ORDER to OBSERVATION
        /// </summary>
        public static RDS_O01_OBSERVATION AddOBSERVATION(this RDS_O01_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDO_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDO_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDO_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDO_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDO_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDO_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RDO_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RDO_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RDO_O01_PATIENT
        /// </summary>
        public static List<RDO_O01_INSURANCE> GetAllINSURANCERecords(this RDO_O01_PATIENT message)
        {
            return message.GetAllRecords<RDO_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RDO_O01_PATIENT to INSURANCE
        /// </summary>
        public static RDO_O01_INSURANCE AddINSURANCE(this RDO_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RDO_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RDO_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RDO_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RDO_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RDO_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RDO_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<PTR_PCF_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<PTR_PCF_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to PATHWAY_ROLE
        /// </summary>
        public static PTR_PCF_PATHWAY_ROLE AddPATHWAY_ROLE(this PTR_PCF_PATHWAY message)
        {
            return message.GetPATHWAY_ROLE(message.PATHWAY_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PTR_PCF_PATHWAY
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PTR_PCF_PATHWAY message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PTR_PCF_PATHWAY
        /// </summary>
        public static List<PTR_PCF_PROBLEM> GetAllPROBLEMRecords(this PTR_PCF_PATHWAY message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATHWAY to PROBLEM
        /// </summary>
        public static PTR_PCF_PROBLEM AddPROBLEM(this PTR_PCF_PATHWAY message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPV_PCA_PATIENT message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPV_PCA_PATIENT
        /// </summary>
        public static List<PPV_PCA_GOAL> GetAllGOALRecords(this PPV_PCA_PATIENT message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPV_PCA_PATIENT to GOAL
        /// </summary>
        public static PPV_PCA_GOAL AddGOAL(this PPV_PCA_PATIENT message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from PIN_I07_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from PIN_I07_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new PIN_I07_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from PIN_I07_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from PIN_I07_GUARANTOR_INSURANCE
        /// </summary>
        public static List<PIN_I07_INSURANCE> GetAllINSURANCERecords(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<PIN_I07_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new PIN_I07_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static PIN_I07_INSURANCE AddINSURANCE(this PIN_I07_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PGL_PC6_ORDER_DETAIL
        /// </summary>
        public static List<PGL_PC6_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PGL_PC6_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PGL_PC6_ORDER_OBSERVATION AddORDER_OBSERVATION(this PGL_PC6_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORF_R04_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORF_R04_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORF_R04_QUERY_RESPONSE
        /// </summary>
        public static List<ORF_R04_ORDER> GetAllORDERRecords(this ORF_R04_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ORF_R04_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORF_R04_QUERY_RESPONSE to ORDER
        /// </summary>
        public static ORF_R04_ORDER AddORDER(this ORF_R04_QUERY_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_DIET Records from ORD_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDER_DIETRecords(this ORD_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_DIET Records from ORD_O02_RESPONSE
        /// </summary>
        public static List<ORD_O02_ORDER_DIET> GetAllORDER_DIETRecords(this ORD_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORD_O02_ORDER_DIET>("ORDER_DIETRepetitionsUsed", "GetORDER_DIET");
        }

        /// <summary>
        /// Add a new ORD_O02_RESPONSE to ORDER_DIET
        /// </summary>
        public static ORD_O02_ORDER_DIET AddORDER_DIET(this ORD_O02_RESPONSE message)
        {
            return message.GetORDER_DIET(message.ORDER_DIETRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_TRAY Records from ORD_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDER_TRAYRecords(this ORD_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_TRAY Records from ORD_O02_RESPONSE
        /// </summary>
        public static List<ORD_O02_ORDER_TRAY> GetAllORDER_TRAYRecords(this ORD_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORD_O02_ORDER_TRAY>("ORDER_TRAYRepetitionsUsed", "GetORDER_TRAY");
        }

        /// <summary>
        /// Add a new ORD_O02_RESPONSE to ORDER_TRAY
        /// </summary>
        public static ORD_O02_ORDER_TRAY AddORDER_TRAY(this ORD_O02_RESPONSE message)
        {
            return message.GetORDER_TRAY(message.ORDER_TRAYRepetitionsUsed);
        }

        /// <summary>
        /// Get RX_ADMIN Records from CSU_C09_STUDY_PHARM
        /// </summary>
        public static IEnumerable GetRX_ADMINRecords(this CSU_C09_STUDY_PHARM message)
        {
            object[] result = message.GetRecords("RX_ADMINRepetitionsUsed", "GetRX_ADMIN");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RX_ADMIN Records from CSU_C09_STUDY_PHARM
        /// </summary>
        public static List<CSU_C09_RX_ADMIN> GetAllRX_ADMINRecords(this CSU_C09_STUDY_PHARM message)
        {
            return message.GetAllRecords<CSU_C09_RX_ADMIN>("RX_ADMINRepetitionsUsed", "GetRX_ADMIN");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_PHARM to RX_ADMIN
        /// </summary>
        public static CSU_C09_RX_ADMIN AddRX_ADMIN(this CSU_C09_STUDY_PHARM message)
        {
            return message.GetRX_ADMIN(message.RX_ADMINRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this BAR_P05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from BAR_P05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this BAR_P05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new BAR_P05_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this BAR_P05_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A06_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A06_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A06_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A06_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A06_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A05_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A05_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A05_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A05_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A05_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A03_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A03_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A03_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A03_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A03_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I08_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I08_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDS_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O01_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O01_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDS_O01_COMPONENT to RXC
        /// </summary>
        public static RXC AddRXC(this RDS_O01_COMPONENT message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDS_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDS_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDS_O01_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDS_O01_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDS_O01_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDS_O01_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDO_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDO_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDO_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDO_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDO_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RDO_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<PPG_PCG_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<PPG_PCG_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to PATHWAY_ROLE
        /// </summary>
        public static PPG_PCG_PATHWAY_ROLE AddPATHWAY_ROLE(this PPG_PCG_PATHWAY message)
        {
            return message.GetPATHWAY_ROLE(message.PATHWAY_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPG_PCG_PATHWAY
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPG_PCG_PATHWAY message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPG_PCG_PATHWAY
        /// </summary>
        public static List<PPG_PCG_GOAL> GetAllGOALRecords(this PPG_PCG_PATHWAY message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPG_PCG_PATHWAY to GOAL
        /// </summary>
        public static PPG_PCG_GOAL AddGOAL(this PPG_PCG_PATHWAY message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORS_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORS_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORS_O02_RESPONSE
        /// </summary>
        public static List<ORS_O02_ORDER> GetAllORDERRecords(this ORS_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORS_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORS_O02_RESPONSE to ORDER
        /// </summary>
        public static ORS_O02_ORDER AddORDER(this ORS_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORS_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORS_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORS_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static IEnumerable GetNTERecords(this NMD_N02_APP_STATUS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from NMD_N02_APP_STATUS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this NMD_N02_APP_STATUS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new NMD_N02_APP_STATUS to NTE
        /// </summary>
        public static NTE AddNTE(this NMD_N02_APP_STATUS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get FINANCIAL_PROCEDURE Records from DFT_P03_FINANCIAL
        /// </summary>
        public static IEnumerable GetFINANCIAL_PROCEDURERecords(this DFT_P03_FINANCIAL message)
        {
            object[] result = message.GetRecords("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FINANCIAL_PROCEDURE Records from DFT_P03_FINANCIAL
        /// </summary>
        public static List<DFT_P03_FINANCIAL_PROCEDURE> GetAllFINANCIAL_PROCEDURERecords(this DFT_P03_FINANCIAL message)
        {
            return message.GetAllRecords<DFT_P03_FINANCIAL_PROCEDURE>("FINANCIAL_PROCEDURERepetitionsUsed", "GetFINANCIAL_PROCEDURE");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL to FINANCIAL_PROCEDURE
        /// </summary>
        public static DFT_P03_FINANCIAL_PROCEDURE AddFINANCIAL_PROCEDURE(this DFT_P03_FINANCIAL message)
        {
            return message.GetFINANCIAL_PROCEDURE(message.FINANCIAL_PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_OBSERVATION Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_STUDY_OBSERVATION> GetAllSTUDY_OBSERVATIONRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_OBSERVATION>("STUDY_OBSERVATIONRepetitionsUsed", "GetSTUDY_OBSERVATION");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_SCHEDULE to STUDY_OBSERVATION
        /// </summary>
        public static CSU_C09_STUDY_OBSERVATION AddSTUDY_OBSERVATION(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetSTUDY_OBSERVATION(message.STUDY_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_PHARM Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static IEnumerable GetSTUDY_PHARMRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            object[] result = message.GetRecords("STUDY_PHARMRepetitionsUsed", "GetSTUDY_PHARM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_PHARM Records from CSU_C09_STUDY_SCHEDULE
        /// </summary>
        public static List<CSU_C09_STUDY_PHARM> GetAllSTUDY_PHARMRecords(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_PHARM>("STUDY_PHARMRepetitionsUsed", "GetSTUDY_PHARM");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_SCHEDULE to STUDY_PHARM
        /// </summary>
        public static CSU_C09_STUDY_PHARM AddSTUDY_PHARM(this CSU_C09_STUDY_SCHEDULE message)
        {
            return message.GetSTUDY_PHARM(message.STUDY_PHARMRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A07_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A07_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A07_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A07_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A07_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A07_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A05_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A05_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A05_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A05_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A05_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A04_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A04_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A04_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A04_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A04_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A04_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static IEnumerable GetCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RRI_I12_PROVIDER_CONTACT
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RRI_I12_PROVIDER_CONTACT message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RRI_I12_PROVIDER_CONTACT to CTD
        /// </summary>
        public static CTD AddCTD(this RRI_I12_PROVIDER_CONTACT message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRD_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRD_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRD_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRD_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRD_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRD_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RQA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RQA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RQA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RQA_I08_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RQA_I08_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RQA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RQA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RQA_I08_OBSERVATION
        /// </summary>
        public static List<RQA_I08_RESULTS> GetAllRESULTSRecords(this RQA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<RQA_I08_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RQA_I08_OBSERVATION to RESULTS
        /// </summary>
        public static RQA_I08_RESULTS AddRESULTS(this RQA_I08_OBSERVATION message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RQA_I08_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RQA_I08_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RQA_I08_INSURANCE> GetAllINSURANCERecords(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RQA_I08_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RQA_I08_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RQA_I08_INSURANCE AddINSURANCE(this RQA_I08_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPL_I02_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPL_I02_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPL_I02_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPL_I02_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPL_I02_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RER_RER_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RER_RER_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RER_RER_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RER_RER_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RER_RER_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RER_RER_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RER_RER_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RER_RER_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RER_RER_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from REF_I12_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this REF_I12_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from REF_I12_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this REF_I12_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new REF_I12_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this REF_I12_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RCL_I06_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RCL_I06_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RCL_I06_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RCL_I06_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RCL_I06_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PTR_PCF_PROBLEM_ROLE AddPROBLEM_ROLE(this PTR_PCF_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PTR_PCF_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PTR_PCF_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_GOAL> GetAllGOALRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to GOAL
        /// </summary>
        public static PTR_PCF_GOAL AddGOAL(this PTR_PCF_PROBLEM message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PTR_PCF_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PTR_PCF_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PTR_PCF_PROBLEM
        /// </summary>
        public static List<PTR_PCF_ORDER> GetAllORDERRecords(this PTR_PCF_PROBLEM message)
        {
            return message.GetAllRecords<PTR_PCF_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM to ORDER
        /// </summary>
        public static PTR_PCF_ORDER AddORDER(this PTR_PCF_PROBLEM message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PPP_PCB_ORDER_DETAIL
        /// </summary>
        public static List<PPP_PCB_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PPP_PCB_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPP_PCB_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PPP_PCB_ORDER_OBSERVATION AddORDER_OBSERVATION(this PPP_PCB_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<PPG_PCG_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PPG_PCG_PROBLEM_ROLE AddPROBLEM_ROLE(this PPG_PCG_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPG_PCG_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPG_PCG_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPG_PCG_PROBLEM
        /// </summary>
        public static List<PPG_PCG_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPG_PCG_PROBLEM message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PPG_PCG_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PPG_PCG_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get RX_ADMINISTRATION Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetRX_ADMINISTRATIONRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("RX_ADMINISTRATIONRepetitionsUsed", "GetRX_ADMINISTRATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RX_ADMINISTRATION Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PEX_P07_RX_ADMINISTRATION> GetAllRX_ADMINISTRATIONRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PEX_P07_RX_ADMINISTRATION>("RX_ADMINISTRATIONRepetitionsUsed", "GetRX_ADMINISTRATION");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to RX_ADMINISTRATION
        /// </summary>
        public static PEX_P07_RX_ADMINISTRATION AddRX_ADMINISTRATION(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetRX_ADMINISTRATION(message.RX_ADMINISTRATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("PRBRepetitionsUsed", "GetPRB");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRB Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PRB> GetAllPRBRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PRB>("PRBRepetitionsUsed", "GetPRB");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to PRB
        /// </summary>
        public static PRB AddPRB(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetPRB(message.PRBRepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to OBX
        /// </summary>
        public static OBX AddOBX(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to NTE
        /// </summary>
        public static NTE AddNTE(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static IEnumerable GetSTUDYRecords(this PEX_P07_PEX_CAUSE message)
        {
            object[] result = message.GetRecords("STUDYRepetitionsUsed", "GetSTUDY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY Records from PEX_P07_PEX_CAUSE
        /// </summary>
        public static List<PEX_P07_STUDY> GetAllSTUDYRecords(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetAllRecords<PEX_P07_STUDY>("STUDYRepetitionsUsed", "GetSTUDY");
        }

        /// <summary>
        /// Add a new PEX_P07_PEX_CAUSE to STUDY
        /// </summary>
        public static PEX_P07_STUDY AddSTUDY(this PEX_P07_PEX_CAUSE message)
        {
            return message.GetSTUDY(message.STUDYRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from PEX_P07_ASSOCIATED_RX_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new PEX_P07_ASSOCIATED_RX_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this PEX_P07_ASSOCIATED_RX_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get ODS Records from ORD_O02_ORDER_DIET
        /// </summary>
        public static IEnumerable GetODSRecords(this ORD_O02_ORDER_DIET message)
        {
            object[] result = message.GetRecords("ODSRepetitionsUsed", "GetODS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ODS Records from ORD_O02_ORDER_DIET
        /// </summary>
        public static List<ODS> GetAllODSRecords(this ORD_O02_ORDER_DIET message)
        {
            return message.GetAllRecords<ODS>("ODSRepetitionsUsed", "GetODS");
        }

        /// <summary>
        /// Add a new ORD_O02_ORDER_DIET to ODS
        /// </summary>
        public static ODS AddODS(this ORD_O02_ORDER_DIET message)
        {
            return message.GetODS(message.ODSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O02_ORDER_DIET
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O02_ORDER_DIET message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O02_ORDER_DIET
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O02_ORDER_DIET message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O02_ORDER_DIET to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O02_ORDER_DIET message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M09_MF_TEST_CAT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Add a new MFN_M09_MF_TEST_CAT_DETAIL to OM4
        /// </summary>
        public static OM4 AddOM4(this MFN_M09_MF_TEST_CAT_DETAIL message)
        {
            return message.GetOM4(message.OM4RepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P02_PATIENT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P02_PATIENT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P02_PATIENT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P02_PATIENT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P02_PATIENT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A28_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A28_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A28_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A28_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A28_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A28_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A08_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A08_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A08_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A08_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A08_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A08_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A06_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A06_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A06_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A06_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A06_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXR_V03_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXR_V03_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXR_V03_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new VXR_V03_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this VXR_V03_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PRODUCT Records from SUR_P09_FACILITY
        /// </summary>
        public static IEnumerable GetPRODUCTRecords(this SUR_P09_FACILITY message)
        {
            object[] result = message.GetRecords("PRODUCTRepetitionsUsed", "GetPRODUCT");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRODUCT Records from SUR_P09_FACILITY
        /// </summary>
        public static List<SUR_P09_PRODUCT> GetAllPRODUCTRecords(this SUR_P09_FACILITY message)
        {
            return message.GetAllRecords<SUR_P09_PRODUCT>("PRODUCTRepetitionsUsed", "GetPRODUCT");
        }

        /// <summary>
        /// Add a new SUR_P09_FACILITY to PRODUCT
        /// </summary>
        public static SUR_P09_PRODUCT AddPRODUCT(this SUR_P09_FACILITY message)
        {
            return message.GetPRODUCT(message.PRODUCTRepetitionsUsed);
        }

        /// <summary>
        /// Get FACILITY_DETAIL Records from SUR_P09_FACILITY
        /// </summary>
        public static IEnumerable GetFACILITY_DETAILRecords(this SUR_P09_FACILITY message)
        {
            object[] result = message.GetRecords("FACILITY_DETAILRepetitionsUsed", "GetFACILITY_DETAIL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all FACILITY_DETAIL Records from SUR_P09_FACILITY
        /// </summary>
        public static List<SUR_P09_FACILITY_DETAIL> GetAllFACILITY_DETAILRecords(this SUR_P09_FACILITY message)
        {
            return message.GetAllRecords<SUR_P09_FACILITY_DETAIL>("FACILITY_DETAILRepetitionsUsed", "GetFACILITY_DETAIL");
        }

        /// <summary>
        /// Add a new SUR_P09_FACILITY to FACILITY_DETAIL
        /// </summary>
        public static SUR_P09_FACILITY_DETAIL AddFACILITY_DETAIL(this SUR_P09_FACILITY message)
        {
            return message.GetFACILITY_DETAIL(message.FACILITY_DETAILRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RRO_O02_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRO_O02_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRO_O02_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRO_O02_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRO_O02_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRO_O02_ORDER_DETAIL to RXC
        /// </summary>
        public static RXC AddRXC(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE2 Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTE2Records(this RRO_O02_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTE2RepetitionsUsed", "GetNTE2");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE2 Records from RRO_O02_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTE2Records(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTE2RepetitionsUsed", "GetNTE2");
        }

        /// <summary>
        /// Add a new RRO_O02_ORDER_DETAIL to NTE2
        /// </summary>
        public static NTE AddNTE2(this RRO_O02_ORDER_DETAIL message)
        {
            return message.GetNTE2(message.NTE2RepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRD_O02_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRD_O02_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRD_O02_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRD_O02_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRD_O02_DISPENSE to RXR
        /// </summary>
        public static RXR AddRXR(this RRD_O02_DISPENSE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRD_O02_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRD_O02_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRD_O02_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRD_O02_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRD_O02_DISPENSE to RXC
        /// </summary>
        public static RXC AddRXC(this RRD_O02_DISPENSE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O01_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O01_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O01_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O01_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O01_GIVE to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O01_GIVE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGV_O01_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGV_O01_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGV_O01_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGV_O01_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGV_O01_GIVE to RXC
        /// </summary>
        public static RXC AddRXC(this RGV_O01_GIVE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RGV_O01_GIVE
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RGV_O01_GIVE message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RGV_O01_GIVE
        /// </summary>
        public static List<RGV_O01_OBSERVATION> GetAllOBSERVATIONRecords(this RGV_O01_GIVE message)
        {
            return message.GetAllRecords<RGV_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RGV_O01_GIVE to OBSERVATION
        /// </summary>
        public static RGV_O01_OBSERVATION AddOBSERVATION(this RGV_O01_GIVE message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDR_RDR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDR_RDR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDR_RDR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDR_RDR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDR_RDR_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RDR_RDR_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDR_RDR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDR_RDR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDR_RDR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDR_RDR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDR_RDR_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RDR_RDR_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O01_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAS_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAS_O01_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RAS_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RAS_O01_COMPONENTS
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAS_O01_COMPONENTS message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAS_O01_COMPONENTS
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAS_O01_COMPONENTS message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RAS_O01_COMPONENTS to RXC
        /// </summary>
        public static RXC AddRXC(this RAS_O01_COMPONENTS message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O01_COMPONENTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O01_COMPONENTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O01_COMPONENTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O01_COMPONENTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O01_COMPONENTS to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O01_COMPONENTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PTR_PCF_PATIENT
        /// </summary>
        public static List<PTR_PCF_PATHWAY> GetAllPATHWAYRecords(this PTR_PCF_PATIENT message)
        {
            return message.GetAllRecords<PTR_PCF_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PTR_PCF_PATIENT to PATHWAY
        /// </summary>
        public static PTR_PCF_PATHWAY AddPATHWAY(this PTR_PCF_PATIENT message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PRR_PC5_GOAL
        /// </summary>
        public static List<PRR_PC5_GOAL_ROLE> GetAllGOAL_ROLERecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to GOAL_ROLE
        /// </summary>
        public static PRR_PC5_GOAL_ROLE AddGOAL_ROLE(this PRR_PC5_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PRR_PC5_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PRR_PC5_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PRR_PC5_GOAL
        /// </summary>
        public static List<PRR_PC5_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PRR_PC5_GOAL message)
        {
            return message.GetAllRecords<PRR_PC5_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PRR_PC5_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PRR_PC5_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static IEnumerable GetPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            object[] result = message.GetRecords("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PEX_OBSERVATION Records from PEX_P07_EXPERIENCE
        /// </summary>
        public static List<PEX_P07_PEX_OBSERVATION> GetAllPEX_OBSERVATIONRecords(this PEX_P07_EXPERIENCE message)
        {
            return message.GetAllRecords<PEX_P07_PEX_OBSERVATION>("PEX_OBSERVATIONRepetitionsUsed", "GetPEX_OBSERVATION");
        }

        /// <summary>
        /// Add a new PEX_P07_EXPERIENCE to PEX_OBSERVATION
        /// </summary>
        public static PEX_P07_PEX_OBSERVATION AddPEX_OBSERVATION(this PEX_P07_EXPERIENCE message)
        {
            return message.GetPEX_OBSERVATION(message.PEX_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from OMN_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this OMN_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from OMN_O01_ORDER_DETAIL
        /// </summary>
        public static List<OMN_O01_OBSERVATION> GetAllOBSERVATIONRecords(this OMN_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<OMN_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new OMN_O01_ORDER_DETAIL to OBSERVATION
        /// </summary>
        public static OMN_O01_OBSERVATION AddOBSERVATION(this OMN_O01_ORDER_DETAIL message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A28_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A28_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A28_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A28_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A28_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A28_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A07_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A07_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A07_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A07_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A07_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A07_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to NK1
        /// </summary>
        public static NK1 AddNK1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DB1> GetAllDB1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to DB1
        /// </summary>
        public static DB1 AddDB1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to OBX
        /// </summary>
        public static OBX AddOBX(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to AL1
        /// </summary>
        public static AL1 AddAL1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to DG1
        /// </summary>
        public static DG1 AddDG1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ADR_A19_PROCEDURE> GetAllPROCEDURERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ADR_A19_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to PROCEDURE
        /// </summary>
        public static ADR_A19_PROCEDURE AddPROCEDURE(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to GT1
        /// </summary>
        public static GT1 AddGT1(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ADR_A19_QUERY_RESPONSE
        /// </summary>
        public static List<ADR_A19_INSURANCE> GetAllINSURANCERecords(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetAllRecords<ADR_A19_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ADR_A19_QUERY_RESPONSE to INSURANCE
        /// </summary>
        public static ADR_A19_INSURANCE AddINSURANCE(this ADR_A19_QUERY_RESPONSE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from VXR_V03_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this VXR_V03_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from VXR_V03_ORDER
        /// </summary>
        public static List<VXR_V03_OBSERVATION> GetAllOBSERVATIONRecords(this VXR_V03_ORDER message)
        {
            return message.GetAllRecords<VXR_V03_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new VXR_V03_ORDER to OBSERVATION
        /// </summary>
        public static VXR_V03_OBSERVATION AddOBSERVATION(this VXR_V03_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRM_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRM_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRM_S01_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRM_S01_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_SCHEDULE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_SCHEDULE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static IEnumerable GetRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            object[] result = message.GetRecords("RESOURCESRepetitionsUsed", "GetRESOURCES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESOURCES Records from SQR_S25_SCHEDULE
        /// </summary>
        public static List<SQR_S25_RESOURCES> GetAllRESOURCESRecords(this SQR_S25_SCHEDULE message)
        {
            return message.GetAllRecords<SQR_S25_RESOURCES>("RESOURCESRepetitionsUsed", "GetRESOURCES");
        }

        /// <summary>
        /// Add a new SQR_S25_SCHEDULE to RESOURCES
        /// </summary>
        public static SQR_S25_RESOURCES AddRESOURCES(this SQR_S25_SCHEDULE message)
        {
            return message.GetRESOURCES(message.RESOURCESRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQC_I05_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQC_I05_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQC_I05_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQC_I05_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQC_I05_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from ROR_R0R_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this ROR_R0R_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from ROR_R0R_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this ROR_R0R_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new ROR_R0R_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this ROR_R0R_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from ROR_R0R_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this ROR_R0R_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from ROR_R0R_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this ROR_R0R_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new ROR_R0R_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this ROR_R0R_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O01_ORDER_DETAIL_SUPPLEMENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGV_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGV_O01_ORDER_DETAIL_SUPPLEMENT
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGV_O01_ORDER_DETAIL_SUPPLEMENT to RXR
        /// </summary>
        public static RXR AddRXR(this RGV_O01_ORDER_DETAIL_SUPPLEMENT message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RER_RER_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RER_RER_DEFINITION
        /// </summary>
        public static List<RER_RER_ORDER> GetAllORDERRecords(this RER_RER_DEFINITION message)
        {
            return message.GetAllRecords<RER_RER_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RER_RER_DEFINITION to ORDER
        /// </summary>
        public static RER_RER_ORDER AddORDER(this RER_RER_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RCI_I05_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RCI_I05_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RCI_I05_OBSERVATION
        /// </summary>
        public static List<RCI_I05_RESULTS> GetAllRESULTSRecords(this RCI_I05_OBSERVATION message)
        {
            return message.GetAllRecords<RCI_I05_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RCI_I05_OBSERVATION to RESULTS
        /// </summary>
        public static RCI_I05_RESULTS AddRESULTS(this RCI_I05_OBSERVATION message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPG_PCG_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPG_PCG_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to GOAL_ROLE
        /// </summary>
        public static PPG_PCG_GOAL_ROLE AddGOAL_ROLE(this PPG_PCG_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PPG_PCG_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PPG_PCG_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_PROBLEM> GetAllPROBLEMRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to PROBLEM
        /// </summary>
        public static PPG_PCG_PROBLEM AddPROBLEM(this PPG_PCG_GOAL message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PPG_PCG_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPG_PCG_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPG_PCG_GOAL
        /// </summary>
        public static List<PPG_PCG_ORDER> GetAllORDERRecords(this PPG_PCG_GOAL message)
        {
            return message.GetAllRecords<PPG_PCG_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PPG_PCG_GOAL to ORDER
        /// </summary>
        public static PPG_PCG_ORDER AddORDER(this PPG_PCG_GOAL message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORN_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORN_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORN_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORN_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORN_O02_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORN_O02_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from OMN_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMN_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMN_O01_PATIENT
        /// </summary>
        public static List<OMN_O01_INSURANCE> GetAllINSURANCERecords(this OMN_O01_PATIENT message)
        {
            return message.GetAllRecords<OMN_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new OMN_O01_PATIENT to INSURANCE
        /// </summary>
        public static OMN_O01_INSURANCE AddINSURANCE(this OMN_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMN_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMN_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMN_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMN_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMN_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMN_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCHRepetitionsUsed", "GetLCH");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCH Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCH> GetAllLCHRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCH>("LCHRepetitionsUsed", "GetLCH");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOC_DEPT to LCH
        /// </summary>
        public static LCH AddLCH(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetLCH(message.LCHRepetitionsUsed);
        }

        /// <summary>
        /// Get LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static IEnumerable GetLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            object[] result = message.GetRecords("LCCRepetitionsUsed", "GetLCC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LCC Records from MFN_M05_MF_LOC_DEPT
        /// </summary>
        public static List<LCC> GetAllLCCRecords(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetAllRecords<LCC>("LCCRepetitionsUsed", "GetLCC");
        }

        /// <summary>
        /// Add a new MFN_M05_MF_LOC_DEPT to LCC
        /// </summary>
        public static LCC AddLCC(this MFN_M05_MF_LOC_DEPT message)
        {
            return message.GetLCC(message.LCCRepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A08_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A08_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A08_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A08_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A08_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A08_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get SERVICE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_SERVICE> GetAllSERVICERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Add a new SRR_S01_RESOURCES to SERVICE
        /// </summary>
        public static SRR_S01_SERVICE AddSERVICE(this SRR_S01_RESOURCES message)
        {
            return message.GetSERVICE(message.SERVICERepetitionsUsed);
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Add a new SRR_S01_RESOURCES to GENERAL_RESOURCE
        /// </summary>
        public static SRR_S01_GENERAL_RESOURCE AddGENERAL_RESOURCE(this SRR_S01_RESOURCES message)
        {
            return message.GetGENERAL_RESOURCE(message.GENERAL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Add a new SRR_S01_RESOURCES to LOCATION_RESOURCE
        /// </summary>
        public static SRR_S01_LOCATION_RESOURCE AddLOCATION_RESOURCE(this SRR_S01_RESOURCES message)
        {
            return message.GetLOCATION_RESOURCE(message.LOCATION_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SRR_S01_RESOURCES
        /// </summary>
        public static List<SRR_S01_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SRR_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRR_S01_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Add a new SRR_S01_RESOURCES to PERSONNEL_RESOURCE
        /// </summary>
        public static SRR_S01_PERSONNEL_RESOURCE AddPERSONNEL_RESOURCE(this SRR_S01_RESOURCES message)
        {
            return message.GetPERSONNEL_RESOURCE(message.PERSONNEL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetOBXRecords(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from SRM_S01_PATIENT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new SRM_S01_PATIENT to OBX
        /// </summary>
        public static OBX AddOBX(this SRM_S01_PATIENT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRM_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRM_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRM_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SRM_S01_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SRM_S01_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRO_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRO_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRO_O02_RESPONSE
        /// </summary>
        public static List<RRO_O02_ORDER> GetAllORDERRecords(this RRO_O02_RESPONSE message)
        {
            return message.GetAllRecords<RRO_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRO_O02_RESPONSE to ORDER
        /// </summary>
        public static RRO_O02_ORDER AddORDER(this RRO_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RRA_O02_ADMINISTRATION
        /// </summary>
        public static IEnumerable GetRXARecords(this RRA_O02_ADMINISTRATION message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RRA_O02_ADMINISTRATION
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RRA_O02_ADMINISTRATION message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RRA_O02_ADMINISTRATION to RXA
        /// </summary>
        public static RXA AddRXA(this RRA_O02_ADMINISTRATION message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQI_I02_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQI_I02_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQI_I02_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQI_I02_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQI_I02_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQI_I02_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPI_I04_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I04_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I04_INSURANCE> GetAllINSURANCERecords(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I04_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPI_I04_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RPI_I04_INSURANCE AddINSURANCE(this RPI_I04_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDS_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDS_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDS_O01_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDS_O01_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDS_O01_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RDS_O01_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDS_O01_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDS_O01_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDS_O01_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDS_O01_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDS_O01_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RDS_O01_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDR_RDR_DISPENSE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDR_RDR_DISPENSE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDR_RDR_DISPENSE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDR_RDR_DISPENSE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDR_RDR_DISPENSE to RXR
        /// </summary>
        public static RXR AddRXR(this RDR_RDR_DISPENSE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDR_RDR_DISPENSE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDR_RDR_DISPENSE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDR_RDR_DISPENSE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDR_RDR_DISPENSE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDR_RDR_DISPENSE to RXC
        /// </summary>
        public static RXC AddRXC(this RDR_RDR_DISPENSE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RDR_RDR_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this RDR_RDR_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RDR_RDR_DEFINITION
        /// </summary>
        public static List<RDR_RDR_ORDER> GetAllORDERRecords(this RDR_RDR_DEFINITION message)
        {
            return message.GetAllRecords<RDR_RDR_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RDR_RDR_DEFINITION to ORDER
        /// </summary>
        public static RDR_RDR_ORDER AddORDER(this RDR_RDR_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PTR_PCF_GOAL
        /// </summary>
        public static List<PTR_PCF_GOAL_ROLE> GetAllGOAL_ROLERecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to GOAL_ROLE
        /// </summary>
        public static PTR_PCF_GOAL_ROLE AddGOAL_ROLE(this PTR_PCF_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PTR_PCF_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PTR_PCF_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PTR_PCF_GOAL
        /// </summary>
        public static List<PTR_PCF_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PTR_PCF_GOAL message)
        {
            return message.GetAllRecords<PTR_PCF_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PTR_PCF_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PTR_PCF_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PTR_PCF_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_GOAL_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_GOAL_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_GOAL_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_PATHWAY_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_PATHWAY_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_PATHWAY_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_PATHWAY_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPP_PCB_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPP_PCB_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPP_PCB_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPP_PCB_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPP_PCB_GOAL
        /// </summary>
        public static List<PPP_PCB_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to GOAL_ROLE
        /// </summary>
        public static PPP_PCB_GOAL_ROLE AddGOAL_ROLE(this PPP_PCB_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPP_PCB_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPP_PCB_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPP_PCB_GOAL
        /// </summary>
        public static List<PPP_PCB_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPP_PCB_GOAL message)
        {
            return message.GetAllRecords<PPP_PCB_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPP_PCB_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PPP_PCB_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PPP_PCB_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get CSP Records from PEX_P07_STUDY
        /// </summary>
        public static IEnumerable GetCSPRecords(this PEX_P07_STUDY message)
        {
            object[] result = message.GetRecords("CSPRepetitionsUsed", "GetCSP");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CSP Records from PEX_P07_STUDY
        /// </summary>
        public static List<CSP> GetAllCSPRecords(this PEX_P07_STUDY message)
        {
            return message.GetAllRecords<CSP>("CSPRepetitionsUsed", "GetCSP");
        }

        /// <summary>
        /// Add a new PEX_P07_STUDY to CSP
        /// </summary>
        public static CSP AddCSP(this PEX_P07_STUDY message)
        {
            return message.GetCSP(message.CSPRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORF_R04_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORF_R04_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORF_R04_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORF_R04_ORDER
        /// </summary>
        public static List<ORF_R04_OBSERVATION> GetAllOBSERVATIONRecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<ORF_R04_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new ORF_R04_ORDER to OBSERVATION
        /// </summary>
        public static ORF_R04_OBSERVATION AddOBSERVATION(this ORF_R04_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORF_R04_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORF_R04_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORF_R04_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORF_R04_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORF_R04_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORF_R04_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMN_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMN_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMN_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMN_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMN_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMN_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this DFT_P03_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from DFT_P03_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this DFT_P03_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new DFT_P03_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this DFT_P03_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A31_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A31_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A31_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A31_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A31_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A31_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADR_A19_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADR_A19_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADR_A19_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADR_A19_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADR_A19_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRE_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRE_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRE_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRE_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRE_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRE_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RPA_I08_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RPA_I08_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS Records from RPA_I08_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTSRecords(this RPA_I08_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTSRepetitionsUsed", "GetRESULTS");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS Records from RPA_I08_OBSERVATION
        /// </summary>
        public static List<RPA_I08_RESULTS> GetAllRESULTSRecords(this RPA_I08_OBSERVATION message)
        {
            return message.GetAllRecords<RPA_I08_RESULTS>("RESULTSRepetitionsUsed", "GetRESULTS");
        }

        /// <summary>
        /// Add a new RPA_I08_OBSERVATION to RESULTS
        /// </summary>
        public static RPA_I08_RESULTS AddRESULTS(this RPA_I08_OBSERVATION message)
        {
            return message.GetRESULTS(message.RESULTSRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDO_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDO_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDO_O01_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDO_O01_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDO_O01_COMPONENT to RXC
        /// </summary>
        public static RXC AddRXC(this RDO_O01_COMPONENT message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDO_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDO_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDO_O01_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDO_O01_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDO_O01_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDO_O01_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDE_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O01_ORDER_DETAIL
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER_DETAIL to RXR
        /// </summary>
        public static RXR AddRXR(this RDE_O01_ORDER_DETAIL message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RDE_O01_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RDE_O01_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RDE_O01_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RDE_O01_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RDE_O01_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDE_O01_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDE_O01_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDE_O01_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDE_O01_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RDE_O01_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RDE_O01_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RDE_O01_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RDE_O01_ORDER
        /// </summary>
        public static List<RDE_O01_OBSERVATION> GetAllOBSERVATIONRecords(this RDE_O01_ORDER message)
        {
            return message.GetAllRecords<RDE_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER to OBSERVATION
        /// </summary>
        public static RDE_O01_OBSERVATION AddOBSERVATION(this RDE_O01_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from RDE_O01_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RDE_O01_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RDE_O01_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RDE_O01_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new RDE_O01_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this RDE_O01_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_PROBLEM_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_PROBLEM_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_PROBLEM_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNK1Records(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT to NK1
        /// </summary>
        public static NK1 AddNK1(this ORU_R01_PATIENT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<ORU_R01_OBSERVATION> GetAllOBSERVATIONRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<ORU_R01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to OBSERVATION
        /// </summary>
        public static ORU_R01_OBSERVATION AddOBSERVATION(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORU_R01_ORDER_OBSERVATION
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORU_R01_ORDER_OBSERVATION to CTI
        /// </summary>
        public static CTI AddCTI(this ORU_R01_ORDER_OBSERVATION message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from ORM_O01_PATIENT
        /// </summary>
        public static List<ORM_O01_INSURANCE> GetAllINSURANCERecords(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<ORM_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new ORM_O01_PATIENT to INSURANCE
        /// </summary>
        public static ORM_O01_INSURANCE AddINSURANCE(this ORM_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this ORM_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from ORM_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this ORM_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new ORM_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this ORM_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from DFT_P03_FINANCIAL_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new DFT_P03_FINANCIAL_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this DFT_P03_FINANCIAL_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P01_VISIT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P01_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to OBX
        /// </summary>
        public static OBX AddOBX(this BAR_P01_VISIT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to AL1
        /// </summary>
        public static AL1 AddAL1(this BAR_P01_VISIT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P01_VISIT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P01_VISIT
        /// </summary>
        public static List<BAR_P01_PROCEDURE> GetAllPROCEDURERecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<BAR_P01_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to PROCEDURE
        /// </summary>
        public static BAR_P01_PROCEDURE AddPROCEDURE(this BAR_P01_VISIT message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to GT1
        /// </summary>
        public static GT1 AddGT1(this BAR_P01_VISIT message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P01_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to NK1
        /// </summary>
        public static NK1 AddNK1(this BAR_P01_VISIT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this BAR_P01_VISIT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from BAR_P01_VISIT
        /// </summary>
        public static List<BAR_P01_INSURANCE> GetAllINSURANCERecords(this BAR_P01_VISIT message)
        {
            return message.GetAllRecords<BAR_P01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new BAR_P01_VISIT to INSURANCE
        /// </summary>
        public static BAR_P01_INSURANCE AddINSURANCE(this BAR_P01_VISIT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A31_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A31_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A31_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A31_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A31_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A31_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A13_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A13_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A13_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A13_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A13_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A13_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this VXU_V04_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from VXU_V04_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this VXU_V04_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new VXU_V04_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this VXU_V04_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SRR_S01_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SRR_S01_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SRR_S01_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SRR_S01_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get SERVICE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_SERVICE> GetAllSERVICERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Add a new SRM_S01_RESOURCES to SERVICE
        /// </summary>
        public static SRM_S01_SERVICE AddSERVICE(this SRM_S01_RESOURCES message)
        {
            return message.GetSERVICE(message.SERVICERepetitionsUsed);
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Add a new SRM_S01_RESOURCES to GENERAL_RESOURCE
        /// </summary>
        public static SRM_S01_GENERAL_RESOURCE AddGENERAL_RESOURCE(this SRM_S01_RESOURCES message)
        {
            return message.GetGENERAL_RESOURCE(message.GENERAL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Add a new SRM_S01_RESOURCES to LOCATION_RESOURCE
        /// </summary>
        public static SRM_S01_LOCATION_RESOURCE AddLOCATION_RESOURCE(this SRM_S01_RESOURCES message)
        {
            return message.GetLOCATION_RESOURCE(message.LOCATION_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SRM_S01_RESOURCES
        /// </summary>
        public static List<SRM_S01_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SRM_S01_RESOURCES message)
        {
            return message.GetAllRecords<SRM_S01_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Add a new SRM_S01_RESOURCES to PERSONNEL_RESOURCE
        /// </summary>
        public static SRM_S01_PERSONNEL_RESOURCE AddPERSONNEL_RESOURCE(this SRM_S01_RESOURCES message)
        {
            return message.GetPERSONNEL_RESOURCE(message.PERSONNEL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_PERSONNEL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_PERSONNEL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_PERSONNEL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_GENERAL_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_GENERAL_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_GENERAL_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_GENERAL_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRI_I12_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RRI_I12_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static IEnumerable GetRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            object[] result = message.GetRecords("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RESULTS_NOTES Records from RRI_I12_OBSERVATION
        /// </summary>
        public static List<RRI_I12_RESULTS_NOTES> GetAllRESULTS_NOTESRecords(this RRI_I12_OBSERVATION message)
        {
            return message.GetAllRecords<RRI_I12_RESULTS_NOTES>("RESULTS_NOTESRepetitionsUsed", "GetRESULTS_NOTES");
        }

        /// <summary>
        /// Add a new RRI_I12_OBSERVATION to RESULTS_NOTES
        /// </summary>
        public static RRI_I12_RESULTS_NOTES AddRESULTS_NOTES(this RRI_I12_OBSERVATION message)
        {
            return message.GetRESULTS_NOTES(message.RESULTS_NOTESRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RRA_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RRA_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RRA_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RRA_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RRA_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RRA_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static IEnumerable GetNTERecords(this RPA_I08_RESULTS message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RPA_I08_RESULTS
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RPA_I08_RESULTS message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RPA_I08_RESULTS to NTE
        /// </summary>
        public static NTE AddNTE(this RPA_I08_RESULTS message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PROBLEM_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPR_PC1_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PPR_PC1_PROBLEM_ROLE AddPROBLEM_ROLE(this PPR_PC1_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PATHWAY> GetAllPATHWAYRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to PATHWAY
        /// </summary>
        public static PPR_PC1_PATHWAY AddPATHWAY(this PPR_PC1_PROBLEM message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY_OBSERVATION Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetPATHWAY_OBSERVATIONRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("PATHWAY_OBSERVATIONRepetitionsUsed", "GetPATHWAY_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_OBSERVATION Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_PATHWAY_OBSERVATION> GetAllPATHWAY_OBSERVATIONRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_PATHWAY_OBSERVATION>("PATHWAY_OBSERVATIONRepetitionsUsed", "GetPATHWAY_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to PATHWAY_OBSERVATION
        /// </summary>
        public static PPR_PC1_PATHWAY_OBSERVATION AddPATHWAY_OBSERVATION(this PPR_PC1_PROBLEM message)
        {
            return message.GetPATHWAY_OBSERVATION(message.PATHWAY_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_GOAL> GetAllGOALRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to GOAL
        /// </summary>
        public static PPR_PC1_GOAL AddGOAL(this PPR_PC1_PROBLEM message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PPR_PC1_PROBLEM
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPR_PC1_PROBLEM message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPR_PC1_PROBLEM
        /// </summary>
        public static List<PPR_PC1_ORDER> GetAllORDERRecords(this PPR_PC1_PROBLEM message)
        {
            return message.GetAllRecords<PPR_PC1_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PPR_PC1_PROBLEM to ORDER
        /// </summary>
        public static PPR_PC1_ORDER AddORDER(this PPR_PC1_PROBLEM message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<PGL_PC6_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PGL_PC6_PROBLEM_ROLE AddPROBLEM_ROLE(this PGL_PC6_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PGL_PC6_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PGL_PC6_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PGL_PC6_PROBLEM
        /// </summary>
        public static List<PGL_PC6_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PGL_PC6_PROBLEM message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PGL_PC6_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PGL_PC6_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PGL_PC6_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this ORR_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ORR_O02_RESPONSE
        /// </summary>
        public static List<ORR_O02_ORDER> GetAllORDERRecords(this ORR_O02_RESPONSE message)
        {
            return message.GetAllRecords<ORR_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ORR_O02_RESPONSE to ORDER
        /// </summary>
        public static ORR_O02_ORDER AddORDER(this ORR_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORR_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORR_O02_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORR_O02_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from ORR_O02_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this ORR_O02_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from ORR_O02_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this ORR_O02_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new ORR_O02_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this ORR_O02_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from OMS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this OMS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from OMS_O01_PATIENT
        /// </summary>
        public static List<OMS_O01_INSURANCE> GetAllINSURANCERecords(this OMS_O01_PATIENT message)
        {
            return message.GetAllRecords<OMS_O01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new OMS_O01_PATIENT to INSURANCE
        /// </summary>
        public static OMS_O01_INSURANCE AddINSURANCE(this OMS_O01_PATIENT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from OMS_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this OMS_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from OMS_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this OMS_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new OMS_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this OMS_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ADT_A14_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ADT_A14_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ADT_A14_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ADT_A14_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ADT_A14_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ADT_A14_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADR_A19_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADR_A19_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADR_A19_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADR_A19_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADR_A19_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static IEnumerable GetDG1Records(this SRR_S01_PATIENT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from SRR_S01_PATIENT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this SRR_S01_PATIENT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new SRR_S01_PATIENT to DG1
        /// </summary>
        public static DG1 AddDG1(this SRR_S01_PATIENT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SQR_S25_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SQR_S25_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SQR_S25_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SQR_S25_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SQR_S25_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_LOCATION_RESOURCE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_LOCATION_RESOURCE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_LOCATION_RESOURCE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_LOCATION_RESOURCE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RRG_O02_GIVE
        /// </summary>
        public static IEnumerable GetRXRRecords(this RRG_O02_GIVE message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RRG_O02_GIVE
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RRG_O02_GIVE message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RRG_O02_GIVE to RXR
        /// </summary>
        public static RXR AddRXR(this RRG_O02_GIVE message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RRG_O02_GIVE
        /// </summary>
        public static IEnumerable GetRXCRecords(this RRG_O02_GIVE message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RRG_O02_GIVE
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RRG_O02_GIVE message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RRG_O02_GIVE to RXC
        /// </summary>
        public static RXC AddRXC(this RRG_O02_GIVE message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RPR_I03_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RPR_I03_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RPR_I03_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RPR_I03_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RPR_I03_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<GT1> GetAllGT1Records(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new RPI_I01_GUARANTOR_INSURANCE to GT1
        /// </summary>
        public static GT1 AddGT1(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from RPI_I01_GUARANTOR_INSURANCE
        /// </summary>
        public static List<RPI_I01_INSURANCE> GetAllINSURANCERecords(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetAllRecords<RPI_I01_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new RPI_I01_GUARANTOR_INSURANCE to INSURANCE
        /// </summary>
        public static RPI_I01_INSURANCE AddINSURANCE(this RPI_I01_GUARANTOR_INSURANCE message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from ROR_R0R_DEFINITION
        /// </summary>
        public static IEnumerable GetORDERRecords(this ROR_R0R_DEFINITION message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from ROR_R0R_DEFINITION
        /// </summary>
        public static List<ROR_R0R_ORDER> GetAllORDERRecords(this ROR_R0R_DEFINITION message)
        {
            return message.GetAllRecords<ROR_R0R_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new ROR_R0R_DEFINITION to ORDER
        /// </summary>
        public static ROR_R0R_ORDER AddORDER(this ROR_R0R_DEFINITION message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXGRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXGRepetitionsUsed", "GetRXG");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXG Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXG> GetAllRXGRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXG>("RXGRepetitionsUsed", "GetRXG");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXG
        /// </summary>
        public static RXG AddRXG(this RGR_RGR_ORDER message)
        {
            return message.GetRXG(message.RXGRepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXRRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXR
        /// </summary>
        public static RXR AddRXR(this RGR_RGR_ORDER message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static IEnumerable GetRXCRecords(this RGR_RGR_ORDER message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RGR_RGR_ORDER
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RGR_RGR_ORDER message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RGR_RGR_ORDER to RXC
        /// </summary>
        public static RXC AddRXC(this RGR_RGR_ORDER message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RAS_O01_ORDER
        /// </summary>
        public static IEnumerable GetRXARecords(this RAS_O01_ORDER message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAS_O01_ORDER
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAS_O01_ORDER message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RAS_O01_ORDER to RXA
        /// </summary>
        public static RXA AddRXA(this RAS_O01_ORDER message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from RAS_O01_ORDER
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this RAS_O01_ORDER message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from RAS_O01_ORDER
        /// </summary>
        public static List<RAS_O01_OBSERVATION> GetAllOBSERVATIONRecords(this RAS_O01_ORDER message)
        {
            return message.GetAllRecords<RAS_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new RAS_O01_ORDER to OBSERVATION
        /// </summary>
        public static RAS_O01_OBSERVATION AddOBSERVATION(this RAS_O01_ORDER message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get CTI Records from RAS_O01_ORDER
        /// </summary>
        public static IEnumerable GetCTIRecords(this RAS_O01_ORDER message)
        {
            object[] result = message.GetRecords("CTIRepetitionsUsed", "GetCTI");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTI Records from RAS_O01_ORDER
        /// </summary>
        public static List<CTI> GetAllCTIRecords(this RAS_O01_ORDER message)
        {
            return message.GetAllRecords<CTI>("CTIRepetitionsUsed", "GetCTI");
        }

        /// <summary>
        /// Add a new RAS_O01_ORDER to CTI
        /// </summary>
        public static CTI AddCTI(this RAS_O01_ORDER message)
        {
            return message.GetCTI(message.CTIRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAS_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this RAS_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAS_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAS_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAS_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this RAS_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static IEnumerable GetRXARecords(this RAR_RAR_ORDER message)
        {
            object[] result = message.GetRecords("RXARepetitionsUsed", "GetRXA");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXA Records from RAR_RAR_ORDER
        /// </summary>
        public static List<RXA> GetAllRXARecords(this RAR_RAR_ORDER message)
        {
            return message.GetAllRecords<RXA>("RXARepetitionsUsed", "GetRXA");
        }

        /// <summary>
        /// Add a new RAR_RAR_ORDER to RXA
        /// </summary>
        public static RXA AddRXA(this RAR_RAR_ORDER message)
        {
            return message.GetRXA(message.RXARepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPV_PCA_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPV_PCA_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPV_PCA_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPV_PCA_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to GOAL_ROLE
        /// </summary>
        public static PPV_PCA_GOAL_ROLE AddGOAL_ROLE(this PPV_PCA_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_PATHWAY Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_PATHWAYRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_PATHWAYRepetitionsUsed", "GetGOAL_PATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_PATHWAY Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_PATHWAY> GetAllGOAL_PATHWAYRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_PATHWAY>("GOAL_PATHWAYRepetitionsUsed", "GetGOAL_PATHWAY");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to GOAL_PATHWAY
        /// </summary>
        public static PPV_PCA_GOAL_PATHWAY AddGOAL_PATHWAY(this PPV_PCA_GOAL message)
        {
            return message.GetGOAL_PATHWAY(message.GOAL_PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PPV_PCA_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PPV_PCA_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_PROBLEM> GetAllPROBLEMRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to PROBLEM
        /// </summary>
        public static PPV_PCA_PROBLEM AddPROBLEM(this PPV_PCA_GOAL message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PPV_PCA_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPV_PCA_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPV_PCA_GOAL
        /// </summary>
        public static List<PPV_PCA_ORDER> GetAllORDERRecords(this PPV_PCA_GOAL message)
        {
            return message.GetAllRecords<PPV_PCA_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PPV_PCA_GOAL to ORDER
        /// </summary>
        public static PPV_PCA_ORDER AddORDER(this PPV_PCA_GOAL message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PATHWAY message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PATHWAY message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY_ROLE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetPATHWAY_ROLERecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY_ROLE Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<PPT_PCL_PATHWAY_ROLE> GetAllPATHWAY_ROLERecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<PPT_PCL_PATHWAY_ROLE>("PATHWAY_ROLERepetitionsUsed", "GetPATHWAY_ROLE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to PATHWAY_ROLE
        /// </summary>
        public static PPT_PCL_PATHWAY_ROLE AddPATHWAY_ROLE(this PPT_PCL_PATHWAY message)
        {
            return message.GetPATHWAY_ROLE(message.PATHWAY_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL Records from PPT_PCL_PATHWAY
        /// </summary>
        public static IEnumerable GetGOALRecords(this PPT_PCL_PATHWAY message)
        {
            object[] result = message.GetRecords("GOALRepetitionsUsed", "GetGOAL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL Records from PPT_PCL_PATHWAY
        /// </summary>
        public static List<PPT_PCL_GOAL> GetAllGOALRecords(this PPT_PCL_PATHWAY message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL>("GOALRepetitionsUsed", "GetGOAL");
        }

        /// <summary>
        /// Add a new PPT_PCL_PATHWAY to GOAL
        /// </summary>
        public static PPT_PCL_GOAL AddGOAL(this PPT_PCL_PATHWAY message)
        {
            return message.GetGOAL(message.GOALRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPR_PC1_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPR_PC1_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPR_PC1_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPR_PC1_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PGL_PC6_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PGL_PC6_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PGL_PC6_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PGL_PC6_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_GOAL_ROLE> GetAllGOAL_ROLERecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to GOAL_ROLE
        /// </summary>
        public static PGL_PC6_GOAL_ROLE AddGOAL_ROLE(this PGL_PC6_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PATHWAY Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetPATHWAYRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("PATHWAYRepetitionsUsed", "GetPATHWAY");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PATHWAY Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_PATHWAY> GetAllPATHWAYRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_PATHWAY>("PATHWAYRepetitionsUsed", "GetPATHWAY");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to PATHWAY
        /// </summary>
        public static PGL_PC6_PATHWAY AddPATHWAY(this PGL_PC6_GOAL message)
        {
            return message.GetPATHWAY(message.PATHWAYRepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_OBSERVATION> GetAllOBSERVATIONRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to OBSERVATION
        /// </summary>
        public static PGL_PC6_OBSERVATION AddOBSERVATION(this PGL_PC6_GOAL message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_PROBLEM> GetAllPROBLEMRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to PROBLEM
        /// </summary>
        public static PGL_PC6_PROBLEM AddPROBLEM(this PGL_PC6_GOAL message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PGL_PC6_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PGL_PC6_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PGL_PC6_GOAL
        /// </summary>
        public static List<PGL_PC6_ORDER> GetAllORDERRecords(this PGL_PC6_GOAL message)
        {
            return message.GetAllRecords<PGL_PC6_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PGL_PC6_GOAL to ORDER
        /// </summary>
        public static PGL_PC6_ORDER AddORDER(this PGL_PC6_GOAL message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORS_O02_ORDER
        /// </summary>
        public static IEnumerable GetNTERecords(this ORS_O02_ORDER message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORS_O02_ORDER
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORS_O02_ORDER message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORS_O02_ORDER to NTE
        /// </summary>
        public static NTE AddNTE(this ORS_O02_ORDER message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get IN3 Records from ORM_O01_INSURANCE
        /// </summary>
        public static IEnumerable GetIN3Records(this ORM_O01_INSURANCE message)
        {
            object[] result = message.GetRecords("IN3RepetitionsUsed", "GetIN3");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all IN3 Records from ORM_O01_INSURANCE
        /// </summary>
        public static List<IN3> GetAllIN3Records(this ORM_O01_INSURANCE message)
        {
            return message.GetAllRecords<IN3>("IN3RepetitionsUsed", "GetIN3");
        }

        /// <summary>
        /// Add a new ORM_O01_INSURANCE to IN3
        /// </summary>
        public static IN3 AddIN3(this ORM_O01_INSURANCE message)
        {
            return message.GetIN3(message.IN3RepetitionsUsed);
        }

        /// <summary>
        /// Get PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static IEnumerable GetPRCRecords(this MFN_M04_MF_CDM message)
        {
            object[] result = message.GetRecords("PRCRepetitionsUsed", "GetPRC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PRC Records from MFN_M04_MF_CDM
        /// </summary>
        public static List<PRC> GetAllPRCRecords(this MFN_M04_MF_CDM message)
        {
            return message.GetAllRecords<PRC>("PRCRepetitionsUsed", "GetPRC");
        }

        /// <summary>
        /// Add a new MFN_M04_MF_CDM to PRC
        /// </summary>
        public static PRC AddPRC(this MFN_M04_MF_CDM message)
        {
            return message.GetPRC(message.PRCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new CSU_C09_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this CSU_C09_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static IEnumerable GetSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            object[] result = message.GetRecords("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_PHASE Records from CSU_C09_PATIENT
        /// </summary>
        public static List<CSU_C09_STUDY_PHASE> GetAllSTUDY_PHASERecords(this CSU_C09_PATIENT message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_PHASE>("STUDY_PHASERepetitionsUsed", "GetSTUDY_PHASE");
        }

        /// <summary>
        /// Add a new CSU_C09_PATIENT to STUDY_PHASE
        /// </summary>
        public static CSU_C09_STUDY_PHASE AddSTUDY_PHASE(this CSU_C09_PATIENT message)
        {
            return message.GetSTUDY_PHASE(message.STUDY_PHASERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A13_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A13_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A13_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A13_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A13_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A13_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get SERVICE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetSERVICERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("SERVICERepetitionsUsed", "GetSERVICE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all SERVICE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_SERVICE> GetAllSERVICERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_SERVICE>("SERVICERepetitionsUsed", "GetSERVICE");
        }

        /// <summary>
        /// Add a new SQR_S25_RESOURCES to SERVICE
        /// </summary>
        public static SQR_S25_SERVICE AddSERVICE(this SQR_S25_RESOURCES message)
        {
            return message.GetSERVICE(message.SERVICERepetitionsUsed);
        }

        /// <summary>
        /// Get GENERAL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetGENERAL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GENERAL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_GENERAL_RESOURCE> GetAllGENERAL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_GENERAL_RESOURCE>("GENERAL_RESOURCERepetitionsUsed", "GetGENERAL_RESOURCE");
        }

        /// <summary>
        /// Add a new SQR_S25_RESOURCES to GENERAL_RESOURCE
        /// </summary>
        public static SQR_S25_GENERAL_RESOURCE AddGENERAL_RESOURCE(this SQR_S25_RESOURCES message)
        {
            return message.GetGENERAL_RESOURCE(message.GENERAL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get PERSONNEL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetPERSONNEL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PERSONNEL_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_PERSONNEL_RESOURCE> GetAllPERSONNEL_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_PERSONNEL_RESOURCE>("PERSONNEL_RESOURCERepetitionsUsed", "GetPERSONNEL_RESOURCE");
        }

        /// <summary>
        /// Add a new SQR_S25_RESOURCES to PERSONNEL_RESOURCE
        /// </summary>
        public static SQR_S25_PERSONNEL_RESOURCE AddPERSONNEL_RESOURCE(this SQR_S25_RESOURCES message)
        {
            return message.GetPERSONNEL_RESOURCE(message.PERSONNEL_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get LOCATION_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static IEnumerable GetLOCATION_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            object[] result = message.GetRecords("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all LOCATION_RESOURCE Records from SQR_S25_RESOURCES
        /// </summary>
        public static List<SQR_S25_LOCATION_RESOURCE> GetAllLOCATION_RESOURCERecords(this SQR_S25_RESOURCES message)
        {
            return message.GetAllRecords<SQR_S25_LOCATION_RESOURCE>("LOCATION_RESOURCERepetitionsUsed", "GetLOCATION_RESOURCE");
        }

        /// <summary>
        /// Add a new SQR_S25_RESOURCES to LOCATION_RESOURCE
        /// </summary>
        public static SQR_S25_LOCATION_RESOURCE AddLOCATION_RESOURCE(this SQR_S25_RESOURCES message)
        {
            return message.GetLOCATION_RESOURCE(message.LOCATION_RESOURCERepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from RRE_O02_RESPONSE
        /// </summary>
        public static IEnumerable GetORDERRecords(this RRE_O02_RESPONSE message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from RRE_O02_RESPONSE
        /// </summary>
        public static List<RRE_O02_ORDER> GetAllORDERRecords(this RRE_O02_RESPONSE message)
        {
            return message.GetAllRecords<RRE_O02_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new RRE_O02_RESPONSE to ORDER
        /// </summary>
        public static RRE_O02_ORDER AddORDER(this RRE_O02_RESPONSE message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RDE_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetRXCRecords(this RDE_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RDE_O01_COMPONENT
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RDE_O01_COMPONENT message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RDE_O01_COMPONENT to RXC
        /// </summary>
        public static RXC AddRXC(this RDE_O01_COMPONENT message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDE_O01_COMPONENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDE_O01_COMPONENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDE_O01_COMPONENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDE_O01_COMPONENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDE_O01_COMPONENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDE_O01_COMPONENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXRRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXRRepetitionsUsed", "GetRXR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXR Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXR> GetAllRXRRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXR>("RXRRepetitionsUsed", "GetRXR");
        }

        /// <summary>
        /// Add a new RAR_RAR_ENCODING to RXR
        /// </summary>
        public static RXR AddRXR(this RAR_RAR_ENCODING message)
        {
            return message.GetRXR(message.RXRRepetitionsUsed);
        }

        /// <summary>
        /// Get RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static IEnumerable GetRXCRecords(this RAR_RAR_ENCODING message)
        {
            object[] result = message.GetRecords("RXCRepetitionsUsed", "GetRXC");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all RXC Records from RAR_RAR_ENCODING
        /// </summary>
        public static List<RXC> GetAllRXCRecords(this RAR_RAR_ENCODING message)
        {
            return message.GetAllRecords<RXC>("RXCRepetitionsUsed", "GetRXC");
        }

        /// <summary>
        /// Add a new RAR_RAR_ENCODING to RXC
        /// </summary>
        public static RXC AddRXC(this RAR_RAR_ENCODING message)
        {
            return message.GetRXC(message.RXCRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_GOAL_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_GOAL_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_GOAL_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_GOAL_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPG_PCG_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPG_PCG_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPG_PCG_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPG_PCG_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<DG1> GetAllDG1Records(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER_DETAIL to DG1
        /// </summary>
        public static DG1 AddDG1(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBSERVATION Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetOBSERVATIONRecords(this ORM_O01_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBSERVATION Records from ORM_O01_ORDER_DETAIL
        /// </summary>
        public static List<ORM_O01_OBSERVATION> GetAllOBSERVATIONRecords(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetAllRecords<ORM_O01_OBSERVATION>("OBSERVATIONRepetitionsUsed", "GetOBSERVATION");
        }

        /// <summary>
        /// Add a new ORM_O01_ORDER_DETAIL to OBSERVATION
        /// </summary>
        public static ORM_O01_OBSERVATION AddOBSERVATION(this ORM_O01_ORDER_DETAIL message)
        {
            return message.GetOBSERVATION(message.OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static IEnumerable GetSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            object[] result = message.GetRecords("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all STUDY_SCHEDULE Records from CSU_C09_STUDY_PHASE
        /// </summary>
        public static List<CSU_C09_STUDY_SCHEDULE> GetAllSTUDY_SCHEDULERecords(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetAllRecords<CSU_C09_STUDY_SCHEDULE>("STUDY_SCHEDULERepetitionsUsed", "GetSTUDY_SCHEDULE");
        }

        /// <summary>
        /// Add a new CSU_C09_STUDY_PHASE to STUDY_SCHEDULE
        /// </summary>
        public static CSU_C09_STUDY_SCHEDULE AddSTUDY_SCHEDULE(this CSU_C09_STUDY_PHASE message)
        {
            return message.GetSTUDY_SCHEDULE(message.STUDY_SCHEDULERepetitionsUsed);
        }

        /// <summary>
        /// Get DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDB1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DB1RepetitionsUsed", "GetDB1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DB1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DB1> GetAllDB1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DB1>("DB1RepetitionsUsed", "GetDB1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to DB1
        /// </summary>
        public static DB1 AddDB1(this BAR_P05_VISIT message)
        {
            return message.GetDB1(message.DB1RepetitionsUsed);
        }

        /// <summary>
        /// Get OBX Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetOBXRecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("OBXRepetitionsUsed", "GetOBX");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OBX Records from BAR_P05_VISIT
        /// </summary>
        public static List<OBX> GetAllOBXRecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<OBX>("OBXRepetitionsUsed", "GetOBX");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to OBX
        /// </summary>
        public static OBX AddOBX(this BAR_P05_VISIT message)
        {
            return message.GetOBX(message.OBXRepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetAL1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to AL1
        /// </summary>
        public static AL1 AddAL1(this BAR_P05_VISIT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetDG1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("DG1RepetitionsUsed", "GetDG1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all DG1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<DG1> GetAllDG1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<DG1>("DG1RepetitionsUsed", "GetDG1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to DG1
        /// </summary>
        public static DG1 AddDG1(this BAR_P05_VISIT message)
        {
            return message.GetDG1(message.DG1RepetitionsUsed);
        }

        /// <summary>
        /// Get PROCEDURE Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetPROCEDURERecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("PROCEDURERepetitionsUsed", "GetPROCEDURE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROCEDURE Records from BAR_P05_VISIT
        /// </summary>
        public static List<BAR_P05_PROCEDURE> GetAllPROCEDURERecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BAR_P05_PROCEDURE>("PROCEDURERepetitionsUsed", "GetPROCEDURE");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to PROCEDURE
        /// </summary>
        public static BAR_P05_PROCEDURE AddPROCEDURE(this BAR_P05_VISIT message)
        {
            return message.GetPROCEDURE(message.PROCEDURERepetitionsUsed);
        }

        /// <summary>
        /// Get GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetGT1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("GT1RepetitionsUsed", "GetGT1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GT1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<GT1> GetAllGT1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<GT1>("GT1RepetitionsUsed", "GetGT1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to GT1
        /// </summary>
        public static GT1 AddGT1(this BAR_P05_VISIT message)
        {
            return message.GetGT1(message.GT1RepetitionsUsed);
        }

        /// <summary>
        /// Get NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetNK1Records(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("NK1RepetitionsUsed", "GetNK1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NK1 Records from BAR_P05_VISIT
        /// </summary>
        public static List<NK1> GetAllNK1Records(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<NK1>("NK1RepetitionsUsed", "GetNK1");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to NK1
        /// </summary>
        public static NK1 AddNK1(this BAR_P05_VISIT message)
        {
            return message.GetNK1(message.NK1RepetitionsUsed);
        }

        /// <summary>
        /// Get INSURANCE Records from BAR_P05_VISIT
        /// </summary>
        public static IEnumerable GetINSURANCERecords(this BAR_P05_VISIT message)
        {
            object[] result = message.GetRecords("INSURANCERepetitionsUsed", "GetINSURANCE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all INSURANCE Records from BAR_P05_VISIT
        /// </summary>
        public static List<BAR_P05_INSURANCE> GetAllINSURANCERecords(this BAR_P05_VISIT message)
        {
            return message.GetAllRecords<BAR_P05_INSURANCE>("INSURANCERepetitionsUsed", "GetINSURANCE");
        }

        /// <summary>
        /// Add a new BAR_P05_VISIT to INSURANCE
        /// </summary>
        public static BAR_P05_INSURANCE AddINSURANCE(this BAR_P05_VISIT message)
        {
            return message.GetINSURANCE(message.INSURANCERepetitionsUsed);
        }

        /// <summary>
        /// Get ROL Records from ADT_A14_PROCEDURE
        /// </summary>
        public static IEnumerable GetROLRecords(this ADT_A14_PROCEDURE message)
        {
            object[] result = message.GetRecords("ROLRepetitionsUsed", "GetROL");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ROL Records from ADT_A14_PROCEDURE
        /// </summary>
        public static List<ROL> GetAllROLRecords(this ADT_A14_PROCEDURE message)
        {
            return message.GetAllRecords<ROL>("ROLRepetitionsUsed", "GetROL");
        }

        /// <summary>
        /// Add a new ADT_A14_PROCEDURE to ROL
        /// </summary>
        public static ROL AddROL(this ADT_A14_PROCEDURE message)
        {
            return message.GetROL(message.ROLRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static IEnumerable GetNTERecords(this SIU_S12_SERVICE message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from SIU_S12_SERVICE
        /// </summary>
        public static List<NTE> GetAllNTERecords(this SIU_S12_SERVICE message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new SIU_S12_SERVICE to NTE
        /// </summary>
        public static NTE AddNTE(this SIU_S12_SERVICE message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQI_I03_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQI_I03_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQI_I03_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQI_I03_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQI_I03_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQI_I03_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get CTD Records from RQC_I06_PROVIDER
        /// </summary>
        public static IEnumerable GetCTDRecords(this RQC_I06_PROVIDER message)
        {
            object[] result = message.GetRecords("CTDRepetitionsUsed", "GetCTD");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all CTD Records from RQC_I06_PROVIDER
        /// </summary>
        public static List<CTD> GetAllCTDRecords(this RQC_I06_PROVIDER message)
        {
            return message.GetAllRecords<CTD>("CTDRepetitionsUsed", "GetCTD");
        }

        /// <summary>
        /// Add a new RQC_I06_PROVIDER to CTD
        /// </summary>
        public static CTD AddCTD(this RQC_I06_PROVIDER message)
        {
            return message.GetCTD(message.CTDRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ROR_R0R_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ROR_R0R_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ROR_R0R_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ROR_R0R_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ROR_R0R_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ROR_R0R_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RGV_O01_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RGV_O01_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RGV_O01_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RGV_O01_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RGV_O01_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RGV_O01_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get AL1 Records from RGV_O01_PATIENT
        /// </summary>
        public static IEnumerable GetAL1Records(this RGV_O01_PATIENT message)
        {
            object[] result = message.GetRecords("AL1RepetitionsUsed", "GetAL1");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all AL1 Records from RGV_O01_PATIENT
        /// </summary>
        public static List<AL1> GetAllAL1Records(this RGV_O01_PATIENT message)
        {
            return message.GetAllRecords<AL1>("AL1RepetitionsUsed", "GetAL1");
        }

        /// <summary>
        /// Add a new RGV_O01_PATIENT to AL1
        /// </summary>
        public static AL1 AddAL1(this RGV_O01_PATIENT message)
        {
            return message.GetAL1(message.AL1RepetitionsUsed);
        }

        /// <summary>
        /// Get GIVE Records from RGV_O01_ORDER
        /// </summary>
        public static IEnumerable GetGIVERecords(this RGV_O01_ORDER message)
        {
            object[] result = message.GetRecords("GIVERepetitionsUsed", "GetGIVE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GIVE Records from RGV_O01_ORDER
        /// </summary>
        public static List<RGV_O01_GIVE> GetAllGIVERecords(this RGV_O01_ORDER message)
        {
            return message.GetAllRecords<RGV_O01_GIVE>("GIVERepetitionsUsed", "GetGIVE");
        }

        /// <summary>
        /// Add a new RGV_O01_ORDER to GIVE
        /// </summary>
        public static RGV_O01_GIVE AddGIVE(this RGV_O01_ORDER message)
        {
            return message.GetGIVE(message.GIVERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RER_RER_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RER_RER_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RER_RER_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RER_RER_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RER_RER_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RER_RER_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RDR_RDR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RDR_RDR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RDR_RDR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RDR_RDR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RDR_RDR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RDR_RDR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this RAR_RAR_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from RAR_RAR_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this RAR_RAR_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new RAR_RAR_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this RAR_RAR_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static IEnumerable GetVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PTR_PCF_ORDER_OBSERVATION
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PTR_PCF_ORDER_OBSERVATION to VAR
        /// </summary>
        public static VAR AddVAR(this PTR_PCF_ORDER_OBSERVATION message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_DETAIL to NTE
        /// </summary>
        public static NTE AddNTE(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_DETAIL to VAR
        /// </summary>
        public static VAR AddVAR(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER_OBSERVATION Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static IEnumerable GetORDER_OBSERVATIONRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            object[] result = message.GetRecords("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER_OBSERVATION Records from PRR_PC5_ORDER_DETAIL
        /// </summary>
        public static List<PRR_PC5_ORDER_OBSERVATION> GetAllORDER_OBSERVATIONRecords(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetAllRecords<PRR_PC5_ORDER_OBSERVATION>("ORDER_OBSERVATIONRepetitionsUsed", "GetORDER_OBSERVATION");
        }

        /// <summary>
        /// Add a new PRR_PC5_ORDER_DETAIL to ORDER_OBSERVATION
        /// </summary>
        public static PRR_PC5_ORDER_OBSERVATION AddORDER_OBSERVATION(this PRR_PC5_ORDER_DETAIL message)
        {
            return message.GetORDER_OBSERVATION(message.ORDER_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM_ROLE
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM_ROLE message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM_ROLE to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PROBLEM_ROLE message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_PROBLEM message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_PROBLEM message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_ROLE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_ROLERecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_ROLE Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<PPT_PCL_PROBLEM_ROLE> GetAllPROBLEM_ROLERecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM_ROLE>("PROBLEM_ROLERepetitionsUsed", "GetPROBLEM_ROLE");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to PROBLEM_ROLE
        /// </summary>
        public static PPT_PCL_PROBLEM_ROLE AddPROBLEM_ROLE(this PPT_PCL_PROBLEM message)
        {
            return message.GetPROBLEM_ROLE(message.PROBLEM_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM_OBSERVATION Records from PPT_PCL_PROBLEM
        /// </summary>
        public static IEnumerable GetPROBLEM_OBSERVATIONRecords(this PPT_PCL_PROBLEM message)
        {
            object[] result = message.GetRecords("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM_OBSERVATION Records from PPT_PCL_PROBLEM
        /// </summary>
        public static List<PPT_PCL_PROBLEM_OBSERVATION> GetAllPROBLEM_OBSERVATIONRecords(this PPT_PCL_PROBLEM message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM_OBSERVATION>("PROBLEM_OBSERVATIONRepetitionsUsed", "GetPROBLEM_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPT_PCL_PROBLEM to PROBLEM_OBSERVATION
        /// </summary>
        public static PPT_PCL_PROBLEM_OBSERVATION AddPROBLEM_OBSERVATION(this PPT_PCL_PROBLEM message)
        {
            return message.GetPROBLEM_OBSERVATION(message.PROBLEM_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetNTERecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from PPT_PCL_GOAL
        /// </summary>
        public static List<NTE> GetAllNTERecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to NTE
        /// </summary>
        public static NTE AddNTE(this PPT_PCL_GOAL message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetVARRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("VARRepetitionsUsed", "GetVAR");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all VAR Records from PPT_PCL_GOAL
        /// </summary>
        public static List<VAR> GetAllVARRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<VAR>("VARRepetitionsUsed", "GetVAR");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to VAR
        /// </summary>
        public static VAR AddVAR(this PPT_PCL_GOAL message)
        {
            return message.GetVAR(message.VARRepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_ROLE Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_ROLERecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_ROLE Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_GOAL_ROLE> GetAllGOAL_ROLERecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL_ROLE>("GOAL_ROLERepetitionsUsed", "GetGOAL_ROLE");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to GOAL_ROLE
        /// </summary>
        public static PPT_PCL_GOAL_ROLE AddGOAL_ROLE(this PPT_PCL_GOAL message)
        {
            return message.GetGOAL_ROLE(message.GOAL_ROLERepetitionsUsed);
        }

        /// <summary>
        /// Get GOAL_OBSERVATION Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetGOAL_OBSERVATIONRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all GOAL_OBSERVATION Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_GOAL_OBSERVATION> GetAllGOAL_OBSERVATIONRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_GOAL_OBSERVATION>("GOAL_OBSERVATIONRepetitionsUsed", "GetGOAL_OBSERVATION");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to GOAL_OBSERVATION
        /// </summary>
        public static PPT_PCL_GOAL_OBSERVATION AddGOAL_OBSERVATION(this PPT_PCL_GOAL message)
        {
            return message.GetGOAL_OBSERVATION(message.GOAL_OBSERVATIONRepetitionsUsed);
        }

        /// <summary>
        /// Get PROBLEM Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetPROBLEMRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("PROBLEMRepetitionsUsed", "GetPROBLEM");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all PROBLEM Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_PROBLEM> GetAllPROBLEMRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_PROBLEM>("PROBLEMRepetitionsUsed", "GetPROBLEM");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to PROBLEM
        /// </summary>
        public static PPT_PCL_PROBLEM AddPROBLEM(this PPT_PCL_GOAL message)
        {
            return message.GetPROBLEM(message.PROBLEMRepetitionsUsed);
        }

        /// <summary>
        /// Get ORDER Records from PPT_PCL_GOAL
        /// </summary>
        public static IEnumerable GetORDERRecords(this PPT_PCL_GOAL message)
        {
            object[] result = message.GetRecords("ORDERRepetitionsUsed", "GetORDER");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all ORDER Records from PPT_PCL_GOAL
        /// </summary>
        public static List<PPT_PCL_ORDER> GetAllORDERRecords(this PPT_PCL_GOAL message)
        {
            return message.GetAllRecords<PPT_PCL_ORDER>("ORDERRepetitionsUsed", "GetORDER");
        }

        /// <summary>
        /// Add a new PPT_PCL_GOAL to ORDER
        /// </summary>
        public static PPT_PCL_ORDER AddORDER(this PPT_PCL_GOAL message)
        {
            return message.GetORDER(message.ORDERRepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from ORD_O02_PATIENT
        /// </summary>
        public static IEnumerable GetNTERecords(this ORD_O02_PATIENT message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from ORD_O02_PATIENT
        /// </summary>
        public static List<NTE> GetAllNTERecords(this ORD_O02_PATIENT message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new ORD_O02_PATIENT to NTE
        /// </summary>
        public static NTE AddNTE(this ORD_O02_PATIENT message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get NTE Records from OMS_O01_OBSERVATION
        /// </summary>
        public static IEnumerable GetNTERecords(this OMS_O01_OBSERVATION message)
        {
            object[] result = message.GetRecords("NTERepetitionsUsed", "GetNTE");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all NTE Records from OMS_O01_OBSERVATION
        /// </summary>
        public static List<NTE> GetAllNTERecords(this OMS_O01_OBSERVATION message)
        {
            return message.GetAllRecords<NTE>("NTERepetitionsUsed", "GetNTE");
        }

        /// <summary>
        /// Add a new OMS_O01_OBSERVATION to NTE
        /// </summary>
        public static NTE AddNTE(this OMS_O01_OBSERVATION message)
        {
            return message.GetNTE(message.NTERepetitionsUsed);
        }

        /// <summary>
        /// Get OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static IEnumerable GetOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            object[] result = message.GetRecords("OM4RepetitionsUsed", "GetOM4");

            if ((result != null) && (result.Count() > 0))
            {
                for (int i = 0; i < result.Count(); i++)
                    yield return result[i];
            }
        }

        /// <summary>
        /// Get all OM4 Records from MFN_M10_MF_TEST_BATT_DETAIL
        /// </summary>
        public static List<OM4> GetAllOM4Records(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            return message.GetAllRecords<OM4>("OM4RepetitionsUsed", "GetOM4");
        }

        /// <summary>
        /// Add a new MFN_M10_MF_TEST_BATT_DETAIL to OM4
        /// </summary>
        public static OM4 AddOM4(this MFN_M10_MF_TEST_BATT_DETAIL message)
        {
            return message.GetOM4(message.OM4RepetitionsUsed);
        }
        #endregion
    }
}
