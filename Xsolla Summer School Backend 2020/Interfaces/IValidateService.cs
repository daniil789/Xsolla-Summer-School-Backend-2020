using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xsolla_Summer_School_Backend_2020.Models;

namespace Xsolla_Summer_School_Backend_2020.Interfaces
{
    public interface IValidateService
    {
         bool LuhnAlgorithm(string number);

    }
}
