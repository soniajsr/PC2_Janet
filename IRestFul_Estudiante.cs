using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace PC2_Janet
{

      [ServiceContract]
    public interface  IRestFul_Estudiante
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/", Method = "POST")]
          Estudiante CreateStudent(Estudiante s);

        [OperationContract]
        [WebGet(UriTemplate = "/students/")]
        List<Estudiante> GetAllStudent();

        [OperationContract]
        [WebGet(UriTemplate = "/students/search/{query}")]
        Estudiante GetQuery(string query);

        [OperationContract]
        [WebGet(UriTemplate = "/students/{id}")]
        Estudiante GetAStudent(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{id}", Method = "PUT")]
        Estudiante UpdateStudent(string id, Estudiante s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/students/{id}", Method = "DELETE")]
        void DeleteStudent(string id);

    }

      #region Entidad Estudiante
      [DataContract]
      public class Estudiante
      {
          [DataMember]
          public string ID;
          [DataMember]
          public string birthdate;
          [DataMember]
          public string firstname;
          [DataMember]
          public string idbooster;
          [DataMember]
          public string lastname;

      }
      #endregion


}