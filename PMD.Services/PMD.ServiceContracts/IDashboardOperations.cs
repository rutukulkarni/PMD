using System.ServiceModel;
using  PMD.DataContracts;
using System.ServiceModel.Web;
namespace  PMD.ServiceContracts
{
    [ServiceContract]
    public interface IDashboardOperations
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateDashboard", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        int CreateDashboard(Dashboard dashboardDetails, UserDetails UserDetails);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "EditDashboard", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool EditDashboard(Dashboard dashboardDetails, int UserDetails,string[] newSource,int [] deletedSource,DashboardStatus[]newStatus,int []deletedStatus);

        [WebInvoke(Method = "POST", UriTemplate = "deleteDashboard", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool deleteDashboard(int dashboardID);
    }

}
