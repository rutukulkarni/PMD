using System.Collections.Generic;
using System.ServiceModel;
using  PMD.DataContracts;

namespace  PMD.ServiceContracts
{
    [ServiceContract]
    public interface IUserRegistration
    {

        [OperationContract]
        bool UserRegistration(UserDetails userDetails);
        [OperationContract]
        List<Company> RetriveCompanyNames();
        [OperationContract]
        int CompanyRegistration(Company company);
      
    }
}
