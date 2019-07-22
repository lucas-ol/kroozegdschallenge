using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Interfaces;
using Ninject.Injection;
using Ninject;

namespace Krooze.EntranceTest.WriteHere.Tests.InjectionTests
{
    public class InjectionTest
    {
        private IGetCruise _getCruise ;
        
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            //TODO: This method receives a generic request, that has a cruise company code on it
            //There is an interface (IGetCruise) that is implemented by 3 classes (Company1, Company2 and Company3)
            //Make sure that the correct class is injected based on the CruiseCompanyCode on the request
            //without directly referencing the 3 classes and the method GetCruises of the chosen implementation is called
            //      Ninject.IKernel kiko = new StandardKernel();
            //    kiko.Bind(typeof(sr)) 
            return null;        
        }
    }
}
