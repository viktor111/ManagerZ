using ManagerZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Services
{
    interface ISqlDay
    {
        DayModel SaveDay(DayModel day);

        DayModel GetOneByDate(string date);

        void DeleteOneByDate(string date);

        DayModel Update(DayModel day);
    }
}
