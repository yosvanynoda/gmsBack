using Dapper;
using GMS.DBModels.Helper;
using System.Data;

namespace GMS.Data.DataHelper
{
    public interface IDataHelper
    {
        #region Base...
        Task<IEnumerable<T>?> QueryStoreProcedure<T>(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0);

        Task<BaseResult> ExecuteStoreProcedureWithResult(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0);

        Task<int> ExecuteStoreProcedure(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0);

        Task<QueryMultipleResponse?> QueryMultipleStoreProcedure(string cn, string storeProcedureName, DynamicParameters parameters, int timeout = 0);
        #endregion

        #region From Db...

        #region Company CMN...

        Task<BaseResult> CMN_CreateCompany(string cn, int companyId, string companyName, int username, int action);

        Task<BaseResult> CMN_CreateDocType(string cn, int docTypeId, string docType, string comment, int applyFor, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateRoleType(string cn, int roleTypeId, string roleType, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateDisease(string cn, int diseaseId, string diseaseName, int companyId, int username, int action, string diseaseCode);

        Task<BaseResult> CMN_CreateSponsorType(string cn, int id, string sponsorType, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateSite(string cn, int siteId, string siteName, string address, string contact, string phone, string email, string code, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateTaskType(string cn, int taskTypeId, string taskType, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateTask(string cn, int taskId, string taskName, int taskTypeId, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateStaff(string cn, int staffId, string firstName, string lastName, string phone, string email, string role, string department,
                                                     int companyId, int site, string status, int username, int action);
        Task<BaseResult> CMN_CreateAllergy(string cn, int id, string allergy, string? comment, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateLanguage(string cn, int id, string language, string comment, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateMedication(string cn, int medicationId, string medicationName, string medicationDose, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateRelationType(string cn, int id, string relationType, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateStaffDocument(string cn, DataTable cmnStaffDocUDT, int staffId);

        Task<PayloadResult?> CMN_GetDocTypeList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetRelationTypeList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetDiseaseList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetAllergyList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetMedicationList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetRoleTypeList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetSiteList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetTaskTypeList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetTaskList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetStaffList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetStaffStudio(string cn, int companyId, int siteId, int? staffId, int? studioId);

        Task<PayloadResult?> CMN_GetSponsorTypeList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetRaceList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetGenderList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetEthnicityList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetLanguageList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetStaffDocumentList(string cn, int companyId, int staffId);

        Task<BaseResult> CMN_CreateEthnicity(string cn, int id, string ethnicity, string comment, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateGender(string cn, int id, string gender, string comment, int companyId, int username, int action);

        Task<BaseResult> CMN_CreateRace(string cn, int id, string race, string comment, int companyId, int username, int action);

        Task<PayloadResult?> CMN_GetCROList(string cn, int companyId);

        Task<BaseResult> CMN_CreateCRO(string cn, int id, string cro, string comment, int companyId, int username, int action);

        Task<PayloadResult?> CMN_GetFlagDropList(string cn, int companyId);

        Task<PayloadResult?> CMN_GetVLTStatusList(string cn, int companyId);

        Task<BaseResult> CMN_CreateVLTStatus(string cn, int id, string name, string comment, int companyId, int username, int action);

        #endregion

        #region PRJ...

        Task<BaseResult> PRJ_CreateStudioSubject(string cn, int subjectId, int studioId, DateTime startTime, DateTime endTime, int companyId);

        #endregion

        #region STD....

        Task<BaseResult> STD_CrudMonitor(string cn, string fName, string lName, string email, string phone, string role, int companyId, int siteId, int id, int username, int sponsorId, int action);

        Task<BaseResult> STD_CrudProtocol(string cn, int id, string protocol, DateTime dateCreated, string version, string notes, DateTime? startDate, DateTime? endDate, int companyId, int username, int action, int? siteId);

        Task<BaseResult> STD_CrudSponsor(string cn, string name, int typeId, string? contactName, string? contactEmail, string? contactPhone, int companyId, int siteId, int id, int username, int action);

        Task<BaseResult> STD_CreateStudioData(string cn, DataTable dtGeneralData, DataTable dtDocumentation, DataTable dtMonitor, DataTable dtProtocol, DataTable dtArms, 
                                              DataTable dtVisits, int companyId, int siteId, int userName);

        Task<BaseResult> STD_UpdateStudioData(string cn, DataTable dtGeneralData, DataTable dtDocumentation, DataTable dtMonitor, DataTable dtProtocol, DataTable dtArms,
                                              DataTable dtVisits, int companyId, int siteId, int userName);

        Task<BaseResult> STD_CreateStudioDoc(string cn, int id, int studioId, string name, int typeId, DateTime docDate, string version, string notes, int companyId, int username, int action, int? siteId);

        Task<PayloadResult?> STD_GetMonitorList(string cn, int companyId);

        Task<PayloadResult?> STD_GetProtocolList(string cn, int companyId);

        Task<PayloadResult?> STD_GetSponsorList(string cn, int companyId);

        Task<PayloadResult?> STD_GetStudioList(string cn, int companyId, int siteId);

        Task<PayloadResult?> STD_GetSubjectList(string cn, int companyId);

        Task<PayloadResult?> STD_GetStudioDocList(string cn, int companyId);

        Task<PayloadResult?> STD_GetMonitorDropList(string cn, int companyId, int sponsorId);

        Task<PayloadResult?> STD_GetSponsorDropList(string cn, int companyId);

        Task<PayloadResult?> STD_GetDiseaseDropList(string cn, int companyId);

        Task<PayloadResult?> STD_GetCroDropList(string cn, int companyId);

        Task<PayloadResult?> STD_GetStaffDropList(string cn, int companyId, int siteId);

        Task<PayloadResult?> STD_GetStudioDropList(string cn, int companyId, int siteId);

        Task<BaseResult> STD_CreateStudioStaff(string cn, int studioId, int staffId, int roleId, DateTime? startDate, DateTime? endDate, int companyId, int siteId, int username, int action);

        Task<PayloadResult?> STD_GetProtocolVersionList(string cn, int companyId, int protocolId);

        Task<PayloadResult?> STD_GetStudioData(string cn, int companyId, int siteId, int studyId);



        #endregion

        #region SUB....

        Task<BaseResult> SUB_CreateContact(string cn, int subjectId, string name, string phone, int relation, int companyId);

        Task<BaseResult> SUB_CreateRandomCode(string cn, int subjectId, int studioId, string code, int companyId);

        Task<BaseResult> SUB_CreateSubject(string cn, string fName, string lName, DateTime dob, string ssNumber, string email, string phone, int addressId, string id, int companyId);

        Task<BaseResult> SUB_CreateSubjectData(string cn, DataTable subDataUDT);

        #endregion

        #region VLT....

        Task<BaseResult> VLT_CreateVolunteerData(string cn, DataTable dtGd, DataTable dtAllergy, DataTable dtDisease,
                DataTable dtDoc, DataTable dtEmergc, DataTable dtMed);

        Task<BaseResult> VLT_UpdateVolunteerData(string cn, DataTable dtGd, DataTable dtAllergy, DataTable dtDisease,
              DataTable dtDoc, DataTable dtEmergc, DataTable dtMed, int companyId, int siteId, int username);

        Task<PayloadResult?> VLT_GetVolunteerList(string cn, int companyId, int siteId);

        Task<PayloadResult?> VLT_GetVolunteerData(string cn, int companyId, int siteId, int volunteerId);

        Task<PayloadResult?> VLT_GetVLTStatusDropList(string cn, int companyId);

        #endregion

        #endregion

    }
}
