using System;
using Entities.Concrete;
namespace Business .Abstract
{
	public interface IApplicantService
	{
		void ApplyForMask();
		bool ChechPerson(Person person);
		List<Person> GetAll();
	}
}

