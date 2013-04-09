using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;


namespace PC2_Janet
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    public class RestFul_Estudiante : IRestFul_Estudiante
    {


        List<Estudiante> objStudent = new List<Estudiante>();
        int studentCount = 0;

        public Estudiante CreateStudent(Estudiante s)
        {
            s.ID = (++studentCount).ToString();
            objStudent.Add(s);
            return s;
        }

        public List<Estudiante> GetAllStudent()
        {
            return objStudent.ToList();
        }

        public Estudiante GetQuery(string query)
        {
            return objStudent.FirstOrDefault(e => e.firstname.Equals(query));
        }

        public Estudiante GetAStudent(string id)
        {
            return objStudent.FirstOrDefault(e => e.ID.Equals(id));
        }

        public Estudiante UpdateStudent(string id, Estudiante s)
        {
            Estudiante p = objStudent.FirstOrDefault(e => e.ID.Equals(id));
            p.birthdate = s.birthdate;
            p.firstname = s.firstname;
            p.lastname = s.lastname;
            p.idbooster = s.idbooster;
            return p;
        }

        public void DeleteStudent(string id)
        {
            objStudent.RemoveAll(e => e.ID.Equals(id));
        }
    }
}