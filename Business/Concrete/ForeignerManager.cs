using Business.Abstract;
using Entities.Concrete;
using YabanciMernisServiceReference;

namespace Business;

public class ForeignerManager : IApplicantService
{
    public void applyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool checkPerson(Person person)
    {
        KPSPublicYabanciDogrulaSoapClient client = new KPSPublicYabanciDogrulaSoapClient(KPSPublicYabanciDogrulaSoapClient.EndpointConfiguration.KPSPublicYabanciDogrulaSoap);
        var response = client.YabanciKimlikNoDogrulaAsync(
            new YabanciKimlikNoDogrulaRequest(
                new YabanciKimlikNoDogrulaRequestBody(
                    person.NationalId, person.FirstName, person.LastName, person.DateOfBirthDay, person.DateOfBirthMonth, person.DateOfBirthYear)));

        return response.Result.Body.YabanciKimlikNoDogrulaResult;
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }
}
