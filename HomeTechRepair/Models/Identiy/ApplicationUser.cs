﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTechRepair.Models.Identiy
{
    public class ApplicationUser: IdentityUser
    {
        [Required, StringLength(50)]
        [PersonalData]
        public string Name { get; set; }
        [Required, StringLength(50)]
        [PersonalData]
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        //This property is needed if we decide to implement a sms service in the future //https://www.twilio.com/docs/sms/quickstart/csharp-dotnet-core
        //public bool NotificationPreference { get; set; } //True : mail False: sms

    }
}
