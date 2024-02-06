using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business;

public class PersonManager : IApplicantService
{
    public void applyForMask(Person person)
    {
        throw new NotImplementedException();


    }

    public bool checkPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var responese = client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest((
                new TCKimlikNoDogrulaRequestBody(
                    person.NationalId, person.FirstName, person.LastName, person.DateOfBirthYear))));
        return responese.Result.Body.TCKimlikNoDogrulaResult;


    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }
}
