using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }


    public void GiveMask(Person person)
    {
        if (_applicantService.checkPerson(person))
        {
            Console.WriteLine($"{person.FirstName},size maske verildi!");

        }
        else
        {
            Console.WriteLine($"{person.FirstName} için kimlik bilgileri doğrulanamadı!");

        }

    }


}
