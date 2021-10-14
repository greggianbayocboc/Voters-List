using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gregg.Helpers
{
    public enum AssessmentOption : int
    {
        [Display(Name = "ATO")]
        ATO = 2,
        [Display(Name = "DILE ATO")]
        DILE_ATO = -2,
        [Display(Name = "DUHA-DUHA")]
        DUHA_DUHA = 0,
        [Display(Name = "INC")]
        INC = 0
    }
}
