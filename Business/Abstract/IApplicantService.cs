using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService
{
    void applyForMask(Person person);


    List<Person> GetList();


    bool checkPerson(Person person);

}
