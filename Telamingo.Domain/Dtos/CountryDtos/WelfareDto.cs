using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.CountryDtos
{
    public class WelfareDto
    {
        public SavingDto Saving { get; set; }
        public SpecialtyDto Specialty { get; set; }
    }
    public class SavingDto
    {
        public int HowMuchDoYouExpectToSaveAnnually { get; set; }
        public int HowMuchIsYourCurrentSavings { get; set; }
    }
    public class SpecialtyDto
    {
        public int WhatIsYourJobOrSkillNow { get; set; }
        public int WhatIsYourSecondJobOrSkillNow { get; set; }
        public int WhatJobDoYouWantToPursueAfterEmigrating { get; set; }
    }
}
