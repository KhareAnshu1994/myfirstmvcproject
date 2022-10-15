using Assesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Helper_class
{
    public class Users
    {

        public Responsemodel Saveproject(ProjectDatamodel objmodel)
        {
            Responsemodel result = new Responsemodel();
            if (objmodel.Project_Name == "" || objmodel.Project_Name == null)
            {

                result.status = false;
                result.message = "Name not recieved Successfully";
            }
            else

            {

                result.status = true;
                result.message = "Name recieved Successfully";

            }
            return result;
        }
        public Responsemodel GetProject()
        {
            Responsemodel result = new Responsemodel();

            return result;
        }

        public List<ProjectDatamodel> getName()
        {
            List<ProjectDatamodel> UserDetails = new List<ProjectDatamodel>()
            {

                new ProjectDatamodel()
            };

            return UserDetails;

        }

        public Responsemodel UpdateProject(ProjectDatamodel objmodel)
        {
            Responsemodel result = new Responsemodel();

            return result;
        }

        public Responsemodel DeleteProject(int Id)
        {
            Responsemodel result = new Responsemodel();

            return result;
        }
    }
}
