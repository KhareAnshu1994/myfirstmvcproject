using Assesment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Service_class
{
    public class ProjectClass
    {

        public Responsemodel SaveProject(ProjectDatamodel objmodel)
        {


            Responsemodel result = new Responsemodel();


            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");
            try
            {
                SqlCommand cmd = new SqlCommand("SaveProjectDetails", con);





                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Project_Name", objmodel.Project_Name);

                cmd.Parameters.AddWithValue("@Project_Status", objmodel.Project_Status);

                cmd.Parameters.AddWithValue("@Project_Completed", DateTime.UtcNow);

                cmd.Parameters.AddWithValue("@Project_Description", objmodel.Project_Description);

                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                con.Open();

                cmd.ExecuteNonQuery();

                var id = Convert.ToInt32(cmd.Parameters["@id"].Value.ToString());
                con.Close();
                con.Dispose();


                if (id > 0)

                {
                    result.status = true;
                    result.message = "Data saved succesfully";
                    result.id = id;
                }
                else
                {
                    result.status = false;
                    result.message = "Plz check something went Wrong";
                }
            }
            catch (Exception ex)
            {
                result.status = false;
                result.message = "Exception ocuures";


            }

            finally
            {
                con.Close();

                con.Dispose();

            }
            return result;
        }

        public ProjectDatamodel GetProject(int Id)
        {
            ProjectDatamodel UserDetails = new ProjectDatamodel();


            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");



            try
            {

                SqlCommand cmd = new SqlCommand("GetProjectDetails", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataSet ds = new DataSet();
                da.Fill(ds);




                for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
                {




                    UserDetails.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);

                    UserDetails.Project_Name = ds.Tables[0].Rows[i]["Project_Name"].ToString();

                    UserDetails.Project_Status = ds.Tables[0].Rows[i]["Project_Status"].ToString();

                    UserDetails.Project_Completed = (DateTime)ds.Tables[0].Rows[i]["Project_Completed"];


                    UserDetails.Project_Description = ds.Tables[0].Rows[i]["Project_Description"].ToString();


                }

                var formatedDate = UserDetails.Project_Completed.ToString("yyyy-MM-dd");
                UserDetails.Project_Completed_formated = formatedDate;

            }


            catch (Exception ex)
            {

                UserDetails = new ProjectDatamodel();
            }


            finally
            {
                con.Close();

                con.Dispose();

            }




            return UserDetails;
        }

        public ProjectDatamodel getdatabyDropdownselection(ProjectDatamodel obj)
        {
            ProjectDatamodel UserDetails = new ProjectDatamodel();


            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");



            try
            {

                SqlCommand cmd = new SqlCommand("GetProjectDetailsbyname", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@project_status", obj.Project_Status);

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataSet ds = new DataSet();
                da.Fill(ds);




                for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
                {




                    UserDetails.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"]);

                    UserDetails.Project_Name = ds.Tables[0].Rows[i]["Project_Name"].ToString();

                    UserDetails.Project_Status = ds.Tables[0].Rows[i]["Project_Status"].ToString();

                    UserDetails.Project_Completed = (DateTime)ds.Tables[0].Rows[i]["Project_Completed"];


                    UserDetails.Project_Description = ds.Tables[0].Rows[i]["Project_Description"].ToString();


                }

                var formatedDate = UserDetails.Project_Completed.ToString("yyyy-MM-dd");
                UserDetails.Project_Completed_formated = formatedDate;

            }


            catch (Exception ex)
            {

                UserDetails = new ProjectDatamodel();
            }


            finally
            {
                con.Close();

                con.Dispose();

            }




            return UserDetails;
        }
        public Responsemodel UpdateProject(ProjectDatamodel objmodel)
        {


            Responsemodel result = new Responsemodel();


            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateProjectDetails", con);



                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id", objmodel.Id);

                cmd.Parameters.AddWithValue("@Project_Name", objmodel.Project_Name);

                cmd.Parameters.AddWithValue("@Project_Status", objmodel.Project_Status);

                cmd.Parameters.AddWithValue("@Project_Completed", DateTime.UtcNow);

                cmd.Parameters.AddWithValue("@Project_Description", objmodel.Project_Description);



                con.Open();

                cmd.ExecuteNonQuery();

                //var id = Convert.ToInt32(cmd.Parameters[objmodel.id].Value.ToString());
                con.Close();
                con.Dispose();

                {

                    result.status = true;
                    result.message = "Record Updated";

                }

            }

            catch (Exception ex)
            {
                result.status = false;
                result.message = "Exception ocuures";


            }

            finally
            {
                con.Close();

                con.Dispose();

            }
            return result;
        }

       
        public List<ProjectDatamodel> getName()
        {
            List<ProjectDatamodel> UserDetails = new List<ProjectDatamodel>();
            
            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");
            try
            {

                SqlCommand cmd = new SqlCommand("ShowProjectDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;


                con.Open();
                SqlDataAdapter ds = new SqlDataAdapter();
                ds.SelectCommand = cmd;
                DataSet da = new DataSet();
                ds.Fill(da);

                for (var i = 0; i < da.Tables[0].Rows.Count; i++)
                {
                    ProjectDatamodel emp = new ProjectDatamodel();
                    emp.Id = Int16.Parse(da.Tables[0].Rows[i]["Id"].ToString());
                    emp.Project_Name = da.Tables[0].Rows[i]["Project_Name"].ToString();
                    emp.Project_Description = da.Tables[0].Rows[i]["Project_Description"].ToString();
                    emp.Project_Status = da.Tables[0].Rows[i]["Project_Status"].ToString();
                    emp.Project_Completed = Convert.ToDateTime(da.Tables[0].Rows[i]["Project_Completed"]);
                    UserDetails.Add(emp);
                }
            }
            catch (Exception ex)
            {
                UserDetails = new List<ProjectDatamodel>();
                
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return UserDetails;
        }
        public Responsemodel DeleteProject(int Id)
        {


            Responsemodel result = new Responsemodel();


            SqlConnection con = new SqlConnection("Server=DESKTOP-442DCNL\\SQLEXPRESS01;Initial Catalog=Project;User Id=root; Password=root");
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteProjectDetails", con);



                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();

               var Query_result =cmd.ExecuteNonQuery();

                //var id = Convert.ToInt32(cmd.Parameters[objmodel.id].Value.ToString());
               if(Query_result>0)

                {

                    result.status = true;
                    result.message = "Record Deleted Succesfully";

                }
               else
                {
                    result.status = false;
                    result.message = "Please Check Something Wrong";

                }

            }

            catch (Exception ex)
            {
                result.status = false;
                result.message = "Exception ocuures";


            }

            finally
            {
                con.Close();

                con.Dispose();

            }
            return result;
        }
    }
}
