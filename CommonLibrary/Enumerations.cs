

namespace CommonLibrary
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public enum Role
    {
        ADMINISTRATOR = 1,              // ONE OR TWO PEOPLE   // SEE ALL GROUPS
        UPPER_MANAGEMENT = 2,           // DAN, SHANE, RICK, DIRECTORS, SERVICE MANAGERS  // SEE SPECIFIC GROUPS ON PEOPLE
        TEAM_LEAD = 3,                  // SHOULD ONLY SEE THEIR PEOPLE
        INSTRUCTOR = 4,                 // MAKING THIS ROLE BECAUSE I CAN AND I'M THE DEVELOPER AND NO ONE CAN STOP ME !!!!  
                                        // CAN USE TIMEKEEPING FUNCTIONS, WEEKLY STUDENT ACCESSMENTS, EQUIPMENT CHECKOUT
        EMPLOYEE = 5,                   // SHOULD ONLY SEE STUFF ABOUT THEMSELVES
        BOOTCAMP_HIRING_MANAGER = 6     // SHOULD BE ABLE TO DO CAPSTONE EVALUATION PART OF APP
    }
}
